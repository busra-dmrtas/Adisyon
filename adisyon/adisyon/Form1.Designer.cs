namespace adisyon
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
            this.tanımlamalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masaTanımlamalarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünGrubuTanımlamalarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünTanımlamalarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adisyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masalarListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanımlamalarToolStripMenuItem,
            this.adisyonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tanımlamalarToolStripMenuItem
            // 
            this.tanımlamalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masaTanımlamalarıToolStripMenuItem,
            this.ürünGrubuTanımlamalarıToolStripMenuItem,
            this.ürünTanımlamalarıToolStripMenuItem});
            this.tanımlamalarToolStripMenuItem.Name = "tanımlamalarToolStripMenuItem";
            this.tanımlamalarToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.tanımlamalarToolStripMenuItem.Text = "Tanımlamalar";
            // 
            // masaTanımlamalarıToolStripMenuItem
            // 
            this.masaTanımlamalarıToolStripMenuItem.Name = "masaTanımlamalarıToolStripMenuItem";
            this.masaTanımlamalarıToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.masaTanımlamalarıToolStripMenuItem.Text = "Masa Tanımlamaları";
            this.masaTanımlamalarıToolStripMenuItem.Click += new System.EventHandler(this.masaTanımlamalarıToolStripMenuItem_Click);
            // 
            // ürünGrubuTanımlamalarıToolStripMenuItem
            // 
            this.ürünGrubuTanımlamalarıToolStripMenuItem.Name = "ürünGrubuTanımlamalarıToolStripMenuItem";
            this.ürünGrubuTanımlamalarıToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.ürünGrubuTanımlamalarıToolStripMenuItem.Text = "Ürün Grubu Tanımlamaları";
            this.ürünGrubuTanımlamalarıToolStripMenuItem.Click += new System.EventHandler(this.ürünGrubuTanımlamalarıToolStripMenuItem_Click);
            // 
            // ürünTanımlamalarıToolStripMenuItem
            // 
            this.ürünTanımlamalarıToolStripMenuItem.Name = "ürünTanımlamalarıToolStripMenuItem";
            this.ürünTanımlamalarıToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.ürünTanımlamalarıToolStripMenuItem.Text = "Ürün Tanımlamaları";
            this.ürünTanımlamalarıToolStripMenuItem.Click += new System.EventHandler(this.ürünTanımlamalarıToolStripMenuItem_Click);
            // 
            // adisyonToolStripMenuItem
            // 
            this.adisyonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masalarListesiToolStripMenuItem});
            this.adisyonToolStripMenuItem.Name = "adisyonToolStripMenuItem";
            this.adisyonToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.adisyonToolStripMenuItem.Text = "Adisyon";
            // 
            // masalarListesiToolStripMenuItem
            // 
            this.masalarListesiToolStripMenuItem.Name = "masalarListesiToolStripMenuItem";
            this.masalarListesiToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.masalarListesiToolStripMenuItem.Text = "Masalar Listesi";
            this.masalarListesiToolStripMenuItem.Click += new System.EventHandler(this.masalarListesiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tanımlamalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masaTanımlamalarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünGrubuTanımlamalarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünTanımlamalarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adisyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masalarListesiToolStripMenuItem;
    }
}

