namespace FactorialCalculator
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
            this.lstList = new System.Windows.Forms.ListBox();
            this.lblFactorial = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstList
            // 
            this.lstList.FormattingEnabled = true;
            this.lstList.Location = new System.Drawing.Point(16, 135);
            this.lstList.Name = "lstList";
            this.lstList.Size = new System.Drawing.Size(201, 43);
            this.lstList.TabIndex = 0;
            // 
            // lblFactorial
            // 
            this.lblFactorial.AutoSize = true;
            this.lblFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactorial.Location = new System.Drawing.Point(12, 9);
            this.lblFactorial.Name = "lblFactorial";
            this.lblFactorial.Size = new System.Drawing.Size(216, 24);
            this.lblFactorial.TabIndex = 1;
            this.lblFactorial.Text = "Enter factorial number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.AllowDrop = true;
            this.btnCalculate.Location = new System.Drawing.Point(80, 88);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 190);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblFactorial);
            this.Controls.Add(this.lstList);
            this.Name = "Form1";
            this.Text = "Factorial ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstList;
        private System.Windows.Forms.Label lblFactorial;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCalculate;
    }
}

