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
    public partial class SelectAccountcycleForm : Form
    {
        private List<Accountcycle> _currAccountcycle;

        private List<Accountcycle> accountcycleList;

        private DataTable accountcycleDt;

        public SelectAccountcycleForm()
        {
            InitializeComponent();
        }

        internal List<Accountcycle> CurrAccountcycle
        {
            get
            {
                return _currAccountcycle;
            }

            set
            {
                _currAccountcycle = value;
            }
        }

        private void SelectAccountcycleForm_Load(object sender, EventArgs e)
        {
            AccountcycleFactory af = new AccountcycleFactory();
            this.accountcycleList = af.query(-11,1);

            accountcycleDt = new DataTable();

            DataColumn idCol = new DataColumn();
            idCol.ColumnName = "id";
            idCol.DataType = Type.GetType("System.String");
            accountcycleDt.Columns.Add(idCol);
            accountcycleDt.Columns.Add("月份", Type.GetType("System.String"));

            foreach (Accountcycle item in this.accountcycleList)
            {
                DataRow datarow = accountcycleDt.NewRow();

                datarow[0] = item.Id;
                datarow[1] = item.Name;
                accountcycleDt.Rows.Add(datarow);
            }

            this.AccountcycleDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.AccountcycleDataGridView.MultiSelect = false;

            this.AccountcycleDataGridView.ColumnHeadersHeight = 30;
            this.AccountcycleDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AccountcycleDataGridView.RowTemplate.Height = 20;
            this.AccountcycleDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.AccountcycleDataGridView.DataSource = accountcycleDt;
            this.AccountcycleDataGridView.Columns["id"].Visible = false;

        }

        private void select()
        {

            if (this.AccountcycleDataGridView.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请先选择客户！");
                return;
            }

            Accountcycle accountcycle = this.findAccountcycle(this.AccountcycleDataGridView.CurrentRow.Cells[0].Value.ToString());

            if (accountcycle != null)
            {
                this.CurrAccountcycle = new List<Accountcycle>();
                this.CurrAccountcycle.Add(accountcycle);

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Abort;
            }

            this.Close();
        }

        private Accountcycle findAccountcycle(string id)
        {
            foreach (Accountcycle item in this.accountcycleList)
            {
                if (item.Id == id) return item;
            }
            return null;
        }


        private void AccountcycleDataGridView_DoubleClick(object sender, EventArgs e)
        {
            this.select();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.select();
        }
    }
}
