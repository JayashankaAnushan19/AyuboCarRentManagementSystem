namespace AyuboCarRentManagementSystem
{
    partial class FrmPackageView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPackageView));
            this.rbtnPerMonth = new System.Windows.Forms.RadioButton();
            this.rbtnPerWeek = new System.Windows.Forms.RadioButton();
            this.rbtnPerDay = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnPerMonth
            // 
            this.rbtnPerMonth.AutoSize = true;
            this.rbtnPerMonth.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPerMonth.Location = new System.Drawing.Point(535, 17);
            this.rbtnPerMonth.Name = "rbtnPerMonth";
            this.rbtnPerMonth.Size = new System.Drawing.Size(117, 24);
            this.rbtnPerMonth.TabIndex = 37;
            this.rbtnPerMonth.TabStop = true;
            this.rbtnPerMonth.Text = "For Long Hire";
            this.rbtnPerMonth.UseVisualStyleBackColor = true;
            this.rbtnPerMonth.Click += new System.EventHandler(this.rbtnPerMonth_Click);
            // 
            // rbtnPerWeek
            // 
            this.rbtnPerWeek.AutoSize = true;
            this.rbtnPerWeek.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPerWeek.Location = new System.Drawing.Point(383, 17);
            this.rbtnPerWeek.Name = "rbtnPerWeek";
            this.rbtnPerWeek.Size = new System.Drawing.Size(110, 24);
            this.rbtnPerWeek.TabIndex = 36;
            this.rbtnPerWeek.TabStop = true;
            this.rbtnPerWeek.Text = "For Day Hire";
            this.rbtnPerWeek.UseVisualStyleBackColor = true;
            this.rbtnPerWeek.Click += new System.EventHandler(this.rbtnPerWeek_Click);
            // 
            // rbtnPerDay
            // 
            this.rbtnPerDay.AutoSize = true;
            this.rbtnPerDay.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPerDay.Location = new System.Drawing.Point(259, 17);
            this.rbtnPerDay.Name = "rbtnPerDay";
            this.rbtnPerDay.Size = new System.Drawing.Size(82, 24);
            this.rbtnPerDay.TabIndex = 35;
            this.rbtnPerDay.TabStop = true;
            this.rbtnPerDay.Text = "For Rent";
            this.rbtnPerDay.UseVisualStyleBackColor = true;
            this.rbtnPerDay.Click += new System.EventHandler(this.rbtnPerDay_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Package Category";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1169, 365);
            this.dataGridView1.TabIndex = 39;
            // 
            // FrmPackageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1177, 427);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rbtnPerMonth);
            this.Controls.Add(this.rbtnPerWeek);
            this.Controls.Add(this.rbtnPerDay);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPackageView";
            this.Text = "Package View";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnPerMonth;
        private System.Windows.Forms.RadioButton rbtnPerWeek;
        private System.Windows.Forms.RadioButton rbtnPerDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}