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
    //
    //弹出账套选择的界面方法与设置start
    //
    public partial class SelectT3AccsetForm : Form
    {
        //
        //选择账套的封装字段start
        //
        private List<YYT3accset> _yYT3AccsetList;
        private YYT3accset _accset;

        DataTable accsetDt;
        public SelectT3AccsetForm()
        {
            InitializeComponent();
        }

        internal List<YYT3accset> YYT3AccsetList
        {
            get
            {
                return _yYT3AccsetList;
            }

            set
            {
                _yYT3AccsetList = value;
            }
        }

        internal YYT3accset Accset
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
        //
        //选择账套的封装字段end
        //
        //显示账套列表的方法start
        //
        private void SelectAccsetForm_Load(object sender, EventArgs e)
        {
            accsetDt = new DataTable();

            accsetDt.Columns.Add("Id", Type.GetType("System.String"));
            accsetDt.Columns.Add("账套名称", Type.GetType("System.String"));

            foreach (YYT3accset item in this.YYT3AccsetList)
            {
                DataRow datarow = accsetDt.NewRow();

                datarow[0] = item.CAcc_Id;
                datarow[1] = item.CAcc_Name;
                accsetDt.Rows.Add(datarow);
            }

            this.accsetDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.accsetDataGridView.MultiSelect = false;

            this.accsetDataGridView.ColumnHeadersHeight = 30;
            this.accsetDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.accsetDataGridView.RowTemplate.Height = 20;
            this.accsetDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.accsetDataGridView.DataSource = accsetDt;
            this.accsetDataGridView.Columns["Id"].Visible = false;
            //this.accsetDataGridView.Columns["Id"].Width = 50;
            this.accsetDataGridView.Columns["账套名称"].Width = 500;
            
        }
        //
        //显示账套列表的方法end
        
        private void select()
        {

            if (this.accsetDataGridView.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请先选择账套！");
                return;
            }

            YYT3accset accset = this.findAccset(this.accsetDataGridView.CurrentRow.Cells[0].Value.ToString());

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
        private YYT3accset findAccset(string id)
        {
            foreach (YYT3accset item in this.YYT3AccsetList)
            {
                if (item.CAcc_Id == id) return item;
            }
            return null;
        }
        //
        //选择账套按钮start
        //
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.select();
        }
        //
        //选择账套按钮end
        //
        private void accsetDataGridView_DoubleClick(object sender, EventArgs e)
        {
            this.select();
        }
        //
        //搜索账套start
        //
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
        //
        //搜索账套end
        //
    }
    //
    //弹出账套选择的界面方法与设置end
    //
}