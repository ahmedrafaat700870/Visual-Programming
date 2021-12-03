namespace Task4_2
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
            this.text1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Char = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.re = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(214, 12);
            this.text1.Multiline = true;
            this.text1.Name = "text1";
            this.text1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text1.Size = new System.Drawing.Size(574, 147);
            this.text1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the Text";
            // 
            // Char
            // 
            this.Char.Location = new System.Drawing.Point(214, 191);
            this.Char.Name = "Char";
            this.Char.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Char.Size = new System.Drawing.Size(574, 20);
            this.Char.TabIndex = 2;
            this.Char.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Char_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter the Charcter";
            // 
            // re
            // 
            this.re.AutoSize = true;
            this.re.Location = new System.Drawing.Point(387, 282);
            this.re.Name = "re";
            this.re.Size = new System.Drawing.Size(0, 13);
            this.re.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.re);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Char);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Char;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label re;
    }
}

