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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.lbEmpHours.FormattingEnabled = true;
            this.lbEmpHours.Location = new System.Drawing.Point(12, 90);
            this.lbEmpHours.Name = "lbEmpHours";
            this.lbEmpHours.Size = new System.Drawing.Size(318, 433);
            this.lbEmpHours.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(336, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(404, 430);
            this.dataGridView1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 532);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbEmpHours);
            this.Controls.Add(this.btnCalcEmpHours);
            this.Controls.Add(this.lblPayEnd);
            this.Controls.Add(this.lblPayStart);
            this.Controls.Add(this.dtpPayEnd);
            this.Controls.Add(this.dtpPayStart);
            this.Name = "Form1";
            this.Text = "MBA Time Clock";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

