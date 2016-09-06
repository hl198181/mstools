namespace MicroServiceApplication
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
            this.财务软件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sd300ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.财务软件ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1002, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 财务软件ToolStripMenuItem
            // 
            this.财务软件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KisToolStripMenuItem,
            this.Sd300ToolStripMenuItem});
            this.财务软件ToolStripMenuItem.Name = "财务软件ToolStripMenuItem";
            this.财务软件ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.财务软件ToolStripMenuItem.Text = "凭证导出";
            // 
            // KisToolStripMenuItem
            // 
            this.KisToolStripMenuItem.Name = "KisToolStripMenuItem";
            this.KisToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.KisToolStripMenuItem.Text = "金蝶标准凭证格式";
            this.KisToolStripMenuItem.Click += new System.EventHandler(this.KisToolStripMenuItem_Click);
            // 
            // Sd300ToolStripMenuItem
            // 
            this.Sd300ToolStripMenuItem.Name = "Sd300ToolStripMenuItem";
            this.Sd300ToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.Sd300ToolStripMenuItem.Text = "速达3000";
            this.Sd300ToolStripMenuItem.Click += new System.EventHandler(this.Sd300ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 713);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "小微服-辅助工具";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 财务软件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Sd300ToolStripMenuItem;
    }
}