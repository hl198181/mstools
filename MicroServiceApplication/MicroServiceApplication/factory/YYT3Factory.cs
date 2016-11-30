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
using System.Data.OleDb;

namespace MicroServiceApplication.factory
{
    //
    //获取凭证start
    //
    class YYT3Voucher
    {
        private List<YYT3Voucher> _items;

        public YYT3Voucher(JObject jobject)
        {
            if (jobject == null) return;

            if (jobject["items"] != null)
            {
                this.Items = new List<YYT3Voucher>();
                foreach (JObject item in jobject["items"])
                {
                    var detail = new YYT3Voucher(item);
                    this.Items.Add(detail);
                }
            }
        }

        internal List<YYT3Voucher> Items
        {
            get
            {
                return _items;
            }

            set
            {
                _items = value;
            }
        }
    }
    //
    //获取凭证end
    //
    //凭证封装字段start
    //
    class YYT3VoucherItem
    {
        private string _id;
        private string _instid;
        private string _clientid;
        private string _accountcyclesn;
        private string _bizaccountcyclesn;
        private string _libraryid;
        private string _libraryitemid;
        private string _inputtype;
        private string _bizid;
        private string _biztype;
        private DateTime _bizdate;
        private string _summary;
        private string _descr;
        private string _subjectno;
        private string _subjectname;
        private string _subjectno1;
        private string _subjectname1;
        private string _subjectno2;
        private string _subjectname2;
        private string _subjectno3;
        private string _subjectname3;
        private string _subjectno4;
        private string _subjectname4;
        private string _subjectno5;
        private string _subjectname5;
        private string _subjectno6;
        private string _subjectname6;
        private string _debitcredit;
        private decimal _debit;
        private decimal _credit;
        private int _sort;
        private int _disabled;
        private DateTime _createdate;
        private string _createby;
        private string _createbyname;
        private string _librarylabel;
        private string _libraryname;
        private string _categoryname;
        private string _categorylabel;
        private string _groupname;
        private string __createbyheadimgurl;
        private int _voucherNum;
        private int _warn;
        private string _warntext;
        private string _remark;

        public string Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Instid
        {
            get
            {
                return _instid;
            }

            set
            {
                _instid = value;
            }
        }

        public string Clientid
        {
            get
            {
                return _clientid;
            }

            set
            {
                _clientid = value;
            }
        }

        public string Accountcyclesn
        {
            get
            {
                return _accountcyclesn;
            }

            set
            {
                _accountcyclesn = value;
            }
        }

        public string Bizaccountcyclesn
        {
            get
            {
                return _bizaccountcyclesn;
            }

            set
            {
                _bizaccountcyclesn = value;
            }
        }

        public string Libraryid
        {
            get
            {
                return _libraryid;
            }

            set
            {
                _libraryid = value;
            }
        }

        public string Libraryitemid
        {
            get
            {
                return _libraryitemid;
            }

            set
            {
                _libraryitemid = value;
            }
        }

        public string Inputtype
        {
            get
            {
                return _inputtype;
            }

            set
            {
                _inputtype = value;
            }
        }

        public string Bizid
        {
            get
            {
                return _bizid;
            }

            set
            {
                _bizid = value;
            }
        }

        public string Biztype
        {
            get
            {
                return _biztype;
            }

            set
            {
                _biztype = value;
            }
        }

        public DateTime Bizdate
        {
            get
            {
                return _bizdate;
            }

            set
            {
                _bizdate = value;
            }
        }

        public string Summary
        {
            get
            {
                return _summary;
            }

            set
            {
                _summary = value;
            }
        }

        public string Descr
        {
            get
            {
                return _descr;
            }

            set
            {
                _descr = value;
            }
        }

        public string Subjectno
        {
            get
            {
                return _subjectno;
            }

            set
            {
                _subjectno = value;
            }
        }

        public string Subjectname
        {
            get
            {
                return _subjectname;
            }

            set
            {
                _subjectname = value;
            }
        }

        public string Subjectno1
        {
            get
            {
                return _subjectno1;
            }

            set
            {
                _subjectno1 = value;
            }
        }

        public string Subjectname1
        {
            get
            {
                return _subjectname1;
            }

            set
            {
                _subjectname1 = value;
            }
        }

