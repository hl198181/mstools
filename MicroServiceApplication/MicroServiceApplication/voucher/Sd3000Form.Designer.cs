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
            this.OutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BankDealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PayrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PaytaxreportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalreporttaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initSubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dbIpTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dbUserTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dbPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.accsetNameTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.subjectPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClientSubjectDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.refreshButton = new System.Windows.Forms.Button();
            this.InformationTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.exportInfoPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.subjectPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientSubjectDataGridView)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出ToolStripMenuItem,
            this.exportSubjectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(685, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IncomeToolStripMenuItem,
            this.OutputToolStripMenuItem,
            this.BankDealToolStripMenuItem,
            this.PayrollToolStripMenuItem,
            this.PaytaxreportToolStripMenuItem,
            this.LocalreporttaxToolStripMenuItem});
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.导出ToolStripMenuItem.Text = "导出凭证";
            // 
            // IncomeToolStripMenuItem
            // 
            this.IncomeToolStripMenuItem.Name = "IncomeToolStripMenuItem";
            this.IncomeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.IncomeToolStripMenuItem.Text = "进项";
            this.IncomeToolStripMenuItem.Click += new System.EventHandler(this.IncomeToolStripMenuItem_Click);
            // 
            // OutputToolStripMenuItem
            // 
            this.OutputToolStripMenuItem.Name = "OutputToolStripMenuItem";
            this.OutputToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.OutputToolStripMenuItem.Text = "销项";
            this.OutputToolStripMenuItem.Click += new System.EventHandler(this.OutputToolStripMenuItem_Click);
            // 
            // BankDealToolStripMenuItem
            // 
            this.BankDealToolStripMenuItem.Name = "BankDealToolStripMenuItem";
            this.BankDealToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.BankDealToolStripMenuItem.Text = "银行对账单";
            this.BankDealToolStripMenuItem.Click += new System.EventHandler(this.BankDealToolStripMenuItem_Click);
            // 
            // PayrollToolStripMenuItem
            // 
            this.PayrollToolStripMenuItem.Name = "PayrollToolStripMenuItem";
            this.PayrollToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.PayrollToolStripMenuItem.Text = "工资表";
            this.PayrollToolStripMenuItem.Click += new System.EventHandler(this.PayrollToolStripMenuItem_Click);
            // 
            // PaytaxreportToolStripMenuItem
            // 
            this.PaytaxreportToolStripMenuItem.Name = "PaytaxreportToolStripMenuItem";
            this.PaytaxreportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.PaytaxreportToolStripMenuItem.Text = "国税";
            this.PaytaxreportToolStripMenuItem.Click += new System.EventHandler(this.PaytaxreportToolStripMenuItem_Click);
            // 
            // LocalreporttaxToolStripMenuItem
            // 
            this.LocalreporttaxToolStripMenuItem.Name = "LocalreporttaxToolStripMenuItem";
            this.LocalreporttaxToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.LocalreporttaxToolStripMenuItem.Text = "地税";
            this.LocalreporttaxToolStripMenuItem.Click += new System.EventHandler(this.LocalreporttaxToolStripMenuItem_Click);
            // 
            // exportSubjectToolStripMenuItem
            // 
            this.exportSubjectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始导出ToolStripMenuItem,
            this.TestToolStripMenuItem,
            this.initSubjectToolStripMenuItem});
            this.exportSubjectToolStripMenuItem.Name = "exportSubjectToolStripMenuItem";
            this.exportSubjectToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.exportSubjectToolStripMenuItem.Text = "科目设置";
            // 
            // 开始导出ToolStripMenuItem
            // 
            this.开始导出ToolStripMenuItem.Name = "开始导出ToolStripMenuItem";
            this.开始导出ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.开始导出ToolStripMenuItem.Text = "新科目导出";
            this.开始导出ToolStripMenuItem.Click += new System.EventHandler(this.开始导出ToolStripMenuItem_Click);
            // 
            // TestToolStripMenuItem
            // 
            this.TestToolStripMenuItem.Name = "TestToolStripMenuItem";
            this.TestToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.TestToolStripMenuItem.Text = "新科目设置为已经导入";
            this.TestToolStripMenuItem.Visible = false;
            this.TestToolStripMenuItem.Click += new System.EventHandler(this.TestToolStripMenuItem_Click);
            // 
            // initSubjectToolStripMenuItem
            // 
            this.initSubjectToolStripMenuItem.Name = "initSubjectToolStripMenuItem";
            this.initSubjectToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.initSubjectToolStripMenuItem.Text = "从财务系统初始化科目";
            this.initSubjectToolStripMenuItem.Click += new System.EventHandler(this.initSubjectToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(675, 130);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "导出信息";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Controls.Add(this.createbyTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.clientTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.accountcycleTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.11243F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.88757F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(655, 96);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // createbyTextBox
            // 
            this.createbyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createbyTextBox.Location = new System.Drawing.Point(66, 71);
            this.createbyTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.createbyTextBox.Name = "createbyTextBox";
            this.createbyTextBox.ReadOnly = true;
            this.createbyTextBox.Size = new System.Drawing.Size(507, 21);
            this.createbyTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "客户：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(2, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "月份：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientTextBox
            // 
            this.clientTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientTextBox.Location = new System.Drawing.Point(66, 2);
            this.clientTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.clientTextBox.Name = "clientTextBox";
            this.clientTextBox.ReadOnly = true;
            this.clientTextBox.Size = new System.Drawing.Size(507, 21);
            this.clientTextBox.TabIndex = 2;
            // 
            // accountcycleTextBox
            // 
            this.accountcycleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountcycleTextBox.Location = new System.Drawing.Point(66, 36);
            this.accountcycleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.accountcycleTextBox.Name = "accountcycleTextBox";
            this.accountcycleTextBox.ReadOnly = true;
            this.accountcycleTextBox.Size = new System.Drawing.Size(507, 21);
            this.accountcycleTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(2, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "操作人：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "选择客户";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(577, 36);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "选择月份";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // exportInfoPanel
            // 
            this.exportInfoPanel.Controls.Add(this.groupBox3);
            this.exportInfoPanel.Controls.Add(this.groupBox1);
            this.exportInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.exportInfoPanel.Location = new System.Drawing.Point(0, 25);
            this.exportInfoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.exportInfoPanel.Name = "exportInfoPanel";
            this.exportInfoPanel.Padding = new System.Windows.Forms.Padding(5);
            this.exportInfoPanel.Size = new System.Drawing.Size(685, 321);
            this.exportInfoPanel.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(5, 135);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox3.Size = new System.Drawing.Size(675, 184);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "账套信息";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dbIpTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dbUserTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dbPasswordTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button3, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.accsetNameTextBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.button4, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 24);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(655, 154);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dbIpTextBox
            // 
            this.dbIpTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbIpTextBox.Location = new System.Drawing.Point(88, 2);
            this.dbIpTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.dbIpTextBox.Name = "dbIpTextBox";
            this.dbIpTextBox.Size = new System.Drawing.Size(565, 21);
            this.dbIpTextBox.TabIndex = 4;
            this.dbIpTextBox.Text = "localhost";
            this.dbIpTextBox.TextChanged += new System.EventHandler(this.dbIpTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "服务器地址：";
            // 
            // dbUserTextBox
            // 
            this.dbUserTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbUserTextBox.Location = new System.Drawing.Point(88, 27);
            this.dbUserTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.dbUserTextBox.Name = "dbUserTextBox";
            this.dbUserTextBox.Size = new System.Drawing.Size(565, 21);
            this.dbUserTextBox.TabIndex = 6;
            this.dbUserTextBox.Text = "sa";
            this.dbUserTextBox.TextChanged += new System.EventHandler(this.dbUserTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "用户名：";
            // 
            // dbPasswordTextBox
            // 
            this.dbPasswordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbPasswordTextBox.Location = new System.Drawing.Point(88, 52);
            this.dbPasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.dbPasswordTextBox.Name = "dbPasswordTextBox";
            this.dbPasswordTextBox.PasswordChar = '*';
            this.dbPasswordTextBox.Size = new System.Drawing.Size(565, 21);
            this.dbPasswordTextBox.TabIndex = 7;
            this.dbPasswordTextBox.TextChanged += new System.EventHandler(this.dbPasswordTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "密码：";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(88, 127);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 25);
            this.button3.TabIndex = 8;
            this.button3.Text = "连接测试";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // accsetNameTextBox
            // 
            this.accsetNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accsetNameTextBox.Location = new System.Drawing.Point(88, 77);
            this.accsetNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.accsetNameTextBox.Name = "accsetNameTextBox";
            this.accsetNameTextBox.ReadOnly = true;
            this.accsetNameTextBox.Size = new System.Drawing.Size(565, 21);
            this.accsetNameTextBox.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(88, 102);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 21);
            this.button4.TabIndex = 9;
            this.button4.Text = "选择账套";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "账套：";
            // 
            // subjectPanel
            // 
            this.subjectPanel.Controls.Add(this.groupBox2);
            this.subjectPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.subjectPanel.Location = new System.Drawing.Point(0, 346);
            this.subjectPanel.Margin = new System.Windows.Forms.Padding(2);
            this.subjectPanel.Name = "subjectPanel";
            this.subjectPanel.Padding = new System.Windows.Forms.Padding(5);
            this.subjectPanel.Size = new System.Drawing.Size(685, 242);
            this.subjectPanel.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClientSubjectDataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(5, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(675, 232);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "新科目列表";
            // 
            // ClientSubjectDataGridView
            // 
            this.ClientSubjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientSubjectDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientSubjectDataGridView.Location = new System.Drawing.Point(2, 16);
            this.ClientSubjectDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.ClientSubjectDataGridView.Name = "ClientSubjectDataGridView";
            this.ClientSubjectDataGridView.RowTemplate.Height = 37;
            this.ClientSubjectDataGridView.Size = new System.Drawing.Size(671, 214);
            this.ClientSubjectDataGridView.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.refreshButton, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 588);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(685, 38);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(3, 3);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(91, 29);
            this.refreshButton.TabIndex = 0;
            this.refreshButton.Text = "刷新";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // InformationTextBox
            // 
            this.InformationTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.InformationTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.InformationTextBox.Location = new System.Drawing.Point(0, 626);
            this.InformationTextBox.Name = "InformationTextBox";
            this.InformationTextBox.ReadOnly = true;
            this.InformationTextBox.Size = new System.Drawing.Size(310, 21);
            this.InformationTextBox.TabIndex = 7;
            this.InformationTextBox.Visible = false;
            // 
            // Sd3000Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 742);
            this.Controls.Add(this.InformationTextBox);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.subjectPanel);
            this.Controls.Add(this.exportInfoPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Sd3000Form";
            this.Text = "速达3000凭证导出";
            this.Load += new System.EventHandler(this.Sd3000Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.exportInfoPanel.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.subjectPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientSubjectDataGridView)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dbIpTextBox;
        private System.Windows.Forms.TextBox accsetNameTextBox;
        private System.Windows.Forms.TextBox dbUserTextBox;
        private System.Windows.Forms.TextBox dbPasswordTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem exportSubjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OutputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BankDealToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PayrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PaytaxreportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LocalreporttaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initSubjectToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox InformationTextBox;
    }
}