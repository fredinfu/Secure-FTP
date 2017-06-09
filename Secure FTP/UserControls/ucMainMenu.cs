using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureFtpClient.UserControls
{
    public partial class ucMainMenu : ucBase
    {
        public ucMainMenu()
        {
            InitializeComponent();
        }

        private void ucMainMenu_Load(object sender, EventArgs e)
        {

        }
        
        private void MakeDigitarCuentaVisible()
        {
            //mtbDigitarCuenta.Visible = true;
            //mcbCuentaDestino.Visible = false;
        }

        private void MakeSelectCuentaVisible()
        {
            //mtbDigitarCuenta.Visible = false;
            //mcbCuentaDestino.Visible = true;
        }

        private void mbCuentaOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //mpCuentaDestino.Visible = true;
        }

        private void mrbDigitarCuenta_CheckedChanged(object sender, EventArgs e)
        {
            MakeDigitarCuentaVisible();
        }

        private void mrbPropias_CheckedChanged(object sender, EventArgs e)
        {
            MakeSelectCuentaVisible();
        }

        private void mtbDigitarCuenta_TextChanged(object sender, EventArgs e)
        {
            //mpMonto.Visible = mtbDigitarCuenta.Text.Trim() != string.Empty;
        }

        private void mcbCuentaDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            //mpMonto.Visible = true;
        }

        private void mtbLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void mrbFavoritos_CheckedChanged(object sender, EventArgs e)
        {
            MakeSelectCuentaVisible();
        }

        private void metroQryCuentas_Click(object sender, EventArgs e)
        {
            ShowConsultasCuentasBancarias();
        }

        private void ShowConsultasCuentasBancarias()
        {
            BringToFront(typeof(ucMisArchivosDescarga).Name);
            ucMisArchivosDescarga.Instance.LoadDataForm();
        }

        //private void metroQryTarjetas_Click(object sender, EventArgs e)
        //{
        //    BringToFront(typeof(ucConsultasTarjetasCredito).Name);
        //    ucConsultasTarjetasCredito.Instance.LoadDataForm();
        //}

        private void mtExplore_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Title = "Selecciona tu archivo";
            dialog.InitialDirectory = @"C:\";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                mtFilePath.Text = dialog.FileName;
            }
            //var openFileDialog1 = new OpenFileDialog();
            //if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    var sr = new System.IO.StreamReader(openFileDialog1.FileName);

            //}
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ShowConsultasCuentasBancarias();
        }

        private void mtShareDl_Click(object sender, EventArgs e)
        {
            BringToFront(typeof(ucArchivosPermitidosDescarga).Name);
            ucArchivosPermitidosDescarga.Instance.LoadDataForm();
        }
    }
}
