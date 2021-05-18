using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace TESTFORM
{
    public partial class Calculatefrm : Form
    {
        public Calculatefrm()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Optimum Spare Parts";
            printer.SubTitle = lblYear.Text;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            
            printer.Footer = string.Format("Print Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(datacal);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
