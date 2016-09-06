namespace MicroServiceApplication.voucher
{
    partial class Sd3000Form
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
            this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IncomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectClientComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1779, 41);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IncomeToolStripMenuItem});
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(74, 35);
            this.导出ToolStripMenuItem.Text = "导出";
            // 
            // IncomeToolStripMenuItem
            // 
            this.IncomeToolStripMenuItem.Name = "IncomeToolStripMenuItem";
            this.IncomeToolStripMenuItem.Size = new System.Drawing.Size(161, 38);
            this.IncomeToolStripMenuItem.Text = "进项";
            this.IncomeToolStripMenuItem.Click += new System.EventHandler(this.IncomeToolStripMenuItem_Click);
            // 
            // selectClientComboBox
            // 
            this.selectClientComboBox.FormattingEnabled = true;
            this.selectClientComboBox.Location = new System.Drawing.Point(127, 74);
            this.selectClientComboBox.Name = "selectClientComboBox";
            this.selectClientComboBox.Size = new System.Drawing.Size(1141, 32);
            this.selectClientComboBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1101, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "选择客户";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sd3000Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1779, 1319);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectClientComboBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Sd3000Form";
            this.Text = "速达3000凭证导出";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IncomeToolStripMenuItem;
        private System.Windows.Forms.ComboBox selectClientComboBox;
        private System.Windows.Forms.Button button1;
    }
}