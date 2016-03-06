namespace TimeClockApp
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
            this.dtpPayStart = new System.Windows.Forms.DateTimePicker();
            this.dtpPayEnd = new System.Windows.Forms.DateTimePicker();
            this.lblPayStart = new System.Windows.Forms.Label();
            this.lblPayEnd = new System.Windows.Forms.Label();
            this.btnCalcEmpHours = new System.Windows.Forms.Button();
            this.lbEmpHours = new System.Windows.Forms.ListBox();
            this.dgvEmpHours = new System.Windows.Forms.DataGridView();
            this.colEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpHours)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpPayStart
            // 
            this.dtpPayStart.Location = new System.Drawing.Point(130, 9);
            this.dtpPayStart.Name = "dtpPayStart";
            this.dtpPayStart.Size = new System.Drawing.Size(200, 20);
            this.dtpPayStart.TabIndex = 0;
            this.dtpPayStart.ValueChanged += new System.EventHandler(this.dtpPayStart_ValueChanged);
            // 
            // dtpPayEnd
            // 
            this.dtpPayEnd.Location = new System.Drawing.Point(130, 35);
            this.dtpPayEnd.Name = "dtpPayEnd";
            this.dtpPayEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpPayEnd.TabIndex = 1;
            this.dtpPayEnd.ValueChanged += new System.EventHandler(this.dtpPayEnd_ValueChanged);
            // 
            // lblPayStart
            // 
            this.lblPayStart.AutoSize = true;
            this.lblPayStart.Location = new System.Drawing.Point(12, 9);
            this.lblPayStart.Name = "lblPayStart";
            this.lblPayStart.Size = new System.Drawing.Size(112, 13);
            this.lblPayStart.TabIndex = 2;
            this.lblPayStart.Text = "Pay Period Start Date:";
            // 
            // lblPayEnd
            // 
            this.lblPayEnd.AutoSize = true;
            this.lblPayEnd.Location = new System.Drawing.Point(12, 35);
            this.lblPayEnd.Name = "lblPayEnd";
            this.lblPayEnd.Size = new System.Drawing.Size(109, 13);
            this.lblPayEnd.TabIndex = 3;
            this.lblPayEnd.Text = "Pay Period End Date:";
            // 
            // btnCalcEmpHours
            // 
            this.btnCalcEmpHours.Location = new System.Drawing.Point(12, 61);
            this.btnCalcEmpHours.Name = "btnCalcEmpHours";
            this.btnCalcEmpHours.Size = new System.Drawing.Size(144, 23);
            this.btnCalcEmpHours.TabIndex = 5;
            this.btnCalcEmpHours.Text = "Calculate Employee Hours";
            this.btnCalcEmpHours.UseVisualStyleBackColor = true;
            this.btnCalcEmpHours.Click += new System.EventHandler(this.btnCalcEmpHours_Click);
            // 
            // lbEmpHours
            // 
            this.lbEmpHours.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbEmpHours.FormattingEnabled = true;
            this.lbEmpHours.Location = new System.Drawing.Point(12, 90);
            this.lbEmpHours.Name = "lbEmpHours";
            this.lbEmpHours.Size = new System.Drawing.Size(277, 537);
            this.lbEmpHours.TabIndex = 6;
            // 
            // dgvEmpHours
            // 
            this.dgvEmpHours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpHours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmpHours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpHours.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmployee,
            this.colDate,
            this.colDescription,
            this.colLocation,
            this.colStart,
            this.colEnd,
            this.colHours});
            this.dgvEmpHours.Location = new System.Drawing.Point(295, 90);
            this.dgvEmpHours.Name = "dgvEmpHours";
            this.dgvEmpHours.Size = new System.Drawing.Size(643, 537);
            this.dgvEmpHours.TabIndex = 7;
            // 
            // colEmployee
            // 
            this.colEmployee.HeaderText = "Employee";
            this.colEmployee.Name = "colEmployee";
            this.colEmployee.ReadOnly = true;
            this.colEmployee.Width = 78;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 55;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Width = 85;
            // 
            // colLocation
            // 
            this.colLocation.HeaderText = "Location";
            this.colLocation.Name = "colLocation";
            this.colLocation.ReadOnly = true;
            this.colLocation.Width = 73;
            // 
            // colStart
            // 
            this.colStart.HeaderText = "Start Time";
            this.colStart.Name = "colStart";
            this.colStart.ReadOnly = true;
            this.colStart.Width = 80;
            // 
            // colEnd
            // 
            this.colEnd.HeaderText = "End Time";
            this.colEnd.Name = "colEnd";
            this.colEnd.ReadOnly = true;
            this.colEnd.Width = 77;
            // 
            // colHours
            // 
            this.colHours.HeaderText = "Hours Worked";
            this.colHours.Name = "colHours";
            this.colHours.ReadOnly = true;
            this.colHours.Width = 101;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 632);
            this.Controls.Add(this.dgvEmpHours);
            this.Controls.Add(this.lbEmpHours);
            this.Controls.Add(this.btnCalcEmpHours);
            this.Controls.Add(this.lblPayEnd);
            this.Controls.Add(this.lblPayStart);
            this.Controls.Add(this.dtpPayEnd);
            this.Controls.Add(this.dtpPayStart);
            this.Name = "Form1";
            this.Text = "MBA Time Clock";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpPayStart;
        private System.Windows.Forms.DateTimePicker dtpPayEnd;
        private System.Windows.Forms.Label lblPayStart;
        private System.Windows.Forms.Label lblPayEnd;
        private System.Windows.Forms.Button btnCalcEmpHours;
        private System.Windows.Forms.ListBox lbEmpHours;
        private System.Windows.Forms.DataGridView dgvEmpHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHours;
    }
}

