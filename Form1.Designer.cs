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
            this.lbTotals = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbResults = new System.Windows.Forms.TextBox();
            this.tabOptions = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvEmpHours = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtpJobLaborStart = new System.Windows.Forms.DateTimePicker();
            this.dtpJobLaborEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvJobLabor = new System.Windows.Forms.DataGridView();
            this.colEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJobEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJobDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJobSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJobDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJobLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJobStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJobEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJobHoursWorked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabOptions.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpHours)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobLabor)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpPayStart
            // 
            this.dtpPayStart.Location = new System.Drawing.Point(124, 6);
            this.dtpPayStart.Name = "dtpPayStart";
            this.dtpPayStart.Size = new System.Drawing.Size(200, 20);
            this.dtpPayStart.TabIndex = 0;
            this.dtpPayStart.ValueChanged += new System.EventHandler(this.dtpPayStart_ValueChanged);
            // 
            // dtpPayEnd
            // 
            this.dtpPayEnd.Location = new System.Drawing.Point(124, 32);
            this.dtpPayEnd.Name = "dtpPayEnd";
            this.dtpPayEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpPayEnd.TabIndex = 1;
            this.dtpPayEnd.ValueChanged += new System.EventHandler(this.dtpPayEnd_ValueChanged);
            // 
            // lblPayStart
            // 
            this.lblPayStart.AutoSize = true;
            this.lblPayStart.Location = new System.Drawing.Point(6, 6);
            this.lblPayStart.Name = "lblPayStart";
            this.lblPayStart.Size = new System.Drawing.Size(112, 13);
            this.lblPayStart.TabIndex = 2;
            this.lblPayStart.Text = "Pay Period Start Date:";
            // 
            // lblPayEnd
            // 
            this.lblPayEnd.AutoSize = true;
            this.lblPayEnd.Location = new System.Drawing.Point(6, 32);
            this.lblPayEnd.Name = "lblPayEnd";
            this.lblPayEnd.Size = new System.Drawing.Size(109, 13);
            this.lblPayEnd.TabIndex = 3;
            this.lblPayEnd.Text = "Pay Period End Date:";
            // 
            // btnCalcEmpHours
            // 
            this.btnCalcEmpHours.Location = new System.Drawing.Point(143, 67);
            this.btnCalcEmpHours.Name = "btnCalcEmpHours";
            this.btnCalcEmpHours.Size = new System.Drawing.Size(144, 23);
            this.btnCalcEmpHours.TabIndex = 2;
            this.btnCalcEmpHours.Text = "Calculate Employee Hours";
            this.btnCalcEmpHours.UseVisualStyleBackColor = true;
            this.btnCalcEmpHours.Click += new System.EventHandler(this.btnCalcEmpHours_Click);
            // 
            // lbTotals
            // 
            this.lbTotals.FormattingEnabled = true;
            this.lbTotals.Location = new System.Drawing.Point(143, 126);
            this.lbTotals.Name = "lbTotals";
            this.lbTotals.Size = new System.Drawing.Size(188, 290);
            this.lbTotals.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Employee hours for pay period:";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(224, 82);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 20);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(143, 80);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbResults
            // 
            this.tbResults.Location = new System.Drawing.Point(224, 108);
            this.tbResults.Name = "tbResults";
            this.tbResults.ReadOnly = true;
            this.tbResults.Size = new System.Drawing.Size(100, 20);
            this.tbResults.TabIndex = 12;
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.tabPage1);
            this.tabOptions.Controls.Add(this.tabPage2);
            this.tabOptions.Location = new System.Drawing.Point(12, 12);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.SelectedIndex = 0;
            this.tabOptions.Size = new System.Drawing.Size(1393, 608);
            this.tabOptions.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.dgvEmpHours);
            this.tabPage1.Controls.Add(this.dtpPayStart);
            this.tabPage1.Controls.Add(this.dtpPayEnd);
            this.tabPage1.Controls.Add(this.lblPayStart);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblPayEnd);
            this.tabPage1.Controls.Add(this.lbTotals);
            this.tabPage1.Controls.Add(this.btnCalcEmpHours);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1385, 582);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Calculate Employee Hours";
            // 
            // dgvEmpHours
            // 
            this.dgvEmpHours.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvEmpHours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmpHours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpHours.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmployee,
            this.colDate,
            this.colSummary,
            this.colDescription,
            this.colLocation,
            this.colStart,
            this.colEnd,
            this.colHours});
            this.dgvEmpHours.Location = new System.Drawing.Point(378, 6);
            this.dgvEmpHours.Name = "dgvEmpHours";
            this.dgvEmpHours.Size = new System.Drawing.Size(1002, 570);
            this.dgvEmpHours.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.dtpJobLaborStart);
            this.tabPage2.Controls.Add(this.dtpJobLaborEnd);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dgvJobLabor);
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Controls.Add(this.tbResults);
            this.tabPage2.Controls.Add(this.tbSearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1385, 582);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calculate Job Labor";
            // 
            // dtpJobLaborStart
            // 
            this.dtpJobLaborStart.Location = new System.Drawing.Point(124, 6);
            this.dtpJobLaborStart.Name = "dtpJobLaborStart";
            this.dtpJobLaborStart.Size = new System.Drawing.Size(200, 20);
            this.dtpJobLaborStart.TabIndex = 14;
            this.dtpJobLaborStart.ValueChanged += new System.EventHandler(this.dtpJobLaborStart_ValueChanged);
            // 
            // dtpJobLaborEnd
            // 
            this.dtpJobLaborEnd.Location = new System.Drawing.Point(124, 32);
            this.dtpJobLaborEnd.Name = "dtpJobLaborEnd";
            this.dtpJobLaborEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpJobLaborEnd.TabIndex = 15;
            this.dtpJobLaborEnd.ValueChanged += new System.EventHandler(this.dtpJobLaborEnd_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Pay Period Start Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Pay Period End Date:";
            // 
            // dgvJobLabor
            // 
            this.dgvJobLabor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvJobLabor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvJobLabor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobLabor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colJobEmployee,
            this.colJobDate,
            this.colJobSummary,
            this.colJobDescription,
            this.colJobLocation,
            this.colJobStartTime,
            this.colJobEndTime,
            this.colJobHoursWorked});
            this.dgvJobLabor.Location = new System.Drawing.Point(378, 6);
            this.dgvJobLabor.Name = "dgvJobLabor";
            this.dgvJobLabor.Size = new System.Drawing.Size(1002, 570);
            this.dgvJobLabor.TabIndex = 13;
            // 
            // colEmployee
            // 
            this.colEmployee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colEmployee.HeaderText = "Employee";
            this.colEmployee.Name = "colEmployee";
            this.colEmployee.ReadOnly = true;
            this.colEmployee.Width = 150;
            // 
            // colDate
            // 
            this.colDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 65;
            // 
            // colSummary
            // 
            this.colSummary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSummary.HeaderText = "Summary";
            this.colSummary.Name = "colSummary";
            this.colSummary.ReadOnly = true;
            this.colSummary.Width = 200;
            // 
            // colDescription
            // 
            this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Width = 200;
            // 
            // colLocation
            // 
            this.colLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colLocation.HeaderText = "Location";
            this.colLocation.Name = "colLocation";
            this.colLocation.ReadOnly = true;
            this.colLocation.Width = 150;
            // 
            // colStart
            // 
            this.colStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colStart.HeaderText = "Start Time";
            this.colStart.Name = "colStart";
            this.colStart.ReadOnly = true;
            this.colStart.Width = 60;
            // 
            // colEnd
            // 
            this.colEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colEnd.HeaderText = "End Time";
            this.colEnd.Name = "colEnd";
            this.colEnd.ReadOnly = true;
            this.colEnd.Width = 60;
            // 
            // colHours
            // 
            this.colHours.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colHours.HeaderText = "Hours Worked";
            this.colHours.Name = "colHours";
            this.colHours.ReadOnly = true;
            this.colHours.Width = 74;
            // 
            // colJobEmployee
            // 
            this.colJobEmployee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colJobEmployee.HeaderText = "Employee";
            this.colJobEmployee.Name = "colJobEmployee";
            this.colJobEmployee.ReadOnly = true;
            this.colJobEmployee.Width = 150;
            // 
            // colJobDate
            // 
            this.colJobDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colJobDate.HeaderText = "Date";
            this.colJobDate.Name = "colJobDate";
            this.colJobDate.ReadOnly = true;
            this.colJobDate.Width = 65;
            // 
            // colJobSummary
            // 
            this.colJobSummary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colJobSummary.HeaderText = "Summary";
            this.colJobSummary.Name = "colJobSummary";
            this.colJobSummary.ReadOnly = true;
            this.colJobSummary.Width = 200;
            // 
            // colJobDescription
            // 
            this.colJobDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colJobDescription.HeaderText = "Description";
            this.colJobDescription.Name = "colJobDescription";
            this.colJobDescription.ReadOnly = true;
            this.colJobDescription.Width = 200;
            // 
            // colJobLocation
            // 
            this.colJobLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colJobLocation.HeaderText = "Location";
            this.colJobLocation.Name = "colJobLocation";
            this.colJobLocation.ReadOnly = true;
            this.colJobLocation.Width = 150;
            // 
            // colJobStartTime
            // 
            this.colJobStartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colJobStartTime.HeaderText = "Start Time";
            this.colJobStartTime.Name = "colJobStartTime";
            this.colJobStartTime.ReadOnly = true;
            this.colJobStartTime.Width = 60;
            // 
            // colJobEndTime
            // 
            this.colJobEndTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colJobEndTime.HeaderText = "End Time";
            this.colJobEndTime.Name = "colJobEndTime";
            this.colJobEndTime.ReadOnly = true;
            this.colJobEndTime.Width = 60;
            // 
            // colJobHoursWorked
            // 
            this.colJobHoursWorked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colJobHoursWorked.HeaderText = "Hours Worked";
            this.colJobHoursWorked.Name = "colJobHoursWorked";
            this.colJobHoursWorked.ReadOnly = true;
            this.colJobHoursWorked.Width = 74;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 632);
            this.Controls.Add(this.tabOptions);
            this.Name = "Form1";
            this.Text = "MBA Electric Time Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabOptions.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpHours)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobLabor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpPayStart;
        private System.Windows.Forms.DateTimePicker dtpPayEnd;
        private System.Windows.Forms.Label lblPayStart;
        private System.Windows.Forms.Label lblPayEnd;
        private System.Windows.Forms.Button btnCalcEmpHours;
        private System.Windows.Forms.ListBox lbTotals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbResults;
        private System.Windows.Forms.TabControl tabOptions;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvEmpHours;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvJobLabor;
        private System.Windows.Forms.DateTimePicker dtpJobLaborStart;
        private System.Windows.Forms.DateTimePicker dtpJobLaborEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobHoursWorked;
    }
}

