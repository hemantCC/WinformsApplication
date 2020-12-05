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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.Main.UI.Forms
{
    public partial class Register : Form
    {
        #region Private members

        private readonly MainMdiContainer _mdiParent;

        private readonly Login _login;

        #endregion

        #region Constructors

        public Register()
        {
            InitializeComponent();
            PopulateDropdown().ConfigureAwait(false);
        }

        public Register(MainMdiContainer _mdiParent)
        {
            InitializeComponent();
            this._mdiParent = _mdiParent;
            _login = new Login(_mdiParent);
            PopulateDropdown().ConfigureAwait(false);
        }

        #endregion

        #region Private Methods

        private async Task PopulateDropdown()
        {
            Task<HttpResponseMessage> taskResponse = HttpClientHelper.WebApiClient.GetAsync(ApiUrlConstants.GetAllRolesBaseUrl);
            HttpResponseMessage response = taskResponse.GetAwaiter().GetResult();
            var SerialisedResponse = await response.Content.ReadAsStringAsync();
            var DeserialisedResponse = JsonConvert.DeserializeObject<List<string>>(SerialisedResponse);
            comboBoxRoles.Items.AddRange(DeserialisedResponse.ToArray());
        }

        private void ClearForm()
        {
            textBoxEmail.Text = textBoxFirstname.Text = textBoxConfirmPassword.Text =
                textBoxLastName.Text = textBoxPassword.Text = textBoxUsername.Text = "";
        }
        private bool FormValid()
        {
            return ValidateFirstName() && ValidateLastName() && ValidateEmail() &&
                ValidateUsername() && ValidatePassword() && ValidateConfirmpassword() && ValidateRoleSelection();
        }

        private HttpResponseMessage CheckIfUserExists()
        {
            HttpResponseMessage response = HttpClientHelper.WebApiClient
               .PostAsync(ApiUrlConstants.CheckIfUserExistisBaseUrl + $"?Username={textBoxUsername.Text}", null).Result;
            return response;
        }

        #endregion

        #region Event Handlers

        private void buttonRegister_Click_1(object sender, EventArgs e)
        {
            if (FormValid())
            {
                if (!CheckIfUserExists().IsSuccessStatusCode)
                {
                    UserViewModel user = new UserViewModel()
                    {
                        FirstName = textBoxFirstname.Text,
                        LastName = textBoxLastName.Text,
                        Email = textBoxEmail.Text,
                        Password = DataHelper.EncryptString(textBoxPassword.Text.Trim()),
                        Username = textBoxUsername.Text,
                        Role = comboBoxRoles.SelectedItem.ToString()
                    };
                    HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(user),
                        Encoding.UTF8, CommonConstants.DefaultContentType);
                    Task<HttpResponseMessage> taskResponse = HttpClientHelper.WebApiClient.PostAsync(ApiUrlConstants.RegisterBaseUrl, httpContent);
                    HttpResponseMessage response = taskResponse.GetAwaiter().GetResult();
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("User Registered.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        _login.MdiParent = _mdiParent;
                        _login.Dock = DockStyle.Fill;
                        this.Hide();
                        _login.Show();
                    }
                    else
                        MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase
                            , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Username Already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Form Is Invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            ValidateUsername();
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            ValidateEmail();
        }

        private void textBoxFirstname_TextChanged(object sender, EventArgs e)
        {
            ValidateFirstName();
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            ValidateLastName();
        }

        private void buttonAvailability_Click(object sender, EventArgs e)
        {
            if (ValidateUsername())
            {
                labelUsernameAvailability.Visible = true;
                labelUsernameAvailability.BackColor = Color.White;
                if (!CheckIfUserExists().IsSuccessStatusCode)
                {
                    labelUsernameAvailability.Text = "Username Available";
                    labelUsernameAvailability.ForeColor = Color.ForestGreen;
                }
                else
                {
                    labelUsernameAvailability.Text = "Username Already Taken";
                    labelUsernameAvailability.ForeColor = Color.Red;
                }
            }
            else
                MessageBox.Show("Invalid Email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonBase1_Click(object sender, EventArgs e)
        {
            _login.MdiParent = _mdiParent;
            _login.Dock = DockStyle.Fill;
            this.Hide();
            _login.Show();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sure you want to exit?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            ValidatePassword();
        }


        private void textBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            ValidateConfirmpassword();
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.BackColor = Color.Red;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.BackColor = Color.DimGray;
        }

        private void labelMinimize_Click(object sender, EventArgs e)
        {
            _mdiParent.WindowState = FormWindowState.Minimized;
        }

        private void labelMinimize_MouseEnter(object sender, EventArgs e)
        {
            labelMinimize.BackColor = Color.BlueViolet;
        }

        private void labelMinimize_MouseLeave(object sender, EventArgs e)
        {
            labelMinimize.BackColor = Color.DimGray;
        }

        #endregion

        #region Validation Methods

        private bool ValidatePassword()
        {
            bool isValid = false;
            string password = textBoxPassword.Text;
            if (!ReConstants.PasswordReg.IsMatch(password))
                errorProviderPassword.SetError(textBoxPassword, "Password Length 8 and Maximum 15 character \n Require Special Chars \n Require Digit \n Require Lower Case \n Require Upper Case");
            else
            {
                isValid = true;
                errorProviderPassword.Clear();
            }
            return isValid;
        }

        private bool ValidateRoleSelection()
        {
            bool isValid = false;

            if (comboBoxRoles.SelectedIndex == -1)
                errorProviderRoles.SetError(comboBoxRoles, "Please Select a Role");
            else
            {
                isValid = true;
                errorProviderRoles.Clear();
            }
            return isValid;
        }

        private bool ValidateConfirmpassword()
        {
            bool isValid = false;
            if (textBoxPassword.Text != textBoxConfirmPassword.Text)
                errorProviderConfirmPassword.SetError(textBoxConfirmPassword, "Do no match with confirm Password!");
            else
            {
                isValid = true;
                errorProviderConfirmPassword.Clear();
            }
            return isValid;
        }

        private bool ValidateUsername()
        {
            bool isValid = false;
            string username = textBoxUsername.Text;
            if (username.Length < 6)
                errorProviderUsername.SetError(textBoxUsername, "Lenght must be atleasr 6!");
            else if (!ReConstants.SpecialCharacterReg.IsMatch(username))
                errorProviderUsername.SetError(textBoxUsername, "Special Characters Not Allowed");
            else if (username.Contains(" "))
                errorProviderUsername.SetError(textBoxUsername, "White Space Not Allowed");
            else
            {
                isValid = true;
                errorProviderUsername.Clear();
            }
            return isValid;
        }

        private bool ValidateEmail()
        {
            bool isValid = false;
            if (!ReConstants.EmailReg.IsMatch(textBoxEmail.Text))
                errorProviderEmail.SetError(textBoxEmail, "Invalid Email!");
            else
            {
                isValid = true;
                errorProviderEmail.Clear();
            }
            return isValid;
        }

        private bool ValidateFirstName()
        {
            bool isValid = false;
            if (!ReConstants.NameBaseReg.IsMatch(textBoxFirstname.Text))
                errorProviderFirstName.SetError(textBoxFirstname, "Only Alphabets allowed! \n Must contain 3 -10 characters only!");
            else
            {
                isValid = true;
                errorProviderFirstName.Clear();
            }
            return isValid;
        }

        private bool ValidateLastName()
        {
            bool isValid = false;
            if (!ReConstants.NameBaseReg.IsMatch(textBoxLastName.Text))
                errorProviderLastName.SetError(textBoxLastName, "Only Alphabets allowed! \n Must contain 3 -10 characters only!");
            else
            {
                isValid = true;
                errorProviderLastName.Clear();
            }
            return isValid;
        }

        #endregion

    }
}
