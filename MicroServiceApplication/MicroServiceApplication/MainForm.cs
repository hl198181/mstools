using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MicroServiceApplication.voucher;

namespace MicroServiceApplication
{
    public partial class MainForm : Form
    {
        KisExportsForm kisExportsForm;
        Sd3000Form sd3000Form ;
        public MainForm()
        {
            InitializeComponent();
           
        }



        private void KisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kisExportsForm == null || kisExportsForm.IsDisposed)
            {
                kisExportsForm = new KisExportsForm();
                kisExportsForm.MdiParent = this;
                kisExportsForm.WindowState = FormWindowState.Maximized;
                kisExportsForm.Show();
            }
            else
            {
                kisExportsForm.Activate();
            }
            
        }

        private void Sd300ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sd3000Form == null || sd3000Form.IsDisposed)
            {
                sd3000Form = new Sd3000Form();
                sd3000Form.MdiParent = this;
                sd3000Form.WindowState = FormWindowState.Maximized;
                sd3000Form.Show();
            }
            else
            {
                sd3000Form.Activate();
            }
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + " - " + Session.GetInstance().Inst.Name;

            ToolStripMenuItem menuItem = new ToolStripMenuItem();
            menuItem.Name = "exportvoucher";
            menuItem.Text = "凭证导出";

            this.menuStrip1.Items.Add(menuItem);

            ToolStripMenuItem kisMenuItem = new ToolStripMenuItem();
            kisMenuItem.Name = "kis";
            kisMenuItem.Text = "金蝶标准凭证格式";
            kisMenuItem.Click += new EventHandler(KisToolStripMenuItem_Click);
            menuItem.DropDownItems.Add(kisMenuItem);

            ToolStripMenuItem sd3000MenuItem = new ToolStripMenuItem();
            sd3000MenuItem.Name = "sd3000";
            sd3000MenuItem.Text = "速达3000";
            sd3000MenuItem.Click += new EventHandler(Sd300ToolStripMenuItem_Click);
            menuItem.DropDownItems.Add(sd3000MenuItem);
        }
    }
}
