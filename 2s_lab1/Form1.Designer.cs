namespace _2s_lab1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.создатьКонцертToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьВыступлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посмотретьРезультатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обьеденитьВыступленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьКонцертToolStripMenuItem,
            this.добавитьToolStripMenuItem,
            this.файлToolStripMenuItem,
            this.посмотретьРезультатToolStripMenuItem,
            this.обьеденитьВыступленияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // создатьКонцертToolStripMenuItem
            // 
            this.создатьКонцертToolStripMenuItem.Name = "создатьКонцертToolStripMenuItem";
            this.создатьКонцертToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.создатьКонцертToolStripMenuItem.Text = "Создать концерт";
            this.создатьКонцертToolStripMenuItem.Click += new System.EventHandler(this.создатьКонцертToolStripMenuItem_Click);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьВыступлениеToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить выступление";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // добавитьВыступлениеToolStripMenuItem
            // 
            this.добавитьВыступлениеToolStripMenuItem.Name = "добавитьВыступлениеToolStripMenuItem";
            this.добавитьВыступлениеToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.добавитьВыступлениеToolStripMenuItem.Text = "Добавить выступление";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // посмотретьРезультатToolStripMenuItem
            // 
            this.посмотретьРезультатToolStripMenuItem.Name = "посмотретьРезультатToolStripMenuItem";
            this.посмотретьРезультатToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.посмотретьРезультатToolStripMenuItem.Text = "Посмотреть результат";
            this.посмотретьРезультатToolStripMenuItem.Click += new System.EventHandler(this.посмотретьРезультатToolStripMenuItem_Click);
            // 
            // обьеденитьВыступленияToolStripMenuItem
            // 
            this.обьеденитьВыступленияToolStripMenuItem.Name = "обьеденитьВыступленияToolStripMenuItem";
            this.обьеденитьВыступленияToolStripMenuItem.Size = new System.Drawing.Size(159, 20);
            this.обьеденитьВыступленияToolStripMenuItem.Text = "Обьеденить выступления";
            this.обьеденитьВыступленияToolStripMenuItem.Click += new System.EventHandler(this.обьеденитьВыступленияToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 465);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьКонцертToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьВыступлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посмотретьРезультатToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обьеденитьВыступленияToolStripMenuItem;
    }
}

