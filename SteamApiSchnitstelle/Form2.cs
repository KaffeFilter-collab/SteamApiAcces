﻿using System;
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
        public Form1() { set; get; }

        private string appid;
        public fmSettings()
        {
            InitializeComponent();
        }
        fd

        private void txtAppId_TextChanged(object sender, EventArgs e)
        {
            if  (txtAppId.Text != String.Empty && txtAppId.Text != "") appid = txtAppId.Text;
        }

        private void btnSafe_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
