using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MicroServiceApplication.factory;
using MicroServiceApplication.Bean;
using MicroServiceApplication.Common;

namespace MicroServiceApplication.voucher
{
    public partial class Sd3000Form : Form
    {

        private Client client;
        private Inst inst;
        private User user;
        private Accountcycle accountcycle;
        private Sd3000Accset accset;
        private List<ClientSubject> clientSubjects;

        public Sd3000Form()
        {
            InitializeComponent();
        }

        private void IncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.exports("income");
        }

        private void connectTest()
        {
            if (this.accset == null)
            {
                MessageBox.Show("请选择账套!");
                return;
            }

            try
            {
                Sd3000Factory factory = new Sd3000Factory();
                factory.connectTest(this.accset);
                MessageBox.Show("连接成功！");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void resetAccset()
        {
            this.accset = null;
            this.accsetNameTextBox.Text = "";
        }

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

            if (this.accountcycle == null || this.accountcycle.Sn == null)
            {
                MessageBox.Show("请选择月份！");
                return;
            }

            if (this.accset == null)
            {
                MessageBox.Show("请选择账套！");
                return;
            }
            
            if (this.accset.Corpname != this.client.Fullname)
            {
                DialogResult dr = MessageBox.Show("选择的客户与账套名称不一致，是否继续导入?","系统提示",MessageBoxButtons.OKCancel);

                if (dr != DialogResult.OK)
                {
                    return;
                }
            }

            exportBean.Instid = this.inst.Id;
            exportBean.Clientid = this.client.Id;
            exportBean.Accountcyclesn = this.accountcycle.Sn;
            exportBean.Createby = this.user.Id;
            exportBean.Categoryname = categoryname;
            try
            {
                Sd3000Factory factory = new Sd3000Factory();
                factory.exports(exportBean, this.accset);
                MessageBox.Show("凭证导出成功！请登录财务系统查看结果!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                MessageBox.Show(e.Message);
            }
        }

        private void exportSubject()
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

            if (this.accountcycle == null || this.accountcycle.Sn == null)
            {
                MessageBox.Show("请选择月份！");
                return;
            }

            if (this.accset == null)
            {
                MessageBox.Show("请选择账套！");
                return;
            }

            if (this.accset.Corpname != this.client.Fullname)
            {
                DialogResult dr = MessageBox.Show("选择的客户与账套名称不一致，是否继续导入?", "系统提示", MessageBoxButtons.OKCancel);

                if (dr != DialogResult.OK)
                {
                    return;
                }
            }

            exportBean.Instid = this.inst.Id;
            exportBean.Clientid = this.client.Id;
            exportBean.Accountcyclesn = this.accountcycle.Sn;
            exportBean.Createby = this.user.Id;
            try
            {
                Sd3000Factory factory = new Sd3000Factory();
                factory.exportsSubject(exportBean, this.accset);

                ClientSubjectFactory csf = new ClientSubjectFactory();
                csf.updateIsNew(this.clientSubjects, 0);
                this.queryClientNewSubject(this.client.Id);

                MessageBox.Show("科目导出成功！请登录财务系统查看结果!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            List<Client> clientList = CommonManager.selectClient();

            if (clientList!=null && clientList.Count > 0)
            {
                MessageBox.Show(clientList[0].Name);
            }else
            {
                MessageBox.Show("未选择!");
            }
        }

        private void Sd3000Form_Load(object sender, EventArgs e)
        {
            this.inst = Session.GetInstance().Inst;
            this.user = Session.GetInstance().User;

            this.createbyTextBox.Text = this.user.Name;
            this.initAccountcycle();
        }

        private void initAccountcycle()
        {
            AccountcycleFactory af = new AccountcycleFactory();
            List<Accountcycle> accountcycleList = af.query(-1, -1);
            if (accountcycleList != null && accountcycleList.Count > 0)
            {
                this.accountcycle = accountcycleList[0];
                this.accountcycleTextBox.Text = this.accountcycle.Name;
            }
        }

        private void queryClientNewSubject(string clientid)
        {
            ClientSubjectFactory csf = new ClientSubjectFactory();
            this.clientSubjects = csf.query(clientid, 1,1);
            
            DataTable clientSubjectDt = new DataTable();

            clientSubjectDt.Columns.Add("ID", Type.GetType("System.String"));
            clientSubjectDt.Columns.Add("科目编号", Type.GetType("System.String"));
            clientSubjectDt.Columns.Add("科目名称", Type.GetType("System.String"));

            foreach (ClientSubject item in this.clientSubjects)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<Client> clientList = CommonManager.selectClient();

            if (clientList != null && clientList.Count > 0)
            {
                this.client = clientList[0];
                this.clientTextBox.Text = this.client.Fullname;
                this.queryClientNewSubject(this.client.Id);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Accountcycle> accountcycleList = CommonManager.selectAccountcycle();
            if (accountcycleList != null && accountcycleList.Count > 0)
            {
                this.accountcycle = accountcycleList[0];
                this.accountcycleTextBox.Text = this.accountcycle.Name;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.connectTest();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.dbIpTextBox.Text == "" || this.dbIpTextBox.Text == null)
            {
                MessageBox.Show("请输入账套服务器地址!");
                return ;
            }
            
            if (this.dbUserTextBox.Text == "" || this.dbUserTextBox.Text == null)
            {
                MessageBox.Show("请输入账套数据库用户名!");
                return ;
            }
            if (this.dbPasswordTextBox.Text == null)
            {
                this.dbPasswordTextBox.Text = "";
            }

            Sd3000Factory sdfactory = new Sd3000Factory();
            try
            {
                List<Sd3000Accset> accsetList = sdfactory.queryAccset(this.dbUserTextBox.Text, this.dbPasswordTextBox.Text, this.dbIpTextBox.Text, "SD11001N_");
                this.accset = CommonManager.selectAccset(accsetList);
                if (this.accset != null)
                {
                    this.accsetNameTextBox.Text = this.accset.Corpname + "[" + this.accset.DbName + "]";
                }
            }
            catch(Exception e1)
            {
                Console.WriteLine(e1.StackTrace);
                MessageBox.Show(e1.Message);
            }
            
        }

        private void dbIpTextBox_TextChanged(object sender, EventArgs e)
        {
            this.resetAccset();
        }

        private void dbUserTextBox_TextChanged(object sender, EventArgs e)
        {
            this.resetAccset();
        }

        private void dbPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            this.resetAccset();
        }

        private void 开始导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.exportSubject();
        }

        private void TestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.client == null)
            {
                MessageBox.Show("请先选择客户!");
            }
            try
            {
                ClientSubjectFactory csf = new ClientSubjectFactory();
                csf.updateIsNew(this.clientSubjects, 0);
                this.queryClientNewSubject(this.client.Id);
                MessageBox.Show("设置成功!");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            
        }

        private void OutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.exports("output");
        }

        private void BankDealToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void initSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.accset == null)
            {
                MessageBox.Show("请先选择账套!");
                return;
            }

            if (this.client == null)
            {
                MessageBox.Show("请先选择客户!");
                return;
            }

            try
            {
                Sd3000Factory sdf = new Sd3000Factory();
                sdf.initSubjectBySd3000(this.accset,this.client,Session.GetInstance().User);
                MessageBox.Show("初始化成功，请打开小微服查看!");

            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.StackTrace);
                MessageBox.Show(e1.Message);
            }

        }
    }
}
