using Assignment.Base.Common.Helpers;
using Assignment.Base.Constants;
using Assignment.Base.Models.ViewModels;
using Assignment.Vehicle.Forms;
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
using System.Windows;

namespace Assignment.Vehicle
{
    public partial class Vehicles : Form
    {
        #region Constructor

        public Vehicles()
        {
            InitializeComponent();
            PopulateData().ConfigureAwait(false);
            ControlsInitialSettings();
        }


        #endregion

        #region Event Handlers

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewVehicles.SelectedRows.Count == 0 || dataGridViewVehicles.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select one item!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                VehicleViewModel vehicle = new VehicleViewModel()
                {
                    Id = int.Parse(dataGridViewVehicles.SelectedRows[0].Cells["Id"].Value.ToString()),
                    Available = dataGridViewVehicles.SelectedRows[0].Cells["Available"].Value as bool?,
                    Category = dataGridViewVehicles.SelectedRows[0].Cells["Category"].Value.ToString(),
                    Color = dataGridViewVehicles.SelectedRows[0].Cells["Color"].Value.ToString(),
                    EngineSize = decimal.Parse(dataGridViewVehicles.SelectedRows[0].Cells["EngineSize"].Value.ToString()),
                    FuelTypeName = dataGridViewVehicles.SelectedRows[0].Cells["FuelTypeName"].Value.ToString(),
                    Make = dataGridViewVehicles.SelectedRows[0].Cells["Make"].Value.ToString(),
                    MaxPassangers = int.Parse(dataGridViewVehicles.SelectedRows[0].Cells["MaxPassangers"].Value.ToString()),
                    Mileage = int.Parse(dataGridViewVehicles.SelectedRows[0].Cells["Mileage"].Value.ToString()),
                    Model = dataGridViewVehicles.SelectedRows[0].Cells["Model"].Value.ToString(),
                    Plate = dataGridViewVehicles.SelectedRows[0].Cells["Plate"].Value.ToString(),
                    TankCapacity = int.Parse(dataGridViewVehicles.SelectedRows[0].Cells["TankCapacity"].Value.ToString()),
                    TransmissionTypeName = dataGridViewVehicles.SelectedRows[0].Cells["TransmissionTypeName"].Value.ToString(),
                    TypeName = dataGridViewVehicles.SelectedRows[0].Cells["TypeName"].Value.ToString(),
                    Vin = dataGridViewVehicles.SelectedRows[0].Cells["Vin"].Value.ToString(),
                    Year = dataGridViewVehicles.SelectedRows[0].Cells["Year"].Value.ToString()
                };
                CommonFormHelper.GetFormInstance(typeof(VehicleAdd), this.MdiParent, vehicle).Show(); // shows Vehicle Add Form
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewVehicles.SelectedRows.Count == 0 || dataGridViewVehicles.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select one Item!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = int.Parse(dataGridViewVehicles.SelectedRows[0].Cells["Id"].Value.ToString());
                    HttpResponseMessage response = HttpClientHelper.WebApiClient.DeleteAsync(ApiUrlConstants.DeleteVehicleBaseUrl + "?Id=" + id).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        PopulateData().ConfigureAwait(false);
                        MessageBox.Show("Vehicle Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase
                   , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dataGridViewVehicles_Click(object sender, EventArgs e)
        {
            if (dataGridViewVehicles.SelectedRows.Count != 0)
            {
                buttonEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                buttonDelete.Enabled = true;
                buttonEdit.Enabled = true;
            }
            else
            {
                AddModeSettings();
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            PopulateData(textBoxSearch.Text).ConfigureAwait(false);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            CommonFormHelper.GetFormInstance(typeof(VehicleAdd), this.MdiParent).Show(); // shows Vehicle Add Form
        }

        private void Vehicles_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommonFormHelper.HandleFormClosing(this.GetType());
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Populates the data.
        /// </summary>
        /// <param name="searchString">The search string.</param>
        private async Task PopulateData(string searchString = null)
        {
            HttpResponseMessage result = HttpClientHelper.WebApiClient.GetAsync(ApiUrlConstants.GetVehiclesBaseUrl + "?searchString=" + searchString).Result;
            var vehicles = await result.Content.ReadAsStringAsync();
            dataGridViewVehicles.DataSource = JsonConvert.DeserializeObject<List<VehicleViewModel>>(vehicles.ToString()); ;
        }

        /// <summary>
        /// Controls initial settings.
        /// </summary>
        private void ControlsInitialSettings()
        {
            dataGridViewVehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewVehicles.DefaultCellStyle.Font = new Font("Segoe UI Light", 10);
            dataGridViewVehicles.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12);
            dataGridViewVehicles.RowTemplate.Height = 30;
            AddModeSettings();
        }

        /// <summary>
        /// Add mode settings.
        /// </summary>
        private void AddModeSettings()
        {
            buttonEdit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            buttonDelete.Enabled = false;
            buttonEdit.Enabled = false;
        }

        #endregion

    }
}
