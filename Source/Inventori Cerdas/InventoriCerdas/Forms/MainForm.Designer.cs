namespace InventoriCerdas.Forms
{
    partial class MainForm
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
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kabelMasukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kabelKeluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1415, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cableToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // cableToolStripMenuItem
            // 
            this.cableToolStripMenuItem.Name = "cableToolStripMenuItem";
            this.cableToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cableToolStripMenuItem.Text = "Kabel";
            this.cableToolStripMenuItem.Click += new System.EventHandler(this.CableToolStripMenuItem_Click);
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kabelMasukToolStripMenuItem,
            this.kabelKeluarToolStripMenuItem});
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // kabelMasukToolStripMenuItem
            // 
            this.kabelMasukToolStripMenuItem.Name = "kabelMasukToolStripMenuItem";
            this.kabelMasukToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.kabelMasukToolStripMenuItem.Text = "Kabel Masuk";
            // 
            // kabelKeluarToolStripMenuItem
            // 
            this.kabelKeluarToolStripMenuItem.Name = "kabelKeluarToolStripMenuItem";
            this.kabelKeluarToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.kabelKeluarToolStripMenuItem.Text = "Kabel Keluar";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 698);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Inventori Cerdas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kabelMasukToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kabelKeluarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
    }
}

