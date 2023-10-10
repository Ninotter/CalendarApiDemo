namespace FormsDemo
{
    partial class FormTestCalendar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            monthCalendar1 = new MonthCalendar();
            labelYear = new Label();
            labelMonth = new Label();
            numericUpDownYear = new NumericUpDown();
            numericUpDownMonth = new NumericUpDown();
            buttonGenerate = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMonth).BeginInit();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(28, 113);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Location = new Point(54, 41);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(29, 15);
            labelYear.TabIndex = 2;
            labelYear.Text = "Year";
            // 
            // labelMonth
            // 
            labelMonth.AutoSize = true;
            labelMonth.Location = new Point(181, 41);
            labelMonth.Name = "labelMonth";
            labelMonth.Size = new Size(43, 15);
            labelMonth.TabIndex = 3;
            labelMonth.Text = "Month";
            // 
            // numericUpDownYear
            // 
            numericUpDownYear.Location = new Point(28, 59);
            numericUpDownYear.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDownYear.Name = "numericUpDownYear";
            numericUpDownYear.Size = new Size(98, 23);
            numericUpDownYear.TabIndex = 4;
            // 
            // numericUpDownMonth
            // 
            numericUpDownMonth.Location = new Point(157, 59);
            numericUpDownMonth.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numericUpDownMonth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownMonth.Name = "numericUpDownMonth";
            numericUpDownMonth.Size = new Size(98, 23);
            numericUpDownMonth.TabIndex = 5;
            numericUpDownMonth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonGenerate
            // 
            buttonGenerate.Location = new Point(99, 88);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(75, 23);
            buttonGenerate.TabIndex = 6;
            buttonGenerate.Text = "Generate";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // FormTestCalendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 293);
            Controls.Add(buttonGenerate);
            Controls.Add(numericUpDownMonth);
            Controls.Add(numericUpDownYear);
            Controls.Add(labelMonth);
            Controls.Add(labelYear);
            Controls.Add(monthCalendar1);
            MaximumSize = new Size(308, 332);
            MinimumSize = new Size(308, 332);
            Name = "FormTestCalendar";
            Text = "Calendar API demo";
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMonth).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MonthCalendar monthCalendar1;
        private Label labelYear;
        private Label labelMonth;
        private NumericUpDown numericUpDownYear;
        private NumericUpDown numericUpDownMonth;
        private Button buttonGenerate;
    }
}