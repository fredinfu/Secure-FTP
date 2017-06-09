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
    public partial class ucBase : MetroUserControl
    {
        public ucBase(){}

        protected string account;
        protected string description;

        public virtual void LoadDataForm() { }
        public virtual void Download(bool set) { }

        protected void BringToFront(string control)
        {
            if (!mainForm.Instance.MetroContainer.Controls.ContainsKey(control))
            {
                var uc = new ucMainMenu();
                uc.Dock = DockStyle.Fill;
                mainForm.Instance.MetroContainer.Controls.Add(uc);
            }
            mainForm.Instance.MetroContainer.Controls[control].BringToFront();
            mainForm.Instance.MetroBack.Visible = true;
        }

        protected override bool ProcessCmdKey(ref Message message, Keys keys)
        {
            switch (keys)
            {
                case Keys.Control | Keys.Tab:
                    {
                        NextTab();
                        return true;
                    }
                case Keys.Control | Keys.Shift | Keys.Tab:
                    {
                        PreviousTab();
                        return true;
                    }
            }
            return base.ProcessCmdKey(ref message, keys);
        }


        private void NextTab()
        {
            //this.TabIndex
        }

        private void PreviousTab()
        {
            //this.TabIndex
        }

    }
}
