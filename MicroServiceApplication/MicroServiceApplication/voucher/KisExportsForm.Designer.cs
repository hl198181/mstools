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
            this.clientidTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.accountcyclesnTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.createbyTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1867, 41);
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
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(74, 35);
            this.导出ToolStripMenuItem.Text = "导出";
            // 
            // IncomeToolStripMenuItem
            // 
            this.IncomeToolStripMenuItem.Name = "IncomeToolStripMenuItem";
            this.IncomeToolStripMenuItem.Size = new System.Drawing.Size(209, 38);
            this.IncomeToolStripMenuItem.Text = "进项";
            this.IncomeToolStripMenuItem.Click += new System.EventHandler(this.IncomeToolStripMenuItem_Click);
            // 
            // OutputToolStripMenuItem
            // 
            this.OutputToolStripMenuItem.Name = "OutputToolStripMenuItem";
            this.OutputToolStripMenuItem.Size = new System.Drawing.Size(209, 38);
            this.OutputToolStripMenuItem.Text = "销项";
            this.OutputToolStripMenuItem.Click += new System.EventHandler(this.OutputToolStripMenuItem_Click);
            // 
            // BankbillToolStripMenuItem
            // 
            this.BankbillToolStripMenuItem.Name = "BankbillToolStripMenuItem";
            this.BankbillToolStripMenuItem.Size = new System.Drawing.Size(209, 38);
            this.BankbillToolStripMenuItem.Text = "银行回单";
            this.BankbillToolStripMenuItem.Click += new System.EventHandler(this.BankbillToolStripMenuItem_Click);
            // 
            // PayrollToolStripMenuItem
            // 
            this.PayrollToolStripMenuItem.Name = "PayrollToolStripMenuItem";
            this.PayrollToolStripMenuItem.Size = new System.Drawing.Size(209, 38);
            this.PayrollToolStripMenuItem.Text = "工资表";
            this.PayrollToolStripMenuItem.Click += new System.EventHandler(this.PayrollToolStripMenuItem_Click);
            // 
            // PaytaxreportToolStripMenuItem
            // 
            this.PaytaxreportToolStripMenuItem.Name = "PaytaxreportToolStripMenuItem";
            this.PaytaxreportToolStripMenuItem.Size = new System.Drawing.Size(209, 38);
            this.PaytaxreportToolStripMenuItem.Text = "国税";
            this.PaytaxreportToolStripMenuItem.Click += new System.EventHandler(this.PaytaxreportToolStripMenuItem_Click);
            // 
            // LocalreporttaxToolStripMenuItem
            // 
            this.LocalreporttaxToolStripMenuItem.Name = "LocalreporttaxToolStripMenuItem";
            this.LocalreporttaxToolStripMenuItem.Size = new System.Drawing.Size(209, 38);
            this.LocalreporttaxToolStripMenuItem.Text = "地税";
            this.LocalreporttaxToolStripMenuItem.Click += new System.EventHandler(this.LocalreporttaxToolStripMenuItem_Click);
            // 
            // clientidTextBox
            // 
            this.clientidTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientidTextBox.Location = new System.Drawing.Point(151, 4);
            this.clientidTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.clientidTextBox.Name = "clientidTextBox";
            this.clientidTextBox.ReadOnly = true;
            this.clientidTextBox.Size = new System.Drawing.Size(1555, 35);
            this.clientidTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 74);
            this.label2.TabIndex = 5;
            this.label2.Text = "客户";
            // 
            // accountcyclesnTextBox
            // 
            this.accountcyclesnTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountcyclesnTextBox.Location = new System.Drawing.Point(151, 78);
            this.accountcyclesnTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.accountcyclesnTextBox.Name = "accountcyclesnTextBox";
            this.accountcyclesnTextBox.Size = new System.Drawing.Size(1555, 35);
            this.accountcyclesnTextBox.TabIndex = 8;
            this.accountcyclesnTextBox.Text = "201605";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 73);
            this.label3.TabIndex = 7;
            this.label3.Text = "月份";
            // 
            // createbyTextBox
            // 
            this.createbyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createbyTextBox.Location = new System.Drawing.Point(151, 151);
            this.createbyTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.createbyTextBox.Name = "createbyTextBox";
            this.createbyTextBox.ReadOnly = true;
            this.createbyTextBox.Size = new System.Drawing.Size(1555, 35);
            this.createbyTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(4, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 69);
            this.label4.TabIndex = 9;
            this.label4.Text = "操作人";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1713, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 51);
            this.button1.TabIndex = 11;
            this.button1.Text = "选择客户";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1713, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 51);
            this.button2.TabIndex = 12;
            this.button2.Text = "选择月份";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.596491F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.40351F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel1.Controls.Add(this.clientidTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.createbyTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.accountcyclesnTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.37037F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.62963F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1867, 216);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // KisExportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1867, 1329);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KisExportsForm";
            this.Text = "金蝶标准凭证格式";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.TextBox clientidTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accountcyclesnTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox createbyTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}