using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MicroServiceApplication.factory;
using MicroServiceApplication.Bean;

namespace MicroServiceApplication.voucher
{
    public partial class Sd3000Form : Form
    {
        public Sd3000Form()
        {
            InitializeComponent();
        }

        private void IncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sd3000Factory factory = new Sd3000Factory();

            ExportBean exportBean = new ExportBean();
            exportBean.Createby = SessionClass.GetInstance().User.Id;
            exportBean.Instid = SessionClass.GetInstance().Inst.Id;
            exportBean.Accountcyclesn = "200511";
            exportBean.Clientid = "";
            factory.exports(exportBean);

        }
    }
}
