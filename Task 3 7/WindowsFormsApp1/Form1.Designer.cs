using System;

namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.TextBox();
            this.Month = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Week = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Resalut = new System.Windows.Forms.Label();
            this.Menit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Hour = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the Year";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(531, 23);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(100, 20);
            this.Year.TabIndex = 1;
            this.Year.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Year.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Year_KeyUp);
            // 
            // Month
            // 
            this.Month.Location = new System.Drawing.Point(531, 82);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(100, 20);
            this.Month.TabIndex = 3;
            this.Month.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Month_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter the Month";
            // 
            // Week
            // 
            this.Week.Location = new System.Drawing.Point(531, 147);
            this.Week.Name = "Week";
            this.Week.Size = new System.Drawing.Size(100, 20);
            this.Week.TabIndex = 5;
            this.Week.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Week_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter the Week";
            // 
            // Resalut
            // 
            this.Resalut.AutoSize = true;
            this.Resalut.Location = new System.Drawing.Point(363, 411);
            this.Resalut.Name = "Resalut";
            this.Resalut.Size = new System.Drawing.Size(0, 13);
            this.Resalut.TabIndex = 6;
            // 
            // Menit
            // 
            this.Menit.Location = new System.Drawing.Point(531, 329);
            this.Menit.Name = "Menit";
            this.Menit.Size = new System.Drawing.Size(100, 20);
            this.Menit.TabIndex = 12;
            this.Menit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Menit_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Enter the Menit";
            // 
            // Hour
            // 
            this.Hour.Location = new System.Drawing.Point(531, 264);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(100, 20);
            this.Hour.TabIndex = 10;
            this.Hour.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Hour_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Enter the hour";
            // 
            // Day
            // 
            this.Day.Location = new System.Drawing.Point(531, 201);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(100, 20);
            this.Day.TabIndex = 8;
            this.Day.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Day_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Enter the Day";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Menit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Hour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Resalut);
            this.Controls.Add(this.Week);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.TextBox Month;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Week;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Resalut;
        private System.Windows.Forms.TextBox Menit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Hour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Day;
        private System.Windows.Forms.Label label7;
    }
}

