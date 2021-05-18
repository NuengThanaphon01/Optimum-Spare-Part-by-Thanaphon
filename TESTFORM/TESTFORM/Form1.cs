using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using MathNet.Numerics;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Sdk;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Server;
using System.Numerics;
using System.Data.Sql;
using System.Collections;


namespace TESTFORM
{
    public partial class Form1 : Form
    {
        public double[] reliabilityarray = new double[9000];
        public int fleetqty = 1;
        public bool chkAVGAC = true;
        public int maxyear = 0;
        public int minyear = 0;
        public int firstmonth = 1;
        public int lastmonth = 12;
        public double avgacperyr = 0;
        public int numberofac = 0;
        public string conString = "Data Source=(local)\\SQLEXPRESS;Integrated Security=True";
        public string tableName = "SPAREPART.dbo.Dataset";
        public ulong timeinterval = 720;

        public Form1()
        {
            InitializeComponent();
            Array.Clear(reliabilityarray, 0, 9000);

        }

        //  DataSet result;
        DataTableCollection tableCollection;

        private void button3_Click(object sender, EventArgs e)
        {
            
            dataExcel.DataSource = null;
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    txtFLoc.Text = openFileDialog.FileName;
                    
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            }
                                );
                            tableCollection = result.Tables;
                            cbYear.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cbYear.Items.Add(table.TableName); //Add sheet to combobox
                            cbYear.Text = "กรุณาเลือกข้อมูล";

