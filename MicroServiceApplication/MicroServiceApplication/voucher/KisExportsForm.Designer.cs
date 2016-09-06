namespace MicroServiceApplication
{
    partial class KisExportsForm
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
            this.OutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BankbillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PayrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PaytaxreportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalreporttaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.instidTextBox = new System.Windows.Forms.TextBox();
            this.clientidTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.accountcyclesnTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.createbyTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1400, 32);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IncomeToolStripMenuItem,
            this.OutputToolStripMenuItem,
            this.BankbillToolStripMenuItem,
            this.PayrollToolStripMenuItem,
            this.PaytaxreportToolStripMenuItem,
            this.LocalreporttaxToolStripMenuItem});
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.导出ToolStripMenuItem.Text = "导出";
            // 
            // IncomeToolStripMenuItem
            // 
            this.IncomeToolStripMenuItem.Name = "IncomeToolStripMenuItem";
            this.IncomeToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.IncomeToolStripMenuItem.Text = "进项";
            this.IncomeToolStripMenuItem.Click += new System.EventHandler(this.IncomeToolStripMenuItem_Click);
            // 
            // OutputToolStripMenuItem
            // 
            this.OutputToolStripMenuItem.Name = "OutputToolStripMenuItem";
            this.OutputToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.OutputToolStripMenuItem.Text = "销项";
            this.OutputToolStripMenuItem.Click += new System.EventHandler(this.OutputToolStripMenuItem_Click);
            // 
            // BankbillToolStripMenuItem
            // 
            this.BankbillToolStripMenuItem.Name = "BankbillToolStripMenuItem";
            this.BankbillToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.BankbillToolStripMenuItem.Text = "银行回单";
            this.BankbillToolStripMenuItem.Click += new System.EventHandler(this.BankbillToolStripMenuItem_Click);
            // 
            // PayrollToolStripMenuItem
            // 
            this.PayrollToolStripMenuItem.Name = "PayrollToolStripMenuItem";
            this.PayrollToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.PayrollToolStripMenuItem.Text = "工资表";
            this.PayrollToolStripMenuItem.Click += new System.EventHandler(this.PayrollToolStripMenuItem_Click);
            // 
            // PaytaxreportToolStripMenuItem
            // 
            this.PaytaxreportToolStripMenuItem.Name = "PaytaxreportToolStripMenuItem";
            this.PaytaxreportToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.PaytaxreportToolStripMenuItem.Text = "国税";
            this.PaytaxreportToolStripMenuItem.Click += new System.EventHandler(this.PaytaxreportToolStripMenuItem_Click);
            // 
            // LocalreporttaxToolStripMenuItem
            // 
            this.LocalreporttaxToolStripMenuItem.Name = "LocalreporttaxToolStripMenuItem";
            this.LocalreporttaxToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.LocalreporttaxToolStripMenuItem.Text = "地税";
            this.LocalreporttaxToolStripMenuItem.Click += new System.EventHandler(this.LocalreporttaxToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "机构ID";
            // 
            // instidTextBox
            // 
            this.instidTextBox.Location = new System.Drawing.Point(109, 52);
            this.instidTextBox.Name = "instidTextBox";
            this.instidTextBox.Size = new System.Drawing.Size(881, 28);
            this.instidTextBox.TabIndex = 4;
            this.instidTextBox.Text = "10000001463017";
            // 
            // clientidTextBox
            // 
            this.clientidTextBox.Location = new System.Drawing.Point(109, 96);
            this.clientidTextBox.Name = "clientidTextBox";
            this.clientidTextBox.Size = new System.Drawing.Size(881, 28);
            this.clientidTextBox.TabIndex = 6;
            this.clientidTextBox.Text = "77db7a35-1dd3-4dad-a0d5-8f3c5a48d989";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "客户ID";
            // 
            // accountcyclesnTextBox
            // 
            this.accountcyclesnTextBox.Location = new System.Drawing.Point(109, 140);
            this.accountcyclesnTextBox.Name = "accountcyclesnTextBox";
            this.accountcyclesnTextBox.Size = new System.Drawing.Size(881, 28);
            this.accountcyclesnTextBox.TabIndex = 8;
            this.accountcyclesnTextBox.Text = "201605";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "月份";
            // 
            // createbyTextBox
            // 
            this.createbyTextBox.Location = new System.Drawing.Point(109, 184);
            this.createbyTextBox.Name = "createbyTextBox";
            this.createbyTextBox.Size = new System.Drawing.Size(881, 28);
            this.createbyTextBox.TabIndex = 10;
            this.createbyTextBox.Text = "e808be8d-044b-4b91-b35f-36ab185db5b3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "操作人ID";
            // 
            // KisExportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 997);
            this.Controls.Add(this.createbyTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.accountcyclesnTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clientidTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.instidTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KisExportsForm";
            this.Text = "金蝶标准凭证格式";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IncomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OutputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BankbillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PayrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PaytaxreportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LocalreporttaxToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox instidTextBox;
        private System.Windows.Forms.TextBox clientidTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accountcyclesnTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox createbyTextBox;
        private System.Windows.Forms.Label label4;
    }
}