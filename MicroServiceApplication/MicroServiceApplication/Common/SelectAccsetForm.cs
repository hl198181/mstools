using MicroServiceApplication.factory;
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
    public partial class SelectAccsetForm : Form
    {
        private List<Sd3000Accset> _sd3000AccsetList;
        private Sd3000Accset _accset;

        DataTable accsetDt;
        public SelectAccsetForm()
        {
            InitializeComponent();
        }

        internal List<Sd3000Accset> Sd3000AccsetList
        {
            get
            {
                return _sd3000AccsetList;
            }

            set
            {
                _sd3000AccsetList = value;
            }
        }

        internal Sd3000Accset Accset
        {
            get
            {
                return _accset;
            }

            set
            {
                _accset = value;
            }
        }

        private void SelectAccsetForm_Load(object sender, EventArgs e)
        {
            accsetDt = new DataTable();
            
            accsetDt.Columns.Add("accsetid", Type.GetType("System.String"));
            accsetDt.Columns.Add("账套名称", Type.GetType("System.String"));

            foreach (Sd3000Accset item in this.Sd3000AccsetList)
            {
                DataRow datarow = accsetDt.NewRow();

                datarow[0] = item.Accsetid;
                datarow[1] = item.Corpname;
                accsetDt.Rows.Add(datarow);
            }

            this.accsetDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.accsetDataGridView.MultiSelect = false;

            this.accsetDataGridView.ColumnHeadersHeight = 30;
            this.accsetDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.accsetDataGridView.RowTemplate.Height = 20;
            this.accsetDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.accsetDataGridView.DataSource = accsetDt;
            this.accsetDataGridView.Columns["accsetid"].Visible = false;
            this.accsetDataGridView.Columns["账套名称"].Width = 500;
        }


        private void select()
        {

            if (this.accsetDataGridView.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请先选择账套！");
                return;
            }

            Sd3000Accset accset = this.findAccset(this.accsetDataGridView.CurrentRow.Cells[0].Value.ToString());

            if (accset != null)
            {
                this.Accset = accset;

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Abort;
            }

            this.Close();
        }

        private Sd3000Accset findAccset(string id)
        {
            foreach (Sd3000Accset item in this.Sd3000AccsetList)
            {
                if (item.Accsetid == id) return item;
            }
            return null;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.select();
        }

        private void accsetDataGridView_DoubleClick(object sender, EventArgs e)
        {
            this.select();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.accsetNametextBox.Text == "" || this.accsetNametextBox.Text == null)
            {
                this.accsetDt.DefaultView.RowFilter = "";
            }
            else
            {
                this.accsetDt.DefaultView.RowFilter = "账套名称 like '%" + this.accsetNametextBox.Text + "%'";
            }

        }
    }
}
