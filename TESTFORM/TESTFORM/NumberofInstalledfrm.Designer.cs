
namespace TESTFORM
{
    partial class NumberofInstalledfrm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.dataInstalled = new System.Windows.Forms.DataGridView();
            this.ColSeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkReliability = new System.Windows.Forms.CheckBox();
            this.numRT = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataInstalled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(673, 39);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "ตกลง";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dataInstalled
            // 
            this.dataInstalled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInstalled.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSeq,
            this.ColPName,
            this.ColPNumber,
            this.ColQTY});
            this.dataInstalled.Location = new System.Drawing.Point(16, 30);
            this.dataInstalled.Name = "dataInstalled";
            this.dataInstalled.Size = new System.Drawing.Size(622, 408);
            this.dataInstalled.TabIndex = 3;
            // 
            // ColSeq
            // 
            this.ColSeq.HeaderText = "ลำดับ";
            this.ColSeq.Name = "ColSeq";
            // 
            // ColPName
            // 
            this.ColPName.HeaderText = "ชื่ออะไหล่";
            this.ColPName.Name = "ColPName";
            this.ColPName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColPName.Width = 150;
            // 
            // ColPNumber
            // 
            this.ColPNumber.HeaderText = "หมายเลขอะไหล่";
            this.ColPNumber.Name = "ColPNumber";
            this.ColPNumber.Width = 150;
            // 
            // ColQTY
            // 
            this.ColQTY.HeaderText = "ค่าความน่าเชื่อถือ";
            this.ColQTY.Name = "ColQTY";
            this.ColQTY.Width = 150;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(673, 82);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkReliability
            // 
            this.chkReliability.AutoSize = true;
            this.chkReliability.Location = new System.Drawing.Point(657, 132);
            this.chkReliability.Name = "chkReliability";
            this.chkReliability.Size = new System.Drawing.Size(174, 17);
            this.chkReliability.TabIndex = 5;
            this.chkReliability.Text = "กำหนดค่าความน่าเชื่อถือทั้งหมด";
            this.chkReliability.UseVisualStyleBackColor = true;
            this.chkReliability.CheckedChanged += new System.EventHandler(this.chkReliability_CheckedChanged);
            // 
            // numRT
            // 
            this.numRT.DecimalPlaces = 2;
            this.numRT.Enabled = false;
            this.numRT.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numRT.Location = new System.Drawing.Point(705, 165);
            this.numRT.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRT.Name = "numRT";
            this.numRT.Size = new System.Drawing.Size(76, 20);
            this.numRT.TabIndex = 6;
            this.numRT.Value = new decimal(new int[] {
            95,
            0,
            0,
            131072});
            // 
            // NumberofInstalledfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 458);
            this.Controls.Add(this.numRT);
            this.Controls.Add(this.chkReliability);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataInstalled);
            this.Controls.Add(this.btnSave);
            this.Name = "NumberofInstalledfrm";
            this.Text = "กำหนดค่าความน่าเชื่อถือ";
            ((System.ComponentModel.ISupportInitialize)(this.dataInstalled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.DataGridView dataInstalled;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSeq;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQTY;
        private System.Windows.Forms.CheckBox chkReliability;
        private System.Windows.Forms.NumericUpDown numRT;
    }
}