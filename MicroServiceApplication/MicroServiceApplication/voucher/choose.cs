using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MicroServiceApplication.voucher
{
    public partial class Choose : Form
    {
        public Choose()
        {
            InitializeComponent();
        }
        public string vouchernumber;
        public void button1_Click(object sender, EventArgs e)
        {
            vouchernumber = "three";
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vouchernumber = "two";
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vouchernumber = "no";
            this.Close();
                
        }
    }
}
