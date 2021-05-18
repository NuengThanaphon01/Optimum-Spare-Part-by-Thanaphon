using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTFORM
{
    public partial class Form2 : Form
    {

        Form1 f1;
        public Form2(Form1 frm1)
        {
            InitializeComponent();
           f1 = frm1;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
                f1.timeinterval = Convert.ToUInt32(txtTimeInterval.Text);
                f1.fleetqty = Convert.ToInt32(txtFleet.Text);
                f1.chkAVGAC = chkAVGAC.Checked;
                f1.minyear = Convert.ToInt32(txtMinYr.Text);
                f1.maxyear = Convert.ToInt32(txtMaxYr.Text);
                f1.firstmonth = Convert.ToInt32(cmbFirstMonth.Text);
                f1.lastmonth = Convert.ToInt32(cmbLastMonth.Text);
            //  f1.lblRelia.Text = txtReliability.Text;
            //  f1.lblFleet.Text = txtFleet.Text;
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAVGAC.Checked == true)
                txtFleet.Enabled = false;
            else
                txtFleet.Enabled = true;
        }
    }
}
