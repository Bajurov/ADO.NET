namespace ADO.NET_application
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.работаСБазойДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подключитьсяКБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отключитьсяОтБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.асинхронноеПодключениеКБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.списокПодключенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСБазойДанныхToolStripMenuItem,
            this.списокПодключенийToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(346, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работаСБазойДанныхToolStripMenuItem
            // 
            this.работаСБазойДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подключитьсяКБДToolStripMenuItem,
            this.отключитьсяОтБДToolStripMenuItem,
            this.асинхронноеПодключениеКБДToolStripMenuItem});
            this.работаСБазойДанныхToolStripMenuItem.Name = "работаСБазойДанныхToolStripMenuItem";
            this.работаСБазойДанныхToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.работаСБазойДанныхToolStripMenuItem.Text = "Работа с базой данных";
            // 
            // подключитьсяКБДToolStripMenuItem
            // 
            this.подключитьсяКБДToolStripMenuItem.Name = "подключитьсяКБДToolStripMenuItem";
            this.подключитьсяКБДToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.подключитьсяКБДToolStripMenuItem.Text = "Подключиться к БД";
            this.подключитьсяКБДToolStripMenuItem.Click += new System.EventHandler(this.подключитьсяКБДToolStripMenuItem_Click);
            // 
            // отключитьсяОтБДToolStripMenuItem
            // 
            this.отключитьсяОтБДToolStripMenuItem.Name = "отключитьсяОтБДToolStripMenuItem";
            this.отключитьсяОтБДToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.отключитьсяОтБДToolStripMenuItem.Text = "Отключиться от БД";
            this.отключитьсяОтБДToolStripMenuItem.Click += new System.EventHandler(this.отключитьсяОтБДToolStripMenuItem_Click);
            // 
            // асинхронноеПодключениеКБДToolStripMenuItem
            // 
            this.асинхронноеПодключениеКБДToolStripMenuItem.Name = "асинхронноеПодключениеКБДToolStripMenuItem";
            this.асинхронноеПодключениеКБДToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.асинхронноеПодключениеКБДToolStripMenuItem.Text = "Асинхронное подключение к БД";
            this.асинхронноеПодключениеКБДToolStripMenuItem.Click += new System.EventHandler(this.асинхронноеПодключениеКБДToolStripMenuItem_Click);
            // 
            // списокПодключенийToolStripMenuItem
            // 
            this.списокПодключенийToolStripMenuItem.Name = "списокПодключенийToolStripMenuItem";
            this.списокПодключенийToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.списокПодключенийToolStripMenuItem.Text = "Список Подключений";
            this.списокПодключенийToolStripMenuItem.Click += new System.EventHandler(this.списокПодключенийToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 96);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "DBConnectionApplication";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работаСБазойДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подключитьсяКБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отключитьсяОтБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem асинхронноеПодключениеКБДToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem списокПодключенийToolStripMenuItem;
    }
}

