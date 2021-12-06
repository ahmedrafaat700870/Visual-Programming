namespace XO_Game
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
            this.control = new System.Windows.Forms.Panel();
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.com = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.frind = new System.Windows.Forms.RadioButton();
            this.Score = new System.Windows.Forms.Panel();
            this.Score_Tow = new System.Windows.Forms.Label();
            this.Score_One = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.l9 = new System.Windows.Forms.Label();
            this.l8 = new System.Windows.Forms.Label();
            this.l7 = new System.Windows.Forms.Label();
            this.l6 = new System.Windows.Forms.Label();
            this.l5 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.control.SuspendLayout();
            this.Score.SuspendLayout();
            this.SuspendLayout();
            // 
            // control
            // 
            this.control.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.control.Controls.Add(this.Start);
            this.control.Controls.Add(this.label1);
            this.control.Controls.Add(this.com);
            this.control.Controls.Add(this.label2);
            this.control.Controls.Add(this.frind);
            this.control.Location = new System.Drawing.Point(175, 12);
            this.control.Name = "control";
            this.control.Size = new System.Drawing.Size(443, 94);
            this.control.TabIndex = 8;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(326, 30);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 5;
            this.Start.Text = "Start Game";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Play With Frind";
            // 
            // com
            // 
            this.com.AutoSize = true;
            this.com.Location = new System.Drawing.Point(25, 56);
            this.com.Name = "com";
            this.com.Size = new System.Drawing.Size(70, 17);
            this.com.TabIndex = 1;
            this.com.TabStop = true;
            this.com.Text = "Computer";
            this.com.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Play With Computer";
            // 
            // frind
            // 
            this.frind.AutoSize = true;
            this.frind.Location = new System.Drawing.Point(25, 20);
            this.frind.Name = "frind";
            this.frind.Size = new System.Drawing.Size(48, 17);
            this.frind.TabIndex = 0;
            this.frind.TabStop = true;
            this.frind.Text = "Frind";
            this.frind.UseVisualStyleBackColor = true;
            // 
            // Score
            // 
            this.Score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Score.Controls.Add(this.Score_Tow);
            this.Score.Controls.Add(this.Score_One);
            this.Score.Controls.Add(this.label3);
            this.Score.Controls.Add(this.label7);
            this.Score.Location = new System.Drawing.Point(175, 463);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(443, 100);
            this.Score.TabIndex = 29;
            // 
            // Score_Tow
            // 
            this.Score_Tow.AutoSize = true;
            this.Score_Tow.Location = new System.Drawing.Point(270, 70);
            this.Score_Tow.Name = "Score_Tow";
            this.Score_Tow.Size = new System.Drawing.Size(0, 13);
            this.Score_Tow.TabIndex = 7;
            // 
            // Score_One
            // 
            this.Score_One.AutoSize = true;
            this.Score_One.Location = new System.Drawing.Point(54, 70);
            this.Score_One.Name = "Score_One";
            this.Score_One.Size = new System.Drawing.Size(0, 13);
            this.Score_One.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Score Player One";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Score Computer ";
            // 
            // l9
            // 
            this.l9.AutoSize = true;
            this.l9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l9.ForeColor = System.Drawing.Color.Green;
            this.l9.Location = new System.Drawing.Point(458, 338);
            this.l9.MinimumSize = new System.Drawing.Size(70, 70);
            this.l9.Name = "l9";
            this.l9.Size = new System.Drawing.Size(70, 70);
            this.l9.TabIndex = 28;
            this.l9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l8
            // 
            this.l8.AutoSize = true;
            this.l8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l8.ForeColor = System.Drawing.Color.Green;
            this.l8.Location = new System.Drawing.Point(349, 338);
            this.l8.MinimumSize = new System.Drawing.Size(70, 70);
            this.l8.Name = "l8";
            this.l8.Size = new System.Drawing.Size(70, 70);
            this.l8.TabIndex = 27;
            this.l8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l7
            // 
            this.l7.AutoSize = true;
            this.l7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l7.ForeColor = System.Drawing.Color.Green;
            this.l7.Location = new System.Drawing.Point(237, 338);
            this.l7.MinimumSize = new System.Drawing.Size(70, 70);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(70, 70);
            this.l7.TabIndex = 26;
            this.l7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l6.ForeColor = System.Drawing.Color.Green;
            this.l6.Location = new System.Drawing.Point(458, 249);
            this.l6.MinimumSize = new System.Drawing.Size(70, 70);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(70, 70);
            this.l6.TabIndex = 25;
            this.l6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l5.ForeColor = System.Drawing.Color.Green;
            this.l5.Location = new System.Drawing.Point(349, 249);
            this.l5.MinimumSize = new System.Drawing.Size(70, 70);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(70, 70);
            this.l5.TabIndex = 24;
            this.l5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4.ForeColor = System.Drawing.Color.Green;
            this.l4.Location = new System.Drawing.Point(237, 249);
            this.l4.MinimumSize = new System.Drawing.Size(70, 70);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(70, 70);
            this.l4.TabIndex = 23;
            this.l4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.ForeColor = System.Drawing.Color.Green;
            this.l3.Location = new System.Drawing.Point(458, 159);
            this.l3.MinimumSize = new System.Drawing.Size(70, 70);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(70, 70);
            this.l3.TabIndex = 22;
            this.l3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.ForeColor = System.Drawing.Color.Green;
            this.l2.Location = new System.Drawing.Point(349, 161);
            this.l2.MinimumSize = new System.Drawing.Size(70, 70);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(70, 70);
            this.l2.TabIndex = 21;
            this.l2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.ForeColor = System.Drawing.Color.Green;
            this.l1.Location = new System.Drawing.Point(237, 161);
            this.l1.MinimumSize = new System.Drawing.Size(70, 70);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(70, 70);
            this.l1.TabIndex = 20;
            this.l1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.l9);
            this.Controls.Add(this.l8);
            this.Controls.Add(this.l7);
            this.Controls.Add(this.l6);
            this.Controls.Add(this.l5);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.control);
            this.Name = "Form1";
            this.Text = "Form1";
            this.control.ResumeLayout(false);
            this.control.PerformLayout();
            this.Score.ResumeLayout(false);
            this.Score.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel control;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton com;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton frind;
        private System.Windows.Forms.Panel Score;
        private System.Windows.Forms.Label Score_Tow;
        private System.Windows.Forms.Label Score_One;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label l9;
        private System.Windows.Forms.Label l8;
        private System.Windows.Forms.Label l7;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l1;
    }
}

