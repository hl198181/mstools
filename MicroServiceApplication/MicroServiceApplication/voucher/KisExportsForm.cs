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
        private Accountcycle accountcycle;

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

            if(this.accountcycle == null || this.accountcycle.Sn == null)
            {
                MessageBox.Show("请选择月份！");
                return;
            }


            exportBean.Instid = this.inst.Id;
            exportBean.Clientid = this.client.Id;
            exportBean.Accountcyclesn = this.accountcycle.Sn;
            exportBean.Createby = this.user.Id;
            exportBean.Categoryname = categoryname;

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
            this.initAccountcycle();
        }

        private void initAccountcycle()
        {
            AccountcycleFactory af = new AccountcycleFactory();
            List<Accountcycle> accountcycleList = af.query(-1,-1);
            if (accountcycleList!=null  && accountcycleList.Count > 0)
            {
                this.accountcycle = accountcycleList[0];
                this.accountcyclesnTextBox.Text = this.accountcycle.Name;
            }
        }

        private void queryClientNewSubject(string clientid)
        {
            ClientSubjectFactory csf = new ClientSubjectFactory();
            List<ClientSubject> clientSubjects = csf.query(clientid, 1,1);


            DataTable clientSubjectDt = new DataTable();

            clientSubjectDt.Columns.Add("ID", Type.GetType("System.String"));
            clientSubjectDt.Columns.Add("科目编号", Type.GetType("System.String"));
            clientSubjectDt.Columns.Add("科目名称", Type.GetType("System.String"));

            foreach (ClientSubject item in clientSubjects)
            {
                DataRow datarow = clientSubjectDt.NewRow();

                datarow[0] = item.Id;
                datarow[1] = item.Sn;
                datarow[2] = item.Label;
                clientSubjectDt.Rows.Add(datarow);
            }

            this.ClientSubjectDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.ClientSubjectDataGridView.MultiSelect = false;

            this.ClientSubjectDataGridView.ColumnHeadersHeight = 30;
            this.ClientSubjectDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ClientSubjectDataGridView.RowTemplate.Height = 20;
            this.ClientSubjectDataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            this.ClientSubjectDataGridView.DataSource = clientSubjectDt;
            this.ClientSubjectDataGridView.Columns["id"].Visible = false;
            this.ClientSubjectDataGridView.Columns[2].Width = 500;

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
                this.queryClientNewSubject(this.client.Id);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Accountcycle> accountcycleList = CommonManager.selectAccountcycle();
            if(accountcycleList != null && accountcycleList.Count > 0)
            {
                this.accountcycle = accountcycleList[0];
                this.accountcyclesnTextBox.Text = this.accountcycle.Name;
            }
        }
    }
}
