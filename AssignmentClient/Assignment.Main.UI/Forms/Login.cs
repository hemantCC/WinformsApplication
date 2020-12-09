using Assignment.Base.Common.Global;
using Assignment.Base.Common.Helpers;
using Assignment.Base.Constants;
using Assignment.Base.Models.ViewModels;
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
    public partial class Login : Form
    {
        #region Private Members

        private readonly MainMdiContainer _mdiParent;

        #endregion

        #region Constructor

        public Login()
        {
            InitializeComponent();
        }

        public Login(MainMdiContainer MdiParent)
        {
            InitializeComponent();
            _mdiParent = MdiParent;
        }

        #endregion

        #region Event Handlers
        private void labelClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sure you want to exit?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            Register RegisterForm = new Register(_mdiParent);
            RegisterForm.MdiParent = _mdiParent;
            RegisterForm.Dock = DockStyle.Fill;
            RegisterForm.Show();
            this.Hide();
        }


        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            if (ValidateUsername() && ValidatePassword())
            {
                string username = textBoxUsername.Text.Trim();
                string password = DataHelper.EncryptString(textBoxPassword.Text);
                Task<HttpResponseMessage> taskResponse = HttpClientHelper.WebApiClient
                    .PostAsync(ApiUrlConstants.LoginBaseUrl + $"?Username={username}&password={password}", null);
                HttpResponseMessage response = taskResponse.GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    GlobalInfo.CurrentUser = new UserInfo("",textBoxUsername.Text);
                    HomeMdiContainer home = new HomeMdiContainer();
                    home.Show();
                    _mdiParent.Hide();
                    MessageBox.Show("You have successfully Logged in.", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    ClearFormError();
                }
                else
                    MessageBox.Show("Login Failed, Please try again." + "\n" + "Error Code" + response.StatusCode
                        , "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Form Is Invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            ValidateUsername();
        }


        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            ValidatePassword();
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.BackColor = Color.Red;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.BackColor = Color.DimGray;
        }

        private void labelMinimize_MouseEnter(object sender, EventArgs e)
        {
            labelMinimize.BackColor = Color.BlueViolet;
        }

        private void labelMinimize_MouseLeave(object sender, EventArgs e)
        {
            labelMinimize.BackColor = Color.DimGray;
        }

        private void labelMinimize_Click(object sender, EventArgs e)
        {
            _mdiParent.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Private Methods
        private void ClearForm()
        {
            textBoxUsername.Text = textBoxPassword.Text = "";
        }

        private void ClearFormError()
        {
            errorProviderUsername.Clear();
            errorProviderPassword.Clear();
        }

        #endregion

        #region Field Validation Methods

        //validates Username
        private bool ValidateUsername()
        {
            bool isValid = false;
            string username = textBoxUsername.Text;
            if (username.Length < 6)
                errorProviderUsername.SetError(textBoxUsername, "Lenght must be atleasr 6!");
            else if (!ReConstants.SpecialCharacterReg.IsMatch(username))
                errorProviderUsername.SetError(textBoxUsername, "Special Characters Not Allowed");
            else if (username.Contains(" "))
                errorProviderUsername.SetError(textBoxUsername, "White space Not Allowed");
            else
            {
                isValid = true;
                errorProviderUsername.Clear();
            }
            return isValid;
        }

        //validates Password
        private bool ValidatePassword()
        {
            bool idValid = false;
            string password = textBoxPassword.Text;
            if (!ReConstants.PasswordReg.IsMatch(password))
                errorProviderPassword.SetError(textBoxPassword, "Password Length 8 and Maximum 15 character \n Require Unique Chars \n Require Digit \n Require Lower Case \n Require Upper Case");
            else
            {
                idValid = true;
                errorProviderPassword.Clear();
            }
            return idValid;
        }


        #endregion

    }
}
