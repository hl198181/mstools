using MicroServiceApplication.Factory;
using System;
using System.Windows.Forms;

namespace MicroServiceApplication.voucher
{
    public partial class KisFileForm : Form
    {
        public KisFileForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "AIS文件   (*.AIS)|*.AIS";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                KisDbFileParams param = new KisDbFileParams();
                param.DbFilePath = openFileDialog.FileName;
                param.DbFileName = System.IO.Path.GetFileName(openFileDialog.FileName);

                KisDbFileExportFactory kdbfef = new KisDbFileExportFactory();
                kdbfef.export(param);
            }
            else
            {
                return;
            }


        }
    }
}
