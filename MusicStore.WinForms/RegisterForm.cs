using MusicStore.BLL.Services;
using MusicStore.DTO.Enum;
using System;
using System.Windows.Forms;

namespace MusicStore.WinForms
{
    public partial class RegisterForm : Form
    {
        private readonly IAuthenticationService authService;
        private readonly IApplicationContext context;

        public RegisterForm(IAuthenticationService authService, IApplicationContext context)
        {
            this.authService = authService;
            this.context = context;
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var registered = this.authService.Register(
                    textBoxFirstName.Text,
                    textBoxLastName.Text,
                    textBoxEmail.Text,
                    textBoxLogin.Text,
                    textBoxPassword.Text,
                    radioButtonMale.Checked ? GenderDto.Male : GenderDto.Female,
                    textBoxAddress.Text,
                    textBoxPhoneNumber.Text,
                    textBoxSecretWord.Text,
                    textBoxCardNumber.Text,
                    dateTimePickerExpirationDate.Value,
                    textBoxBankName.Text
                );

            if (registered)
            {
                MessageBox.Show("Registered successfully");

                this.Close();
            }
            else 
            {
                MessageBox.Show("Error occured");
            }

        }
    }
}
