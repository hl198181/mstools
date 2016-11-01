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
        private KisExportsForm kisExportsForm;
        private Sd3000Form sd3000Form ;
        private KisFileForm kisFileForm;
        private YYT3Form yYT3Form;

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

        private void KisFileToolStripMenuItem_Click(object sender,EventArgs e)
        {
            if (kisFileForm == null || kisFileForm.IsDisposed)
            {
                kisFileForm = new KisFileForm();
                kisFileForm.MdiParent = this;
                kisFileForm.WindowState = FormWindowState.Maximized;
                kisFileForm.Show();
            }else
            {
                kisFileForm.Activate();
            }
        }

        private void YYT3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (yYT3Form == null || yYT3Form.IsDisposed)
            {
                yYT3Form = new YYT3Form();
                yYT3Form.MdiParent = this;
                yYT3Form.WindowState = FormWindowState.Maximized;
                yYT3Form.Show();
            }
            else
            {
                yYT3Form.Activate();
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

            ToolStripMenuItem kisFileMenuItem = new ToolStripMenuItem();
            kisFileMenuItem.Name = "KisFile";
            kisFileMenuItem.Text = "金蝶KIS数据库文件导入";
            kisFileMenuItem.Click += new EventHandler(KisFileToolStripMenuItem_Click);
            menuItem.DropDownItems.Add(kisFileMenuItem);

            ToolStripMenuItem sd3000MenuItem = new ToolStripMenuItem();
            sd3000MenuItem.Name = "sd3000";
            sd3000MenuItem.Text = "速达3000";
            sd3000MenuItem.Click += new EventHandler(Sd300ToolStripMenuItem_Click);
            menuItem.DropDownItems.Add(sd3000MenuItem);

            ToolStripMenuItem YYT3MenuItem = new ToolStripMenuItem();
            YYT3MenuItem.Name = "yYT3";
            YYT3MenuItem.Text = "用友T3";
            YYT3MenuItem.Click += new EventHandler(YYT3ToolStripMenuItem_Click);
            menuItem.DropDownItems.Add(YYT3MenuItem);
        }
    }
}