                            lblSource.Text = "Source = MS EXCEL";
                            lblSource.Visible = true;
                            
                        }
                    }
                }
            }
        }


        private void btnConnectDB_Click(object sender, EventArgs e)
        {
            dataExcel.DataSource = null;
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM "+ tableName, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dataExcel.DataSource = dt;
                lblSource.Text = "Source = MS SQL Server";
                txtFLoc.Text = con.DataSource;
                lblSource.Visible = true;
                btnCAL.Enabled = true;


                int i = dataExcel.Rows.Count - 1;
                lblDataQTY.Text = i.ToString();

                string duplicatecells = dataExcel.Rows[0].Cells[4].Value.ToString();
                int[] year = new int[dataExcel.Rows.Count - 1];

                for (int j = 0; j < dataExcel.Rows.Count - 1; j++)
                {
                    year[j] = Convert.ToInt32(dataExcel.Rows[j].Cells[4].Value);
                }

                int[] notdubdatayear = year.Distinct().ToArray();
                string[] acregis = new string[dataExcel.Rows.Count];
                Array.Clear(acregis, 0, dataExcel.Rows.Count);
                int numberofac = 0;
                minyear = notdubdatayear.Min();
                maxyear = notdubdatayear.Max();

                for (int k = minyear; k <= maxyear; k++)
                {
                    for (int l = 0; l < dataExcel.Rows.Count - 1; l++)
                    {
                        if (k.ToString() == dataExcel.Rows[l].Cells[4].Value.ToString())
                        {
                            acregis[l] = dataExcel.Rows[l].Cells[5].Value.ToString();
                        }

                    }
                    numberofac = numberofac + acregis.Distinct().Count() - 1;
                    lblacqty.Text = numberofac.ToString();
                    Array.Clear(acregis, 0, dataExcel.Rows.Count);
                }
                avgacperyr = Math.Ceiling(Convert.ToDouble(numberofac) / (maxyear - minyear + 1));
                btnCAL.Enabled = true;


                cbYear.Items.Clear();
                cbYear.Text = tableName;
                btnSpareQTYperAC.Enabled = true;

            }

        }
        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cbYear.SelectedItem.ToString()];
            dataExcel.DataSource = dt;
            int i = dataExcel.Rows.Count - 1;
            lblDataQTY.Text = i.ToString();

            string duplicatecells = dataExcel.Rows[0].Cells[4].Value.ToString();
            int[] year = new int[dataExcel.Rows.Count - 1];

            for (int j = 0; j < dataExcel.Rows.Count - 1; j++)
            {
                year[j] = Convert.ToInt32(dataExcel.Rows[j].Cells[4].Value);
            }

            int[] notdubdatayear = year.Distinct().ToArray();
            string[] acregis = new string[dataExcel.Rows.Count];
            Array.Clear(acregis, 0, dataExcel.Rows.Count);
            int numberofac = 0;
            minyear = notdubdatayear.Min();
            maxyear = notdubdatayear.Max();

            for (int k = minyear; k <= maxyear; k++)
            {
                for (int l = 0; l < dataExcel.Rows.Count - 1; l++)
                {
                    if (k.ToString() == dataExcel.Rows[l].Cells[4].Value.ToString())
                    {
                        acregis[l] = dataExcel.Rows[l].Cells[5].Value.ToString();
                    }

                }
                numberofac = numberofac + acregis.Distinct().Count() - 1;
                lblacqty.Text = numberofac.ToString();
                Array.Clear(acregis, 0, dataExcel.Rows.Count);
            }

            avgacperyr = Math.Ceiling(Convert.ToDouble(numberofac) / (maxyear - minyear + 1));

            /*lblTest.Text = "";
            for (int k = 0; k < notdubdatayear.Length; k++)
            {
                lblTest.Text = lblTest.Text + notdubdatayear[k].ToString();

            }*/
            btnCAL.Enabled = true;
            btnSpareQTYperAC.Enabled = true;



        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.txtTimeInterval.Text = timeinterval.ToString();
            f2.txtFleet.Text = fleetqty.ToString();
            f2.chkAVGAC.Checked = chkAVGAC;
            f2.txtMinYr.Text = minyear.ToString();
            f2.txtMaxYr.Text = maxyear.ToString();
            f2.cmbFirstMonth.Text = firstmonth.ToString();
            f2.cmbLastMonth.Text = lastmonth.ToString();
            f2.ShowDialog();
        }

        private void btnSpareQTYperAC_Click(object sender, EventArgs e)
        {
            string duplicatecells = dataExcel.Rows[0].Cells[2].Value.ToString();

            string[] partnumdatadub = new string[dataExcel.Rows.Count];



            for (int i = 0; i < dataExcel.Rows.Count - 1; i++)
                partnumdatadub[i] = dataExcel.Rows[i].Cells[2].Value.ToString();


            string[] notDupData = partnumdatadub.Distinct().ToArray();

            if (reliabilityarray[0] == 0)
            {
                Array.Clear(reliabilityarray, 0, 9000);
                for (int i= 0;i < notDupData.Length - 1; i++)
                {
                    reliabilityarray[i] = 0.95;
                }
            }

            NumberofInstalledfrm frminstall = new NumberofInstalledfrm(this);


            for (int j = 0; j < notDupData.Length - 1; j++)
            {
                String searchValue = notDupData[j];
                int rowIndex = -1;
                string Partname = "";
                foreach (DataGridViewRow row in dataExcel.Rows)
                {
                    if (row.Cells[2].Value.ToString().Equals(searchValue))
                    {
                        rowIndex = row.Index;
                        Partname = dataExcel.Rows[rowIndex].Cells[1].Value.ToString();
                        break;
                    }
                }
                frminstall.dataInstalled.Rows.Add(j + 1, Partname, notDupData[j], reliabilityarray[j]);

            }


            frminstall.ShowDialog(this);
        }

        private void btnCAL_Click(object sender, EventArgs e)
        {
            string duplicatecells = dataExcel.Rows[0].Cells[2].Value.ToString();
            string[] partnumdatadub = new string[dataExcel.Rows.Count];



            for (int i = 0; i < dataExcel.Rows.Count-1; i++)
            {
                partnumdatadub[i] = dataExcel.Rows[i].Cells[2].Value.ToString();
            }

            string[] notDupData = partnumdatadub.Distinct().ToArray();
            if (reliabilityarray[0] == 0)
            {
                Array.Clear(reliabilityarray, 0, 9000);
                for (int i = 0; i < notDupData.Length - 1; i++)
                {
                    reliabilityarray[i] = 0.95;
                }
            }



            Calculatefrm frmcal = new Calculatefrm();
            string[] PartinEachAC = new string[9000];



            for (int j = 0; j < notDupData.Length-1; j++)
            {
                Array.Clear(PartinEachAC,0,9000);
                String searchValue = notDupData[j];
                int rowIndex = -1;
                string Partname = "";
                double[] failurerate = new double[notDupData.Length];
                failurerate[j] = 0;
                double[] avgprt = new double[notDupData.Length];
                foreach (DataGridViewRow row in dataExcel.Rows)
                {
                    if (row.Cells[2].Value.ToString().Equals(searchValue))
                    {
                        rowIndex = row.Index;
                        Partname = dataExcel.Rows[rowIndex].Cells[1].Value.ToString();
                        break;
                    }
                }

                for (int k = 0; k < Convert.ToInt32(lblDataQTY.Text); k++)
                {

                    if (dataExcel.Rows[k].Cells[2].Value.ToString() == notDupData[j])
                    {

                        failurerate[j] = failurerate[j] + Convert.ToDouble(dataExcel.Rows[k].Cells[3].Value);

                    }

                }
                int numoffullyrs = (maxyear - minyear - 1) * 12;
                int yrs1 = (12 - firstmonth) + 1;
                int totmonths = numoffullyrs + yrs1 + lastmonth;

                for (int i = 0; i < dataExcel.RowCount - 1; i++)
                {
                    if (dataExcel.Rows[i].Cells[2].Value.ToString() == searchValue)
                    {
                        PartinEachAC[i]=dataExcel.Rows[i].Cells[5].Value.ToString() + dataExcel.Rows[i].Cells[7].Value.ToString();
                    }
                }

                //avgprt[j] = failurerate[j] / (PartinEachAC.Distinct().Count()-1);
                avgprt[j] = failurerate[j] / Convert.ToInt32(lblacqty.Text);


                failurerate[j] = (failurerate[j] / totmonths) / (30 * 24);

                double acperyrs = Math.Ceiling(Convert.ToDouble(lblacqty.Text)/(maxyear-minyear+1));

                frmcal.txtACQTY.Text = lblacqty.Text;
                frmcal.txtACAVG.Text = avgacperyr.ToString();
                frmcal.txtTimeInterval.Text = timeinterval.ToString();
                frmcal.lblYear.Text = "ปีที่คำนวณ: " + minyear.ToString() + " - " + maxyear.ToString();

                //double t = (12 / avgacperyr) * 24 * 30;
                //frmcal.lblhrs.Text = t.ToString();

                //Poisson Dist.
                ulong[] partqty = new ulong[notDupData.Length];
                partqty[j] = 0;
                string method = "";
                double[] rt = new double[notDupData.Length];
                Array.Clear(rt, 0, notDupData.Length);
                double mew = avgprt[j] * failurerate[j] * timeinterval* avgacperyr;
                //double mew = avgprt[j] * failurerate[j] * timeinterval* ((PartinEachAC.Distinct().Count() - 1)/5);
                var curve = new MathNet.Numerics.Distributions.Normal();
                var z_value = curve.InverseCumulativeDistribution(reliabilityarray[j]);
                double stock;

                while (rt[j] < reliabilityarray[j])
                {

                    rt[j] += (Math.Pow(mew, partqty[j]) * Math.Exp(-1* mew) / factorial(partqty[j]));
                   // rt[j] = rt[j] + (Math.Pow(mew, partqty[j]) * Math.Exp(-1 * mew) / factorials);
                    if (rt[j]< reliabilityarray[j])
                        partqty[j]++;
                        method = "Poisson Distribution";

                    if (rt[j]>1)
                        {
                        stock = Math.Ceiling(mew + (z_value * Math.Sqrt(mew)));
                        partqty[j] = Convert.ToUInt32(stock);
                        method = "Approximate Normal to Poisson Distribution";
                        rt[j] = Math.Round(reliabilityarray[j],4);
                    } 
                }
                frmcal.datacal.Rows.Add(j + 1, Partname, notDupData[j], Math.Round(failurerate[j],4), Math.Round(avgprt[j],4), partqty[j], reliabilityarray[j], Math.Round(rt[j],4), method); //Add data to cal table
            }


            frmcal.Show(this);
        }


        static ulong factorial(ulong n)
        {
            if (n == 0)
                return 1;

            return n * factorial(n - 1);
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            Credit cf = new Credit();
            cf.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
