namespace _2s_lab1
{
    partial class MixPerformances
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
            this.button1 = new System.Windows.Forms.Button();
            this.performanceBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.concertBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.concertBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.performanceBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Location = new System.Drawing.Point(136, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // performanceBox1
            // 
            this.performanceBox1.FormattingEnabled = true;
            this.performanceBox1.Location = new System.Drawing.Point(85, 70);
            this.performanceBox1.Name = "performanceBox1";
            this.performanceBox1.Size = new System.Drawing.Size(285, 21);
            this.performanceBox1.TabIndex = 6;
            this.performanceBox1.Click += new System.EventHandler(this.performance1_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(127, 407);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 36);
            this.button3.TabIndex = 5;
            this.button3.Text = "Объеденить выступления";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выступление №1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Концерт №1";
            // 
            // concertBox1
            // 
            this.concertBox1.FormattingEnabled = true;
            this.concertBox1.Location = new System.Drawing.Point(85, 25);
            this.concertBox1.Name = "concertBox1";
            this.concertBox1.Size = new System.Drawing.Size(285, 21);
            this.concertBox1.TabIndex = 11;
            this.concertBox1.Click += new System.EventHandler(this.concert1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Концерт №2";
            // 
            // concertBox2
            // 
            this.concertBox2.FormattingEnabled = true;
            this.concertBox2.Location = new System.Drawing.Point(85, 123);
            this.concertBox2.Name = "concertBox2";
            this.concertBox2.Size = new System.Drawing.Size(285, 21);
            this.concertBox2.TabIndex = 15;
            this.concertBox2.Click += new System.EventHandler(this.concert2_click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Выступление №2";
            // 
            // performanceBox2
            // 
            this.performanceBox2.FormattingEnabled = true;
            this.performanceBox2.Location = new System.Drawing.Point(85, 168);
            this.performanceBox2.Name = "performanceBox2";
            this.performanceBox2.Size = new System.Drawing.Size(285, 21);
            this.performanceBox2.TabIndex = 13;
            this.performanceBox2.Click += new System.EventHandler(this.performance2_click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(136, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 36);
            this.button2.TabIndex = 17;
            this.button2.Text = "Объеденить выступления";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MixPerformances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 308);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.concertBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.performanceBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.concertBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.performanceBox1);
            this.Name = "MixPerformances";
            this.Text = "MixPerformances";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox performanceBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox concertBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox concertBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox performanceBox2;
        private System.Windows.Forms.Button button2;
    }
}