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
    public partial class NumberofInstalledfrm : Form
    {
        Form1 f1;
        public NumberofInstalledfrm(Form1 frm1)
        {
            InitializeComponent();
            f1 = frm1;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (chkReliability.Checked == false)
            {
                int i = 0;
                foreach (DataGridViewRow row in dataInstalled.Rows)
                {
                    f1.reliabilityarray[i] = Convert.ToDouble(dataInstalled.Rows[i].Cells[3].Value);
                    i++;
                }
            }
            else
            {
                int i = 0;
                foreach (DataGridViewRow row in dataInstalled.Rows)
                {
                    f1.reliabilityarray[i] = Convert.ToDouble(numRT.Value);
                    i++;
                }

            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkReliability_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReliability.Checked == true)
            {
                numRT.Enabled = true;
                dataInstalled.Enabled = false;

            }
            else if (chkReliability.Checked == false)
                {
                    numRT.Enabled = false;
                    dataInstalled.Enabled = true;
                }
        }
    }
}
