
namespace TESTFORM
{
    partial class Calculatefrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.datacal = new System.Windows.Forms.DataGridView();
            this.lblAC = new System.Windows.Forms.Label();
            this.lblAVGAClbl = new System.Windows.Forms.Label();
            this.lblhrs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtACQTY = new System.Windows.Forms.TextBox();
            this.txtACAVG = new System.Windows.Forms.TextBox();
            this.txtTimeInterval = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.ColSEQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFailure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNumberInstalled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSpare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRTSetting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColReliability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datacal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(12, 512);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(169, 23);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "พิมพ์รายงาน";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(1032, 51);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(141, 27);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "ตกลง";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // datacal
            // 
            this.datacal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datacal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datacal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSEQ,
            this.ColPName,
            this.ColPNumber,
            this.ColFailure,
            this.ColNumberInstalled,
            this.ColSpare,
            this.ColRTSetting,
            this.ColReliability,
            this.ColMethod});
            this.datacal.Location = new System.Drawing.Point(12, 12);
            this.datacal.Name = "datacal";
            this.datacal.Size = new System.Drawing.Size(951, 494);
            this.datacal.TabIndex = 3;
            // 
            // lblAC
            // 
            this.lblAC.AutoSize = true;
            this.lblAC.Location = new System.Drawing.Point(985, 115);
            this.lblAC.Name = "lblAC";
            this.lblAC.Size = new System.Drawing.Size(130, 13);
            this.lblAC.TabIndex = 4;
            this.lblAC.Text = "จำนวนอากาศยานในข้อมูล";
            // 
            // lblAVGAClbl
            // 
            this.lblAVGAClbl.AutoSize = true;
            this.lblAVGAClbl.Location = new System.Drawing.Point(1004, 144);
            this.lblAVGAClbl.Name = "lblAVGAClbl";
            this.lblAVGAClbl.Size = new System.Drawing.Size(111, 13);
            this.lblAVGAClbl.TabIndex = 6;
            this.lblAVGAClbl.Text = "จำนวนอากาศยานต่อปี";
            // 
            // lblhrs
            // 
            this.lblhrs.AutoSize = true;
            this.lblhrs.Location = new System.Drawing.Point(1174, 517);
            this.lblhrs.Name = "lblhrs";
            this.lblhrs.Size = new System.Drawing.Size(44, 13);
            this.lblhrs.TabIndex = 7;
            this.lblhrs.Text = "ACHRS";
            this.lblhrs.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1019, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ระยะเวลา Restock";
            // 
            // txtACQTY
            // 
            this.txtACQTY.Location = new System.Drawing.Point(1120, 112);
            this.txtACQTY.Name = "txtACQTY";
            this.txtACQTY.ReadOnly = true;
            this.txtACQTY.Size = new System.Drawing.Size(73, 20);
            this.txtACQTY.TabIndex = 9;
            this.txtACQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtACAVG
            // 
            this.txtACAVG.Location = new System.Drawing.Point(1120, 141);
            this.txtACAVG.Name = "txtACAVG";
            this.txtACAVG.ReadOnly = true;
            this.txtACAVG.Size = new System.Drawing.Size(73, 20);
            this.txtACAVG.TabIndex = 9;
            this.txtACAVG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTimeInterval
            // 
            this.txtTimeInterval.Location = new System.Drawing.Point(1120, 171);
            this.txtTimeInterval.Name = "txtTimeInterval";
            this.txtTimeInterval.ReadOnly = true;
            this.txtTimeInterval.Size = new System.Drawing.Size(73, 20);
            this.txtTimeInterval.TabIndex = 9;
            this.txtTimeInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(1019, 204);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 10;
            this.lblYear.Text = "Year";
            // 
            // ColSEQ
            // 
            this.ColSEQ.HeaderText = "ลำดับ";
            this.ColSEQ.Name = "ColSEQ";
            // 
            // ColPName
            // 
            this.ColPName.HeaderText = "ชื่ออะไหล่";
            this.ColPName.Name = "ColPName";
            // 
            // ColPNumber
            // 
            this.ColPNumber.HeaderText = "หมายเลขอะไหล่";
            this.ColPNumber.Name = "ColPNumber";
            // 
            // ColFailure
            // 
            this.ColFailure.HeaderText = "อัตราชำรุดต่อชั่วโมง";
            this.ColFailure.Name = "ColFailure";
            // 
            // ColNumberInstalled
            // 
            this.ColNumberInstalled.HeaderText = "จำนวนเฉลี่ยที่เสียต่อเดือน";
            this.ColNumberInstalled.Name = "ColNumberInstalled";
            // 
            // ColSpare
            // 
            this.ColSpare.HeaderText = "จำนวนอะไหล่ที่เหมาะสม";
            this.ColSpare.Name = "ColSpare";
            // 
            // ColRTSetting
            // 
            this.ColRTSetting.HeaderText = "ความน่าเชื่อถือที่กำหนด";
            this.ColRTSetting.Name = "ColRTSetting";
            // 
            // ColReliability
            // 
            this.ColReliability.HeaderText = "ความน่าเชื่อถือที่คำนวณได้";
            this.ColReliability.Name = "ColReliability";
            // 
            // ColMethod
            // 
            this.ColMethod.HeaderText = "หลักการคำนวณ";
            this.ColMethod.Name = "ColMethod";
            // 
            // Calculatefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 547);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtTimeInterval);
            this.Controls.Add(this.txtACAVG);
            this.Controls.Add(this.txtACQTY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblhrs);
            this.Controls.Add(this.lblAVGAClbl);
            this.Controls.Add(this.lblAC);
            this.Controls.Add(this.datacal);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnPrint);
            this.Name = "Calculatefrm";
            this.Text = "Calcurated Form";
            ((System.ComponentModel.ISupportInitialize)(this.datacal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.DataGridView datacal;
        private System.Windows.Forms.Label lblAC;
        private System.Windows.Forms.Label lblAVGAClbl;
        public System.Windows.Forms.Label lblhrs;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtACQTY;
        public System.Windows.Forms.TextBox txtACAVG;
        public System.Windows.Forms.TextBox txtTimeInterval;
        public System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSEQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFailure;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumberInstalled;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSpare;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRTSetting;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColReliability;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMethod;
    }
}