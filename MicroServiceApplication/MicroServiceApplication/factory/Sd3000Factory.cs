using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MicroServiceApplication.Bean;
using System.Windows.Forms;

namespace MicroServiceApplication.factory
{
    class Sd3000Factory
    {
        class ExportSd3000Context
        {
            private ExportBean _exportBean;

            public ExportBean ExportBean
            {
                get { return _exportBean; }
                set { _exportBean = value; }
            }
            private int _maxCredid;

            public int MaxCredid
            {
                get { return _maxCredid; }
                set { _maxCredid = value; }
            }
            private int _maxCredcode;

            public int MaxCredcode
            {
                get { return _maxCredcode; }
                set { _maxCredcode = value; }
            }

            private SqlConnection _connection;

            public SqlConnection Connection
            {
                get { return _connection; }
                set { _connection = value; }
            }

        }

        string connurl = "Server=192.168.1.185;Database=SD11001N_Sample;user id=sa ;password=sybase12 ;";

        public void exports(ExportBean exportBean)
        {
            ExportSd3000Context context = new ExportSd3000Context();
            context.ExportBean = exportBean;

            SqlConnection connection = new SqlConnection(connurl);
            context.Connection = connection;

            try
            {
                getCredid(context);
                getGroupNameId("记", context);

            }
            catch (Exception e)
            {
                MessageBox.Show("导出速达凭证错误."+e);
            }
            finally
            {
                context.Connection.Close();
            }





            //SqlDataAdapter myDataAdapter = new SqlDataAdapter("select * from credence", mycon);
            //DataSet myDataSet = new DataSet();		// 创建DataSet
            //myDataAdapter.Fill(myDataSet, "credence");

            //DataTable myTable = myDataSet.Tables["credence"];

            //foreach (DataRow myRow in myTable.Rows)
            //{
            //    foreach (DataColumn myColumn in myTable.Columns)
            //    {
            //        Console.WriteLine(myRow[myColumn]);	//遍历表中的每个单元格
            //    }
            //}

            //mycon.Close();
        }

        //获取凭证字id
        private string getGroupNameId(string groupname,ExportSd3000Context context)
        {
            string sql = "select * from credtype where name = '"+groupname+"'";

            SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, context.Connection);
            DataSet myDataSet = new DataSet();		// 创建DataSet
            myDataAdapter.Fill(myDataSet, "credtype");
            DataTable myTable = myDataSet.Tables["credtype"];

            string typeid  = myTable.Rows[0][myTable.Columns["typeid"]].ToString();
            return typeid;

        }

        //获取凭证最大序号
        private void getCredid(ExportSd3000Context context)
        {
            string sql = "select max(credid) as credid,max(credcode) as credcode from credence where credid like '" + context.ExportBean.Accountcyclesn + "%'";
            
            SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, context.Connection);
            DataSet myDataSet = new DataSet();		// 创建DataSet
            
            myDataAdapter.Fill(myDataSet, "credence");
            DataTable myTable = myDataSet.Tables["credence"];

            string credid = myTable.Rows[0][myTable.Columns["credid"]].ToString();
            string credcode = myTable.Rows[0][myTable.Columns["credcode"]].ToString();

            if (credid == "" || credid == null)
            {
                context.MaxCredid = 0;
            }
            else if (credid.Length == 12)
            {
                string snstr = credid.Substring(6);
                context.MaxCredid = int.Parse(snstr);
            }
            else
            {
                throw new Exception("无法识别的凭证序号类型:" + credid);
            }

            if (credcode == "" || credcode == null)
            {
                context.MaxCredcode = 0;
            }
            else
            {
                context.MaxCredcode = int.Parse(credcode);
            }
        }
    }
}
