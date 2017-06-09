using MetroFramework.Controls;
using MetroFramework.Forms;
using SecureFtpClient.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureFtpClient
{
    public partial class mainForm : MetroForm
    {
        static mainForm _instance;

        public static mainForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new mainForm();
                return _instance;
            }
        }

        public MetroPanel MetroContainer
        {
            get { return mpMainPanel; }
            set { mpMainPanel = value; }
        }

        public MetroLink MetroBack
        {
            get { return mlBack; }
            set { mlBack = value; }
        }
        
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            mlBack.Visible = false;
            _instance = this;
            LoadMainPanelControls();
        }

        private void LoadMainPanelControls()
        {
            mpMainPanel.Controls.Add(new ucLogin { Dock = DockStyle.Fill });
            //mpMainPanel.Controls.Add(new ucConsultasCuentasBancarias { Dock = DockStyle.Fill });
            //mpMainPanel.Controls.Add(new ucConsultasTarjetasCredito { Dock = DockStyle.Fill });
            //mpMainPanel.Controls.Add(new ucDetalleCuentaBancaria { Dock = DockStyle.Fill });
            mpMainPanel.Controls.Add(new ucMisArchivosDescarga { Dock = DockStyle.Fill });
            mpMainPanel.Controls.Add(new ucArchivosPermitidosDescarga { Dock = DockStyle.Fill });
        }

        private void mlBack_Click(object sender, EventArgs e)
        {
            BringToFront(typeof(ucMainMenu).Name);
            mlBack.Visible = false;
        }

        protected void BringToFront(string control)
        {
            if (!Instance.MetroContainer.Controls.ContainsKey(control))
            {
                var uc = new ucMainMenu();
                uc.Dock = DockStyle.Fill;
                Instance.MetroContainer.Controls.Add(uc);
            }
            Instance.MetroContainer.Controls[control].BringToFront();
            Instance.MetroBack.Visible = true;
        }
    }
}
