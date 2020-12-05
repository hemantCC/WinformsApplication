using Assignment.Base.Common.Helpers;
using Assignment.Base.Constants;
using Assignment.Base.Models.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.Vehicle.Forms
{
    public partial class VehicleAdd : Form
    {
        #region Private Members

        private readonly VehicleViewModel _vehicle = new VehicleViewModel();

        #endregion

        #region Constructors

        public VehicleAdd()
        {
            InitializeComponent();
            PopulateDropdowns();
        }

        public VehicleAdd(VehicleViewModel vehicle) : this()
        {
            _vehicle = vehicle;
            PopulateFields();
        }

        #endregion

        #region Private Members   
        
        /// <summary>
        /// Populates the fields.
        /// </summary>
        private void PopulateFields()
        {
            checkBoxAvailable.Checked = _vehicle.Available ?? false;
            textBoxColor.Text = _vehicle.Color;
            textBoxEngineSize.Text = _vehicle.EngineSize.ToString();
            comboBoxFuelType.SelectedItem = _vehicle.FuelTypeName;
            textBoxMaker.Text = _vehicle.Make;
            textBoxMaxPassengers.Text = _vehicle.MaxPassangers.ToString();
            textBoxMileage.Text = _vehicle.Mileage.ToString();
            textBoxModel.Text = _vehicle.Model;
            textBoxPlate.Text = _vehicle.Plate;
            textBoxTankCapacity.Text = _vehicle.TankCapacity.ToString();
            comboBoxTransmissionType.SelectedItem = _vehicle.TransmissionTypeName;
            comboBoxCarType.SelectedItem = _vehicle.TypeName;
            textBoxVin.Text = _vehicle.Vin;
            textBoxYear.Text = _vehicle.Year;
            switch (_vehicle.Category)
            {
                case "Passanger Car":
                    radioButtonPassanger.Checked = true;
                    break;
                case "Utility Car":
                    radioButtonUtility.Checked = true;
                    break;
                default:
                    radioButtonCargo.Checked = true;
                    break;
            }
            Text = "Update Vehicle";
            buttonSave.Text = "UPDATE";
        }

        /// <summary>
        /// Populates the dropdowns asynchronously.
        /// </summary>
        private void PopulateDropdowns()
        {
            HttpResponseMessage vehicleTypes = HttpClientHelper.WebApiClient.GetAsync(ApiUrlConstants.GetVehicleTypesBaseUrl).GetAwaiter().GetResult(); ;
            HttpResponseMessage transmissionTypes = HttpClientHelper.WebApiClient.GetAsync(ApiUrlConstants.GetTransmissionTypesBaseUrl).GetAwaiter().GetResult(); ;
            HttpResponseMessage fuelTypes = HttpClientHelper.WebApiClient.GetAsync(ApiUrlConstants.GetFuelTypesBaseUrl).GetAwaiter().GetResult();

            comboBoxCarType.DataSource = GetDeserializedDropdownValues(vehicleTypes);
            comboBoxTransmissionType.DataSource = GetDeserializedDropdownValues(transmissionTypes);
            comboBoxFuelType.DataSource = GetDeserializedDropdownValues(fuelTypes);
        }

        /// <summary>
        /// Gets the deserialized dropdown values.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        private List<string> GetDeserializedDropdownValues(HttpResponseMessage message)
        {
            var serializedValues =  message.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<List<string>>(serializedValues.ToString());
        }

        /// <summary>
        /// Seeds the vehicle object.
        /// </summary>
        /// <returns>VehicleViewModel with data from UI Controls</returns>
        private VehicleViewModel SeedVehicleObject()
        {
            string category = radioButtonPassanger.Checked ? radioButtonPassanger.Text :
                radioButtonUtility.Checked ? radioButtonUtility.Text : radioButtonCargo.Text;

            VehicleViewModel vehicle = new VehicleViewModel()
            {
                Id = _vehicle.Id,
                Available = checkBoxAvailable.Checked,
                Category = category,
                Color = textBoxColor.Text.Trim(),
                EngineSize = decimal.Parse(textBoxEngineSize.Text.Trim()),
                FuelTypeName = comboBoxFuelType.SelectedItem.ToString(),
                Make = textBoxMaker.Text.Trim(),
                MaxPassangers = int.Parse(textBoxMaxPassengers.Text.Trim()),
                Mileage = int.Parse(textBoxMileage.Text.Trim()),
                Model = textBoxModel.Text.Trim(),
                Plate = textBoxPlate.Text.Trim(),
                TankCapacity = int.Parse(textBoxTankCapacity.Text.Trim()),
                TransmissionTypeName = comboBoxTransmissionType.SelectedItem.ToString(),
                TypeName = comboBoxCarType.SelectedItem.ToString(),
                Vin = textBoxVin.Text.Trim(),
                Year = textBoxYear.Text.Trim()
            };
            return vehicle;
        }

        #endregion

        #region Event Handlers

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            if (IsValidForm())
            {
                HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(SeedVehicleObject()),
                            Encoding.UTF8, CommonConstants.DefaultContentType);
                HttpResponseMessage response = HttpClientHelper.WebApiClient.PostAsync(ApiUrlConstants.AddOrEditVehicleBaseUrl, httpContent).Result;
                if (response.IsSuccessStatusCode)
                {
                    CommonFormHelper.GetFormInstance(typeof(Vehicles),MdiParent).Close();
                    CommonFormHelper.GetFormInstance(typeof(Vehicles),MdiParent).Show();
                    MessageBox.Show("Operation Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase
                        , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Form Invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void VehicleAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommonFormHelper.HandleFormClosing(this.GetType());
        }

        private void textBoxVin_TextChanged(object sender, EventArgs e)
        {
            ValidateVin();
        }
        private void textBoxMaker_TextChanged(object sender, EventArgs e)
        {
            ValidateMake();
        }

        private void textBoxModel_TextChanged(object sender, EventArgs e)
        {
            ValidateModel();
        }

        private void textBoxColor_TextChanged(object sender, EventArgs e)
        {
            ValidateColor();
        }
        private void textBoxMileage_TextChanged(object sender, EventArgs e)
        {
            ValidateMileage();
        }
        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {
            ValidateYear();
        }

        private void textBoxPlate_TextChanged(object sender, EventArgs e)
        {
            ValidatePlate();
        }

        private void textBoxMaxPassengers_TextChanged(object sender, EventArgs e)
        {
            ValidateMaxPassengers();
        }

        private void textBoxTankCapacity_TextChanged(object sender, EventArgs e)
        {
            ValidateTankCapacity();
        }

        private void textBoxEngineSize_TextChanged(object sender, EventArgs e)
        {
            ValidateEngineSize();
        }


        #endregion

        #region Private Validation Methods

        private bool IsValidForm()
        {
            return ValidateVin() && ValidateYear() && ValidateMake() && ValidateModel() && ValidateColor()
                && ValidatePlate() && ValidateMaxPassengers() && ValidateEngineSize() && ValidateTankCapacity()
                && ValidateMileage();
        }


        private bool ValidateVin()
        {
            bool isValid = false;
            string vin = textBoxVin.Text;
            if (!ReConstants.SpecialCharacterReg.IsMatch(vin))
                errorProviderVin.SetError(textBoxVin, "Special Characters Not Allowed");
            if (vin.Length > 10)
                errorProviderVin.SetError(textBoxVin, "Length must be less than 10");
            else if (vin.Contains(" "))
                errorProviderVin.SetError(textBoxVin, "White space Not Allowed");
            else
            {
                isValid = true;
                errorProviderVin.Clear();
            }
            return isValid;
        }

       

        private bool ValidateYear()
        {
            bool isValid = false;
            string year = textBoxYear.Text;
            if (!ReConstants.YearReg.IsMatch(year))
                errorProviderYear.SetError(textBoxYear, "Must be of type year. Ex: 2018");
            else if (int.Parse(year) > DateTime.UtcNow.Year)
                errorProviderYear.SetError(textBoxYear, $"Must not be greater than {DateTime.UtcNow.Year}");
            else
            {
                isValid = true;
                errorProviderYear.Clear();
            }
            return isValid;
        }

        private bool ValidateMake()
        {
            bool isValid = false;
            string make = textBoxMaker.Text;
            if (!ReConstants.NameBaseReg.IsMatch(make))
                errorProviderMaker.SetError(textBoxMaker, "Must be Alphanumeric \n Characters between 3 to 10");
            else
            {
                isValid = true;
                errorProviderMaker.Clear();
            }
            return isValid;
        }
        private bool ValidateModel()
        {
            bool isValid = false;
            string model = textBoxModel.Text;
            if (!ReConstants.NameBaseReg.IsMatch(model))
                errorProviderModel.SetError(textBoxModel, "Must be Alphanumeric \n Characters between 3 to 10");
            else
            {
                isValid = true;
                errorProviderModel.Clear();
            }
            return isValid;
        }


        private bool ValidateColor()
        {
            bool isValid = false;
            string color = textBoxColor.Text;
            if (color.GetType() != typeof(string))
                errorProviderColor.SetError(textBoxColor, "Must be String");
            if (color.Length > 10)
                errorProviderColor.SetError(textBoxColor, "Must not be greater than 10");
            else
            {
                isValid = true;
                errorProviderColor.Clear();
            }
            return isValid;
        }

       

        private bool ValidatePlate()
        {
            bool isValid = false;
            string plate = textBoxPlate.Text;
            if (plate.Length > 8)
                errorProviderPlate.SetError(textBoxPlate, "Must be small or equal to 8");
            else
            {
                isValid = true;
                errorProviderPlate.Clear();
            }
            return isValid;
        }

        private bool ValidateMaxPassengers()
        {
            bool isValid = false;
            bool success = int.TryParse(textBoxMaxPassengers.Text, out int number);
            if (!success || number > 100)
                errorProviderMaxPassangers.SetError(textBoxMaxPassengers, "Must be integer with length less than 100");
            else
            {
                isValid = true;
                errorProviderMaxPassangers.Clear();
            }
            return isValid;
        }

        private bool ValidateEngineSize()
        {
            bool isValid = false;
            bool success = double.TryParse(textBoxEngineSize.Text, out double size);
            if (!success || size > 10.0)
                errorProviderEngineSize.SetError(textBoxEngineSize, "Must be decimal with length less than 10.0");
            else
            {
                isValid = true;
                errorProviderEngineSize.Clear();
            }
            return isValid;
        }

        private bool ValidateTankCapacity()
        {
            bool isValid = false;
            bool success = int.TryParse(textBoxTankCapacity.Text, out int number);
            if (!success || number > 150)
                errorProviderTankcapacity.SetError(textBoxTankCapacity, "Must be integer with length less than 150");
            else
            {
                isValid = true;
                errorProviderMaxPassangers.Clear();
            }
            return isValid;
        }



        private bool ValidateMileage()
        {
            bool isValid = false;
            bool success = int.TryParse(textBoxMileage.Text, out int number);
            if (!success || number > 100000000)
                errorProviderMileage.SetError(textBoxMileage, "Must be integer with length less than 100000000");
            else
            {
                isValid = true;
                errorProviderMileage.Clear();
            }
            return isValid;
        }

        
        #endregion
    }
}
