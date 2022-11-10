using Microsoft.Extensions.DependencyInjection;
using MusicStore.BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicStore.WinForms
{
    public partial class LoginForm : Form
    {
        private readonly IAuthenticationService authService;
        private readonly IApplicationContext context;

        public LoginForm(IAuthenticationService authService, IApplicationContext context)
        {
            this.authService = authService;
            this.context = context;

            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            SignIn();
        }

        private void SignIn() 
        {
            var user = authService.SignIn(this.loginTextBox.Text, this.passwordTextBox.Text);
            if (user != null)
            {
                context.CurrentUser = user;
                this.Close();
            }
            else 
            {
                MessageBox.Show("Invalid credentials");
            }
        }

        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) 
            {
                SignIn();
            }
        }

        private void LinkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<RegisterForm>();
            form.ShowDialog();
        }


        private void LinkReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<ResetPasswordForm>();
            form.ShowDialog();
        }


        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (context.CurrentUser == null)
            {
                Application.Exit();
            }
        }
    }
}