        public string Subjectno2
        {
            get
            {
                return _subjectno2;
            }

            set
            {
                _subjectno2 = value;
            }
        }

        public string Subjectname2
        {
            get
            {
                return _subjectname2;
            }

            set
            {
                _subjectname2 = value;
            }
        }

        public string Subjectno3
        {
            get
            {
                return _subjectno3;
            }

            set
            {
                _subjectno3 = value;
            }
        }

        public string Subjectname3
        {
            get
            {
                return _subjectname3;
            }

            set
            {
                _subjectname3 = value;
            }
        }

        public string Subjectno4
        {
            get
            {
                return _subjectno4;
            }

            set
            {
                _subjectno4 = value;
            }
        }

        public string Subjectname4
        {
            get
            {
                return _subjectname4;
            }

            set
            {
                _subjectname4 = value;
            }
        }

        public string Subjectno5
        {
            get
            {
                return _subjectno5;
            }

            set
            {
                _subjectno5 = value;
            }
        }

        public string Subjectname5
        {
            get
            {
                return _subjectname5;
            }

            set
            {
                _subjectname5 = value;
            }
        }

        public string Subjectno6
        {
            get
            {
                return _subjectno6;
            }

            set
            {
                _subjectno6 = value;
            }
        }

        public string Subjectname6
        {
            get
            {
                return _subjectname6;
            }

            set
            {
                _subjectname6 = value;
            }
        }

        public string Debitcredit
        {
            get
            {
                return _debitcredit;
            }

            set
            {
                _debitcredit = value;
            }
        }

        public decimal Debit
        {
            get
            {
                return _debit;
            }

            set
            {
                _debit = value;
            }
        }

        public decimal Credit
        {
            get
            {
                return _credit;
            }

            set
            {
                _credit = value;
            }
        }

        public int Sort
        {
            get
            {
                return _sort;
            }

            set
            {
                _sort = value;
            }
        }

        public int Disabled
        {
            get
            {
                return _disabled;
            }

            set
            {
                _disabled = value;
            }
        }

        public DateTime Createdate
        {
            get
            {
                return _createdate;
            }

            set
            {
                _createdate = value;
            }
        }

        public string Createby
        {
            get
            {
                return _createby;
            }

            set
            {
                _createby = value;
            }
        }

        public string Createbyname
        {
            get
            {
                return _createbyname;
            }

            set
            {
                _createbyname = value;
            }
        }

        public string Librarylabel
        {
            get
            {
                return _librarylabel;
            }

            set
            {
                _librarylabel = value;
            }
        }

        public string Libraryname
        {
            get
            {
                return _libraryname;
            }

            set
            {
                _libraryname = value;
            }
        }

        public string Categoryname
        {
            get
            {
                return _categoryname;
            }

            set
            {
                _categoryname = value;
            }
        }

        public string Categorylabel
        {
            get
            {
                return _categorylabel;
            }

            set
            {
                _categorylabel = value;
            }
        }

        public string Groupname
        {
            get
            {
                return _groupname;
            }

            set
            {
                _groupname = value;
            }
        }

        public string Createbyheadimgurl
        {
            get
            {
                return __createbyheadimgurl;
            }

            set
            {
                __createbyheadimgurl = value;
            }
        }

        public int VoucherNum
        {
            get
            {
                return _voucherNum;
            }

            set
            {
                _voucherNum = value;
            }
        }

        public int Warn
        {
            get
            {
                return _warn;
            }

            set
            {
                _warn = value;
            }
        }

        public string Warntext
        {
            get
            {
                return _warntext;
            }

            set
            {
                _warntext = value;
            }
        }

        public string Remark
        {
            get
            {
                return _remark;
            }

            set
            {
                _remark = value;
            }
        }
    }
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
        private int _igrade;//取科目长度表，科目级别
        private string _bproperty;//取上级，借贷方向（1是借，0是贷）
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

        public string Bproperty
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
    class YYT3ExportContext
    {
        private ExportBean _exportBean;

        private List<YYT3Voucher> _vouchers;//凭证

        private Dictionary<string, YYT3AccInformation> _accInformation;//科目长度级次表

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

