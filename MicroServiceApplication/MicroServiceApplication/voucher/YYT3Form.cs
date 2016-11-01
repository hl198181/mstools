using MicroServiceApplication.Bean;
using MicroServiceApplication.Common;
using MicroServiceApplication.factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MicroServiceApplication.voucher
{
    public partial class YYT3Form: Form
    {
        public YYT3Form()
        {
            InitializeComponent();
        }
        private Client client;
        private List<ClientSubject> clientSubjects;
        private Accountcycle accountcycle;
        private YYT3accset accset;
        private Inst inst;
        private User user;
        //
        //选择客户start
        //
        private void selectClientButton_Click(object sender, EventArgs e)
        {
            List<Client> clientList = CommonManager.selectClient(); //弹出选择客户列表
            if(clientList != null && clientList.Count>0)
            {
                this.client = clientList[0];//选择客户
                this.clientTextBox.Text = this.client.Fullname;//客户名称显示栏显示选择的客户名称
                this.queryClientNewSubject(this.client.Id);//引用选择客户同时显示新科目
            }
        }
        //
        //选择客户end
        //
        //显示新会计科目的方法
        private void queryClientNewSubject(String clientid)
        {
            ClientSubjectFactory csf = new ClientSubjectFactory();//new取新会计科目的工厂
            this.clientSubjects = csf.query(clientid, 1, 1);//把工厂里的query取得新科目赋值到声明的变量clientSubjects

            DataTable clientSubjectDT = new DataTable();//创建一个新表格
            //表格的设置有三列
            clientSubjectDT.Columns.Add("ID", Type.GetType("System.String"));
            clientSubjectDT.Columns.Add("科目代码",Type.GetType("System.String"));
            clientSubjectDT.Columns.Add("科目名称", Type.GetType("System.String"));
            //把clientSubjects变量里取到的新科目循环取值放在row里
            foreach(ClientSubject item in this.clientSubjects)
            {
                DataRow datarow = clientSubjectDT.NewRow();//创建新row

                datarow[0] = item.Id;//row[0]取Id
                datarow[1] = item.Sn;//row[1]取Sn
                datarow[2] = item.Label;//row[2]取Label
                clientSubjectDT.Rows.Add(datarow); //把row[1][2][3]放到新表格clientSubjectDT里
            }
            //会计科目模块显示设置
            this.ClientSubjectDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.ClientSubjectDataGridView.MultiSelect = false;
            this.ClientSubjectDataGridView.ColumnHeadersHeight = 30;
            this.ClientSubjectDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ClientSubjectDataGridView.RowTemplate.Height = 20;
            this.ClientSubjectDataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            this.ClientSubjectDataGridView.DataSource = clientSubjectDT;
            this.ClientSubjectDataGridView.Columns["id"].Visible = false;
            this.ClientSubjectDataGridView.Columns[2].Width = 500;
        }
        //
        //选择月份start
        //
        private void selectAccountcycleButton_Click(object sender, EventArgs e)
        {
            List<Accountcycle> accountcycleList = CommonManager.selectAccountcycle();//弹出月份表
            if(accountcycleList != null && accountcycleList.Count > 0)
            {
                this.accountcycle = accountcycleList[0];//选择月份
                this.accountcycleTextBox.Text = this.accountcycle.Name;//月份显示栏里显示选择的月份
            }
        }
        //
        //选择月份end
        //
        //选择账套start
        //
        private void selectAccessButton_Click(object sender, EventArgs e)
        {
            if(this.dbIpTextBox.Text == "" || this.dbIpTextBox.Text == null)
            {
                MessageBox.Show("请输入账套服务器地址!");
            }
            if(this.dbUserTextBox.Text =="" || this.dbUserTextBox.Text == null)
            {
                MessageBox.Show("请输入账套数据库用户名!");
            }
            if(this.dbPasswordTextBox.Text == null)
            {
                this.dbPasswordTextBox.Text = "";
            }

            YYT3Factory yYT3Factory = new YYT3Factory();
            try
            {
                //引用工厂里连接数据库查找总账套的方法
                List<YYT3accset> accsetList = yYT3Factory.queryAccset(this.dbUserTextBox.Text, this.dbPasswordTextBox.Text, this.dbIpTextBox.Text, "UFDATA_");
                this.accset = CommonManager.selectAccset(accsetList);//弹出选择账套窗口
                if (this.accset != null)
                {
                    this.accsetNameTextBox.Text = this.accset.CAcc_Name + "[" + this.accset.DbName + "]";//账套显示栏赋值
                }
            }
            catch(Exception e1)
            {
                Console.WriteLine(e1.StackTrace);
                MessageBox.Show(e1.Message);
            }
        }
        //
        //选择账套end
        //
        //连接测试start
        //
        private void textButton_Click(object sender, EventArgs e)
        {
            this.connectText();//引用创建连接测试
        }
        //创建连接测试
        private void connectText()
        {
            if(this.accset == null)
            {
                MessageBox.Show("请先选择账套!");
            }
            try
            {
                YYT3Factory yYT3Factory = new YYT3Factory();
                yYT3Factory.connectTest(this.accset);//引用Factory工厂里测试连接的方法
                MessageBox.Show("连接成功");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //
        //测试连接end
        //
        //直接显示月份和操作人start
        //
        private void YYT3Form_Load(object sender, EventArgs e)
        {
            this.inst = Session.GetInstance().Inst;//赋值机构
            this.user = Session.GetInstance().User;//赋值用户名
            this.createbyTextBox.Text = this.user.Name;//操作人显示栏显示用户名
            this.iniAccountcycle();//引用显示月份方法显示月份
        }
        private void iniAccountcycle()
        {
            AccountcycleFactory af = new AccountcycleFactory();//new月份工厂
            List<Accountcycle> accountcycleList = af.query(-1, -1);//引用显示月份方法
            if (accountcycleList != null && accountcycleList.Count >0)
            {
                this.accountcycle = accountcycleList[0];
                this.accountcycleTextBox.Text = this.accountcycle.Name;//月份显示栏显示月份
            }
        }

        //
        //直接显示月份和操作人end
        //      
    }
}
