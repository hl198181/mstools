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
    //科目表start
    //
    class YYT3code
    {
        //SET SET IDENTITY_INSERT[dbo].[code]   ON    //开启插入功能
        //SET SET IDENTITY_INSERT[dbo].[code]   OFF   //关闭插入功能
        private int _i_id;//id
        private string _cclass;//取上级，资产、负债、损益
        private string _cclass_engl;//取上级，（资产、负债、损益）的简称
        private string _ccode;//科目代码
        private string _ccode_name;//科目名称
        private string _ccode_engl;//科目名称eng
        private int _igrade;//去科目长度表，科目级别
        private int _bproperty;//取上级，借贷方向（1是借，0是贷）
        private string _cbook_type;//金额式，数量金额式，外币金额式
        private string _cbook_type_engl;//JES,SLJES,WBJES
        private int _bend;//1
        private int _bd_c;//1

        public int I_id
        {
            get
            {
                return _i_id;
            }

            set
            {
                _i_id = value;
            }
        }

        public string Cclass
        {
            get
            {
                return _cclass;
            }

            set
            {
                _cclass = value;
            }
        }

        public string Cclass_engl
        {
            get
            {
                return _cclass_engl;
            }

            set
            {
                _cclass_engl = value;
            }
        }

        public string Ccode
        {
            get
            {
                return _ccode;
            }

            set
            {
                _ccode = value;
            }
        }

        public string Ccode_name
        {
            get
            {
                return _ccode_name;
            }

            set
            {
                _ccode_name = value;
            }
        }

        public string Ccode_engl
        {
            get
            {
                return _ccode_engl;
            }

            set
            {
                _ccode_engl = value;
            }
        }

        public int Igrade
        {
            get
            {
                return _igrade;
            }

            set
            {
                _igrade = value;
            }
        }

        public int Bproperty
        {
            get
            {
                return _bproperty;
            }

            set
            {
                _bproperty = value;
            }
        }

        public string Cbook_type
        {
            get
            {
                return _cbook_type;
            }

            set
            {
                _cbook_type = value;
            }
        }

        public string Cbook_type_engl
        {
            get
            {
                return _cbook_type_engl;
            }

            set
            {
                _cbook_type_engl = value;
            }
        }

        public int Bend
        {
            get
            {
                return _bend;
            }

            set
            {
                _bend = value;
            }
        }

        public int Bd_c
        {
            get
            {
                return _bd_c;
            }

            set
            {
                _bd_c = value;
            }
        }
    }
    //
    //科目表end
    //
    //核算客户表start
    //
    class YYT3Customer
    {
        private int _cCusCode;//id
        private string _cCusName;//客户名称
        private string _cCusAbbName;//客户名称
        private string _cCCCode;//01
        private DateTime _dCusDevDate;//创建日期
        private string _cCusHeadCode;//id
        private int _iCostGrade;//-1
        public string CCusName
        {
            get
            {
                return _cCusName;
            }

            set
            {
                _cCusName = value;
            }
        }

        public string CCusAbbName
        {
            get
            {
                return _cCusAbbName;
            }

            set
            {
                _cCusAbbName = value;
            }
        }

        public string CCCCode
        {
            get
            {
                return _cCCCode;
            }

            set
            {
                _cCCCode = value;
            }
        }

        public DateTime DCusDevDate
        {
            get
            {
                return _dCusDevDate;
            }

            set
            {
                _dCusDevDate = value;
            }
        }

        public string CCusHeadCode
        {
            get
            {
                return _cCusHeadCode;
            }

            set
            {
                _cCusHeadCode = value;
            }
        }

        public int ICostGrade
        {
            get
            {
                return _iCostGrade;
            }

            set
            {
                _iCostGrade = value;
            }
        }

        public int CCusCode
        {
            get
            {
                return _cCusCode;
            }

            set
            {
                _cCusCode = value;
            }
        }
    }
    //
    //核算客户表end
    //
    //核算供应商表start
    //
    class YYT3Vendor
    {
        private int _cVenCode;//id
        private string _cVenName;//供应商名称
        private string _cVenAbbName;//供应商名称
        private string _cVCCode;//01
        private DateTime _dVenDevDate;//创建时间
        private string _cVenHeadCode;//id
        private int _bVenTax;//1
        private int _bisFeeVen;//0

        public int CVenCode
        {
            get
            {
                return _cVenCode;
            }

            set
            {
                _cVenCode = value;
            }
        }

        public string CVenName
        {
            get
            {
                return _cVenName;
            }

            set
            {
                _cVenName = value;
            }
        }

        public string CVenAbbName
        {
            get
            {
                return _cVenAbbName;
            }

            set
            {
                _cVenAbbName = value;
            }
        }

        public string CVCCode
        {
            get
            {
                return _cVCCode;
            }

            set
            {
                _cVCCode = value;
            }
        }

        public DateTime DVenDevDate
        {
            get
            {
                return _dVenDevDate;
            }

            set
            {
                _dVenDevDate = value;
            }
        }

        public string CVenHeadCode
        {
            get
            {
                return _cVenHeadCode;
            }

            set
            {
                _cVenHeadCode = value;
            }
        }

        public int BVenTax
        {
            get
            {
                return _bVenTax;
            }

            set
            {
                _bVenTax = value;
            }
        }

        public int BisFeeVen
        {
            get
            {
                return _bisFeeVen;
            }

            set
            {
                _bisFeeVen = value;
            }
        }
    }
    //
    //核算供应商表end
    //
    //科目编码级次表start
    //
    class YYT3AccInformation
    {
        private string _cSysID;//AA
        private string _cID;//08
        private string _cName;//cGradeLevel
        private string _cCaption;//科目编码级次
        private string _cType;//Text
        private string _cValue;//4，2，2，2，2
        private string _cDefault;//4，2，2，2，
        private int _bVisible;//0
        private int _bEnable;//0

        public string CSysID
        {
            get
            {
                return _cSysID;
            }

            set
            {
                _cSysID = value;
            }
        }

        public string CID
        {
            get
            {
                return _cID;
            }

            set
            {
                _cID = value;
            }
        }

        public string CName
        {
            get
            {
                return _cName;
            }

            set
            {
                _cName = value;
            }
        }

        public string CCaption
        {
            get
            {
                return _cCaption;
            }

            set
            {
                _cCaption = value;
            }
        }

        public string CType
        {
            get
            {
                return _cType;
            }

            set
            {
                _cType = value;
            }
        }

        public string CValue
        {
            get
            {
                return _cValue;
            }

            set
            {
                _cValue = value;
            }
        }

        public string CDefault
        {
            get
            {
                return _cDefault;
            }

            set
            {
                _cDefault = value;
            }
        }

        public int BVisible
        {
            get
            {
                return _bVisible;
            }

            set
            {
                _bVisible = value;
            }
        }

        public int BEnable
        {
            get
            {
                return _bEnable;
            }

            set
            {
                _bEnable = value;
            }
        }
    }
    //
    //科目编码级次表end
    //
    class T3ExportSd3000Context
    {
        private ExportBean _exportBean;

        private List<YYT3code> _subjects;//科目表

        private Dictionary<string, YYT3AccInformation> _accoptionsDict;//科目长度级次表

        private List<ClientSubject> _clientSubjects;//小微服数据库的科目表

        private int _maxSubid;

        private List<string> _sqls = new List<string>();

        internal ExportBean ExportBean
        {
            get
            {
                return _exportBean;
            }

            set
            {
                _exportBean = value;
            }
        }

        internal List<YYT3code> Subjects
        {
            get
            {
                return _subjects;
            }

            set
            {
                _subjects = value;
            }
        }

        internal Dictionary<string, YYT3AccInformation> AccoptionsDict
        {
            get
            {
                return _accoptionsDict;
            }

            set
            {
                _accoptionsDict = value;
            }
        }

        internal List<ClientSubject> ClientSubjects
        {
            get
            {
                return _clientSubjects;
            }

            set
            {
                _clientSubjects = value;
            }
        }

        public int MaxSubid
        {
            get
            {
                return _maxSubid;
            }

            set
            {
                _maxSubid = value;
            }
        }

        public List<string> Sqls
        {
            get
            {
                return _sqls;
            }

            set
            {
                _sqls = value;
            }
        }
    } 

    class YYT3Factory
    {
        //
        //获取帐套信息表start
        //
        public void getaccst(YYT3accset accset)
        {
            SqlConnection connection = this.createConnection(accset);
            string sql = "select * from accst";
            SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, connection);
            DataSet myDataSet = new DataSet();      // 创建DataSet
            List<YYT3accset> yYT3accsetList = new List<YYT3accset>();
            try
            {
                myDataAdapter.Fill(myDataSet, "accst");
                DataTable myTable = myDataSet.Tables["accst"];

                if (myTable.Rows.Count > 0)
                {
                    foreach (DataRow row in myTable.Rows)
                    {
                        YYT3accset yYT3accset = new YYT3accset();

                    }    
                }
            }
            finally
            {
                myDataSet.Dispose();
                myDataAdapter.Dispose();
                connection.Close();
            }
        }
        //
        //获取帐套信息表end
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
        //科目表导入新科目start
        //
        public void exportSubject(ExportBean exportBean,YYT3accset accset)
        {
            T3ExportSd3000Context context = new T3ExportSd3000Context();
            context.ExportBean = exportBean;
            try
            {
                ClientSubjectFactory csf = new ClientSubjectFactory();
                context.ClientSubjects = csf.query(exportBean.Clientid, 1, 1);
                //context.AccoptionsDict = this.queryAccoptions(accset);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw e;
            }

        }
        //
        //科目表导入新科目end
        //
        //
        //
    }
}