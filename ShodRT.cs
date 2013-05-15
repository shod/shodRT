using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShodRT
{
    public partial class ShodRT : Form
    {
        public ShodRT()
        {
            InitializeComponent();
        }

        private void btnHN_Click(object sender, EventArgs e)
        {
            Form frmHexNum = new HexNum();
            frmHexNum.Show();
        }

 
    }
}