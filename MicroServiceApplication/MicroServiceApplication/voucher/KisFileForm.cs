using MicroServiceApplication.Bean;
using MicroServiceApplication.Common;
using MicroServiceApplication.Factory;
using System;
using System.Collections.Generic;
using System.Data;
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

        private void initSubjectButton_Click(object sender, EventArgs e)
        {
            if (this.client == null)
            {
                MessageBox.Show("请选择客户信息！");
                return;
            }

            if (this.kisDbFileParams == null || this.kisDbFileParams.DbFilePath == null)
            {
                MessageBox.Show("请选择账套数据库文件！");
                return;
            }

            KisDbFileFactory kisDbFileFactory = new KisDbFileFactory(this.kisDbFileParams);

            try
            {
                kisDbFileFactory.initSubject(this.client, this.user);
                MessageBox.Show("初始化科目完成，请登录小微服查看！");
            }catch(Exception e1)
            {
                MessageBox.Show("初始化科目错误！"+e1.Message);
            }
            
        }

        private void subjectToKisButton_Click(object sender, EventArgs e)
        {
            if (this.clientSubjects == null || this.clientSubjects.Count <= 0)
            {
                MessageBox.Show("没有需要导入KIS的新科目！");
                return;
            }

            if (this.kisDbFileParams == null || this.kisDbFileParams.DbFilePath == null)
            {
                MessageBox.Show("请先选择财务账套数据库文件!");
                return;
            }

            KisDbFileFactory kisDbFileFactory = new KisDbFileFactory(this.kisDbFileParams);

            try
            {
                kisDbFileFactory.exportSubject2Kis(this.clientSubjects);
                MessageBox.Show("导入新科目到KIS成功，请打开财务系统查看!");
            }
            catch (Exception e1)
            {
                MessageBox.Show("导入新科目到KIS错误！" + e1.Message);
            }
        }
    }
}
