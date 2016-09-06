using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Sql;
using MicroServiceApplication.Bean;
using MicroServiceApplication.Common;

namespace MicroServiceApplication
{
    public partial class KisExportsForm : Form
    {
        ExportKisClass exportKis = new ExportKisClass();

        private Client client;
        private Inst inst;
        private User user;

        private void exports(string categoryname)
        {
            ExportBean exportBean = new ExportBean();

            if (this.inst == null || this.inst.Id == null)
            {
                MessageBox.Show("无法获取当前机构信息！");
                return;
            }

            if (this.user == null || this.user.Id == null)
            {
                MessageBox.Show("无法获取当前用户信息！");
                return;
            }

            if (this.client == null || this.client.Id == null)
            {
                MessageBox.Show("请选择客户信息！");
                return;
            }

            exportBean.Instid = this.inst.Id;
            exportBean.Clientid = this.client.Id;
            exportBean.Accountcyclesn = this.accountcyclesnTextBox.Text;
            exportBean.Createby = this.user.Id;
            exportBean.Categoryname = categoryname;

            if (exportBean.Accountcyclesn == null || exportBean.Accountcyclesn == "")
            {
                MessageBox.Show("请输入月份");
                return;
            }
           

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
            saveFileDialog.Filter = "DBF文件   (*.dbf)|*.dbf";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FilterIndex = 1;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                exportBean.Path = System.IO.Path.GetDirectoryName(saveFileDialog.FileName);
                exportBean.FileName = System.IO.Path.GetFileName(saveFileDialog.FileName);
            }
            else
            {
                return;
            }
            try
            {
                exportKis.exports(exportBean);
            }catch(Exception e)
            {
                MessageBox.Show("导出凭证时出现错误:"+e.Message);
            }
            
        }

        public KisExportsForm()
        {
            InitializeComponent();
        }
      
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.inst = Session.GetInstance().Inst;
            this.user = Session.GetInstance().User;

            this.createbyTextBox.Text = this.user.Name;
        }
   
        private void selectPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                MessageBox.Show("已选择文件夹:" + foldPath, "选择文件夹提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void IncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.exports("income");
        }

        private void OutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.exports("output");
        }

        private void BankbillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.exports("bankbill");
        }

        private void PayrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.exports("payroll");
        }

        private void PaytaxreportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.exports("paytaxreport");
        }

        private void LocalreporttaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.exports("localreporttax");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Client> clientList = CommonManager.selectClient();

            if (clientList != null && clientList.Count > 0)
            {
                this.client = clientList[0];
                this.clientidTextBox.Text = this.client.Fullname;
            }
        }
    }
}
