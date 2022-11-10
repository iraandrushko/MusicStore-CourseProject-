using MusicStore.BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MusicStore.WinForms
{
    public partial class ResetPasswordForm : Form
    {
        private readonly IAuthenticationService authService;
        private readonly IApplicationContext context;

        public ResetPasswordForm(IAuthenticationService authService, IApplicationContext context)
        {
            this.authService = authService;
            this.context = context;
            InitializeComponent();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            var result = authService.ResetPassword(
                textBoxLogin.Text,
                textBoxSecretWord.Text,
                textBoxNewPassword.Text
                );

            if (result)
            {
                MessageBox.Show("Password Reset successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error occured");
            }
        }
    }
}
