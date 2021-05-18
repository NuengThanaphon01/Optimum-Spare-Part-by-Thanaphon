
namespace TESTFORM
{
    partial class Form2
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtTimeInterval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFleet = new System.Windows.Forms.TextBox();
            this.lblACFLT = new System.Windows.Forms.Label();
            this.chkAVGAC = new System.Windows.Forms.CheckBox();
            this.txtMinYr = new System.Windows.Forms.TextBox();
            this.txtMaxYr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFirstMonth = new System.Windows.Forms.ComboBox();
            this.cmbLastMonth = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(377, 36);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(117, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "ตกลง";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(377, 65);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtTimeInterval
            // 
            this.txtTimeInterval.Location = new System.Drawing.Point(215, 38);
            this.txtTimeInterval.Name = "txtTimeInterval";
            this.txtTimeInterval.Size = new System.Drawing.Size(102, 20);
            this.txtTimeInterval.TabIndex = 2;
            this.txtTimeInterval.Text = "720";
            this.txtTimeInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "วงรอบในการสั่งของ";
            // 
            // txtFleet
            // 
            this.txtFleet.Enabled = false;
            this.txtFleet.Location = new System.Drawing.Point(215, 67);
            this.txtFleet.Name = "txtFleet";
            this.txtFleet.Size = new System.Drawing.Size(102, 20);
            this.txtFleet.TabIndex = 4;
            this.txtFleet.Text = "1";
            this.txtFleet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblACFLT
            // 
            this.lblACFLT.AutoSize = true;
            this.lblACFLT.Location = new System.Drawing.Point(92, 70);
            this.lblACFLT.Name = "lblACFLT";
            this.lblACFLT.Size = new System.Drawing.Size(117, 13);
            this.lblACFLT.TabIndex = 5;
            this.lblACFLT.Text = "จำนวนเครื่องบินทั้งหมด";
            // 
            // chkAVGAC
            // 
            this.chkAVGAC.AutoSize = true;
            this.chkAVGAC.Checked = true;
            this.chkAVGAC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAVGAC.Location = new System.Drawing.Point(146, 94);
            this.chkAVGAC.Name = "chkAVGAC";
            this.chkAVGAC.Size = new System.Drawing.Size(174, 17);
            this.chkAVGAC.TabIndex = 6;
            this.chkAVGAC.Text = "ใช้ค่าเฉลี่ยเครื่องบินในชุดข้อมูล";
            this.chkAVGAC.UseVisualStyleBackColor = true;
            this.chkAVGAC.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtMinYr
            // 
            this.txtMinYr.Location = new System.Drawing.Point(146, 117);
            this.txtMinYr.Name = "txtMinYr";
            this.txtMinYr.Size = new System.Drawing.Size(70, 20);
            this.txtMinYr.TabIndex = 7;
            // 
            // txtMaxYr
            // 
            this.txtMaxYr.Location = new System.Drawing.Point(247, 117);
            this.txtMaxYr.Name = "txtMaxYr";
            this.txtMaxYr.Size = new System.Drawing.Size(70, 20);
            this.txtMaxYr.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ถึง";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ปีที่ใช้คำนวณ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "เดือนของปีแรกที่ใช้คำนวณ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "เดือนของปีสุดท้ายที่ใช้คำนวณ";
            // 
            // cmbFirstMonth
            // 
            this.cmbFirstMonth.FormattingEnabled = true;
            this.cmbFirstMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbFirstMonth.Location = new System.Drawing.Point(182, 143);
            this.cmbFirstMonth.Name = "cmbFirstMonth";
            this.cmbFirstMonth.Size = new System.Drawing.Size(135, 21);
            this.cmbFirstMonth.TabIndex = 11;
            // 
            // cmbLastMonth
            // 
            this.cmbLastMonth.FormattingEnabled = true;
            this.cmbLastMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbLastMonth.Location = new System.Drawing.Point(182, 170);
            this.cmbLastMonth.Name = "cmbLastMonth";
            this.cmbLastMonth.Size = new System.Drawing.Size(135, 21);
            this.cmbLastMonth.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "ชั่วโมง";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(508, 236);
            this.Controls.Add(this.cmbLastMonth);
            this.Controls.Add(this.cmbFirstMonth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaxYr);
            this.Controls.Add(this.txtMinYr);
            this.Controls.Add(this.chkAVGAC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblACFLT);
            this.Controls.Add(this.txtFleet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimeInterval);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.Text = "การตั้งค่า";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblACFLT;
        public System.Windows.Forms.CheckBox chkAVGAC;
        public System.Windows.Forms.TextBox txtTimeInterval;
        public System.Windows.Forms.TextBox txtFleet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtMinYr;
        public System.Windows.Forms.TextBox txtMaxYr;
        public System.Windows.Forms.ComboBox cmbFirstMonth;
        public System.Windows.Forms.ComboBox cmbLastMonth;
        private System.Windows.Forms.Label label6;
    }
}