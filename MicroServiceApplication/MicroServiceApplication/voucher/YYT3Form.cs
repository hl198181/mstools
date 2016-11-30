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
    public partial class YYT3Form : Form
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
            if (clientList != null && clientList.Count > 0)
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
            clientSubjectDT.Columns.Add("科目代码", Type.GetType("System.String"));
            clientSubjectDT.Columns.Add("科目名称", Type.GetType("System.String"));
            //把clientSubjects变量里取到的新科目循环取值放在row里
            foreach (ClientSubject item in this.clientSubjects)
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
            if (accountcycleList != null && accountcycleList.Count > 0)
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
            if (this.dbIpTextBox.Text == "" || this.dbIpTextBox.Text == null)
            {
                MessageBox.Show("请输入账套服务器地址!");
            }
            if (this.dbUserTextBox.Text == "" || this.dbUserTextBox.Text == null)
            {
                MessageBox.Show("请输入账套数据库用户名!");
            }
            if (this.dbPasswordTextBox.Text == null)
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
            catch (Exception e1)
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
            if (this.accset == null)
            {
                MessageBox.Show("请先选择账套!");
            }
            try
            {
                YYT3Factory yYT3Factory = new YYT3Factory();
                yYT3Factory.connectTest(this.accset);//引用Factory工厂里测试连接的方法
                MessageBox.Show("连接成功");
            }
            catch (Exception e)
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
            if (accountcycleList != null && accountcycleList.Count > 0)
            {
                this.accountcycle = accountcycleList[0];
                this.accountcycleTextBox.Text = this.accountcycle.Name;//月份显示栏显示月份
            }
        }
        //
        //直接显示月份和操作人end
        //
        //刷新新科目按钮start
        //  
        private void refreshButton_Click(object sender, EventArgs e)
        {
            if (this.client == null)
            {
                MessageBox.Show("请先选择客户信息");
            }
            else
            {
                this.queryClientNewSubject(this.client.Id);
                if (this.clientSubjects.Count <= 0)
                {
                    MessageBox.Show("没有新会计科目");
                }
            }
        }
        //
        //刷新新科目按钮end
        //
        //新科目导出start
        //
        private void newSubject2T3button_Click(object sender, EventArgs e)
        {
            this.exportSubject();
        }
        private void exportSubject()
        {
            ExportBean exporBean = new ExportBean();
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

            if (this.clientSubjects == null || this.clientSubjects.Count <= 0)
            {
                MessageBox.Show("没有需要导入用友T3的新科目");
                return;
            }

            if (this.accset.CAcc_Name != this.client.Fullname && this.accset.CAcc_Name != this.client.Name)
            {
                DialogResult dr = MessageBox.Show("选择的客户与账套名称不一致，是否继续导入?", "系统提示", MessageBoxButtons.OKCancel);

                if (dr != DialogResult.OK)
                {
                    return;
                }
            }
            exporBean.Instid = this.inst.Id;
            exporBean.Clientid = this.client.Id;
            exporBean.Accountcyclesn = this.accountcycle.Sn;
            exporBean.Createby = this.user.Id;
            try
            {
                YYT3Factory yYT3Factory = new YYT3Factory();
                yYT3Factory.exportSubject(exporBean, this.accset);

                ClientSubjectFactory csf = new ClientSubjectFactory();
                csf.updateIsNew(this.clientSubjects, 0);
                this.queryClientNewSubject(this.client.Id);

                MessageBox.Show("新科目导出成功!请登录财务系统查看结果!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //
        //新科目导出end
        //
        //凭证导出start
        //
        private void exportIncomeButton_Click(object sender, EventArgs e)
        {
            this.exports("income");
        }

        private void exportOutputButton_Click(object sender, EventArgs e)
        {
            this.exports("output");
        }

        private void bankbillExportbutton_Click(object sender, EventArgs e)
        {
            this.exports("bankbill");
        }

        private void paytaxreportbutton_Click(object sender, EventArgs e)
        {
            this.exports("paytaxreport");
        }

        private void localreporttaxbutton_Click(object sender, EventArgs e)
        {
            this.exports("localreporttax");
        }

        private void exportpayrollbutton_Click(object sender, EventArgs e)
        {
            this.exports("payroll");
        }
        private void exports(string categoryname)
        {
            ExportBean exportBean = new ExportBean();
            if (this.inst == null || this.inst.Id == null)
            {
                MessageBox.Show("无法获取当前机构信息");
            }
            if (this.client == null || this.client.Id == null)
            {
                MessageBox.Show("无法获取当前客户信息");
            }
            if (this.accountcycle == null || this.accountcycle.Id == null)
            {
                MessageBox.Show("无法获取当前月份信息");
            }
            if (this.user == null || this.user.Id == null)
            {
                MessageBox.Show("无法获取当前用户信息");
            }
            if (this.accset == null)
            {
                MessageBox.Show("请选择账套信息");
            }
            if (accset.CAcc_Name != client.Name && accset.CAcc_Name != client.Fullname)
            {
                DialogResult dr = MessageBox.Show("选择的客户与账套名称不一致，是否继续导入?", "系统提示", MessageBoxButtons.OKCancel);
                if (dr != DialogResult.OK)
                {
                    return;
                }
            }
            exportBean.Instid = this.inst.Id;
            exportBean.Clientid = this.client.Id;
            exportBean.Categoryname = categoryname;
            exportBean.Createby = "Demo";
            exportBean.Accountcyclesn = this.accountcycle.Sn;
            try
            {
                this.InformationTextBox.Text = "正在导出凭证,请稍等……";
                this.InformationTextBox.Visible = true;
                this.InformationTextBox.Font = new Font("宋体", 12);
                if (this.InformationTextBox.Visible == true)
                {
                    YYT3Factory yYT3Factory = new YYT3Factory();
                    yYT3Factory.exports(exportBean, this.accset);
                }
                this.InformationTextBox.Visible = false;
                MessageBox.Show("凭证导出成功!请登录财务系统查看结果!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                MessageBox.Show(e.Message);
            }
        }
        //
        //凭证导出end
        //
        //客户初始化start
        //
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
            if (accset.CAcc_Name != client.Name && accset.CAcc_Name != client.Fullname)
            {
                DialogResult dr = MessageBox.Show("选择的客户与账套名称不一致，是否继续初始化?", "系统提示", MessageBoxButtons.OKCancel);

                if (dr != DialogResult.OK)
                {
                    return;
                }
            }

            try
            {
                this.InformationTextBox.Visible = true;//打开提示框
                this.InformationTextBox.Text = "正在初始化会计科目!请稍等……";//提示文本
                this.InformationTextBox.Font = new Font("宋体", 12);//提示字体

                YYT3Factory yYT3Factory = new YYT3Factory();
                yYT3Factory.initSubjectByYYT3(this.accset, this.client, Session.GetInstance().User);

                this.InformationTextBox.Visible = false;//关闭提示框

                MessageBox.Show("初始化成功，请打开小微服查看!");

            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.StackTrace);
                this.InformationTextBox.Visible = false;//关闭提示框
                MessageBox.Show(e1.Message);
            }
        }
        //
        //客户初始化end
        //
    }
}