        internal Dictionary<string, YYT3AccInformation> AccInformation
        {
            get
            {
                return _accInformation;
            }

            set
            {
                _accInformation = value;
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

        internal List<YYT3Voucher> Vouchers
        {
            get
            {
                return _vouchers;
            }

            set
            {
                _vouchers = value;
            }
        }
    } 

    class YYT3Factory
    {
        public OleDbConnection Conn;
        public bool ExecuteSQLNonquery(List<String> sqls)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = Conn;
            OleDbTransaction tx = Conn.BeginTransaction();
            cmd.Transaction = tx;
            try
            {
                for (int n = 0; n < sqls.Count; n++)
                {
                    string strsql = sqls[n].ToString();
                    if (strsql.Trim().Length > 1)
                    {
                        cmd.CommandText = strsql;
                        cmd.ExecuteNonQuery();
                    }
                }
                tx.Commit();
                return true;
            }
            catch (Exception e)
            {
                tx.Rollback();
                throw e;
            }
        }
        //
        //获取帐套科目表start
        //
        public List<YYT3code> getcode(YYT3accset accset)
        {
            SqlConnection connection = this.createConnection(accset);
            string sql = "select * from code ";
            SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, connection);
            DataSet myDataSet = new DataSet();      // 创建DataSet
            List<YYT3code> YYT3codeList = new List<YYT3code>();
            try
            {
                myDataAdapter.Fill(myDataSet, "code");
                DataTable myTable = myDataSet.Tables["code"];

                if (myTable.Rows.Count > 0)
                {
                    foreach (DataRow row in myTable.Rows)
                    {
                        YYT3code yYT3code = new YYT3code();
                        yYT3code.I_id = Int32.Parse(row[myTable.Columns["i_id"]].ToString());
                        yYT3code.Cclass = row[myTable.Columns["cclass"]].ToString();
                        yYT3code.Cclass_engl = row[myTable.Columns["cclass_engl"]].ToString();
                        yYT3code.Ccode = row[myTable.Columns["ccode"]].ToString();
                        yYT3code.Ccode_engl = row[myTable.Columns["ccode_engl"]].ToString();
                        yYT3code.Ccode_name = row[myTable.Columns["ccode_name"]].ToString();
                        yYT3code.Igrade = Int32.Parse(row[myTable.Columns["igrade"]].ToString());
                        yYT3code.Bproperty = (row[myTable.Columns["bproperty"]].ToString() == "False" ? "cr" : "de").ToString();
                        yYT3code.Cbook_type = row[myTable.Columns["cbook_type"]].ToString();
                        yYT3code.Cbook_type_engl = row[myTable.Columns["cbook_type_engl"]].ToString();
                        yYT3code.Bend = Int32.Parse(row[myTable.Columns["bend"]].ToString() == "false"? "0" :"1");
                        yYT3code.Bd_c = Int32.Parse(row[myTable.Columns["bd_c"]].ToString() == "false"? "0" :"1"); 
                        YYT3codeList.Add(yYT3code);
                    }                    
                }
                return YYT3codeList;
            }
            finally
            {
                myDataSet.Dispose();
                myDataAdapter.Dispose();
                connection.Close();
            }
        }
        //
        //获取帐套科目表end
        //
        //获取会计科目最大序号start
        //
        public int getmaxid(YYT3accset accset)
        {
            SqlConnection connection = this.createConnection(accset);
            string sql = "select max(i_id) as maxid from code ";
            SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, connection);
            DataSet myDataSet = new DataSet();
                       
