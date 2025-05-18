namespace TravelAgencyApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxRegions = new System.Windows.Forms.ComboBox();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.numericUpDownBudget = new System.Windows.Forms.NumericUpDown();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.listBoxRegions = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxRegions
            // 
            this.comboBoxRegions.FormattingEnabled = true;
            this.comboBoxRegions.Location = new System.Drawing.Point(12, 12);
            this.comboBoxRegions.Name = "comboBoxRegions";
            this.comboBoxRegions.Size = new System.Drawing.Size(300, 21);
            this.comboBoxRegions.TabIndex = 0;
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Location = new System.Drawing.Point(12, 39);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(300, 21);
            this.comboBoxTime.TabIndex = 1;
            // 
            // numericUpDownBudget
            // 
            this.numericUpDownBudget.Location = new System.Drawing.Point(12, 66);
            this.numericUpDownBudget.Maximum = new decimal(new int[] 
            {
                1000000,
                0,
                0,
                0});
            this.numericUpDownBudget.Name = "numericUpDownBudget";
            this.numericUpDownBudget.Size = new System.Drawing.Size(300, 20);
            this.numericUpDownBudget.TabIndex = 2;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(12, 92);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(300, 23);
            this.buttonCalculate.TabIndex = 3;
            this.buttonCalculate.Text = "Рассчитать";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // listBoxRegions
            // 
            this.listBoxRegions.FormattingEnabled = true;
            this.listBoxRegions.Location = new System.Drawing.Point(12, 121);
            this.listBoxRegions.Name = "listBoxRegions";
            this.listBoxRegions.Size = new System.Drawing.Size(300, 199);
            this.listBoxRegions.TabIndex = 4;
            this.listBoxRegions.SelectedIndexChanged += new System.EventHandler(this.listBoxRegions_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 331);
            this.Controls.Add(this.listBoxRegions);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.numericUpDownBudget);
            this.Controls.Add(this.comboBoxTime);
            this.Controls.Add(this.comboBoxRegions);
            this.Name = "MainForm";
            this.Text = "Travel Agency";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBudget)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox comboBoxRegions;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.NumericUpDown numericUpDownBudget;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.ListBox listBoxRegions;
    }
}