namespace MicroServiceApplication.voucher
{
    partial class KisFileForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.selectClientButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.createbyLabel = new System.Windows.Forms.Label();
            this.createbyTextBox = new System.Windows.Forms.TextBox();
            this.dbFileGroupBox = new System.Windows.Forms.GroupBox();
            this.dbFilePanel = new System.Windows.Forms.Panel();
            this.dbFileTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.selectDbFilelabel = new System.Windows.Forms.Label();
            this.selectDbFileButton = new System.Windows.Forms.Button();
            this.dbFilePathTextBox = new System.Windows.Forms.TextBox();
            this.testConnectButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.initSubjectButton = new System.Windows.Forms.Button();
            this.newSubjectGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ClientSubjectDataGridView = new System.Windows.Forms.DataGridView();
            this.subjectToKisButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.dbFileGroupBox.SuspendLayout();
            this.dbFilePanel.SuspendLayout();
            this.dbFileTableLayoutPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.newSubjectGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientSubjectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1430, 206);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "导出信息";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1424, 172);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.Controls.Add(this.selectClientButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.clientNameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.createbyLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.createbyTextBox, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1424, 172);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // selectClientButton
            // 
            this.selectClientButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectClientButton.Location = new System.Drawing.Point(1247, 3);
            this.selectClientButton.Name = "selectClientButton";
            this.selectClientButton.Size = new System.Drawing.Size(174, 51);
            this.selectClientButton.TabIndex = 2;
            this.selectClientButton.Text = "选择客户";
            this.selectClientButton.UseVisualStyleBackColor = true;
            this.selectClientButton.Click += new System.EventHandler(this.selectClientButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "客户：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientNameTextBox.Location = new System.Drawing.Point(183, 3);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.ReadOnly = true;
            this.clientNameTextBox.Size = new System.Drawing.Size(1058, 35);
            this.clientNameTextBox.TabIndex = 1;
            // 
            // createbyLabel
            // 
            this.createbyLabel.AutoSize = true;
            this.createbyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createbyLabel.Location = new System.Drawing.Point(3, 114);
            this.createbyLabel.Name = "createbyLabel";
            this.createbyLabel.Size = new System.Drawing.Size(174, 58);
            this.createbyLabel.TabIndex = 2;
            this.createbyLabel.Text = "操作人:";
            this.createbyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createbyTextBox
            // 
            this.createbyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createbyTextBox.Location = new System.Drawing.Point(183, 117);
            this.createbyTextBox.Name = "createbyTextBox";
            this.createbyTextBox.ReadOnly = true;
            this.createbyTextBox.Size = new System.Drawing.Size(1058, 35);
            this.createbyTextBox.TabIndex = 3;
            // 
            // dbFileGroupBox
            // 
            this.dbFileGroupBox.Controls.Add(this.dbFilePanel);
            this.dbFileGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.dbFileGroupBox.Location = new System.Drawing.Point(0, 206);
            this.dbFileGroupBox.Name = "dbFileGroupBox";
            this.dbFileGroupBox.Size = new System.Drawing.Size(1430, 208);
            this.dbFileGroupBox.TabIndex = 2;
            this.dbFileGroupBox.TabStop = false;
            this.dbFileGroupBox.Text = "账套信息";
            // 
            // dbFilePanel
            // 
            this.dbFilePanel.Controls.Add(this.dbFileTableLayoutPanel);
            this.dbFilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbFilePanel.Location = new System.Drawing.Point(3, 31);
            this.dbFilePanel.Name = "dbFilePanel";
            this.dbFilePanel.Size = new System.Drawing.Size(1424, 174);
            this.dbFilePanel.TabIndex = 0;
            // 
            // dbFileTableLayoutPanel
            // 
            this.dbFileTableLayoutPanel.ColumnCount = 3;
            this.dbFileTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.dbFileTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dbFileTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.dbFileTableLayoutPanel.Controls.Add(this.selectDbFilelabel, 0, 0);
            this.dbFileTableLayoutPanel.Controls.Add(this.selectDbFileButton, 2, 0);
            this.dbFileTableLayoutPanel.Controls.Add(this.dbFilePathTextBox, 1, 0);
            this.dbFileTableLayoutPanel.Controls.Add(this.testConnectButton, 2, 1);
            this.dbFileTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbFileTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.dbFileTableLayoutPanel.Name = "dbFileTableLayoutPanel";
            this.dbFileTableLayoutPanel.RowCount = 3;
            this.dbFileTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.dbFileTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.dbFileTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.dbFileTableLayoutPanel.Size = new System.Drawing.Size(1424, 174);
            this.dbFileTableLayoutPanel.TabIndex = 0;
            // 
            // selectDbFilelabel
            // 
            this.selectDbFilelabel.AutoSize = true;
            this.selectDbFilelabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectDbFilelabel.Location = new System.Drawing.Point(3, 0);
            this.selectDbFilelabel.Name = "selectDbFilelabel";
            this.selectDbFilelabel.Size = new System.Drawing.Size(174, 58);
            this.selectDbFilelabel.TabIndex = 0;
            this.selectDbFilelabel.Text = "数据库文件：";
            this.selectDbFilelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectDbFileButton
            // 
            this.selectDbFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectDbFileButton.Location = new System.Drawing.Point(1247, 3);
            this.selectDbFileButton.Name = "selectDbFileButton";
            this.selectDbFileButton.Size = new System.Drawing.Size(174, 52);
            this.selectDbFileButton.TabIndex = 1;
            this.selectDbFileButton.Text = "选择文件";
            this.selectDbFileButton.UseVisualStyleBackColor = true;
            this.selectDbFileButton.Click += new System.EventHandler(this.selectDbFileButton_Click);
            // 
            // dbFilePathTextBox
            // 
            this.dbFilePathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbFilePathTextBox.Location = new System.Drawing.Point(183, 3);
            this.dbFilePathTextBox.Name = "dbFilePathTextBox";
            this.dbFilePathTextBox.ReadOnly = true;
            this.dbFilePathTextBox.Size = new System.Drawing.Size(1058, 35);
            this.dbFilePathTextBox.TabIndex = 2;
            // 
            // testConnectButton
            // 
            this.testConnectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testConnectButton.Location = new System.Drawing.Point(1247, 61);
            this.testConnectButton.Name = "testConnectButton";
            this.testConnectButton.Size = new System.Drawing.Size(174, 52);
            this.testConnectButton.TabIndex = 3;
            this.testConnectButton.Text = "测试连接";
            this.testConnectButton.UseVisualStyleBackColor = true;
            this.testConnectButton.Click += new System.EventHandler(this.testConnectButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.initSubjectButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 414);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1430, 70);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // initSubjectButton
            // 
            this.initSubjectButton.Location = new System.Drawing.Point(1230, 3);
            this.initSubjectButton.Name = "initSubjectButton";
            this.initSubjectButton.Size = new System.Drawing.Size(197, 61);
            this.initSubjectButton.TabIndex = 0;
            this.initSubjectButton.Text = "初始化科目";
            this.initSubjectButton.UseVisualStyleBackColor = true;
            this.initSubjectButton.Click += new System.EventHandler(this.initSubjectButton_Click);
            // 
            // newSubjectGroupBox
            // 
            this.newSubjectGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.newSubjectGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.newSubjectGroupBox.Location = new System.Drawing.Point(0, 484);
            this.newSubjectGroupBox.Name = "newSubjectGroupBox";
            this.newSubjectGroupBox.Size = new System.Drawing.Size(1430, 424);
            this.newSubjectGroupBox.TabIndex = 4;
            this.newSubjectGroupBox.TabStop = false;
            this.newSubjectGroupBox.Text = "新科目列表：";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.ClientSubjectDataGridView, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.subjectToKisButton, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1424, 390);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // ClientSubjectDataGridView
            // 
            this.ClientSubjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientSubjectDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientSubjectDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ClientSubjectDataGridView.Name = "ClientSubjectDataGridView";
            this.ClientSubjectDataGridView.RowTemplate.Height = 37;
            this.ClientSubjectDataGridView.Size = new System.Drawing.Size(1418, 304);
            this.ClientSubjectDataGridView.TabIndex = 0;
            // 
            // subjectToKisButton
            // 
            this.subjectToKisButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.subjectToKisButton.Location = new System.Drawing.Point(1212, 313);
            this.subjectToKisButton.Name = "subjectToKisButton";
            this.subjectToKisButton.Size = new System.Drawing.Size(209, 74);
            this.subjectToKisButton.TabIndex = 1;
            this.subjectToKisButton.Text = "新科目导入KIS";
            this.subjectToKisButton.UseVisualStyleBackColor = true;
            this.subjectToKisButton.Click += new System.EventHandler(this.subjectToKisButton_Click);
            // 
            // KisFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 1047);
            this.Controls.Add(this.newSubjectGroupBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dbFileGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "KisFileForm";
            this.Text = "金蝶KIS数据库文件导入";
            this.Load += new System.EventHandler(this.KisFileForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.dbFileGroupBox.ResumeLayout(false);
            this.dbFilePanel.ResumeLayout(false);
            this.dbFileTableLayoutPanel.ResumeLayout(false);
            this.dbFileTableLayoutPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.newSubjectGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientSubjectDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientNameTextBox;
        private System.Windows.Forms.Label createbyLabel;
        private System.Windows.Forms.Button selectClientButton;
        private System.Windows.Forms.GroupBox dbFileGroupBox;
        private System.Windows.Forms.Panel dbFilePanel;
        private System.Windows.Forms.TableLayoutPanel dbFileTableLayoutPanel;
        private System.Windows.Forms.Label selectDbFilelabel;
        private System.Windows.Forms.Button selectDbFileButton;
        private System.Windows.Forms.TextBox dbFilePathTextBox;
        private System.Windows.Forms.Button testConnectButton;
        private System.Windows.Forms.TextBox createbyTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button initSubjectButton;
        private System.Windows.Forms.GroupBox newSubjectGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView ClientSubjectDataGridView;
        private System.Windows.Forms.Button subjectToKisButton;
    }
}