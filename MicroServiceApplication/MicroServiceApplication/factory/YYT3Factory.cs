using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MicroServiceApplication.Bean;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using MicroServiceApplication.Common;
using System.Net.Http.Headers;

namespace MicroServiceApplication.factory
{
    //
    //账套配置的封装字段start
    //
    class YYT3accset
    {
        private string _iSysId;
        private string _cAcc_Id;
        private string _cAcc_Name;
        private string _iYear;
        private string _dbHost;
        private string _dbName;
        private string _dbUser;
        private string _dbPassword;

        public string ISysId
        {
            get
            {
                return _iSysId;
            }

            set
            {
                _iSysId = value;
            }
        }

        public string CAcc_Id
        {
            get
            {
                return _cAcc_Id;
            }

            set
            {
                _cAcc_Id = value;
            }
        }

        public string CAcc_Name
        {
            get
            {
                return _cAcc_Name;
            }

            set
            {
                _cAcc_Name = value;
            }
        }

        public string IYear
        {
            get
            {
                return _iYear;
            }

            set
            {
                _iYear = value;
            }
        }

        public string DbHost
        {
            get
            {
                return _dbHost;
            }

            set
            {
                _dbHost = value;
            }
        }

        public string DbName
        {
            get
            {
                return _dbName;
            }

            set
            {
                _dbName = value;
            }
        }

        public string DbUser
        {
            get
            {
                return _dbUser;
            }

            set
            {
                _dbUser = value;
            }
        }

        public string DbPassword
        {
            get
            {
                return _dbPassword;
            }

            set
            {
                _dbPassword = value;
            }
        }
    }
    //
    //账套配置的封装字段end
    //
    //
    //
    class T3ExportSd3000Context
    {
        //private ExportBean _exportBean;

        //private List<Sd3000Subject> _subjects;

        //private Dictionary<string, Sd3000Accoptions> _accoptionsDict;

        //private List<ClientSubject> _clientSubjects;

        //private int _maxSubid;

        private List<string> _sqls = new List<string>();
    }
    class YYT3Factory
    {
        //
        //创建一个打开数据库的连接start
        //
        private SqlConnection createConnection(YYT3accset accset)
        {
            string connecturl = "Data Source=" + accset.DbHost + ";Initial Catalog=" + accset.DbName + ";Persist Security Info=True;User ID=" + accset.DbUser + ";Password=" + accset.DbPassword;//数据库的ip、用户名、密码
            SqlConnection connection = new SqlConnection(connecturl);//用上面的ip、用户名、密码创建一个打开数据库的连接
            return connection;
        }
        //
        //创建一个打开数据库的连接end
        //
        //选择账套的方法start
        //
        public List<YYT3accset> queryAccset(string dbuser,string dbpassword,string dbip,string dbprefix)
        {
            if (dbip == "" || dbprefix == "" || dbip == null || dbprefix == null)return null;
            List<YYT3accset> accsetList = new List<YYT3accset>();

            string connecturl = "Data Source=" + dbip + ";Initial Catalog=master;Persist Security Info=True;User ID=" + dbuser + ";Password=" + dbpassword;
            SqlConnection connection = new SqlConnection(connecturl);//打开数据库

            string tableName ="UFSystem..UA_Account";//给tableName赋值为总表的名称
            string sql = "select iSysID,cAcc_Id,cAcc_Name,iYear from "+ tableName +"";//账套总表

            SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, connection);//创建一个填充DataSet的数据库连接
            DataSet myDataSet = new DataSet();//创建一个缓存

            try
            {
                myDataAdapter.Fill(myDataSet, tableName);
                DataTable myDataTable = myDataSet.Tables[tableName];//把tableName赋值到创建的一个新表
                if(myDataTable.Rows.Count > 0)//如果表的行数>0,即表示有数据
                {
                    foreach(DataRow row in myDataTable.Rows)//循环新表里取值
                    {
                        YYT3accset accset = new YYT3accset();

                        accset.ISysId = row[myDataTable.Columns["iSysId"]].ToString();//账套配置ISysID封装字段赋值
                        accset.CAcc_Id = row[myDataTable.Columns["cAcc_Id"]].ToString();//账套配置CAcc_Id封装字段赋值
                        accset.CAcc_Name = row[myDataTable.Columns["cAcc_Name"]].ToString();//账套配置CAcc_Name封装字段赋值
                        accset.IYear = row[myDataTable.Columns["iYear"]].ToString();//账套配置IYear封装字段赋值
                        accset.DbName = dbprefix + accset.CAcc_Id+"_"+accset.IYear;//账套配置DbName封装字段赋值
                        accset.DbHost = dbip;//账套配置DbHost封装字段赋值
                        accset.DbPassword = dbpassword;
                        accset.DbUser = dbuser;
                        accsetList.Add(accset);
                         
                    }
                }
                return accsetList;
            }
            finally
            {
                myDataSet.Dispose();
                myDataAdapter.Dispose();
                connection.Close();
            }
        }
        //
        //选择账套的方法end
        //
        //测试连接的方法start
        //
        public void connectTest(YYT3accset accset)
        {
            SqlConnection connection = this.createConnection(accset);//引用数据库打开的方法赋值到一个新的数据库打开方法
            string sql = "select max(i_id) as i_id from GL_accvouch where 1=2 ";//创建sql语句
            SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, connection);//把sql语句和connection数据库打开方法赋值到一个数据库连接
            DataSet myDataSet = new DataSet();//创建一个新的缓存
            try
            {
                myDataAdapter.Fill(myDataSet, "GL_accvouch");//在DataSet中添加数据源
                DataTable myTable = myDataSet.Tables["GL_accvouch"];//创建一个新表
                string i_id = myTable.Rows[0][myTable.Columns["i_id"]].ToString();//声明一个变量把表的(第一行row[0][i_id]列)赋值到i_id
            } 
            finally
            {
                myDataSet.Dispose();
                myDataAdapter.Dispose();
                connection.Close();//关闭数据库
            }
        }
        //
        //测试连接的方法end
        //
        //
        //
        public void exportSubject(ExportBean exportBean,YYT3accset accset)
        {
            T3ExportSd3000Context context = new T3ExportSd3000Context();
            //context.ExportBean = exportBean;

            //try
            //{
            //    ClientSubjectFactory csf = new ClientSubjectFactory();
            //    context.ClientSubjects = csf.query(exportBean.Clientid,1,1);

            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.StackTrace);
            //    throw e;
            //}
               
        }
    }
}