using MicroServiceApplication.Bean;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MicroServiceApplication.Common
{
    public partial class SelectClientForm : Form
    {
        public SelectClientForm()
        {
            InitializeComponent();
        }

        private DataTable clientDt;

        private List<Client> clientList;

        private List<Client> _currClient = new List<Client>();
        
        internal List<Client> CurrClient
        {
            get
            {
                return _currClient;
            }

            set
            {
                _currClient = value;
            }
        }

        private void SelectClientForm_Load(object sender, EventArgs e)
        {
            ClientFactory clientFactory = new ClientFactory();
            clientList = clientFactory.queryByInst(Session.GetInstance().Inst.Id);

            clientDt = new DataTable();

            DataColumn clientIdCol = new DataColumn();
            clientIdCol.ColumnName = "id";
            clientIdCol.DataType = Type.GetType("System.String");
            
            clientDt.Columns.Add(clientIdCol);

            DataColumn clientNoCol = new DataColumn();
            clientNoCol.ColumnName = "客户编号";
            clientNoCol.DataType = Type.GetType("System.String");
            clientDt.Columns.Add(clientNoCol);
       
            //clientDt.Columns.Add("客户编号", Type.GetType("System.String"));
            clientDt.Columns.Add("客户名称", Type.GetType("System.String"));
            clientDt.Columns.Add("纳税方式", Type.GetType("System.String"));

            foreach(Client item in clientList)
            {
                DataRow datarow = clientDt.NewRow();

                datarow[0] = item.Id;
                datarow[1] = item.Sn;
                datarow[2] = item.Name;
                datarow[3] = item.Taxtypeccname;
                
                clientDt.Rows.Add(datarow);
            }

            this.ClientDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.ClientDataGridView.MultiSelect = false;

            this.ClientDataGridView.ColumnHeadersHeight = 30;
            this.ClientDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ClientDataGridView.RowTemplate.Height = 20;
            this.ClientDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.ClientDataGridView.DataSource = clientDt;
            this.ClientDataGridView.Columns["id"].Visible = false;


        }

        private void selectClient()
        {

           if (this.ClientDataGridView.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请先选择客户！");
                return;
            }



            Client client = this.findClient(this.ClientDataGridView.CurrentRow.Cells[0].Value.ToString());

            if (client != null)
            {
                this.CurrClient = new List<Client>();
                this.CurrClient.Add(client);

                this.DialogResult = DialogResult.OK;
            }else
            {
                this.DialogResult = DialogResult.Abort;
            }
           
            this.Close();
        }

        private Client findClient(string id)
        {
            foreach (Client item in this.clientList)
            {
                if (item.Id == id) return item;
            }
            return null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.clientNameTextBox.Text == "" || this.clientNameTextBox.Text == null)
            {
                this.clientDt.DefaultView.RowFilter = "";
            }
            else
            {
                this.clientDt.DefaultView.RowFilter = "客户名称 like '%" + this.clientNameTextBox.Text + "%'";
            }
           
        }

        private void ClientDataGridView_DoubleClick(object sender, EventArgs e)
        {
            this.selectClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.selectClient();
        }

        private void ClientDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            
        }
    }
}
