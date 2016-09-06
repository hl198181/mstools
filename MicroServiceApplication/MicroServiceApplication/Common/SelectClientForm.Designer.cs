namespace MicroServiceApplication.Common
{
    partial class SelectClientForm
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
            this.ClientDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClientDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(27, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1232, 690);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "客户列表";
            // 
            // ClientDataGridView
            // 
            this.ClientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientDataGridView.Location = new System.Drawing.Point(3, 31);
            this.ClientDataGridView.Name = "ClientDataGridView";
            this.ClientDataGridView.RowTemplate.Height = 37;
            this.ClientDataGridView.Size = new System.Drawing.Size(1226, 656);
            this.ClientDataGridView.TabIndex = 0;
            this.ClientDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientDataGridView_RowEnter);
            this.ClientDataGridView.DoubleClick += new System.EventHandler(this.ClientDataGridView_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "客户名称：";
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Location = new System.Drawing.Point(145, 30);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(1111, 35);
            this.clientNameTextBox.TabIndex = 2;
            this.clientNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1060, 810);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "选择客户";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SelectClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 883);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clientNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择客户";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SelectClientForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ClientDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientNameTextBox;
        private System.Windows.Forms.Button button1;
    }
}