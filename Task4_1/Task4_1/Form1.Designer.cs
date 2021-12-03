namespace Task4_1
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
            this.HidePass = new System.Windows.Forms.TextBox();
            this.Show = new System.Windows.Forms.Button();
            this.ShowPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HidePass
            // 
            this.HidePass.Location = new System.Drawing.Point(53, 37);
            this.HidePass.Name = "HidePass";
            this.HidePass.Size = new System.Drawing.Size(192, 20);
            this.HidePass.TabIndex = 0;
            this.HidePass.UseSystemPasswordChar = true;
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(83, 137);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(75, 23);
            this.Show.TabIndex = 3;
            this.Show.Text = "Show Me";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // ShowPass
            // 
            this.ShowPass.Enabled = false;
            this.ShowPass.Location = new System.Drawing.Point(53, 84);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(192, 20);
            this.ShowPass.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 192);
            this.Controls.Add(this.ShowPass);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.HidePass);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HidePass;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.TextBox ShowPass;
    }
}

