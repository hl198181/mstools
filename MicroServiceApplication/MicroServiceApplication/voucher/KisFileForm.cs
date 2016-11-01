using MicroServiceApplication.Bean;
using MicroServiceApplication.Common;
using MicroServiceApplication.Factory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MicroServiceApplication.voucher
{
    public partial class KisFileForm : Form
    {
        private Client client;
        private KisDbFileParams kisDbFileParams;
        private User user;
        private Inst inst;
        private List<ClientSubject> clientSubjects;
        private Accountcycle accountcycle;

        public KisFileForm()
        {
            InitializeComponent();
        }

        private void selectClientButton_Click(object sender, EventArgs e)
        {
            List<Client> clientList =  CommonManager.selectClient();
            if (clientList != null && clientList.Count >0){
                this.client = clientList[0];
                this.clientNameTextBox.Text = this.client.Fullname;
                this.queryClientNewSubject(this.client.Id);
            }
        }

        private void selectDbFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "AIS文件   (*.AIS)|*.AIS";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.kisDbFileParams = new KisDbFileParams();
                this.kisDbFileParams.DbFilePath = openFileDialog.FileName;
                this.kisDbFileParams.DbFileName = System.IO.Path.GetFileName(openFileDialog.FileName);
                this.dbFilePathTextBox.Text = this.kisDbFileParams.DbFilePath;
            }
            else
            {
                return;
            }

        }
        private void testConnectButton_Click(object sender, EventArgs e)
        {
            if (this.kisDbFileParams == null ||  this.kisDbFileParams.DbFilePath == null || this.kisDbFileParams.DbFilePath == "")
            {
                MessageBox.Show("请选择数据库文件!");
                return;
            }
            KisDbFileFactory kisDbFileFactory = new KisDbFileFactory(this.kisDbFileParams);

            try
            {
                kisDbFileFactory.testConnect();
                MessageBox.Show("连接数据库成功！");
            }catch(Exception e1)
            {
                MessageBox.Show("连接数据库错误！"+e1.Message);
            }
        }

        private void KisFileForm_Load(object sender, EventArgs e)
        {
            this.user = Session.GetInstance().User;
            this.inst = Session.GetInstance().Inst;
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
            this.clientSubjects = csf.query(clientid, 1, 1);

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
        private void initSubject()
        {
            if (this.client == null)
            {
                MessageBox.Show("请先选择客户信息!");
                return;
            }

            if (this.kisDbFileParams == null)
            {
                MessageBox.Show("请先选择数据库文件!");
                return;
            }

            KisDbFileFactory kisDbFileFactory = new KisDbFileFactory(this.kisDbFileParams);
            KisDbPref kisDbPref = kisDbFileFactory.getGLPref();
            try
            {
                if (kisDbPref.Fcompany != this.client.Fullname && kisDbPref.Fcompany != this.client.Name)
                {
                    DialogResult dr = MessageBox.Show("选择的客户与账套名称不一致,是否继续初始化?", "系统提示", MessageBoxButtons.OKCancel);
                    if (dr != DialogResult.OK)
                    {
                        return;
                    }
                }
                this.InformationTextBox.Visible = true;//打开提示框
                this.InformationTextBox.Text = "正在初始化会计科目!请稍等……";//提示文本
                this.InformationTextBox.Font = new Font("宋体", 12);//提示字体

                kisDbFileFactory.initSubject(this.client, this.user);//引用工厂里初始化科目的方法

                this.InformationTextBox.Visible = false;//关闭提示框
                MessageBox.Show("初始化科目完成,请登录小微服查看!");
            }
            catch (Exception e1)
            {
                this.InformationTextBox.Visible = false;//关闭提示框
                MessageBox.Show("初始化科目失败" + e1.Message);
            }
        }

        private void subjectToKis()
        {
            if (this.client == null)
            {
                MessageBox.Show("请选择客户信息!");
                return;
            }

            if (this.kisDbFileParams == null || this.kisDbFileParams.DbFilePath == null)
            {
                MessageBox.Show("请选择数据库文件!");
                return;
            }
            if (this.clientSubjects == null || this.clientSubjects.Count <= 0)
            {
                MessageBox.Show("没有需要导入KIS的新科目");
                return;
            }


            KisDbFileFactory kisDbFileFactory = new KisDbFileFactory(this.kisDbFileParams);
            KisDbPref kisDbPref = kisDbFileFactory.getGLPref();
            try
            {
                //检查当前客户与账套信息是否一致
                if (kisDbPref.Fcompany != this.client.Fullname && kisDbPref.Fcompany != this.client.Name)
                {
                    DialogResult dr = MessageBox.Show("选择的客户与账套名称不一致,是否继续导入?", "系统提示", MessageBoxButtons.OKCancel);
                    if (dr != DialogResult.OK)
                    {
                        return;
                    }
                }
                kisDbFileFactory.exportSubject2Kis(this.clientSubjects);//引用工厂里导入新科目的方法
                ClientSubjectFactory csf = new ClientSubjectFactory();
                csf.updateIsNew(this.clientSubjects, 0);//引用新科目导入数据库后更新sinew和audit的状态
                this.queryClientNewSubject(this.client.Id);//显示当前客户新会计科目的方法
                MessageBox.Show("导入新科目到KIS成功,请打开财务系统查看!");
            }
            catch (Exception e1)
            {
                MessageBox.Show("导入新科目到KIS错误!" + e1.Message);
            }
        }

        private void setupKisPath()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "金蝶安全策略文件   (*.MDA)|*.MDA";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                AppConfig.GetInstance().updateAppConfig("kissecurityfile", openFileDialog.FileName);
                AppConfig.GetInstance().reLoadConfig();
                MessageBox.Show("设置成功！");
            }
            else
            {
                return;
            }
        }

        private void selectAccountcycle()
        {
            List<Accountcycle> accountcycleList = CommonManager.selectAccountcycle();
            if (accountcycleList != null && accountcycleList.Count > 0)
            {
                this.accountcycle = accountcycleList[0];
                this.accountcycleTextBox.Text = this.accountcycle.Name;
            }
        }

        private void exports(string categoryname)
        {
            if (this.inst == null || this.inst.Id == null)
            {
                MessageBox.Show("无法获取当前机构信息!");
                return;
            }
            if (this.user == null || this.user.Id == null)
            {
                MessageBox.Show("无法获取当前用户信息!");
            }
            if (this.client == null || this.client.Id == null)
            {
                MessageBox.Show("请先选择客户信息!");
                return;
            }
            if (this.accountcycle == null || this.accountcycle.Id == null)
            {
                MessageBox.Show("请先选择月份!");
                return;
            }
            if (this.kisDbFileParams == null || this.kisDbFileParams.DbFilePath == null)
            {
                MessageBox.Show("请先选择数据库文件!");
                return;
            }

            try
            {
                KisDbFileFactory kisDbFileFactory = new KisDbFileFactory(this.kisDbFileParams);
                KisDbPref kisDbPref = kisDbFileFactory.getGLPref();

                //检查当前客户与账套信息是否一致
                if (kisDbPref.Fcompany != this.client.Fullname && kisDbPref.Fcompany != this.client.Name)
                {
                    DialogResult dr = MessageBox.Show("选择的客户与账套名称不一致,是否继续导入?", "系统提示", MessageBoxButtons.OKCancel);
                    if (dr != DialogResult.OK)
                    {
                        return;
                    }
                }
                //执行导出凭证到KIS
                this.InformationTextBox.Visible = true;//打开提示框
                this.InformationTextBox.Text = "正在初始化会计科目!请稍等……";//提示文本
                this.InformationTextBox.Font = new Font("宋体", 12);//提示字体

                kisDbFileFactory.exportVoucher(this.inst, this.client, this.accountcycle, this.user, categoryname);

                this.InformationTextBox.Visible = false;//关闭提示框
                MessageBox.Show("导出凭证成功!请登录财务系统查看结果");

            }
            catch (Exception e)
            {

                Console.WriteLine(e.StackTrace);
                this.InformationTextBox.Visible = false;//关闭提示框
                MessageBox.Show(e.Message);

            }
        }


        private void subjectToKisButton_Click(object sender, EventArgs e)
        {
            this.subjectToKis();
        }

        private void InitSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.initSubject();
        }

        private void SetupKisDirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.setupKisPath();
        }

        private void selectAccountcycleButton_Click(object sender, EventArgs e)
        {
            this.selectAccountcycle();
        }

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

        private void exportpayrollbutton_Click(object sender, EventArgs e)
        {
            this.exports("payroll");
        }

        private void paytaxreportbutton_Click(object sender, EventArgs e)
        {
            this.exports("paytaxreport");
        }

        private void localreporttaxbutton_Click(object sender, EventArgs e)
        {
            this.exports("localreporttax");
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            if (this.client == null)
            {
                MessageBox.Show("请选择客户信息!");
            }
            else
            {
                this.queryClientNewSubject(this.client.Id);//刷新新会计科目
                if (this.clientSubjects.Count <= 0)
                {
                    MessageBox.Show("没有新会计科目!");
                }
            }
        }
    }
}