            try
            {
                int maxi_id = 0;
                myDataAdapter.Fill(myDataSet, "code");
                DataTable myTable = myDataSet.Tables["code"];
                if (myTable.Rows.Count>0)
                {
                    maxi_id = Int32.Parse(myTable.Rows[0][myTable.Columns[0]].ToString());
                }
                else
                {
                    maxi_id = 0;
                }
                return maxi_id;
             }
            finally
            {
                myDataSet.Dispose();
                myDataAdapter.Dispose();
                connection.Close();
            }
        }
        //
        //获取会计科目最大序号end
        //
        //获取上一级会计科目信息start
        //
        public YYT3code getlastcode(YYT3accset accset , String ccode)
        {
            SqlConnection connection = this.createConnection(accset);
            string sql = "select * from code where ccode = "+ccode+"";
            SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, connection);
            DataSet myDataSet = new DataSet();
            YYT3code yYT3code = null;
            try
            {
                myDataAdapter.Fill(myDataSet, "ccode");
                DataTable myTable = myDataSet.Tables["ccode"];
                if (myTable.Columns.Count>0)
                {
                    DataRow row = myTable.Rows[0];
                    yYT3code = new YYT3code();
                    yYT3code.Cclass = row["cclass"] == null ? null : row["cclass"].ToString();
                    yYT3code.Cclass_engl = row["cclass_engl"] == null ? null : row["cclass_engl"].ToString();
                    yYT3code.Bproperty = row["bproperty"] == null ? null : row["bproperty"].ToString();
                    yYT3code.Cbook_type = row["cbook_type"] == null ? null : row["cbook_type"].ToString();
                    yYT3code.Cbook_type_engl = row["cbook_type_engl"] == null ? null : row["cbook_type_engl"].ToString();
                }
                return yYT3code;
            }
            finally
            {
                myDataSet.Dispose();
                myDataAdapter.Dispose();
                connection.Close();
            }
        }
        //
        //获取上一级会计科目信息end
        //
        //获取账套科目长度表start
        //
        public YYT3AccInformation getAccInformation(YYT3accset accset)
        {
            SqlConnection connection = this.createConnection(accset);
            string cCaption = "科目编码级次";
            string cName = "cGradeLevel";
            string sql = "select * from AccInformation where cName = '"+cName+"' and cCaption = '"+ cCaption + "'";
            SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, connection);
            DataSet myDataSet = new DataSet();      // 创建DataSet
            List<YYT3AccInformation> yYT3AccInformationList = new List<YYT3AccInformation>();
            try
            {
                myDataAdapter.Fill(myDataSet, "AccInformation");
                DataTable myTable = myDataSet.Tables["AccInformation"];
                if (myTable.Rows.Count > 0)
                {
                    foreach (DataRow row in myTable.Rows)
                    {
                        YYT3AccInformation yYT3AccInformation = new YYT3AccInformation();
                        yYT3AccInformation.CValue = row[myTable.Columns["cValue"]].ToString();
                        yYT3AccInformationList.Add(yYT3AccInformation);
                    }
                }             
            }
            finally
            {
                myDataSet.Dispose();
                myDataAdapter.Dispose();
                connection.Close();
            }
            if (yYT3AccInformationList.Count > 0)
            {
                return yYT3AccInformationList[0];
            }
            else
            {
                return null;
            }
        }
        //
        //获取账套科目长度表end
        //
        //获取核算客户表start
        //
        public List<YYT3Customer> getCustomer(YYT3accset accset)
        {
            SqlConnection connection = this.createConnection(accset);
            string sql = "select * from Customer";
            SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, connection);
            DataSet myDataSet = new DataSet();      // 创建DataSet
            List<YYT3Customer> yYT3CustomerList = new List<YYT3Customer>();
            try
            {
                myDataAdapter.Fill(myDataSet, "Customer");
                DataTable myTable = myDataSet.Tables["Customer"];
                if (myTable.Rows.Count > 0)
                    foreach (DataRow row in myTable.Rows)
                    {
                        YYT3Customer yYT3Customer = new YYT3Customer();
                        yYT3Customer.CCusCode = Int32.Parse(row[myTable.Columns["cCusCode"]].ToString());
                        yYT3Customer.CCusName = row[myTable.Columns["cCusName"]].ToString();
                        yYT3Customer.CCusAbbName = row[myTable.Columns["cCusAbbName"]].ToString();
                        yYT3Customer.CCCCode = row[myTable.Columns["cCCCode"]].ToString();
                        yYT3Customer.CCusHeadCode = row[myTable.Columns["cCusHeadCode"]].ToString();
                        yYT3Customer.ICostGrade = Int32.Parse(row[myTable.Columns["iCostGrade"]].ToString());
                        yYT3CustomerList.Add(yYT3Customer);
                    }
                return yYT3CustomerList;
            }
            finally
            {
                myDataSet.Dispose();
                myDataAdapter.Dispose();
                connection.Close();
            }

        }
        //
        //获取核算客户表end
        //
        //获取可算供应商表start
        //
        public List<YYT3Vendor> getVendor(YYT3accset accset)
        {
            SqlConnection connection = this.createConnection(accset);
            string sql = "select * from Customer";
            SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, connection);
            DataSet myDataSet = new DataSet();      // 创建DataSet
            List<YYT3Vendor> yYT3VendorList = new List<YYT3Vendor>();
            try
            {
                myDataAdapter.Fill(myDataSet, "Vendor");
                DataTable myTable = myDataSet.Tables["Vendor"];
                if (myTable.Rows.Count > 0)
                    foreach (DataRow row in myTable.Rows)
                    {
                        YYT3Vendor yYT3Vendor = new YYT3Vendor();
                        yYT3Vendor.CVenCode = Int32.Parse(row[myTable.Columns["cVenCode"]].ToString());
                        yYT3Vendor.CVenName = row[myTable.Columns["cVenName"]].ToString();
                        yYT3Vendor.CVenAbbName = row[myTable.Columns["cVenAbbName"]].ToString();
                        yYT3Vendor.CVCCode = row[myTable.Columns["cVCCode"]].ToString();
                        yYT3Vendor.BisFeeVen = Int32.Parse(row[myTable.Columns["bisFeeVen"]].ToString());
                        yYT3Vendor.BVenTax = Int32.Parse(row[myTable.Columns["bVenTax"]].ToString());
                        yYT3Vendor.CVenHeadCode = row[myTable.Columns["cVenHeadCode"]].ToString();
                        yYT3VendorList.Add(yYT3Vendor);
                    }
                return yYT3VendorList;
            }
            finally
            {
                myDataSet.Dispose();
                myDataAdapter.Dispose();
                connection.Close();
            }
        }
        //
        //获取可算供应商表end
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
            YYT3AccInformation yYT3AccInformation = this.getAccInformation(accset);
            YYT3ExportContext context = new YYT3ExportContext();
            context.ExportBean = exportBean;
            try
            {
                ClientSubjectFactory csf = new ClientSubjectFactory();
                List<ClientSubject> clientSubjectList = csf.query(exportBean.Clientid, 1, 1);
                List<string> sqls = new List<string>();
                int maxid = this.getmaxid(accset);
                foreach (ClientSubject item in clientSubjectList)
                {
                    maxid++;
                    String leve1Subject = item.Sn.Substring(0, Int32.Parse(yYT3AccInformation.CValue.Substring(0,1)));//获取上级科目信息
                    YYT3code yYT3code = this.getlastcode( accset,leve1Subject);
                    int igrade = 1;
                    
                    if (Int32.Parse(yYT3AccInformation.CValue.Substring(0, 1)) == item.Sn.Length && yYT3AccInformation.CValue.Length >0)
                    {
                        igrade = 1;
                    }
                    if(Int32.Parse(yYT3AccInformation.CValue.Substring(2, 1)) == item.Sn.Length- Int32.Parse(yYT3AccInformation.CValue.Substring(0, 1)) && yYT3AccInformation.CValue.Length > 2)
                    {
                        igrade = 2;
                    }
                    if (Int32.Parse(yYT3AccInformation.CValue.Substring(4, 1)) == item.Sn.Length- Int32.Parse(yYT3AccInformation.CValue.Substring(2, 1)) && yYT3AccInformation.CValue.Length > 4)
                    {
                        igrade = 3;
                    }
                    if (Int32.Parse(yYT3AccInformation.CValue.Substring(6, 1)) == item.Sn.Length- Int32.Parse(yYT3AccInformation.CValue.Substring(4, 1)) && yYT3AccInformation.CValue.Length > 6)
                    {
                        igrade = 4;
                    }
                    if (Int32.Parse(yYT3AccInformation.CValue.Substring(8, 1)) == item.Sn.Length- Int32.Parse(yYT3AccInformation.CValue.Substring(6, 1)) && yYT3AccInformation.CValue.Length > 8)
                    {
                        igrade = 5;
                    }
                    if (Int32.Parse(yYT3AccInformation.CValue.Substring(10, 1)) == item.Sn.Length- Int32.Parse(yYT3AccInformation.CValue.Substring(8, 1)) && yYT3AccInformation.CValue.Length > 10)
                    {
                        igrade = 6;
                    }
                    if (Int32.Parse(yYT3AccInformation.CValue.Substring(12, 1)) == item.Sn.Length- Int32.Parse(yYT3AccInformation.CValue.Substring(10, 1)) && yYT3AccInformation.CValue.Length > 12)
                    {
                        igrade = 7;
                    }
                    if (Int32.Parse(yYT3AccInformation.CValue.Substring(14, 1)) == item.Sn.Length- Int32.Parse(yYT3AccInformation.CValue.Substring(12, 1)) && yYT3AccInformation.CValue.Length > 14)
                    {
                        igrade = 8;
                    }
                    if (Int32.Parse(yYT3AccInformation.CValue.Substring(16, 1)) == item.Sn.Length- Int32.Parse(yYT3AccInformation.CValue.Substring(14, 1)) && yYT3AccInformation.CValue.Length > 16)
                    {
                        igrade = 9;
                    }
                    if (Int32.Parse(yYT3AccInformation.CValue.Substring(18, 1)) == item.Sn.Length- Int32.Parse(yYT3AccInformation.CValue.Substring(16, 1)) && yYT3AccInformation.CValue.Length > 18)
                    {
                        igrade = 10;
                    }
                    List <YYT3code> yYT3codeList = new List<YYT3code>();
                    yYT3code.Ccode = item.Sn;
                    yYT3code.Ccode_name = item.Label;
                    
                    sqls.Add("SET SET IDENTITY_INSERT[dbo].[code]   ON");
                    sqls.Add("insert into [dbo].[code] (i_id,cclass,cclass_endl,ccode,ccode_name,ccode_endl,igrade,bproperty,cbook_type,cbook_type_engl,_bend,Bd_c) values (" + maxid + ","+ yYT3code.Cclass+","+yYT3code.Cclass_engl+", "+ yYT3code.Ccode + "," + yYT3code.Ccode_name + "," + yYT3code.Ccode_name + "+ 'engl',"+ igrade + ","+ yYT3code.Bproperty+",‘金额式’，‘JES’，1,1) ");

                }
                sqls.Add("SET SET IDENTITY_INSERT[dbo].[code]   OFF");
                SqlConnection connection = this.createConnection(accset);
                this.ExecuteSQLNonquery(sqls);
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
        //初始化start
        //
        public void initSubjectByYYT3(YYT3accset accset, Client client, User user)
        {
            if (client == null) throw new ArgumentException("请选择客户信息！");
            if (user == null) throw new ArgumentException("用户信息必须输入！");
            if (accset == null) throw new ArgumentException("请选择账套信息！");
            if (client.Id == null) throw new ArgumentException("客户信息必须输入！");
            
            //查询客户账套科目长度配置，并同步
            YYT3AccInformation yYT3AccInformation = this.getAccInformation(accset);

            ClientSubjectLength csl = new ClientSubjectLength();
            int number = yYT3AccInformation.CValue.Length;
            if (number > 0)
            {
                csl.Subject1 = int.Parse(yYT3AccInformation.CValue.Substring(0, 1));
            }
            else
            {
                csl.Subject1 = 0;
            }
            if (number > 2)
            {
                csl.Subject2 = int.Parse(yYT3AccInformation.CValue.Substring(2, 1));
            }
            else
            {
                csl.Subject2 = 0;
            }
            if (number > 4)
            {
                csl.Subject3 = int.Parse(yYT3AccInformation.CValue.Substring(4, 1));
            }
            else
            {
                csl.Subject3 = 0;
            }
            if (number > 6)
            {
                csl.Subject4 = int.Parse(yYT3AccInformation.CValue.Substring(6, 1));
            }
            else
            {
                csl.Subject4 = 0;
            }
            if (number > 8)
            {
                csl.Subject5 = int.Parse(yYT3AccInformation.CValue.Substring(8, 1));
            }
            else
            {
                csl.Subject5 = 0;
            }
            if (number > 10)
            {
                csl.Subject6 = int.Parse(yYT3AccInformation.CValue.Substring(10, 1));
            }
            else
            {
                csl.Subject6 = 0;
            }
            if (number > 12)
            {
                csl.Subject7 = int.Parse(yYT3AccInformation.CValue.Substring(12, 1));
            }
            else
            {
                csl.Subject7 = 0;
            }
            if (number > 14)
            {
                csl.Subject8 = int.Parse(yYT3AccInformation.CValue.Substring(14, 1));
            }
            else
            {
                csl.Subject8 = 0;
            }
            if (number > 16)
            {
                csl.Subject9 = int.Parse(yYT3AccInformation.CValue.Substring(16, 1));
            }
            else
            {
                csl.Subject9 = 0;
            }
            if (number > 18)
            {
                csl.Subject10 = int.Parse(yYT3AccInformation.CValue.Substring(18, 1));
            }
            else
            {
                csl.Subject10 = 0;
            }
            csl.Clientid = client.Id;
            csl.Createby = user.Id;
            ClientSubjectLengthFactory cslf = new ClientSubjectLengthFactory();
            cslf.add(csl);//写入科目长度表
            //清理现有科目
            ClientSubjectFactory csf = new ClientSubjectFactory();
            csf.clean(client.Id);
            //查询客户账套科目
            List<YYT3code> yYT3codeList = this.getcode(accset);

            if (yYT3codeList == null || yYT3codeList.Count <= 0)
            {
                throw new Exception("无法从速达读取科目信息！");
            }
            //写入科目
            foreach (YYT3code item in yYT3codeList)
            {
                ClientSubject subject = new ClientSubject();
                subject.Sn = item.Ccode;
                subject.Label = item.Ccode_name;
                subject.Fullname = item.Ccode_name;
                subject.Debitcredit = item.Bproperty;
                csf.add(subject, client, user);
            }
        }
        //
        //初始化end
        //
        //凭证导入start
        //
        public void exports(ExportBean exportBean, YYT3accset accset)
        {

            YYT3ExportContext context = new YYT3ExportContext();
            context.ExportBean = exportBean;

            try
            {
                //查询凭证数据
                this.getData(context);

                //获取当前Credid
                //this.getCredid(context, accset);
                //this.getCredcode(context, accset);
                //this.getCredno(context, accset);
                //this.execute(context, accset);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw e;
            }
            finally
            {
            }
        }
        //获取凭证
        private void getData(YYT3ExportContext context)
        {
            HttpClient httpClient = AppConfig.GetInstance().crateHttpClient();
            String url = AppConfig.GetInstance().BaseUrl + "/voucher/instance/exports";

            List<KeyValuePair<String, String>> paramList = new List<KeyValuePair<String, String>>();
            paramList.Add(new KeyValuePair<string, string>("instid", context.ExportBean.Instid));
            paramList.Add(new KeyValuePair<string, string>("clientid", context.ExportBean.Clientid));
            paramList.Add(new KeyValuePair<string, string>("accountcyclesn", context.ExportBean.Accountcyclesn));
            paramList.Add(new KeyValuePair<string, string>("categoryname", context.ExportBean.Categoryname));
            paramList.Add(new KeyValuePair<string, string>("createby", context.ExportBean.Createby));
            paramList.Add(new KeyValuePair<string, string>("type", "yyt3"));
            HttpResponseMessage response = httpClient.PostAsync(new Uri(url), new FormUrlEncodedContent(paramList)).Result;
            String result = response.Content.ReadAsStringAsync().Result;
            httpClient.Dispose();
            JObject jo = JObject.Parse(result);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                context.Vouchers = this.buildData(jo);
            }
            else
            {
                string errorMessage = jo["message"] == null ? "" : jo["message"].ToString();
                throw new Exception("获取凭证数据错误!" + errorMessage);
            }
        }
        // 引进凭证
        private List<YYT3Voucher> buildData(JObject resultObject)
        {
            if (resultObject == null) throw new ArgumentException("构建凭证参数不能为空!");
            List<YYT3Voucher> vouchers = new List<YYT3Voucher>();

            var joDatas = resultObject["datas"];
            if (joDatas == null) throw new Exception("服务器返回数据错误。无法获取datas属性");

            var joResult = joDatas["result"];
            if (joResult == null) throw new Exception("当月无导出数据!");

            var jaVoucherItems = joResult["voucherItems"];
            if (jaVoucherItems == null) throw new Exception("当月无凭证分录数据！");

            foreach (JObject item in jaVoucherItems)
            {
                YYT3Voucher voucherItem = new YYT3Voucher(item);
                vouchers.Add(voucherItem);
            }
            return vouchers;
        }
        //
        //凭证导入end
        //
    }
}