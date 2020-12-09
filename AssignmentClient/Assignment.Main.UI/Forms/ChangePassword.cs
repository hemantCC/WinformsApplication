using Assignment.Base.Common.Global;
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

namespace Assignment.Main.UI.Forms
{
    public partial class ChangePassword : Form
    {
        #region Constructor

        public ChangePassword()
        {
            InitializeComponent();
            textBoxUsername.Text = GlobalInfo.CurrentUser.UserName;
        }

        #endregion

        #region Event Handlers

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateNewPassword() && ValidateConfirmPassword() && txtCurrentPassword.Text != "")
            {
                ChangePasswordViewModel passDetails = new ChangePasswordViewModel()
                {
                    Username = GlobalInfo.CurrentUser.UserName,
                    CurentPassword = DataHelper.EncryptString(txtCurrentPassword.Text.Trim()),
                    NewPassword = DataHelper.EncryptString(txtNewPassword.Text.Trim())
                };

                HttpContent httpContent = new StringContent(
                    JsonConvert.SerializeObject(passDetails), 
                    Encoding.UTF8, 
                    CommonConstants.DefaultContentType);

                Task<HttpResponseMessage> taskResponse = HttpClientHelper.WebApiClient
                    .PostAsync(ApiUrlConstants.ChangePasswordBaseUrl, httpContent);

                HttpResponseMessage response = taskResponse.GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Password Changed Successfully.", 
                        "Success", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                    CommonFormHelper.GetFormInstance(typeof(ChangePassword), this.MdiParent).Close(); ;
                }
                else
                {
                    MessageBox.Show("Incorrect Current Password.", 
                        "Failed", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Form is invalid!", 
                    "Failed", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
        }

        private void ChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommonFormHelper.HandleFormClosing(this.GetType());
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            ValidateNewPassword();
        }


        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            ValidateConfirmPassword();
        }
        private void btnSubmit_MouseEnter(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.Teal;
            btnSubmit.ForeColor = Color.WhiteSmoke;
        }

        private void btnSubmit_MouseLeave(object sender, EventArgs e)
        {
            btnSubmit.BackColor = default;
            btnSubmit.ForeColor = default;
        }

        #endregion

        #region Private Field Validation Methods


        //validates New Password
        private bool ValidateNewPassword()
        {
            bool idValid = false;
            string password = txtNewPassword.Text;
            if (!ReConstants.PasswordReg.IsMatch(password))
                errorProviderNewPassword.SetError(txtNewPassword, "Password Length 8 and Maximum 15 character \n Require Unique Chars \n Require Digit \n Require Lower Case \n Require Upper Case");
            else
            {
                idValid = true;
                errorProviderNewPassword.Clear();
            }
            return idValid;
        }


        //validates Confirm Password
        private bool ValidateConfirmPassword()
        {
            bool idValid = false;
            if (txtNewPassword.Text != txtConfirmPassword.Text)
                errorProviderConfirmPassword.SetError(txtConfirmPassword, "Does not match new password!");
            else
            {
                idValid = true;
                errorProviderConfirmPassword.Clear();
            }
            return idValid;
        }


        #endregion

    }
}
