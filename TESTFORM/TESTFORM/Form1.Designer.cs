namespace TESTFORM
{
    partial class Form1
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
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDataQTY = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnCAL = new System.Windows.Forms.Button();
            this.dataExcel = new System.Windows.Forms.DataGridView();
            this.txtFLoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOption = new System.Windows.Forms.Button();
            this.btnSpareQTYperAC = new System.Windows.Forms.Button();
            this.lblacqty = new System.Windows.Forms.Label();
            this.btnConnectDB = new System.Windows.Forms.Button();
            this.lblSource = new System.Windows.Forms.Label();
            this.btnCredit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // cbYear
            // 
            this.cbYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(1019, 96);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(155, 21);
            this.cbYear.TabIndex = 1;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(1015, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "ข้อมูลที่กำลังแสดงจาก";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(956, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "จำนวนข้อมูล :";
            // 
            // lblDataQTY
            // 
            this.lblDataQTY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataQTY.AutoSize = true;
            this.lblDataQTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDataQTY.Location = new System.Drawing.Point(1054, 139);
            this.lblDataQTY.Name = "lblDataQTY";
            this.lblDataQTY.Size = new System.Drawing.Size(161, 24);
            this.lblDataQTY.TabIndex = 12;
            this.lblDataQTY.Text = "ยังไม่ได้เลือกชุดข้อมูล";
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImport.Location = new System.Drawing.Point(12, 582);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(159, 23);
            this.btnImport.TabIndex = 13;
            this.btnImport.Text = "นำเข้าข้อมูลจาก EXCEL";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCAL
            // 
            this.btnCAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCAL.Enabled = false;
            this.btnCAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCAL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCAL.Location = new System.Drawing.Point(993, 516);
            this.btnCAL.Name = "btnCAL";
            this.btnCAL.Size = new System.Drawing.Size(214, 59);
            this.btnCAL.TabIndex = 14;
            this.btnCAL.Text = "คำนวณปริมาณที่เหมาะสม";
            this.btnCAL.UseVisualStyleBackColor = true;
            this.btnCAL.Click += new System.EventHandler(this.btnCAL_Click);
            // 
            // dataExcel
            // 
            this.dataExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataExcel.Location = new System.Drawing.Point(12, 70);
            this.dataExcel.Name = "dataExcel";
            this.dataExcel.Size = new System.Drawing.Size(935, 506);
            this.dataExcel.TabIndex = 16;
            // 
            // txtFLoc
            // 
            this.txtFLoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFLoc.Location = new System.Drawing.Point(123, 12);
            this.txtFLoc.MinimumSize = new System.Drawing.Size(300, 4);
            this.txtFLoc.Name = "txtFLoc";
            this.txtFLoc.ReadOnly = true;
            this.txtFLoc.Size = new System.Drawing.Size(531, 20);
            this.txtFLoc.TabIndex = 17;
            this.txtFLoc.Text = "ยังไม่ได้เลือกแหล่งข้อมูล";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "กำลังอ่านข้อมูลจาก :";
            // 
            // btnOption
            // 
            this.btnOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOption.Location = new System.Drawing.Point(993, 193);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(214, 23);
            this.btnOption.TabIndex = 19;
            this.btnOption.Text = "การตั้งค่า";
            this.btnOption.UseVisualStyleBackColor = true;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // btnSpareQTYperAC
            // 
            this.btnSpareQTYperAC.Enabled = false;
            this.btnSpareQTYperAC.Location = new System.Drawing.Point(993, 233);
            this.btnSpareQTYperAC.Name = "btnSpareQTYperAC";
            this.btnSpareQTYperAC.Size = new System.Drawing.Size(214, 23);
            this.btnSpareQTYperAC.TabIndex = 21;
            this.btnSpareQTYperAC.Text = "การปรับค่าความน่าเชื่อถือ";
            this.btnSpareQTYperAC.UseVisualStyleBackColor = true;
            this.btnSpareQTYperAC.Click += new System.EventHandler(this.btnSpareQTYperAC_Click);
            // 
            // lblacqty
            // 
            this.lblacqty.AutoSize = true;
            this.lblacqty.Location = new System.Drawing.Point(1180, 608);
            this.lblacqty.Name = "lblacqty";
            this.lblacqty.Size = new System.Drawing.Size(35, 13);
            this.lblacqty.TabIndex = 23;
            this.lblacqty.Text = "label3";
            this.lblacqty.Visible = false;
            // 
            // btnConnectDB
            // 
            this.btnConnectDB.Location = new System.Drawing.Point(177, 582);
            this.btnConnectDB.Name = "btnConnectDB";
            this.btnConnectDB.Size = new System.Drawing.Size(159, 23);
            this.btnConnectDB.TabIndex = 24;
            this.btnConnectDB.Text = "เชื่อมต่อฐานข้อมูล";
            this.btnConnectDB.UseVisualStyleBackColor = true;
            this.btnConnectDB.Click += new System.EventHandler(this.btnConnectDB_Click);
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSource.Location = new System.Drawing.Point(18, 35);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(234, 20);
            this.lblSource.TabIndex = 25;
            this.lblSource.Text = "<แสดงแหล่งข้อมูล> (DEF: Hidden)";
            this.lblSource.Visible = false;
            // 
            // btnCredit
            // 
            this.btnCredit.Location = new System.Drawing.Point(824, 582);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(123, 23);
            this.btnCredit.TabIndex = 26;
            this.btnCredit.Text = "เกี่ยวกับฉัน";
            this.btnCredit.UseVisualStyleBackColor = true;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 630);
            this.Controls.Add(this.btnCredit);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.btnConnectDB);
            this.Controls.Add(this.lblacqty);
            this.Controls.Add(this.btnSpareQTYperAC);
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFLoc);
            this.Controls.Add(this.dataExcel);
            this.Controls.Add(this.btnCAL);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lblDataQTY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form1";
            this.Text = "Spare Part Management Programs";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDataQTY;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnCAL;
        private System.Windows.Forms.DataGridView dataExcel;
        private System.Windows.Forms.TextBox txtFLoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.Button btnSpareQTYperAC;
        private System.Windows.Forms.Label lblacqty;
        private System.Windows.Forms.Button btnConnectDB;
        public System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Button btnCredit;
    }
}

