namespace MicroServiceApplication.Common
{
    partial class SelectT3AccsetForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.accsetNametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.accsetDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accsetDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.accsetNametextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(683, 33);
            this.panel2.TabIndex = 2;
            // 
            // accsetNametextBox
            // 
            this.accsetNametextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accsetNametextBox.Location = new System.Drawing.Point(64, 5);
            this.accsetNametextBox.Margin = new System.Windows.Forms.Padding(2);
            this.accsetNametextBox.Name = "accsetNametextBox";
            this.accsetNametextBox.Size = new System.Drawing.Size(614, 21);
            this.accsetNametextBox.TabIndex = 1;
            this.accsetNametextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "账套名称:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.accsetDataGridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 33);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(683, 331);
            this.panel3.TabIndex = 4;
            // 
            // accsetDataGridView
            // 
            this.accsetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accsetDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accsetDataGridView.Location = new System.Drawing.Point(5, 5);
            this.accsetDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.accsetDataGridView.Name = "accsetDataGridView";
            this.accsetDataGridView.RowTemplate.Height = 37;
            this.accsetDataGridView.Size = new System.Drawing.Size(673, 321);
            this.accsetDataGridView.TabIndex = 0;
            this.accsetDataGridView.DoubleClick += new System.EventHandler(this.accsetDataGridView_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 315);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(683, 49);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(603, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "选定账套";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SelectT3AccsetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 364);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SelectT3AccsetForm";
            this.Text = "选择账套";
            this.Load += new System.EventHandler(this.SelectAccsetForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accsetDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox accsetNametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView accsetDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}