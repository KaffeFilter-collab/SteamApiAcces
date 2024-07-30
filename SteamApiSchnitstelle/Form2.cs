using SteamWebAPI2.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamApiSchnitstelle
{   
    public partial class fmSettings : Form
    {

        public string settingsAppId;
        public string settingsUserID;
        public string settingsApiKey;
       
        public fmSettings()
        {
            InitializeComponent();
        }
        

        private void txtAppId_TextChanged(object sender, EventArgs e)
        {
            if  (txtAppId.Text != String.Empty && txtAppId.Text != "") settingsAppId = txtAppId.Text;
        }


        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            settingsUserID = txtUserID.Text;
        }

        private void txtApiKey_TextChanged(object sender, EventArgs e)
        {
          settingsApiKey = txtApiKey.Text;

        }
        private void btnSafe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
