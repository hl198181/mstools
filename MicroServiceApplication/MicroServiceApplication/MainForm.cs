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
            //LayoutMdi(MdiLayout.Cascade);
            this.Text = this.Text + " - "+ SessionClass.GetInstance().Inst.Name;
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
    }
}
