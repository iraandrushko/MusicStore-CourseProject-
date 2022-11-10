using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MusicStore.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm(IApplicationContext context)
        {
            if (context.CurrentUser == null) 
            {
                var form = Program.ServiceProvider.GetRequiredService<LoginForm>();
                form.ShowDialog();
            }



            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
