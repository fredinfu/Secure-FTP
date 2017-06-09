using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace SecureFtpClient.UserControls
{
    public partial class ucLogin : ucBase
    {
        public ucLogin()
        {
            InitializeComponent();
        }

        private void mlSettings_Click(object sender, EventArgs e)
        {
            ShowSettings();
        }

        private void ShowSettings()
        {
            mpSettings.Visible = true;
            this.Controls["mpSettings"].BringToFront();
            mpLogin.Enabled = false;
        }

        private void mlBackSettings_Click(object sender, EventArgs e)
        {
            ShowLogin();
        }

        private void ShowLogin()
        {
            mpSettings.Visible = false;
            mpLogin.Enabled = true;
        }

        private void mbLogin_Click(object sender, EventArgs e)
        {
            ShowMainMenu();
        }

        private void ShowMainMenu()
        {
            BringToFront(typeof(ucMainMenu).Name);
            mainForm.Instance.MetroBack.Visible = false;
        }


    }
}
