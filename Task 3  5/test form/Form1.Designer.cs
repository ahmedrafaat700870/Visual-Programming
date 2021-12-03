namespace test_form
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
            this.firstNum = new System.Windows.Forms.Label();
            this.secondNum = new System.Windows.Forms.Label();
            this.thirNum = new System.Windows.Forms.Label();
            this.t4 = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNum
            // 
            this.firstNum.AutoSize = true;
            this.firstNum.Location = new System.Drawing.Point(79, 48);
            this.firstNum.Name = "firstNum";
            this.firstNum.Size = new System.Drawing.Size(66, 13);
            this.firstNum.TabIndex = 0;
            this.firstNum.Text = "First Number";
            this.firstNum.Click += new System.EventHandler(this.firstNum_Click);
            // 
            // secondNum
            // 
            this.secondNum.AutoSize = true;
            this.secondNum.Location = new System.Drawing.Point(79, 83);
            this.secondNum.Name = "secondNum";
            this.secondNum.Size = new System.Drawing.Size(84, 13);
            this.secondNum.TabIndex = 1;
            this.secondNum.Text = "Second Number";
            // 
            // thirNum
            // 
            this.thirNum.AutoSize = true;
            this.thirNum.Location = new System.Drawing.Point(79, 123);
            this.thirNum.Name = "thirNum";
            this.thirNum.Size = new System.Drawing.Size(71, 13);
            this.thirNum.TabIndex = 2;
            this.thirNum.Text = "Third Number";
            // 
            // t4
            // 
            this.t4.AutoSize = true;
            this.t4.Location = new System.Drawing.Point(289, 210);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(0, 13);
            this.t4.TabIndex = 3;
            this.t4.Click += new System.EventHandler(this.label4_Click);
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(223, 40);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(298, 20);
            this.t1.TabIndex = 4;
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(223, 120);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(298, 20);
            this.t3.TabIndex = 5;
            this.t3.TextChanged += new System.EventHandler(this.t3_TextChanged);
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(223, 83);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(298, 20);
            this.t2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(269, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Show ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.thirNum);
            this.Controls.Add(this.secondNum);
            this.Controls.Add(this.firstNum);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNum;
        private System.Windows.Forms.Label secondNum;
        private System.Windows.Forms.Label thirNum;
        private System.Windows.Forms.Label t4;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.Button button1;
    }
}

