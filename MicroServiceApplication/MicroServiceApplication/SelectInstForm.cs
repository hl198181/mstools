using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MicroServiceApplication.Bean;

namespace MicroServiceApplication
{
    public partial class SelectInstForm : Form
    {
        public SelectInstForm()
        {
            InitializeComponent();
        }

        private void SelectInstForm_Load(object sender, EventArgs e)
        {
            InstFactory instFactory = new InstFactory();

            List<Inst> instList = instFactory.queryByUserById(Session.GetInstance().User.Id);

            this.InstListView.View = View.Details;
            this.InstListView.FullRowSelect = true;
            this.InstListView.Columns.Add("机构名称", 300, HorizontalAlignment.Left);
            this.InstListView.BeginUpdate();
            foreach(Inst item in instList){
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Name;
                lvi.Tag = item;
                this.InstListView.Items.Add(lvi); 
            }

            this.InstListView.EndUpdate();
        }

        private void InstListView_DoubleClick(object sender, EventArgs e)
        {
            this.selectInst();
        }

        private void selectInst()
        {
            int selectCount = this.InstListView.SelectedItems.Count; //SelectedItems.Count就是：取得值，表示SelectedItems集合的物件数目。 
            if (selectCount > 0)//若selectCount大於0，说明用户有选中某列。
            {
                ListViewItem listViewItem = this.InstListView.SelectedItems[0];
                Inst inst = (Inst)listViewItem.Tag;
                Session.GetInstance().Inst = inst;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("请选择机构!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.selectInst();
        }
    }
}
