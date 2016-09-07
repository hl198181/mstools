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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.createbyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clientTextBox = new System.Windows.Forms.TextBox();
            this.accountcycleTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.exportInfoPanel = new System.Windows.Forms.Panel();
            this.subjectPanel = new System.Windows.Forms.Panel();
            this.ClientSubjectDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.exportInfoPanel.SuspendLayout();
            this.subjectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientSubjectDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1643, 41);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(20);
            this.groupBox1.Size = new System.Drawing.Size(1623, 252);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "导出信息";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.Controls.Add(this.createbyTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.clientTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.accountcycleTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.11243F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.88757F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1583, 184);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // createbyTextBox
            // 
            this.createbyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createbyTextBox.Location = new System.Drawing.Point(131, 134);
            this.createbyTextBox.Name = "createbyTextBox";
            this.createbyTextBox.ReadOnly = true;
            this.createbyTextBox.Size = new System.Drawing.Size(1289, 35);
            this.createbyTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "客户：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 67);
            this.label2.TabIndex = 1;
            this.label2.Text = "月份：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientTextBox
            // 
            this.clientTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientTextBox.Location = new System.Drawing.Point(131, 3);
            this.clientTextBox.Name = "clientTextBox";
            this.clientTextBox.ReadOnly = true;
            this.clientTextBox.Size = new System.Drawing.Size(1289, 35);
            this.clientTextBox.TabIndex = 2;
            // 
            // accountcycleTextBox
            // 
            this.accountcycleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountcycleTextBox.Location = new System.Drawing.Point(131, 67);
            this.accountcycleTextBox.Name = "accountcycleTextBox";
            this.accountcycleTextBox.ReadOnly = true;
            this.accountcycleTextBox.Size = new System.Drawing.Size(1289, 35);
            this.accountcycleTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 53);
            this.label3.TabIndex = 4;
            this.label3.Text = "操作人：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1426, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "选择客户";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1426, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 56);
            this.button2.TabIndex = 6;
            this.button2.Text = "选择月份";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // exportInfoPanel
            // 
            this.exportInfoPanel.Controls.Add(this.groupBox1);
            this.exportInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.exportInfoPanel.Location = new System.Drawing.Point(0, 41);
            this.exportInfoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.exportInfoPanel.Name = "exportInfoPanel";
            this.exportInfoPanel.Padding = new System.Windows.Forms.Padding(10);
            this.exportInfoPanel.Size = new System.Drawing.Size(1643, 272);
            this.exportInfoPanel.TabIndex = 2;
            // 
            // subjectPanel
            // 
            this.subjectPanel.Controls.Add(this.groupBox2);
            this.subjectPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.subjectPanel.Location = new System.Drawing.Point(0, 313);
            this.subjectPanel.Name = "subjectPanel";
            this.subjectPanel.Padding = new System.Windows.Forms.Padding(10);
            this.subjectPanel.Size = new System.Drawing.Size(1643, 551);
            this.subjectPanel.TabIndex = 3;
            // 
            // ClientSubjectDataGridView
            // 
            this.ClientSubjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientSubjectDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientSubjectDataGridView.Location = new System.Drawing.Point(3, 31);
            this.ClientSubjectDataGridView.Name = "ClientSubjectDataGridView";
            this.ClientSubjectDataGridView.RowTemplate.Height = 37;
            this.ClientSubjectDataGridView.Size = new System.Drawing.Size(1617, 497);
            this.ClientSubjectDataGridView.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClientSubjectDataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(10, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1623, 531);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "新科目列表";
            // 
            // Sd3000Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1643, 933);
            this.Controls.Add(this.subjectPanel);
            this.Controls.Add(this.exportInfoPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sd3000Form";
            this.Text = "速达3000凭证导出";
            this.Load += new System.EventHandler(this.Sd3000Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.exportInfoPanel.ResumeLayout(false);
            this.subjectPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientSubjectDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IncomeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accountcycleTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox createbyTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel exportInfoPanel;
        private System.Windows.Forms.Panel subjectPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView ClientSubjectDataGridView;
    }
}