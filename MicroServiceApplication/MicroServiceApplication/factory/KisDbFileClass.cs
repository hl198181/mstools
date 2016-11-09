using MicroServiceApplication.Bean;
using MicroServiceApplication.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MicroServiceApplication.Factory
{
    class KisDbFileParams
    {
        private string _dbFilePath;
        private string _dbFileName;

        public string DbFilePath
        {
            get
            {
                return _dbFilePath;
            }

            set
            {
                _dbFilePath = value;
            }
        }

        public string DbFileName
        {
            get
            {
                return _dbFileName;
            }

            set
            {
                _dbFileName = value;
            }
        }
    }
    //
    //
    //
    class KisVouchersInfo
    {
        private DateTime _FDate;

        public DateTime FDate
        {
            get { return _FDate; }
            set { _FDate = value; }
        }


        private int _FPeriod;

        public int FPeriod
        {
            get { return _FPeriod; }
            set { _FPeriod = value; }
        }

        private string _FGroup = "转";

        public string FGroup
        {
            get { return _FGroup; }
            set { _FGroup = value; }
        }
        private int _FNum;

        public int FNum
        {
            get { return _FNum; }
            set { _FNum = value; }
        }
        private int _FEntryID;

        public int FEntryID
        {
            get { return _FEntryID; }
            set { _FEntryID = value; }
        }
        private string _FExp;

        public string FExp
        {
            get { return _FExp; }
            set { _FExp = value; }
        }
        private string _FAcctID;

        public string FAcctID
        {
            get { return _FAcctID; }
            set { _FAcctID = value; }
        }
        private string _FCyID = "RMB";

        public string FCyID
        {
            get { return _FCyID; }
            set { _FCyID = value; }
        }
        private decimal _FExchRate = 1;

        public decimal FExchRate
        {
            get { return _FExchRate; }
            set { _FExchRate = value; }
        }
        private string _FDC;

        public string FDC
        {
            get { return _FDC; }
            set { _FDC = value; }
        }
        private decimal _FFCyAmt;

        public decimal FFCyAmt
        {
            get { return _FFCyAmt; }
            set { _FFCyAmt = value; }
        }
        private decimal _FQty;

        public decimal FQty
        {
            get { return _FQty; }
            set { _FQty = value; }
        }
        private decimal _FPrice;

        public decimal FPrice
        {
            get { return _FPrice; }
            set { _FPrice = value; }
        }
        private decimal _FDebit;

        public decimal FDebit
        {
            get { return _FDebit; }
            set { _FDebit = value; }
        }
        private decimal _FCredit;

        public decimal FCredit
        {
            get { return _FCredit; }
            set { _FCredit = value; }
        }
        private string _FPrepare;

        public string FPrepare
        {
            get { return _FPrepare; }
            set { _FPrepare = value; }
        }
        private int _FAttchment = 0;

        public int FAttchment
        {
            get { return _FAttchment; }
            set { _FAttchment = value; }
        }
        private bool _FPosted = false;

        public bool FPosted
        {
            get { return _FPosted; }
            set { _FPosted = value; }
        }
        private bool _FDeleted = false;

        public bool FDeleted
        {
            get { return _FDeleted; }
            set { _FDeleted = value; }
        }
        private int _FSerialNo;

        public int FSerialNo
        {
            get { return _FSerialNo; }
            set { _FSerialNo = value; }
        }
    }
    //
    //
    //
    class KisDbFileExportContext
    {
        private KisDbFileParams _params;

        internal KisDbFileParams Params
        {
            get
            {
                return _params;
            }

            set
            {
                _params = value;
            }
        }
    }

    class KisDbAcct
    {
        private String _fcctid;

        private String _facctname;

        private String _fhelpercode;

        private String _fgroup;

        private String _fdc;

        private String _fforcy;

        public string Fcctid
        {
            get
            {
                return _fcctid;
            }

            set
            {
                _fcctid = value;
            }
        }

        public string Facctname
        {
            get
            {
                return _facctname;
            }

            set
            {
                _facctname = value;
            }
        }

        public string Fhelpercode
        {
            get
            {
                return _fhelpercode;
            }

            set
            {
                _fhelpercode = value;
            }
        }

        public string Fgroup
        {
            get
            {
                return _fgroup;
            }

            set
            {
                _fgroup = value;
            }
        }

        public string Fdc
        {
            get
            {
                return _fdc;
            }

            set
            {
                _fdc = value;
            }
        }

        public string Fforcy
        {
            get
            {
                return _fforcy;
            }

            set
            {
                _fforcy = value;
            }
        }
    }

    class KisDbPref
    {
        private String _fcompany;
        private int _fstartyear; //启用年份
        private int _fstartperiod; //启用月份
        private int _fcurryear; //当前会计年度
        private int _fcurrperiod;//当前会计月份
        private int _fdaysperperiod; //每期天数
        private int _fperiodsperyear; //每年期间数
        private int _facctyearbeginmonth; //会计年度起始月份
        private int _facctyearbeginday; //会计年度起始日期
        private int _faclevels; //科目级别
        private int _faclen1; //一级科目代码长度
        private int _faclen2; //二级科目代码长度
        private int _faclen3; //三级科目代码长度
        private int _faclen4; //四级科目代码长度
        private int _faclen5; //五级科目代码长度
        private int _faclen6; //六级科目代码长度
        private int _faclen7; //七级科目代码长
        private int _faclen8; //八级科目代码长
        private int _faclen9; //九级科目代码长
        private int _faclen10; //十级科目代码长

        public string Fcompany
        {
            get
            {
                return _fcompany;
            }

            set
            {
                _fcompany = value;
            }
        }

        public int Fstartyear
        {
            get
            {
                return _fstartyear;
            }

            set
            {
                _fstartyear = value;
            }
        }

        public int Fstartperiod
        {
            get
            {
                return _fstartperiod;
            }

            set
            {
                _fstartperiod = value;
            }
        }

        public int Fcurryear
        {
            get
            {
                return _fcurryear;
            }

            set
            {
                _fcurryear = value;
            }
        }

        public int Fcurrperiod
        {
            get
            {
                return _fcurrperiod;
            }

            set
            {
                _fcurrperiod = value;
            }
        }

        public int Fdaysperperiod
        {
            get
            {
                return _fdaysperperiod;
            }

            set
            {
                _fdaysperperiod = value;
            }
        }

        public int Fperiodsperyear
        {
            get
            {
                return _fperiodsperyear;
            }

            set
            {
                _fperiodsperyear = value;
            }
        }

        public int Facctyearbeginmonth
        {
            get
            {
                return _facctyearbeginmonth;
            }

            set
            {
                _facctyearbeginmonth = value;
            }
        }

        public int Facctyearbeginday
        {
            get
            {
                return _facctyearbeginday;
            }

            set
            {
                _facctyearbeginday = value;
            }
        }

        public int Faclevels
        {
            get
            {
                return _faclevels;
            }

            set
            {
                _faclevels = value;
            }
        }

        public int Faclen1
        {
            get
            {
                return _faclen1;
            }

            set
            {
                _faclen1 = value;
            }
        }

        public int Faclen2
        {
            get
            {
                return _faclen2;
            }

            set
            {
                _faclen2 = value;
            }
        }

        public int Faclen3
        {
            get
            {
                return _faclen3;
            }

            set
            {
                _faclen3 = value;
            }
        }

        public int Faclen4
        {
            get
            {
                return _faclen4;
            }

            set
            {
                _faclen4 = value;
            }
        }

        public int Faclen5
        {
            get
            {
                return _faclen5;
            }

            set
            {
                _faclen5 = value;
            }
        }

        public int Faclen6
        {
            get
            {
                return _faclen6;
            }

            set
            {
                _faclen6 = value;
            }
        }

        public int Faclen7
        {
            get
            {
                return _faclen7;
            }

            set
            {
                _faclen7 = value;
            }
        }

        public int Faclen8
        {
            get
            {
                return _faclen8;
            }

            set
            {
                _faclen8 = value;
            }
        }

        public int Faclen9
        {
            get
            {
                return _faclen9;
            }

            set
            {
                _faclen9 = value;
            }
        }

        public int Faclen10
        {
            get
            {
                return _faclen10;
            }

            set
            {
                _faclen10 = value;
            }
        }
    }

    class KisDbFileFactory
    {

        private KisDbFileParams _kdbParams;

        public KisDbFileFactory(KisDbFileParams param)
        {
            this.KdbParams = param;
        }

        internal KisDbFileParams KdbParams
        {
            get
            {
                return _kdbParams;
            }

            set
            {
                _kdbParams = value;
            }
        }

        public List<KisDbAcct> getGLAcct()
        {
            AccessDbClass access = new AccessDbClass(this.KdbParams.DbFilePath);
            String sql = "select * from GLAcct";
            List<KisDbAcct> kisDbAcctList = new List<KisDbAcct>();
            try
            {
                DataTable acctdt = access.SelectToDataTable(sql);
                if (acctdt.Rows.Count > 0)
                {
                    foreach (DataRow row in acctdt.Rows)
                    {
                        KisDbAcct kisDbAcctItem = new KisDbAcct();
                        kisDbAcctItem.Fcctid = row[0] == null ? null : row[0].ToString();
                        kisDbAcctItem.Facctname = row[1] == null ? null : row[1].ToString();
                        kisDbAcctItem.Fhelpercode = row[2] == null ? null : row[2].ToString();
                        kisDbAcctItem.Fgroup = row[3] == null ? null : row[3].ToString();
                        kisDbAcctItem.Fdc = row[4] == null ? null : row[4].ToString();

                        kisDbAcctList.Add(kisDbAcctItem);
                    }
                }

            }
            catch (Exception e)
            {
                throw (new Exception("数据库出错:" + e.Message));
            }
            finally
            {
                access.Close();
            }
            return kisDbAcctList;
        }

        public KisDbAcct getGLAccById(String accid)
        {
            AccessDbClass access = new AccessDbClass(this.KdbParams.DbFilePath);
            String sql = "select * from GLAcct where FAcctID ='" + accid + "'";
            try
            {
                KisDbAcct kisDbAcctItem = null;
                DataTable acctdt = access.SelectToDataTable(sql);
                if (acctdt.Rows.Count > 0)
                {
                    DataRow row = acctdt.Rows[0];
                    kisDbAcctItem = new KisDbAcct();

                    kisDbAcctItem.Fcctid = row[0] == null ? null : row[0].ToString();
                    kisDbAcctItem.Facctname = row[1] == null ? null : row[1].ToString();
                    kisDbAcctItem.Fhelpercode = row[2] == null ? null : row[2].ToString();
                    kisDbAcctItem.Fgroup = row[3] == null ? null : row[3].ToString();
                    kisDbAcctItem.Fdc = row[4] == null ? null : row[4].ToString();
                }
                return kisDbAcctItem;
            }
            catch (Exception e)
            {
                throw (new Exception("数据库出错:" + e.Message));
            }
            finally
            {
                access.Close();
            }
        }

        public KisDbPref getGLPref()
        {
            AccessDbClass access = new AccessDbClass(this.KdbParams.DbFilePath);
            String sql = "select * from GLPref";
            List<KisDbPref> kisDbPrefList = new List<KisDbPref>();
            try
            {
                DataTable prefdt = access.SelectToDataTable(sql);
                if (prefdt.Rows.Count > 0)
                {
                    foreach (DataRow row in prefdt.Rows)
                    {
                        KisDbPref kisDbPref = new KisDbPref();
                        kisDbPref.Fcompany = row["FCompany"] == null ? null : row["FCompany"].ToString();
                        kisDbPref.Fstartyear = row["FStartYear"] == null ? -1 : int.Parse(row["FStartYear"].ToString());
                        kisDbPref.Fstartperiod = row["FStartPeriod"] == null ? -1 : int.Parse(row["FStartPeriod"].ToString());
                        kisDbPref.Fcurryear = row["FCurrYear"] == null ? -1 : int.Parse(row["FCurrYear"].ToString());
                        kisDbPref.Fcurrperiod = row["FCurrPeriod"] == null ? -1 : int.Parse(row["FCurrPeriod"].ToString());
                        kisDbPref.Fdaysperperiod = row["FDaysPerPeriod"] == null ? -1 : int.Parse(row["FDaysPerPeriod"].ToString());
                        kisDbPref.Fperiodsperyear = row["FPeriodsPerYear"] == null ? -1 : int.Parse(row["FPeriodsPerYear"].ToString());
                        kisDbPref.Facctyearbeginmonth = row["FAcctYearBeginMonth"] == null ? -1 : int.Parse(row["FAcctYearBeginMonth"].ToString());
                        kisDbPref.Facctyearbeginday = row["FAcctYearBeginDay"] == null ? -1 : int.Parse(row["FAcctYearBeginDay"].ToString());

                        kisDbPref.Faclevels = row["FAcLevels"] == null ? -1 : int.Parse(row["FAcLevels"].ToString());
                        kisDbPref.Faclen1 = row["FAcLen1"] == null ? -1 : int.Parse(row["FAcLen1"].ToString());
                        kisDbPref.Faclen2 = row["FAcLen2"] == null ? -1 : int.Parse(row["FAcLen2"].ToString());
                        kisDbPref.Faclen3 = row["FAcLen3"] == null ? -1 : int.Parse(row["FAcLen3"].ToString());
                        kisDbPref.Faclen4 = row["FAcLen4"] == null ? -1 : int.Parse(row["FAcLen4"].ToString());
                        kisDbPref.Faclen5 = row["FAcLen5"] == null ? -1 : int.Parse(row["FAcLen5"].ToString());
                        kisDbPref.Faclen6 = row["FAcLen6"] == null ? -1 : int.Parse(row["FAcLen6"].ToString());
                        //kisDbPref.Faclen7 = row["FAcLen7"] == null ? -1 : int.Parse(row["FAcLen7"].ToString());
                        //kisDbPref.Faclen8 = row["FAcLen8"] == null ? -1 : int.Parse(row["FAcLen8"].ToString());
                        //kisDbPref.Faclen9 = row["FAcLen9"] == null ? -1 : int.Parse(row["FAcLen9"].ToString());
                        //kisDbPref.Faclen10 = row["FAcLen10"] == null ? -1 : int.Parse(row["FAcLen10"].ToString());

                        kisDbPrefList.Add(kisDbPref);
                    }
                }

            }
            catch (Exception e)
            {
                throw (new Exception("数据库出错:" + e.Message));
            }
            finally
            {
                access.Close();
            }
            if (kisDbPrefList.Count > 0)
            {
                return kisDbPrefList[0];
            }
            else
            {
                return null;
            }
        }

        public void testConnect()
        {
            AccessDbClass access = new AccessDbClass(this.KdbParams.DbFilePath);
            String sql = "select * from GLAcct";
            List<KisDbAcct> kisDbAcctList = new List<KisDbAcct>();
            try
            {
                access.SelectToDataTable(sql);

            }
            catch (Exception e)
            {
                throw (new Exception("数据库出错:" + e.Message));
            }
            finally
            {
                access.Close();
            }
        }

        public void initSubject(Client client, User user)
        {
            if (client == null) throw new ArgumentException("无法获取客户信息！");
            if (user == null) throw new ArgumentException("无法获取用户信息！");

            //获取当前账套文件中的会计科目
            List<KisDbAcct> acctList = this.getGLAcct();
            if (acctList == null || acctList.Count <= 0) throw new Exception("账套文件中没有找到科目信息！");

            //清理现有科目
            ClientSubjectFactory csf = new ClientSubjectFactory();
            csf.clean(client.Id);

            //写入科目
            foreach (KisDbAcct item in acctList)
            {
                ClientSubject subject = new ClientSubject();
                subject.Clientid = client.Id;
                subject.Label = item.Facctname;
                subject.Fullname = item.Facctname;
                subject.Isnew = 0;
                subject.Sn = item.Fcctid;
                subject.Debitcredit = (item.Fdc == "D" ? "de" : "cr");
                csf.add(subject, client, user);
            }

            //设置科目长度
            KisDbPref kisDbPref = this.getGLPref();
            if (kisDbPref != null)
            {

                ClientSubjectLengthFactory cslf = new ClientSubjectLengthFactory();

                ClientSubjectLength csl = new ClientSubjectLength();
                csl.Clientid = client.Id;
                csl.Createby = user.Id;
                csl.Subject1 = kisDbPref.Faclen1;//封装字段的Subject1取Faclen1
                csl.Subject2 = kisDbPref.Faclen2 - kisDbPref.Faclen1;//封装字段的Subject2取Faclen2 
                csl.Subject3 = kisDbPref.Faclen3 - kisDbPref.Faclen2;//封装字段的Subject3取Faclen3
                csl.Subject4 = kisDbPref.Faclen4 - kisDbPref.Faclen3;//封装字段的Subject4取Faclen4
                csl.Subject5 = kisDbPref.Faclen5 - kisDbPref.Faclen4;//封装字段的Subject5取Faclen5
                csl.Subject6 = kisDbPref.Faclen6 - kisDbPref.Faclen5;//封装字段的Subject6取Faclen6
                //csl.Subject7 = kisDbPref.Faclen7 - kisDbPref.Faclen6;//封装字段的Subject7取Faclen7
                //csl.Subject8 = kisDbPref.Faclen8 - kisDbPref.Faclen7;//封装字段的Subject8取Faclen8
                //csl.Subject9 = kisDbPref.Faclen9 - kisDbPref.Faclen8;//封装字段的Subject9取Faclen9
                //csl.Subject10 = kisDbPref.Faclen10 - kisDbPref.Faclen9;//封装字段的Subject10取Faclen10
                cslf.add(csl);
            }

        }

        private int getMaxFSerialNum()
        {
            AccessDbClass access = new AccessDbClass(this.KdbParams.DbFilePath);

            String sql = "select FSerialNum from GLVch order by FSerialNum desc ";
            try
            {
                DataTable dt = access.SelectToDataTable(sql);
                int FVchSerialNum = 0;
                if (dt.Rows.Count > 0)
                {
                    string maxnum = dt.Rows[0][dt.Columns[0]] == null ? "0" : dt.Rows[0][dt.Columns[0]].ToString();
                    if (maxnum == "" || maxnum == null) maxnum = "0";
                    FVchSerialNum = int.Parse(maxnum);
                }
                else
                {
                    FVchSerialNum = 0;
                }

                return FVchSerialNum;
            }
            catch (Exception e)
            {
                throw (new Exception("获取最大序列号错误:" + e.Message));
            }
            finally
            {
                access.Close();
            }
        }

        private String getMaxFSerialNumUpdateSql(int currNum)
        {
            AccessDbClass access = new AccessDbClass(this.KdbParams.DbFilePath);

            String sql = "select FVchSerialNum from GLVchSerialNum";
            String updateSql = "";
            try
            {
                DataTable dt = access.SelectToDataTable(sql);
                if (dt.Rows.Count > 0)
                {
                    updateSql = "Update GLVchSerialNum set FVchSerialNum = " + (currNum);

                }
                else
                {
                    updateSql = "Insert into GLVchSerialNum(FVchSerialNum) values (" + (currNum) + ")";

                }
                return updateSql;
            }
            catch (Exception e)
            {
                throw (new Exception("获取最大序列号错误:" + e.Message));
            }
            finally
            {
                access.Close();
            }

        }

        private int getMaxFNum(int accountcyclenum, String fgroup)
        {
            AccessDbClass access = new AccessDbClass(this.KdbParams.DbFilePath);
            String sql = "select FPeriod,FGroup,FNum from GLVch where FPeriod = " + accountcyclenum + " and FGroup='" + fgroup + "' order by FNum desc"; //获取最大凭证号的sql
            try
            {
                DataTable dt = access.SelectToDataTable(sql);
                int FMaxNum = 0;
                if (dt.Rows.Count > 0)
                {
                    string maxnum = dt.Rows[0][dt.Columns[2]] == null ? "0" : dt.Rows[0][dt.Columns[2]].ToString();
                    if (maxnum == "" || maxnum == null) maxnum = "0";
                    FMaxNum = int.Parse(maxnum);
                }
                else
                {
                    FMaxNum = 0;
                }
                return FMaxNum;
            }
            catch (Exception e)
            {
                throw (new Exception("获取最大凭证号错误:" + e.Message));
            }
            finally
            {
                access.Close();
            }
        }

        private String getMaxFNumUpdateSql(int accountcyclenum, String fgroup, int currNum)
        {
            AccessDbClass access = new AccessDbClass(this.KdbParams.DbFilePath);
            String sql = "select FPeriod,FGroup,FNum from GLVchMaxNum where FPeriod = " + accountcyclenum + " and FGroup='" + fgroup + "'";
            String updateSql = "";
            try
            {
                DataTable dt = access.SelectToDataTable(sql);
                if (dt.Rows.Count > 0)
                {
                    updateSql = "Update GLVchMaxNum set FNum = " + (currNum) + " where  FPeriod = " + accountcyclenum + " and FGroup='" + fgroup + "'";
                }
                else
                {
                    updateSql = "Insert into GLVchMaxNum(FPeriod,FGroup,FNum) values (" + accountcyclenum + ",'" + fgroup + "'," + (currNum) + ")";
                }
                return updateSql;
            }
            catch (Exception e)
            {
                throw (new Exception("获取最大凭证号错误:" + e.Message));
            }
            finally
            {
                access.Close();
            }
        }

        public void exportSubject2Kis(List<ClientSubject> clientSubjects)
        {
            if (clientSubjects == null || clientSubjects.Count <= 0) return;

            //获取配置信息
            KisDbPref kisDbPref = this.getGLPref();

            List<String> sqls = new List<String>();
            foreach (ClientSubject item in clientSubjects)
            {
                //检查是否已经存在于kis;
                KisDbAcct kisAcct = this.getGLAccById(item.Sn);

                if (kisAcct != null)
                {
                    throw new Exception("科目:" + item.Sn + ",已经存在于Kis系统中！");
                }

                //获取一级科目
                String leve1Subject = item.Sn.Substring(0, kisDbPref.Faclen1);

                KisDbAcct level1Acct = this.getGLAccById(leve1Subject);

                if (level1Acct == null)
                {
                    throw new Exception("无法获取科目:" + item.Sn + "的一级科目信息！");
                }

                //组合插入SQL
                String sql = "INSERT INTO GLAcct(FAcctID,FAcctName,FGroup,FDC) VALUES (" +
                    "'" + item.Sn + "'," +
                    "'" + item.Label + "'," +
                    "'" + level1Acct.Fgroup + "'," + //科目分组，需要根据上级象科目确认
                    "'" + (item.Debitcredit == "de" ? "D" : "C") + "'" +
                    ")";
                sqls.Add(sql);

            }

            //插入数据库
            AccessDbClass access = new AccessDbClass(this.KdbParams.DbFilePath);
            try
            {
                access.ExecuteSQLNonquery(sqls);
            }
            catch (Exception e1)
            {
                throw e1;
            }
            finally
            {
                access.Close();
            }
        }

        private String buildItemSql(KisVoucherInfo item, int fSerialNum, int fNum)
        {
            if (item == null) return null;
            if (fSerialNum < 0) throw new ArgumentException("无法获取凭证序列号");
            if (fNum < 0) throw new ArgumentException("无法获取凭证号");

            //检查当前科目是否存在
            KisDbAcct kda = this.getGLAccById(item.FAcctID);

            if (kda == null) throw new Exception("科目:" + item.FAcctID + ",在财务系统中不存在！");

            String sql = "INSERT INTO GLVch(FSerialNum,FDate,FPeriod,FGroup,FNum,FEntryID,FAcctID,FCyID,FExchRate,FFcyAmt,FDebit,FCredit,FPreparer,FExp) VALUES (" +
                    "" + fSerialNum + "," +
                    "'" + item.FDate + "'," +
                    "" + item.FPeriod + "," +
                    "'" + item.FGroup + "'," +
                    "" + fNum + "," +
                    "" + item.FEntryID + "," +
                    "'" + item.FAcctID + "'," +
                    "'" + item.FCyID + "'," +
                    "" + item.FExchRate + "," +
                    "" + item.FFCyAmt + "," +
                    "" + item.FDebit + "," +
                    "" + item.FCredit + "," +
                    "'" + item.FPrepare + "'," +
                    "'" + item.FExp + "'" +
                    ")";

            return sql;
        }
        private String build3ItemSql(KisVouchersInfo item, int fSerialNum, int fNum)
        {
            if (item == null) return null;
            if (fSerialNum < 0) throw new ArgumentException("无法获取凭证序列号");
            if (fNum < 0) throw new ArgumentException("无法获取凭证号");

            //检查当前科目是否存在
            KisDbAcct kda = this.getGLAccById(item.FAcctID);

            if (kda == null) throw new Exception("科目:" + item.FAcctID + ",在财务系统中不存在！");

            String sql = "INSERT INTO GLVch(FSerialNum,FDate,FPeriod,FGroup,FNum,FEntryID,FAcctID,FCyID,FExchRate,FFcyAmt,FDebit,FCredit,FPreparer,FExp) VALUES (" +
                    "" + fSerialNum + "," +
                    "'" + item.FDate + "'," +
                    "" + item.FPeriod + "," +
                    "'" + item.FGroup + "'," +
                    "" + fNum + "," +
                    "" + item.FEntryID + "," +
                    "'" + item.FAcctID + "'," +
                    "'" + item.FCyID + "'," +
                    "" + item.FExchRate + "," +
                    "" + item.FFCyAmt + "," +
                    "" + item.FDebit + "," +
                    "" + item.FCredit + "," +
                    "'" + item.FPrepare + "'," +
                    "'" + item.FExp + "'" +
                    ")";

            return sql;
        }
        public void exportVoucher(String vouchernumber, Inst inst, Client client, Accountcycle accountcycle, User user, String categoryname)
        {

            if (inst == null) throw new ArgumentException("必须输入机构信息！");
            if (client == null) throw new ArgumentException("必须输入客户信息！");
            if (user == null) throw new ArgumentException("必须输入用户信息！");
            if (accountcycle == null) throw new ArgumentException("必须输入月份信息！");
            if (categoryname == null || categoryname == "") throw new ArgumentException("必须指定导出凭证类型!");

            //获取凭证数据
            KisVoucherFactory kvf = new KisVoucherFactory();
            List<KisVoucherInfo> vouchers = kvf.getKisVoucher(inst.Id, client.Id, accountcycle.Sn, user.Id, categoryname);

            if (vouchers == null || vouchers.Count <= 0) throw new Exception("没有查找到需要导出的凭证信息！");


            //构建凭证SQL
            List<String> sqls = new List<String>();
            int maxFSerialNum = -1;
            int maxFNum = -1;
            if(inst.Id != "653279009C4211E6A731B9323D2BF7D6" && inst.Id != "10000001463017")
                {
                if (vouchernumber == "no")
                {
                    foreach (KisVoucherInfo kvi in vouchers)
                    {
                        if (kvi.FEntryID == 0)
                        {
                            if (maxFSerialNum < 0)
                            {
                                maxFSerialNum = this.getMaxFSerialNum();
                                maxFSerialNum++;
                            }
                            else
                            {
                                maxFSerialNum++;
                            }

                            if (maxFNum < 0)
                            {
                                maxFNum = this.getMaxFNum(kvi.FPeriod, kvi.FGroup);
                                maxFNum++;
                            }
                            else
                            {
                                maxFNum++;
                            }
                        }
                        String sql = this.buildItemSql(kvi, maxFSerialNum, maxFNum);
                        if (sql != null && sql != "") sqls.Add(sql);

                    }
                }
            }
            //
            //只显示一行摘要start
            //
            List<KisVouchersInfo> newvouchers = new List<KisVouchersInfo>();
            foreach(KisVoucherInfo kvi in vouchers)
            {
                if (kvi.FEntryID == 0)
                {
                    KisVouchersInfo kisVouchersInfo = new KisVouchersInfo();
                    kisVouchersInfo.FAcctID = kvi.FAcctID;
                    kisVouchersInfo.FAttchment = kvi.FAttchment;
                    kisVouchersInfo.FCredit = kvi.FCredit;
                    kisVouchersInfo.FCyID = kvi.FCyID;
                    kisVouchersInfo.FDate = kvi.FDate;
                    kisVouchersInfo.FDC = kvi.FDC;
                    kisVouchersInfo.FDebit = kvi.FDebit;
                    kisVouchersInfo.FDeleted = kvi.FDeleted;
                    kisVouchersInfo.FEntryID = kvi.FEntryID;
                    kisVouchersInfo.FExchRate = kvi.FExchRate;
                    kisVouchersInfo.FExp = kvi.FExp;
                    kisVouchersInfo.FFCyAmt = kvi.FFCyAmt;
                    kisVouchersInfo.FGroup = kvi.FGroup;
                    kisVouchersInfo.FNum = kvi.FNum;
                    kisVouchersInfo.FPeriod = kvi.FPeriod;
                    kisVouchersInfo.FPosted = kvi.FPosted;
                    kisVouchersInfo.FPrepare = kvi.FPrepare;
                    kisVouchersInfo.FPrice = kvi.FPrice;
                    kisVouchersInfo.FQty = kvi.FQty;
                    kisVouchersInfo.FSerialNo = kvi.FSerialNo;
                    newvouchers.Add(kisVouchersInfo);
                }
                else
                {
                    KisVouchersInfo kisVouchersInfo = new KisVouchersInfo();
                    kisVouchersInfo.FAcctID = kvi.FAcctID;
                    kisVouchersInfo.FAttchment = kvi.FAttchment;
                    kisVouchersInfo.FCredit = kvi.FCredit;
                    kisVouchersInfo.FCyID = kvi.FCyID;
                    kisVouchersInfo.FDate = kvi.FDate;
                    kisVouchersInfo.FDC = kvi.FDC;
                    kisVouchersInfo.FDebit = kvi.FDebit;
                    kisVouchersInfo.FDeleted = kvi.FDeleted;
                    kisVouchersInfo.FEntryID = kvi.FEntryID;
                    kisVouchersInfo.FExchRate = kvi.FExchRate;
                    kisVouchersInfo.FExp = null;
                    kisVouchersInfo.FFCyAmt = kvi.FFCyAmt;
                    kisVouchersInfo.FGroup = kvi.FGroup;
                    kisVouchersInfo.FNum = kvi.FNum;
                    kisVouchersInfo.FPeriod = kvi.FPeriod;
                    kisVouchersInfo.FPosted = kvi.FPosted;
                    kisVouchersInfo.FPrepare = kvi.FPrepare;
                    kisVouchersInfo.FPrice = kvi.FPrice;
                    kisVouchersInfo.FQty = kvi.FQty;
                    kisVouchersInfo.FSerialNo = kvi.FSerialNo;
                    newvouchers.Add(kisVouchersInfo);
                }
            }
            //
            //只显示一行摘要end
            //
            if (inst.Id == "653279009C4211E6A731B9323D2BF7D6" || inst.Id == "10000001463017")
            {
                //
                //佰佳导入不合并start
                //
                if (vouchernumber == "no")
                {
                    foreach (KisVouchersInfo kvi in newvouchers)
                    {
                        if (kvi.FEntryID == 0)
                        {
                            if (maxFSerialNum < 0)
                            {
                                maxFSerialNum = this.getMaxFSerialNum();
                                maxFSerialNum++;
                            }
                            else
                            {
                                maxFSerialNum++;
                            }

                            if (maxFNum < 0)
                            {
                                maxFNum = this.getMaxFNum(kvi.FPeriod, kvi.FGroup);
                                maxFNum++;
                            }
                            else
                            {
                                maxFNum++;
                            }
                        }
                        String sql = this.build3ItemSql(kvi, maxFSerialNum, maxFNum);
                        if (sql != null && sql != "") sqls.Add(sql);

                    }
                }
                //
                //百佳导入不合并end
                //
                //只显示一行摘要end
                //
                //销项3张凭证合为一张start
                //
                if (vouchernumber == "yes")
                {
                    int number = -1;
                    List<KisVouchersInfo> kisVouchersInfoList = new List<KisVouchersInfo>();
                    if (number <= 0)
                    {
                        KisVouchersInfo kisVouchersInfo1 = new KisVouchersInfo();
                        KisVouchersInfo kisVouchersInfo2 = new KisVouchersInfo();
                        KisVouchersInfo kisVouchersInfo3 = new KisVouchersInfo();
                        KisVouchersInfo kisVouchersInfo4 = new KisVouchersInfo();

                        for (int i = 0; i < vouchers.Count; i++)
                        {
                            if (vouchers[i].FEntryID == 0)
                            {
                                number++;
                                if (number == 3)
                                {
                                    number = 0;
                                }
                            }

                            KisVouchersInfo kisVouchersInfo5 = new KisVouchersInfo();
                            KisVouchersInfo kisVouchersInfo6 = new KisVouchersInfo();
                            KisVouchersInfo kisVouchersInfo7 = new KisVouchersInfo();
                            KisVouchersInfo kisVouchersInfo8 = new KisVouchersInfo();
                            KisVouchersInfo kisVouchersInfo9 = new KisVouchersInfo();
                            KisVouchersInfo kisVouchersInfo10 = new KisVouchersInfo();
                            KisVouchersInfo kisVouchersInfo11 = new KisVouchersInfo();
                            KisVouchersInfo kisVouchersInfo12 = new KisVouchersInfo();
                            KisVouchersInfo kisVouchersInfo13 = new KisVouchersInfo();
                            KisVouchersInfo kisVouchersInfo14 = new KisVouchersInfo();
                            KisVouchersInfo kisVouchersInfo15 = new KisVouchersInfo();
                            KisVouchersInfo kisVouchersInfo16 = new KisVouchersInfo();
                            KisVouchersInfo kisVouchersInfo17 = new KisVouchersInfo();
                            KisVouchersInfo kisVouchersInfo18 = new KisVouchersInfo();

                            if (vouchers[i].FEntryID == 0 && number == 0)
                            {

                                if (vouchers[i].FEntryID == 0)
                                {

                                    KisVouchersInfo kisVouchersInfo = new KisVouchersInfo();
                                    kisVouchersInfo.FAcctID = vouchers[i].FAcctID;
                                    kisVouchersInfo.FAttchment = vouchers[i].FAttchment;
                                    kisVouchersInfo.FCredit = vouchers[i].FCredit;
                                    kisVouchersInfo.FCyID = vouchers[i].FCyID;
                                    kisVouchersInfo.FDate = vouchers[i].FDate;
                                    kisVouchersInfo.FDC = vouchers[i].FDC;
                                    kisVouchersInfo.FDebit = vouchers[i].FDebit;
                                    kisVouchersInfo.FDeleted = vouchers[i].FDeleted;
                                    kisVouchersInfo.FEntryID = 0;
                                    kisVouchersInfo.FExchRate = vouchers[i].FExchRate;
                                    kisVouchersInfo.FExp = "销售收入";
                                    kisVouchersInfo.FFCyAmt = vouchers[i].FFCyAmt;
                                    kisVouchersInfo.FGroup = vouchers[i].FGroup;
                                    kisVouchersInfo.FNum = vouchers[i].FNum;
                                    kisVouchersInfo.FPeriod = vouchers[i].FPeriod;
                                    kisVouchersInfo.FPosted = vouchers[i].FPosted;
                                    kisVouchersInfo.FPrepare = vouchers[i].FPrepare;
                                    kisVouchersInfo.FPrice = vouchers[i].FPrice;
                                    kisVouchersInfo.FQty = vouchers[i].FQty;
                                    kisVouchersInfo.FSerialNo = vouchers[i].FSerialNo;
                                    kisVouchersInfoList.Add(kisVouchersInfo);
                                }
                                if (vouchers[i + 1].FEntryID == 1)
                                {
                                    if (vouchers.Count - i > 3)
                                    {
                                        kisVouchersInfo1.FAcctID = vouchers[i + 1].FAcctID;
                                        kisVouchersInfo1.FAttchment = vouchers[i + 1].FAttchment;
                                        kisVouchersInfo1.FCredit = vouchers[i + 1].FCredit;
                                        kisVouchersInfo1.FCyID = vouchers[i + 1].FCyID;
                                        kisVouchersInfo1.FDate = vouchers[i + 1].FDate;
                                        kisVouchersInfo1.FDC = vouchers[i + 1].FDC;
                                        kisVouchersInfo1.FDebit = vouchers[i + 1].FDebit;
                                        kisVouchersInfo1.FDeleted = vouchers[i + 1].FDeleted;
                                        kisVouchersInfo1.FEntryID = 3;
                                        kisVouchersInfo1.FExchRate = vouchers[i + 1].FExchRate;
                                        kisVouchersInfo1.FExp = null;
                                        kisVouchersInfo1.FFCyAmt = vouchers[i + 1].FFCyAmt;
                                        kisVouchersInfo1.FGroup = vouchers[i + 1].FGroup;
                                        kisVouchersInfo1.FNum = vouchers[i + 1].FNum;
                                        kisVouchersInfo1.FPeriod = vouchers[i + 1].FPeriod;
                                        kisVouchersInfo1.FPosted = vouchers[i + 1].FPosted;
                                        kisVouchersInfo1.FPrepare = vouchers[i + 1].FPrepare;
                                        kisVouchersInfo1.FPrice = vouchers[i + 1].FPrice;
                                        kisVouchersInfo1.FQty = vouchers[i + 1].FQty;
                                        kisVouchersInfo1.FSerialNo = vouchers[i + 1].FSerialNo;
                                    }
                                    else
                                    {
                                        kisVouchersInfo7.FAcctID = vouchers[i + 1].FAcctID;
                                        kisVouchersInfo7.FAttchment = vouchers[i + 1].FAttchment;
                                        kisVouchersInfo7.FCredit = vouchers[i + 1].FCredit;
                                        kisVouchersInfo7.FCyID = vouchers[i + 1].FCyID;
                                        kisVouchersInfo7.FDate = vouchers[i + 1].FDate;
                                        kisVouchersInfo7.FDC = vouchers[i + 1].FDC;
                                        kisVouchersInfo7.FDebit = vouchers[i + 1].FDebit;
                                        kisVouchersInfo7.FDeleted = vouchers[i + 1].FDeleted;
                                        kisVouchersInfo7.FEntryID = 1;
                                        kisVouchersInfo7.FExchRate = vouchers[i + 1].FExchRate;
                                        kisVouchersInfo7.FExp = null;
                                        kisVouchersInfo7.FFCyAmt = vouchers[i + 1].FFCyAmt;
                                        kisVouchersInfo7.FGroup = vouchers[i + 1].FGroup;
                                        kisVouchersInfo7.FNum = vouchers[i + 1].FNum;
                                        kisVouchersInfo7.FPeriod = vouchers[i + 1].FPeriod;
                                        kisVouchersInfo7.FPosted = vouchers[i + 1].FPosted;
                                        kisVouchersInfo7.FPrepare = vouchers[i + 1].FPrepare;
                                        kisVouchersInfo7.FPrice = vouchers[i + 1].FPrice;
                                        kisVouchersInfo7.FQty = vouchers[i + 1].FQty;
                                        kisVouchersInfo7.FSerialNo = vouchers[i + 1].FSerialNo;

                                        kisVouchersInfoList.Add(kisVouchersInfo7);

                                    }
                                }
                                if (i + 3 <= vouchers.Count)
                                {
                                    if (vouchers[i + 2].FEntryID == 2)
                                    {
                                        if (vouchers.Count - i > 3)
                                        {
                                            kisVouchersInfo2.FAcctID = vouchers[i + 2].FAcctID;
                                            kisVouchersInfo2.FAttchment = vouchers[i + 2].FAttchment;
                                            kisVouchersInfo2.FCredit = vouchers[i + 2].FCredit;
                                            kisVouchersInfo2.FCyID = vouchers[i + 2].FCyID;
                                            kisVouchersInfo2.FDate = vouchers[i + 2].FDate;
                                            kisVouchersInfo2.FDC = vouchers[i + 2].FDC;
                                            kisVouchersInfo2.FDebit = vouchers[i + 2].FDebit;
                                            kisVouchersInfo2.FDeleted = vouchers[i + 2].FDeleted;
                                            kisVouchersInfo2.FEntryID = 4;
                                            kisVouchersInfo2.FExchRate = vouchers[i + 2].FExchRate;
                                            kisVouchersInfo2.FExp = null;
                                            kisVouchersInfo2.FFCyAmt = vouchers[i + 2].FFCyAmt;
                                            kisVouchersInfo2.FGroup = vouchers[i + 2].FGroup;
                                            kisVouchersInfo2.FNum = vouchers[i + 2].FNum;
                                            kisVouchersInfo2.FPeriod = vouchers[i + 2].FPeriod;
                                            kisVouchersInfo2.FPosted = vouchers[i + 2].FPosted;
                                            kisVouchersInfo2.FPrepare = vouchers[i + 2].FPrepare;
                                            kisVouchersInfo2.FPrice = vouchers[i + 2].FPrice;
                                            kisVouchersInfo2.FQty = vouchers[i + 2].FQty;
                                            kisVouchersInfo2.FSerialNo = vouchers[i + 2].FSerialNo;
                                        }
                                        else
                                        {
                                            kisVouchersInfo8.FAcctID = vouchers[i + 2].FAcctID;
                                            kisVouchersInfo8.FAttchment = vouchers[i + 2].FAttchment;
                                            kisVouchersInfo8.FCredit = vouchers[i + 2].FCredit;
                                            kisVouchersInfo8.FCyID = vouchers[i + 2].FCyID;
                                            kisVouchersInfo8.FDate = vouchers[i + 2].FDate;
                                            kisVouchersInfo8.FDC = vouchers[i + 2].FDC;
                                            kisVouchersInfo8.FDebit = vouchers[i + 2].FDebit;
                                            kisVouchersInfo8.FDeleted = vouchers[i + 2].FDeleted;
                                            kisVouchersInfo8.FEntryID = 2;
                                            kisVouchersInfo8.FExchRate = vouchers[i + 2].FExchRate;
                                            kisVouchersInfo8.FExp = null;
                                            kisVouchersInfo8.FFCyAmt = vouchers[i + 2].FFCyAmt;
                                            kisVouchersInfo8.FGroup = vouchers[i + 2].FGroup;
                                            kisVouchersInfo8.FNum = vouchers[i + 2].FNum;
                                            kisVouchersInfo8.FPeriod = vouchers[i + 2].FPeriod;
                                            kisVouchersInfo8.FPosted = vouchers[i + 2].FPosted;
                                            kisVouchersInfo8.FPrepare = vouchers[i + 2].FPrepare;
                                            kisVouchersInfo8.FPrice = vouchers[i + 2].FPrice;
                                            kisVouchersInfo8.FQty = vouchers[i + 2].FQty;
                                            kisVouchersInfo8.FSerialNo = vouchers[i + 2].FSerialNo;

                                            kisVouchersInfoList.Add(kisVouchersInfo8);
                                        }
                                    }
                                }
                            }

                            if (vouchers[i].FEntryID == 0 && number == 1)
                            {

                                if (vouchers[i].FEntryID == 0)
                                {
                                    KisVouchersInfo kisVouchersInfo = new KisVouchersInfo();
                                    kisVouchersInfo.FAcctID = vouchers[i].FAcctID;
                                    kisVouchersInfo.FAttchment = vouchers[i].FAttchment;
                                    kisVouchersInfo.FCredit = vouchers[i].FCredit;
                                    kisVouchersInfo.FCyID = vouchers[i].FCyID;
                                    kisVouchersInfo.FDate = vouchers[i].FDate;
                                    kisVouchersInfo.FDC = vouchers[i].FDC;
                                    kisVouchersInfo.FDebit = vouchers[i].FDebit;
                                    kisVouchersInfo.FDeleted = vouchers[i].FDeleted;
                                    kisVouchersInfo.FEntryID = 1;
                                    kisVouchersInfo.FExchRate = vouchers[i].FExchRate;
                                    kisVouchersInfo.FExp = "销售收入";
                                    kisVouchersInfo.FFCyAmt = vouchers[i].FFCyAmt;
                                    kisVouchersInfo.FGroup = vouchers[i].FGroup;
                                    kisVouchersInfo.FNum = vouchers[i].FNum;
                                    kisVouchersInfo.FPeriod = vouchers[i].FPeriod;
                                    kisVouchersInfo.FPosted = vouchers[i].FPosted;
                                    kisVouchersInfo.FPrepare = vouchers[i].FPrepare;
                                    kisVouchersInfo.FPrice = vouchers[i].FPrice;
                                    kisVouchersInfo.FQty = vouchers[i].FQty;
                                    kisVouchersInfo.FSerialNo = vouchers[i].FSerialNo;
                                    kisVouchersInfoList.Add(kisVouchersInfo);
                                }
                                if (vouchers[i + 1].FEntryID == 1)
                                {
                                    if (vouchers.Count - i > 3)
                                    {
                                        kisVouchersInfo3.FAcctID = vouchers[i + 1].FAcctID;
                                        kisVouchersInfo3.FAttchment = vouchers[i + 1].FAttchment;
                                        kisVouchersInfo3.FCredit = vouchers[i + 1].FCredit;
                                        kisVouchersInfo3.FCyID = vouchers[i + 1].FCyID;
                                        kisVouchersInfo3.FDate = vouchers[i + 1].FDate;
                                        kisVouchersInfo3.FDC = vouchers[i + 1].FDC;
                                        kisVouchersInfo3.FDebit = vouchers[i + 1].FDebit;
                                        kisVouchersInfo3.FDeleted = vouchers[i + 1].FDeleted;
                                        kisVouchersInfo3.FEntryID = 3;
                                        kisVouchersInfo3.FExchRate = vouchers[i + 1].FExchRate;
                                        kisVouchersInfo3.FExp = null;
                                        kisVouchersInfo3.FFCyAmt = vouchers[i + 1].FFCyAmt;
                                        kisVouchersInfo3.FGroup = vouchers[i + 1].FGroup;
                                        kisVouchersInfo3.FNum = vouchers[i + 1].FNum;
                                        kisVouchersInfo3.FPeriod = vouchers[i + 1].FPeriod;
                                        kisVouchersInfo3.FPosted = vouchers[i + 1].FPosted;
                                        kisVouchersInfo3.FPrepare = vouchers[i + 1].FPrepare;
                                        kisVouchersInfo3.FPrice = vouchers[i + 1].FPrice;
                                        kisVouchersInfo3.FQty = vouchers[i + 1].FQty;
                                        kisVouchersInfo3.FSerialNo = vouchers[i + 1].FSerialNo;
                                    }
                                    else
                                    {
                                        kisVouchersInfo9.FAcctID = kisVouchersInfo1.FAcctID;
                                        kisVouchersInfo9.FAttchment = kisVouchersInfo1.FAttchment;
                                        kisVouchersInfo9.FCredit = vouchers[i + 1].FCredit + kisVouchersInfo1.FCredit;
                                        kisVouchersInfo9.FCyID = kisVouchersInfo1.FCyID;
                                        kisVouchersInfo9.FDate = kisVouchersInfo1.FDate;
                                        kisVouchersInfo9.FDC = kisVouchersInfo1.FDC;
                                        kisVouchersInfo9.FDebit = vouchers[i + 1].FDebit + kisVouchersInfo1.FDebit;
                                        kisVouchersInfo9.FDeleted = kisVouchersInfo1.FDeleted;
                                        kisVouchersInfo9.FEntryID = 2;
                                        kisVouchersInfo9.FExchRate = kisVouchersInfo1.FExchRate;
                                        kisVouchersInfo9.FExp = null;
                                        kisVouchersInfo9.FFCyAmt = vouchers[i + 1].FFCyAmt + kisVouchersInfo1.FFCyAmt;
                                        kisVouchersInfo9.FGroup = kisVouchersInfo1.FGroup;
                                        kisVouchersInfo9.FNum = kisVouchersInfo1.FNum;
                                        kisVouchersInfo9.FPeriod = kisVouchersInfo1.FPeriod;
                                        kisVouchersInfo9.FPosted = kisVouchersInfo1.FPosted;
                                        kisVouchersInfo9.FPrepare = kisVouchersInfo1.FPrepare;
                                        kisVouchersInfo9.FPrice = kisVouchersInfo1.FPrice;
                                        kisVouchersInfo9.FQty = kisVouchersInfo1.FQty;
                                        kisVouchersInfo9.FSerialNo = kisVouchersInfo1.FSerialNo;
                                        kisVouchersInfoList.Add(kisVouchersInfo9);
                                    }
                                }
                                if (i + 3 <= vouchers.Count)
                                {
                                    if (vouchers[i + 2].FEntryID == 2)
                                    {
                                        if (vouchers.Count - i > 3)
                                        {
                                            kisVouchersInfo4.FAcctID = vouchers[i + 2].FAcctID;
                                            kisVouchersInfo4.FAttchment = vouchers[i + 2].FAttchment;
                                            kisVouchersInfo4.FCredit = vouchers[i + 2].FCredit;
                                            kisVouchersInfo4.FCyID = vouchers[i + 2].FCyID;
                                            kisVouchersInfo4.FDate = vouchers[i + 2].FDate;
                                            kisVouchersInfo4.FDC = vouchers[i + 2].FDC;
                                            kisVouchersInfo4.FDebit = vouchers[i + 2].FDebit;
                                            kisVouchersInfo4.FDeleted = vouchers[i + 2].FDeleted;
                                            kisVouchersInfo4.FEntryID = 4;
                                            kisVouchersInfo4.FExchRate = vouchers[i + 2].FExchRate;
                                            kisVouchersInfo4.FExp = null;
                                            kisVouchersInfo4.FFCyAmt = vouchers[i + 2].FFCyAmt;
                                            kisVouchersInfo4.FGroup = vouchers[i + 2].FGroup;
                                            kisVouchersInfo4.FNum = vouchers[i + 2].FNum;
                                            kisVouchersInfo4.FPeriod = vouchers[i + 2].FPeriod;
                                            kisVouchersInfo4.FPosted = vouchers[i + 2].FPosted;
                                            kisVouchersInfo4.FPrepare = vouchers[i + 2].FPrepare;
                                            kisVouchersInfo4.FPrice = vouchers[i + 2].FPrice;
                                            kisVouchersInfo4.FQty = vouchers[i + 2].FQty;
                                            kisVouchersInfo4.FSerialNo = vouchers[i + 2].FSerialNo;
                                        }
                                        else
                                        {
                                            kisVouchersInfo10.FAcctID = kisVouchersInfo2.FAcctID;
                                            kisVouchersInfo10.FAttchment = kisVouchersInfo2.FAttchment;
                                            kisVouchersInfo10.FCredit = vouchers[i + 2].FCredit + kisVouchersInfo2.FCredit;
                                            kisVouchersInfo10.FCyID = kisVouchersInfo2.FCyID;
                                            kisVouchersInfo10.FDate = kisVouchersInfo2.FDate;
                                            kisVouchersInfo10.FDC = kisVouchersInfo2.FDC;
                                            kisVouchersInfo10.FDebit = vouchers[i + 2].FDebit + kisVouchersInfo2.FDebit;
                                            kisVouchersInfo10.FDeleted = kisVouchersInfo2.FDeleted;
                                            kisVouchersInfo10.FEntryID = 3;
                                            kisVouchersInfo10.FExchRate = kisVouchersInfo2.FExchRate;
                                            kisVouchersInfo10.FExp = null;
                                            kisVouchersInfo10.FFCyAmt = vouchers[i + 2].FFCyAmt + kisVouchersInfo2.FFCyAmt;
                                            kisVouchersInfo10.FGroup = kisVouchersInfo2.FGroup;
                                            kisVouchersInfo10.FNum = kisVouchersInfo2.FNum;
                                            kisVouchersInfo10.FPeriod = kisVouchersInfo2.FPeriod;
                                            kisVouchersInfo10.FPosted = kisVouchersInfo2.FPosted;
                                            kisVouchersInfo10.FPrepare = kisVouchersInfo2.FPrepare;
                                            kisVouchersInfo10.FPrice = kisVouchersInfo2.FPrice;
                                            kisVouchersInfo10.FQty = kisVouchersInfo2.FQty;
                                            kisVouchersInfo10.FSerialNo = kisVouchersInfo2.FSerialNo;
                                            kisVouchersInfoList.Add(kisVouchersInfo10);
                                        }
                                    }
                                }
                                else
                                {
                                    kisVouchersInfo10.FAcctID = kisVouchersInfo2.FAcctID;
                                    kisVouchersInfo10.FAttchment = kisVouchersInfo2.FAttchment;
                                    kisVouchersInfo10.FCredit = kisVouchersInfo2.FCredit;
                                    kisVouchersInfo10.FCyID = kisVouchersInfo2.FCyID;
                                    kisVouchersInfo10.FDate = kisVouchersInfo2.FDate;
                                    kisVouchersInfo10.FDC = kisVouchersInfo2.FDC;
                                    kisVouchersInfo10.FDebit = kisVouchersInfo2.FDebit;
                                    kisVouchersInfo10.FDeleted = kisVouchersInfo2.FDeleted;
                                    kisVouchersInfo10.FEntryID = 3;
                                    kisVouchersInfo10.FExchRate = kisVouchersInfo2.FExchRate;
                                    kisVouchersInfo10.FExp = null;
                                    kisVouchersInfo10.FFCyAmt = kisVouchersInfo2.FFCyAmt;
                                    kisVouchersInfo10.FGroup = kisVouchersInfo2.FGroup;
                                    kisVouchersInfo10.FNum = kisVouchersInfo2.FNum;
                                    kisVouchersInfo10.FPeriod = kisVouchersInfo2.FPeriod;
                                    kisVouchersInfo10.FPosted = kisVouchersInfo2.FPosted;
                                    kisVouchersInfo10.FPrepare = kisVouchersInfo2.FPrepare;
                                    kisVouchersInfo10.FPrice = kisVouchersInfo2.FPrice;
                                    kisVouchersInfo10.FQty = kisVouchersInfo2.FQty;
                                    kisVouchersInfo10.FSerialNo = kisVouchersInfo2.FSerialNo;
                                    kisVouchersInfoList.Add(kisVouchersInfo10);
                                }
                            }

                            if (vouchers[i].FEntryID == 0 && number == 2)
                            {
                                if (vouchers[i].FEntryID == 0)
                                {
                                    KisVouchersInfo kisVouchersInfo = new KisVouchersInfo();
                                    kisVouchersInfo.FAcctID = vouchers[i].FAcctID;
                                    kisVouchersInfo.FAttchment = vouchers[i].FAttchment;
                                    kisVouchersInfo.FCredit = vouchers[i].FCredit;
                                    kisVouchersInfo.FCyID = vouchers[i].FCyID;
                                    kisVouchersInfo.FDate = vouchers[i].FDate;
                                    kisVouchersInfo.FDC = vouchers[i].FDC;
                                    kisVouchersInfo.FDebit = vouchers[i].FDebit;
                                    kisVouchersInfo.FDeleted = vouchers[i].FDeleted;
                                    kisVouchersInfo.FEntryID = 2;
                                    kisVouchersInfo.FExchRate = vouchers[i].FExchRate;
                                    kisVouchersInfo.FExp = "销售收入";
                                    kisVouchersInfo.FFCyAmt = vouchers[i].FFCyAmt;
                                    kisVouchersInfo.FGroup = vouchers[i].FGroup;
                                    kisVouchersInfo.FNum = vouchers[i].FNum;
                                    kisVouchersInfo.FPeriod = vouchers[i].FPeriod;
                                    kisVouchersInfo.FPosted = vouchers[i].FPosted;
                                    kisVouchersInfo.FPrepare = vouchers[i].FPrepare;
                                    kisVouchersInfo.FPrice = vouchers[i].FPrice;
                                    kisVouchersInfo.FQty = vouchers[i].FQty;
                                    kisVouchersInfo.FSerialNo = vouchers[i].FSerialNo;
                                    kisVouchersInfoList.Add(kisVouchersInfo);
                                }
                                if (vouchers[i + 1].FEntryID == 1)
                                {
                                    if (kisVouchersInfo1.FAcctID != null)
                                    {
                                        kisVouchersInfo5.FAcctID = kisVouchersInfo1.FAcctID;
                                        kisVouchersInfo5.FAttchment = kisVouchersInfo1.FAttchment;
                                        kisVouchersInfo5.FCredit = vouchers[i + 1].FCredit + kisVouchersInfo1.FCredit + kisVouchersInfo3.FCredit;
                                        kisVouchersInfo5.FCyID = kisVouchersInfo1.FCyID;
                                        kisVouchersInfo5.FDate = kisVouchersInfo1.FDate;
                                        kisVouchersInfo5.FDC = kisVouchersInfo1.FDC;
                                        kisVouchersInfo5.FDebit = vouchers[i + 1].FDebit + kisVouchersInfo1.FDebit + kisVouchersInfo3.FDebit;
                                        kisVouchersInfo5.FDeleted = kisVouchersInfo1.FDeleted;
                                        kisVouchersInfo5.FEntryID = 3;
                                        kisVouchersInfo5.FExchRate = kisVouchersInfo1.FExchRate;
                                        kisVouchersInfo5.FExp = null;
                                        kisVouchersInfo5.FFCyAmt = vouchers[i + 1].FFCyAmt + kisVouchersInfo1.FFCyAmt + kisVouchersInfo3.FFCyAmt;
                                        kisVouchersInfo5.FGroup = kisVouchersInfo1.FGroup;
                                        kisVouchersInfo5.FNum = kisVouchersInfo1.FNum;
                                        kisVouchersInfo5.FPeriod = kisVouchersInfo1.FPeriod;
                                        kisVouchersInfo5.FPosted = kisVouchersInfo1.FPosted;
                                        kisVouchersInfo5.FPrepare = kisVouchersInfo1.FPrepare;
                                        kisVouchersInfo5.FPrice = kisVouchersInfo1.FPrice;
                                        kisVouchersInfo5.FQty = kisVouchersInfo1.FQty;
                                        kisVouchersInfo5.FSerialNo = kisVouchersInfo1.FSerialNo;
                                        kisVouchersInfoList.Add(kisVouchersInfo5);
                                    }
                                    else
                                    {
                                        kisVouchersInfo11.FAcctID = kisVouchersInfo3.FAcctID;
                                        kisVouchersInfo11.FAttchment = kisVouchersInfo3.FAttchment;
                                        kisVouchersInfo11.FCredit = vouchers[i + 1].FCredit + kisVouchersInfo1.FCredit + kisVouchersInfo3.FCredit;
                                        kisVouchersInfo11.FCyID = kisVouchersInfo3.FCyID;
                                        kisVouchersInfo11.FDate = kisVouchersInfo3.FDate;
                                        kisVouchersInfo11.FDC = kisVouchersInfo3.FDC;
                                        kisVouchersInfo11.FDebit = vouchers[i + 1].FDebit + kisVouchersInfo1.FDebit + kisVouchersInfo3.FDebit;
                                        kisVouchersInfo11.FDeleted = kisVouchersInfo3.FDeleted;
                                        kisVouchersInfo11.FEntryID = 3;
                                        kisVouchersInfo11.FExchRate = kisVouchersInfo3.FExchRate;
                                        kisVouchersInfo11.FExp = null;
                                        kisVouchersInfo11.FFCyAmt = vouchers[i + 1].FFCyAmt + kisVouchersInfo1.FFCyAmt + kisVouchersInfo3.FFCyAmt;
                                        kisVouchersInfo11.FGroup = kisVouchersInfo3.FGroup;
                                        kisVouchersInfo11.FNum = kisVouchersInfo3.FNum;
                                        kisVouchersInfo11.FPeriod = kisVouchersInfo3.FPeriod;
                                        kisVouchersInfo11.FPosted = kisVouchersInfo3.FPosted;
                                        kisVouchersInfo11.FPrepare = kisVouchersInfo3.FPrepare;
                                        kisVouchersInfo11.FPrice = kisVouchersInfo3.FPrice;
                                        kisVouchersInfo11.FQty = kisVouchersInfo3.FQty;
                                        kisVouchersInfo11.FSerialNo = kisVouchersInfo3.FSerialNo;
                                        kisVouchersInfoList.Add(kisVouchersInfo11);
                                    }
                                }
                                else
                                {
                                    if (kisVouchersInfo1.FAcctID != null)
                                    {
                                        kisVouchersInfo12.FAcctID = kisVouchersInfo1.FAcctID;
                                        kisVouchersInfo12.FAttchment = kisVouchersInfo1.FAttchment;
                                        kisVouchersInfo12.FCredit = kisVouchersInfo1.FCredit + kisVouchersInfo3.FCredit;
                                        kisVouchersInfo12.FCyID = kisVouchersInfo1.FCyID;
                                        kisVouchersInfo12.FDate = kisVouchersInfo1.FDate;
                                        kisVouchersInfo12.FDC = kisVouchersInfo1.FDC;
                                        kisVouchersInfo12.FDebit = kisVouchersInfo1.FDebit + kisVouchersInfo3.FDebit;
                                        kisVouchersInfo12.FDeleted = kisVouchersInfo1.FDeleted;
                                        kisVouchersInfo12.FEntryID = 3;
                                        kisVouchersInfo12.FExchRate = kisVouchersInfo1.FExchRate;
                                        kisVouchersInfo12.FExp = null;
                                        kisVouchersInfo12.FFCyAmt = kisVouchersInfo1.FFCyAmt + kisVouchersInfo3.FFCyAmt;
                                        kisVouchersInfo12.FGroup = kisVouchersInfo1.FGroup;
                                        kisVouchersInfo12.FNum = kisVouchersInfo1.FNum;
                                        kisVouchersInfo12.FPeriod = kisVouchersInfo1.FPeriod;
                                        kisVouchersInfo12.FPosted = kisVouchersInfo1.FPosted;
                                        kisVouchersInfo12.FPrepare = kisVouchersInfo1.FPrepare;
                                        kisVouchersInfo12.FPrice = kisVouchersInfo1.FPrice;
                                        kisVouchersInfo12.FQty = kisVouchersInfo1.FQty;
                                        kisVouchersInfo12.FSerialNo = kisVouchersInfo1.FSerialNo;
                                        kisVouchersInfoList.Add(kisVouchersInfo12);
                                    }
                                    else
                                    {
                                        kisVouchersInfo13.FAcctID = kisVouchersInfo3.FAcctID;
                                        kisVouchersInfo13.FAttchment = kisVouchersInfo3.FAttchment;
                                        kisVouchersInfo13.FCredit = kisVouchersInfo1.FCredit + kisVouchersInfo3.FCredit;
                                        kisVouchersInfo13.FCyID = kisVouchersInfo3.FCyID;
                                        kisVouchersInfo13.FDate = kisVouchersInfo3.FDate;
                                        kisVouchersInfo13.FDC = kisVouchersInfo3.FDC;
                                        kisVouchersInfo13.FDebit = kisVouchersInfo1.FDebit + kisVouchersInfo3.FDebit;
                                        kisVouchersInfo13.FDeleted = kisVouchersInfo3.FDeleted;
                                        kisVouchersInfo13.FEntryID = 3;
                                        kisVouchersInfo13.FExchRate = kisVouchersInfo3.FExchRate;
                                        kisVouchersInfo13.FExp = null;
                                        kisVouchersInfo13.FFCyAmt = kisVouchersInfo1.FFCyAmt + kisVouchersInfo3.FFCyAmt;
                                        kisVouchersInfo13.FGroup = kisVouchersInfo3.FGroup;
                                        kisVouchersInfo13.FNum = kisVouchersInfo3.FNum;
                                        kisVouchersInfo13.FPeriod = kisVouchersInfo3.FPeriod;
                                        kisVouchersInfo13.FPosted = kisVouchersInfo3.FPosted;
                                        kisVouchersInfo13.FPrepare = kisVouchersInfo3.FPrepare;
                                        kisVouchersInfo13.FPrice = kisVouchersInfo3.FPrice;
                                        kisVouchersInfo13.FQty = kisVouchersInfo3.FQty;
                                        kisVouchersInfo13.FSerialNo = kisVouchersInfo3.FSerialNo;
                                        kisVouchersInfoList.Add(kisVouchersInfo13);
                                    }
                                }
                                if (i + 3 <= vouchers.Count)
                                {
                                    if (vouchers[i + 2].FEntryID == 2)
                                    {
                                        if (kisVouchersInfo2.FAcctID != null)
                                        {

                                            kisVouchersInfo6.FAcctID = kisVouchersInfo2.FAcctID;
                                            kisVouchersInfo6.FAttchment = kisVouchersInfo2.FAttchment;
                                            kisVouchersInfo6.FCredit = vouchers[i + 2].FCredit + kisVouchersInfo2.FCredit + kisVouchersInfo4.FCredit;
                                            kisVouchersInfo6.FCyID = kisVouchersInfo2.FCyID;
                                            kisVouchersInfo6.FDate = kisVouchersInfo2.FDate;
                                            kisVouchersInfo6.FDC = kisVouchersInfo2.FDC;
                                            kisVouchersInfo6.FDebit = vouchers[i + 2].FDebit + kisVouchersInfo2.FDebit + kisVouchersInfo4.FDebit;
                                            kisVouchersInfo6.FDeleted = kisVouchersInfo2.FDeleted;
                                            kisVouchersInfo6.FEntryID = 4;
                                            kisVouchersInfo6.FExchRate = kisVouchersInfo2.FExchRate;
                                            kisVouchersInfo6.FExp = null;
                                            kisVouchersInfo6.FFCyAmt = vouchers[i + 2].FFCyAmt + kisVouchersInfo2.FFCyAmt + kisVouchersInfo4.FFCyAmt;
                                            kisVouchersInfo6.FGroup = kisVouchersInfo2.FGroup;
                                            kisVouchersInfo6.FNum = kisVouchersInfo2.FNum;
                                            kisVouchersInfo6.FPeriod = kisVouchersInfo2.FPeriod;
                                            kisVouchersInfo6.FPosted = kisVouchersInfo2.FPosted;
                                            kisVouchersInfo6.FPrepare = kisVouchersInfo2.FPrepare;
                                            kisVouchersInfo6.FPrice = kisVouchersInfo2.FPrice;
                                            kisVouchersInfo6.FQty = kisVouchersInfo2.FQty;
                                            kisVouchersInfo6.FSerialNo = kisVouchersInfo2.FSerialNo;
                                            kisVouchersInfoList.Add(kisVouchersInfo6);
                                        }
                                        else
                                        {
                                            kisVouchersInfo14.FAcctID = kisVouchersInfo4.FAcctID;
                                            kisVouchersInfo14.FAttchment = kisVouchersInfo4.FAttchment;
                                            kisVouchersInfo14.FCredit = vouchers[i + 2].FCredit + kisVouchersInfo2.FCredit + kisVouchersInfo4.FCredit;
                                            kisVouchersInfo14.FCyID = kisVouchersInfo4.FCyID;
                                            kisVouchersInfo14.FDate = kisVouchersInfo4.FDate;
                                            kisVouchersInfo14.FDC = kisVouchersInfo4.FDC;
                                            kisVouchersInfo14.FDebit = vouchers[i + 2].FDebit + kisVouchersInfo2.FDebit + kisVouchersInfo4.FDebit;
                                            kisVouchersInfo14.FDeleted = kisVouchersInfo4.FDeleted;
                                            kisVouchersInfo14.FEntryID = 4;
                                            kisVouchersInfo14.FExchRate = kisVouchersInfo4.FExchRate;
                                            kisVouchersInfo14.FExp = null;
                                            kisVouchersInfo14.FFCyAmt = vouchers[i + 2].FFCyAmt + kisVouchersInfo2.FFCyAmt + kisVouchersInfo4.FFCyAmt;
                                            kisVouchersInfo14.FGroup = kisVouchersInfo4.FGroup;
                                            kisVouchersInfo14.FNum = kisVouchersInfo4.FNum;
                                            kisVouchersInfo14.FPeriod = kisVouchersInfo4.FPeriod;
                                            kisVouchersInfo14.FPosted = kisVouchersInfo4.FPosted;
                                            kisVouchersInfo14.FPrepare = kisVouchersInfo4.FPrepare;
                                            kisVouchersInfo14.FPrice = kisVouchersInfo4.FPrice;
                                            kisVouchersInfo14.FQty = kisVouchersInfo4.FQty;
                                            kisVouchersInfo14.FSerialNo = kisVouchersInfo4.FSerialNo;
                                            kisVouchersInfoList.Add(kisVouchersInfo14);
                                        }
                                    }
                                    else
                                    {
                                        if (kisVouchersInfo2.FAcctID != null)
                                        {
                                            kisVouchersInfo15.FAcctID = kisVouchersInfo2.FAcctID;
                                            kisVouchersInfo15.FAttchment = kisVouchersInfo2.FAttchment;
                                            kisVouchersInfo15.FCredit = kisVouchersInfo2.FCredit + kisVouchersInfo4.FCredit;
                                            kisVouchersInfo15.FCyID = kisVouchersInfo2.FCyID;
                                            kisVouchersInfo15.FDate = kisVouchersInfo2.FDate;
                                            kisVouchersInfo15.FDC = kisVouchersInfo2.FDC;
                                            kisVouchersInfo15.FDebit = kisVouchersInfo2.FDebit + kisVouchersInfo4.FDebit;
                                            kisVouchersInfo15.FDeleted = kisVouchersInfo2.FDeleted;
                                            kisVouchersInfo15.FEntryID = 4;
                                            kisVouchersInfo15.FExchRate = kisVouchersInfo2.FExchRate;
                                            kisVouchersInfo15.FExp = null;
                                            kisVouchersInfo15.FFCyAmt = kisVouchersInfo2.FFCyAmt + kisVouchersInfo4.FFCyAmt;
                                            kisVouchersInfo15.FGroup = kisVouchersInfo2.FGroup;
                                            kisVouchersInfo15.FNum = kisVouchersInfo2.FNum;
                                            kisVouchersInfo15.FPeriod = kisVouchersInfo2.FPeriod;
                                            kisVouchersInfo15.FPosted = kisVouchersInfo2.FPosted;
                                            kisVouchersInfo15.FPrepare = kisVouchersInfo2.FPrepare;
                                            kisVouchersInfo15.FPrice = kisVouchersInfo2.FPrice;
                                            kisVouchersInfo15.FQty = kisVouchersInfo2.FQty;
                                            kisVouchersInfo15.FSerialNo = kisVouchersInfo2.FSerialNo;
                                            kisVouchersInfoList.Add(kisVouchersInfo15);
                                        }
                                        else
                                        {
                                            kisVouchersInfo16.FAcctID = kisVouchersInfo4.FAcctID;
                                            kisVouchersInfo16.FAttchment = kisVouchersInfo4.FAttchment;
                                            kisVouchersInfo16.FCredit = +kisVouchersInfo2.FCredit + kisVouchersInfo4.FCredit;
                                            kisVouchersInfo16.FCyID = kisVouchersInfo4.FCyID;
                                            kisVouchersInfo16.FDate = kisVouchersInfo4.FDate;
                                            kisVouchersInfo16.FDC = kisVouchersInfo4.FDC;
                                            kisVouchersInfo16.FDebit = +kisVouchersInfo2.FDebit + kisVouchersInfo4.FDebit;
                                            kisVouchersInfo16.FDeleted = kisVouchersInfo4.FDeleted;
                                            kisVouchersInfo16.FEntryID = 4;
                                            kisVouchersInfo16.FExchRate = kisVouchersInfo4.FExchRate;
                                            kisVouchersInfo16.FExp = null;
                                            kisVouchersInfo16.FFCyAmt = +kisVouchersInfo2.FFCyAmt + kisVouchersInfo4.FFCyAmt;
                                            kisVouchersInfo16.FGroup = kisVouchersInfo4.FGroup;
                                            kisVouchersInfo16.FNum = kisVouchersInfo4.FNum;
                                            kisVouchersInfo16.FPeriod = kisVouchersInfo4.FPeriod;
                                            kisVouchersInfo16.FPosted = kisVouchersInfo4.FPosted;
                                            kisVouchersInfo16.FPrepare = kisVouchersInfo4.FPrepare;
                                            kisVouchersInfo16.FPrice = kisVouchersInfo4.FPrice;
                                            kisVouchersInfo16.FQty = kisVouchersInfo4.FQty;
                                            kisVouchersInfo16.FSerialNo = kisVouchersInfo4.FSerialNo;
                                            kisVouchersInfoList.Add(kisVouchersInfo16);
                                        }
                                    }
                                }
                                else
                                {
                                    if (kisVouchersInfo2.FAcctID != null)
                                    {
                                        kisVouchersInfo15.FAcctID = kisVouchersInfo2.FAcctID;
                                        kisVouchersInfo15.FAttchment = kisVouchersInfo2.FAttchment;
                                        kisVouchersInfo15.FCredit = kisVouchersInfo2.FCredit + kisVouchersInfo4.FCredit;
                                        kisVouchersInfo15.FCyID = kisVouchersInfo2.FCyID;
                                        kisVouchersInfo15.FDate = kisVouchersInfo2.FDate;
                                        kisVouchersInfo15.FDC = kisVouchersInfo2.FDC;
                                        kisVouchersInfo15.FDebit = kisVouchersInfo2.FDebit + kisVouchersInfo4.FDebit;
                                        kisVouchersInfo15.FDeleted = kisVouchersInfo2.FDeleted;
                                        kisVouchersInfo15.FEntryID = 4;
                                        kisVouchersInfo15.FExchRate = kisVouchersInfo2.FExchRate;
                                        kisVouchersInfo15.FExp = null;
                                        kisVouchersInfo15.FFCyAmt = kisVouchersInfo2.FFCyAmt + kisVouchersInfo4.FFCyAmt;
                                        kisVouchersInfo15.FGroup = kisVouchersInfo2.FGroup;
                                        kisVouchersInfo15.FNum = kisVouchersInfo2.FNum;
                                        kisVouchersInfo15.FPeriod = kisVouchersInfo2.FPeriod;
                                        kisVouchersInfo15.FPosted = kisVouchersInfo2.FPosted;
                                        kisVouchersInfo15.FPrepare = kisVouchersInfo2.FPrepare;
                                        kisVouchersInfo15.FPrice = kisVouchersInfo2.FPrice;
                                        kisVouchersInfo15.FQty = kisVouchersInfo2.FQty;
                                        kisVouchersInfo15.FSerialNo = kisVouchersInfo2.FSerialNo;
                                        kisVouchersInfoList.Add(kisVouchersInfo15);
                                    }
                                    else
                                    {
                                        kisVouchersInfo16.FAcctID = kisVouchersInfo4.FAcctID;
                                        kisVouchersInfo16.FAttchment = kisVouchersInfo4.FAttchment;
                                        kisVouchersInfo16.FCredit = +kisVouchersInfo2.FCredit + kisVouchersInfo4.FCredit;
                                        kisVouchersInfo16.FCyID = kisVouchersInfo4.FCyID;
                                        kisVouchersInfo16.FDate = kisVouchersInfo4.FDate;
                                        kisVouchersInfo16.FDC = kisVouchersInfo4.FDC;
                                        kisVouchersInfo16.FDebit = +kisVouchersInfo2.FDebit + kisVouchersInfo4.FDebit;
                                        kisVouchersInfo16.FDeleted = kisVouchersInfo4.FDeleted;
                                        kisVouchersInfo16.FEntryID = 4;
                                        kisVouchersInfo16.FExchRate = kisVouchersInfo4.FExchRate;
                                        kisVouchersInfo16.FExp = null;
                                        kisVouchersInfo16.FFCyAmt = +kisVouchersInfo2.FFCyAmt + kisVouchersInfo4.FFCyAmt;
                                        kisVouchersInfo16.FGroup = kisVouchersInfo4.FGroup;
                                        kisVouchersInfo16.FNum = kisVouchersInfo4.FNum;
                                        kisVouchersInfo16.FPeriod = kisVouchersInfo4.FPeriod;
                                        kisVouchersInfo16.FPosted = kisVouchersInfo4.FPosted;
                                        kisVouchersInfo16.FPrepare = kisVouchersInfo4.FPrepare;
                                        kisVouchersInfo16.FPrice = kisVouchersInfo4.FPrice;
                                        kisVouchersInfo16.FQty = kisVouchersInfo4.FQty;
                                        kisVouchersInfo16.FSerialNo = kisVouchersInfo4.FSerialNo;
                                        kisVouchersInfoList.Add(kisVouchersInfo16);
                                    }
                                }
                            }
                        }
                    }

                    foreach (KisVouchersInfo kvi in kisVouchersInfoList)
                    {
                        if (kvi.FEntryID == 0)
                        {
                            if (maxFSerialNum < 0)
                            {
                                maxFSerialNum = this.getMaxFSerialNum();
                                maxFSerialNum++;
                            }
                            else
                            {
                                maxFSerialNum++;
                            }

                            if (maxFNum < 0)
                            {
                                maxFNum = this.getMaxFNum(kvi.FPeriod, kvi.FGroup);
                                maxFNum++;
                            }
                            else
                            {
                                maxFNum++;
                            }
                        }
                        String sql = this.build3ItemSql(kvi, maxFSerialNum, maxFNum);
                        if (sql != null && sql != "") sqls.Add(sql);
                    }
                }
                //
                //销项3张凭证合为一张end
                //
                //银行3张凭证合为一张凭证start
                //
                if (vouchernumber == "three")
                {
                    List<KisVouchersInfo> kisVouchersInfoList = new List<KisVouchersInfo>();
                    int number = -1;

                    for (int i = 0; i < vouchers.Count; i++)
                    {

                        if (vouchers[i].FEntryID == 0)
                        {
                            number++;
                            if (number == 3)
                            {
                                number = 0;
                            }
                        }
                        KisVouchersInfo kisVouchersInfo1 = new KisVouchersInfo();
                        KisVouchersInfo kisVouchersInfo2 = new KisVouchersInfo();
                        KisVouchersInfo kisVouchersInfo3 = new KisVouchersInfo();
                        if (vouchers[i].FEntryID == 0 && number == 0)
                        {

                            if (vouchers[i].FEntryID == 0)
                            {

                                KisVouchersInfo kisVouchersInfo = new KisVouchersInfo();
                                kisVouchersInfo.FAcctID = vouchers[i].FAcctID;
                                kisVouchersInfo.FAttchment = vouchers[i].FAttchment;
                                kisVouchersInfo.FCredit = vouchers[i].FCredit;
                                kisVouchersInfo.FCyID = vouchers[i].FCyID;
                                kisVouchersInfo.FDate = vouchers[i].FDate;
                                kisVouchersInfo.FDC = vouchers[i].FDC;
                                kisVouchersInfo.FDebit = vouchers[i].FDebit;
                                kisVouchersInfo.FDeleted = vouchers[i].FDeleted;
                                kisVouchersInfo.FEntryID = 0;
                                kisVouchersInfo.FExchRate = vouchers[i].FExchRate;
                                kisVouchersInfo.FExp = vouchers[i].FExp;
                                kisVouchersInfo.FFCyAmt = vouchers[i].FFCyAmt;
                                kisVouchersInfo.FGroup = vouchers[i].FGroup;
                                kisVouchersInfo.FNum = vouchers[i].FNum;
                                kisVouchersInfo.FPeriod = vouchers[i].FPeriod;
                                kisVouchersInfo.FPosted = vouchers[i].FPosted;
                                kisVouchersInfo.FPrepare = vouchers[i].FPrepare;
                                kisVouchersInfo.FPrice = vouchers[i].FPrice;
                                kisVouchersInfo.FQty = vouchers[i].FQty;
                                kisVouchersInfo.FSerialNo = vouchers[i].FSerialNo;
                                kisVouchersInfoList.Add(kisVouchersInfo);

                            }

                            if (vouchers[i + 1].FEntryID == 1)
                            {
                                kisVouchersInfo1.FAcctID = vouchers[i + 1].FAcctID;
                                kisVouchersInfo1.FAttchment = vouchers[i + 1].FAttchment;
                                kisVouchersInfo1.FCredit = vouchers[i + 1].FCredit;
                                kisVouchersInfo1.FCyID = vouchers[i + 1].FCyID;
                                kisVouchersInfo1.FDate = vouchers[i + 1].FDate;
                                kisVouchersInfo1.FDC = vouchers[i + 1].FDC;
                                kisVouchersInfo1.FDebit = vouchers[i + 1].FDebit;
                                kisVouchersInfo1.FDeleted = vouchers[i + 1].FDeleted;
                                kisVouchersInfo1.FEntryID = 1;
                                kisVouchersInfo1.FExchRate = vouchers[i + 1].FExchRate;
                                kisVouchersInfo1.FExp = null;
                                kisVouchersInfo1.FFCyAmt = vouchers[i + 1].FFCyAmt;
                                kisVouchersInfo1.FGroup = vouchers[i + 1].FGroup;
                                kisVouchersInfo1.FNum = vouchers[i + 1].FNum;
                                kisVouchersInfo1.FPeriod = vouchers[i + 1].FPeriod;
                                kisVouchersInfo1.FPosted = vouchers[i + 1].FPosted;
                                kisVouchersInfo1.FPrepare = vouchers[i + 1].FPrepare;
                                kisVouchersInfo1.FPrice = vouchers[i + 1].FPrice;
                                kisVouchersInfo1.FQty = vouchers[i + 1].FQty;
                                kisVouchersInfo1.FSerialNo = vouchers[i + 1].FSerialNo;
                                kisVouchersInfoList.Add(kisVouchersInfo1);

                            }

                            if (i + 3 <= vouchers.Count)
                            {
                                if (vouchers[i + 2].FEntryID == 2)
                                {
                                    kisVouchersInfo2.FAcctID = vouchers[i + 2].FAcctID;
                                    kisVouchersInfo2.FAttchment = vouchers[i + 2].FAttchment;
                                    kisVouchersInfo2.FCredit = vouchers[i + 2].FCredit;
                                    kisVouchersInfo2.FCyID = vouchers[i + 2].FCyID;
                                    kisVouchersInfo2.FDate = vouchers[i + 2].FDate;
                                    kisVouchersInfo2.FDC = vouchers[i + 2].FDC;
                                    kisVouchersInfo2.FDebit = vouchers[i + 2].FDebit;
                                    kisVouchersInfo2.FDeleted = vouchers[i + 2].FDeleted;
                                    kisVouchersInfo2.FEntryID = 2;
                                    kisVouchersInfo2.FExchRate = vouchers[i + 2].FExchRate;
                                    kisVouchersInfo2.FExp = null;
                                    kisVouchersInfo2.FFCyAmt = vouchers[i + 2].FFCyAmt;
                                    kisVouchersInfo2.FGroup = vouchers[i + 2].FGroup;
                                    kisVouchersInfo2.FNum = vouchers[i + 2].FNum;
                                    kisVouchersInfo2.FPeriod = vouchers[i + 2].FPeriod;
                                    kisVouchersInfo2.FPosted = vouchers[i + 2].FPosted;
                                    kisVouchersInfo2.FPrepare = vouchers[i + 2].FPrepare;
                                    kisVouchersInfo2.FPrice = vouchers[i + 2].FPrice;
                                    kisVouchersInfo2.FQty = vouchers[i + 2].FQty;
                                    kisVouchersInfo2.FSerialNo = vouchers[i + 2].FSerialNo;
                                    kisVouchersInfoList.Add(kisVouchersInfo2);
                                }
                            }

                            if (i + 4 <= vouchers.Count)
                            {
                                if (vouchers[i + 3].FEntryID == 3)
                                {
                                    kisVouchersInfo3.FAcctID = vouchers[i + 3].FAcctID;
                                    kisVouchersInfo3.FAttchment = vouchers[i + 3].FAttchment;
                                    kisVouchersInfo3.FCredit = vouchers[i + 3].FCredit;
                                    kisVouchersInfo3.FCyID = vouchers[i + 3].FCyID;
                                    kisVouchersInfo3.FDate = vouchers[i + 3].FDate;
                                    kisVouchersInfo3.FDC = vouchers[i + 3].FDC;
                                    kisVouchersInfo3.FDebit = vouchers[i + 3].FDebit;
                                    kisVouchersInfo3.FDeleted = vouchers[i + 3].FDeleted;
                                    kisVouchersInfo3.FEntryID = 3;
                                    kisVouchersInfo3.FExchRate = vouchers[i + 3].FExchRate;
                                    kisVouchersInfo3.FExp = null;
                                    kisVouchersInfo3.FFCyAmt = vouchers[i + 3].FFCyAmt;
                                    kisVouchersInfo3.FGroup = vouchers[i + 3].FGroup;
                                    kisVouchersInfo3.FNum = vouchers[i + 3].FNum;
                                    kisVouchersInfo3.FPeriod = vouchers[i + 3].FPeriod;
                                    kisVouchersInfo3.FPosted = vouchers[i + 3].FPosted;
                                    kisVouchersInfo3.FPrepare = vouchers[i + 3].FPrepare;
                                    kisVouchersInfo3.FPrice = vouchers[i + 3].FPrice;
                                    kisVouchersInfo3.FQty = vouchers[i + 3].FQty;
                                    kisVouchersInfo3.FSerialNo = vouchers[i + 3].FSerialNo;
                                    kisVouchersInfoList.Add(kisVouchersInfo3);
                                }
                            }
                        }
                        if (vouchers[i].FEntryID == 0 && number == 1)
                        {

                            if (vouchers[i].FEntryID == 0)
                            {

                                KisVouchersInfo kisVouchersInfo = new KisVouchersInfo();
                                kisVouchersInfo.FAcctID = vouchers[i].FAcctID;
                                kisVouchersInfo.FAttchment = vouchers[i].FAttchment;
                                kisVouchersInfo.FCredit = vouchers[i].FCredit;
                                kisVouchersInfo.FCyID = vouchers[i].FCyID;
                                kisVouchersInfo.FDate = vouchers[i].FDate;
                                kisVouchersInfo.FDC = vouchers[i].FDC;
                                kisVouchersInfo.FDebit = vouchers[i].FDebit;
                                kisVouchersInfo.FDeleted = vouchers[i].FDeleted;
                                kisVouchersInfo.FEntryID = vouchers[i - 1].FEntryID + 1;
                                kisVouchersInfo.FExchRate = vouchers[i].FExchRate;
                                kisVouchersInfo.FExp = vouchers[i].FExp;
                                kisVouchersInfo.FFCyAmt = vouchers[i].FFCyAmt;
                                kisVouchersInfo.FGroup = vouchers[i].FGroup;
                                kisVouchersInfo.FNum = vouchers[i].FNum;
                                kisVouchersInfo.FPeriod = vouchers[i].FPeriod;
                                kisVouchersInfo.FPosted = vouchers[i].FPosted;
                                kisVouchersInfo.FPrepare = vouchers[i].FPrepare;
                                kisVouchersInfo.FPrice = vouchers[i].FPrice;
                                kisVouchersInfo.FQty = vouchers[i].FQty;
                                kisVouchersInfo.FSerialNo = vouchers[i].FSerialNo;
                                kisVouchersInfoList.Add(kisVouchersInfo);

                            }

                            if (vouchers[i + 1].FEntryID == 1)
                            {
                                kisVouchersInfo1.FAcctID = vouchers[i + 1].FAcctID;
                                kisVouchersInfo1.FAttchment = vouchers[i + 1].FAttchment;
                                kisVouchersInfo1.FCredit = vouchers[i + 1].FCredit;
                                kisVouchersInfo1.FCyID = vouchers[i + 1].FCyID;
                                kisVouchersInfo1.FDate = vouchers[i + 1].FDate;
                                kisVouchersInfo1.FDC = vouchers[i + 1].FDC;
                                kisVouchersInfo1.FDebit = vouchers[i + 1].FDebit;
                                kisVouchersInfo1.FDeleted = vouchers[i + 1].FDeleted;
                                kisVouchersInfo1.FEntryID = vouchers[i - 1].FEntryID + 2;
                                kisVouchersInfo1.FExchRate = vouchers[i + 1].FExchRate;
                                kisVouchersInfo1.FExp = null;
                                kisVouchersInfo1.FFCyAmt = vouchers[i + 1].FFCyAmt;
                                kisVouchersInfo1.FGroup = vouchers[i + 1].FGroup;
                                kisVouchersInfo1.FNum = vouchers[i + 1].FNum;
                                kisVouchersInfo1.FPeriod = vouchers[i + 1].FPeriod;
                                kisVouchersInfo1.FPosted = vouchers[i + 1].FPosted;
                                kisVouchersInfo1.FPrepare = vouchers[i + 1].FPrepare;
                                kisVouchersInfo1.FPrice = vouchers[i + 1].FPrice;
                                kisVouchersInfo1.FQty = vouchers[i + 1].FQty;
                                kisVouchersInfo1.FSerialNo = vouchers[i + 1].FSerialNo;
                                kisVouchersInfoList.Add(kisVouchersInfo1);

                            }
                            if (i + 3 <= vouchers.Count)
                            {
                                if (vouchers[i + 2].FEntryID == 2)
                                {
                                    kisVouchersInfo2.FAcctID = vouchers[i + 2].FAcctID;
                                    kisVouchersInfo2.FAttchment = vouchers[i + 2].FAttchment;
                                    kisVouchersInfo2.FCredit = vouchers[i + 2].FCredit;
                                    kisVouchersInfo2.FCyID = vouchers[i + 2].FCyID;
                                    kisVouchersInfo2.FDate = vouchers[i + 2].FDate;
                                    kisVouchersInfo2.FDC = vouchers[i + 2].FDC;
                                    kisVouchersInfo2.FDebit = vouchers[i + 2].FDebit;
                                    kisVouchersInfo2.FDeleted = vouchers[i + 2].FDeleted;
                                    kisVouchersInfo2.FEntryID = vouchers[i - 1].FEntryID + 3;
                                    kisVouchersInfo2.FExchRate = vouchers[i + 2].FExchRate;
                                    kisVouchersInfo2.FExp = null;
                                    kisVouchersInfo2.FFCyAmt = vouchers[i + 2].FFCyAmt;
                                    kisVouchersInfo2.FGroup = vouchers[i + 2].FGroup;
                                    kisVouchersInfo2.FNum = vouchers[i + 2].FNum;
                                    kisVouchersInfo2.FPeriod = vouchers[i + 2].FPeriod;
                                    kisVouchersInfo2.FPosted = vouchers[i + 2].FPosted;
                                    kisVouchersInfo2.FPrepare = vouchers[i + 2].FPrepare;
                                    kisVouchersInfo2.FPrice = vouchers[i + 2].FPrice;
                                    kisVouchersInfo2.FQty = vouchers[i + 2].FQty;
                                    kisVouchersInfo2.FSerialNo = vouchers[i + 2].FSerialNo;
                                    kisVouchersInfoList.Add(kisVouchersInfo2);
                                }
                            }

                            if (i + 4 <= vouchers.Count)
                            {
                                if (vouchers[i + 3].FEntryID == 3)
                                {
                                    kisVouchersInfo3.FAcctID = vouchers[i + 3].FAcctID;
                                    kisVouchersInfo3.FAttchment = vouchers[i + 3].FAttchment;
                                    kisVouchersInfo3.FCredit = vouchers[i + 3].FCredit;
                                    kisVouchersInfo3.FCyID = vouchers[i + 3].FCyID;
                                    kisVouchersInfo3.FDate = vouchers[i + 3].FDate;
                                    kisVouchersInfo3.FDC = vouchers[i + 3].FDC;
                                    kisVouchersInfo3.FDebit = vouchers[i + 3].FDebit;
                                    kisVouchersInfo3.FDeleted = vouchers[i + 3].FDeleted;
                                    kisVouchersInfo3.FEntryID = vouchers[i - 1].FEntryID + 4;
                                    kisVouchersInfo3.FExchRate = vouchers[i + 3].FExchRate;
                                    kisVouchersInfo3.FExp = null;
                                    kisVouchersInfo3.FFCyAmt = vouchers[i + 3].FFCyAmt;
                                    kisVouchersInfo3.FGroup = vouchers[i + 3].FGroup;
                                    kisVouchersInfo3.FNum = vouchers[i + 3].FNum;
                                    kisVouchersInfo3.FPeriod = vouchers[i + 3].FPeriod;
                                    kisVouchersInfo3.FPosted = vouchers[i + 3].FPosted;
                                    kisVouchersInfo3.FPrepare = vouchers[i + 3].FPrepare;
                                    kisVouchersInfo3.FPrice = vouchers[i + 3].FPrice;
                                    kisVouchersInfo3.FQty = vouchers[i + 3].FQty;
                                    kisVouchersInfo3.FSerialNo = vouchers[i + 3].FSerialNo;
                                    kisVouchersInfoList.Add(kisVouchersInfo3);
                                }
                            }
                        }
                        if (vouchers[i].FEntryID == 0 && number == 2)
                        {

                            if (vouchers[i].FEntryID == 0)
                            {

                                KisVouchersInfo kisVouchersInfo = new KisVouchersInfo();
                                kisVouchersInfo.FAcctID = vouchers[i].FAcctID;
                                kisVouchersInfo.FAttchment = vouchers[i].FAttchment;
                                kisVouchersInfo.FCredit = vouchers[i].FCredit;
                                kisVouchersInfo.FCyID = vouchers[i].FCyID;
                                kisVouchersInfo.FDate = vouchers[i].FDate;
                                kisVouchersInfo.FDC = vouchers[i].FDC;
                                kisVouchersInfo.FDebit = vouchers[i].FDebit;
                                kisVouchersInfo.FDeleted = vouchers[i].FDeleted;
                                kisVouchersInfo.FEntryID = vouchers[i - 1].FEntryID + vouchers[i - vouchers[i - 1].FEntryID - 2].FEntryID + 2;
                                kisVouchersInfo.FExchRate = vouchers[i].FExchRate;
                                kisVouchersInfo.FExp = vouchers[i].FExp;
                                kisVouchersInfo.FFCyAmt = vouchers[i].FFCyAmt;
                                kisVouchersInfo.FGroup = vouchers[i].FGroup;
                                kisVouchersInfo.FNum = vouchers[i].FNum;
                                kisVouchersInfo.FPeriod = vouchers[i].FPeriod;
                                kisVouchersInfo.FPosted = vouchers[i].FPosted;
                                kisVouchersInfo.FPrepare = vouchers[i].FPrepare;
                                kisVouchersInfo.FPrice = vouchers[i].FPrice;
                                kisVouchersInfo.FQty = vouchers[i].FQty;
                                kisVouchersInfo.FSerialNo = vouchers[i].FSerialNo;
                                kisVouchersInfoList.Add(kisVouchersInfo);

                            }

                            if (vouchers[i + 1].FEntryID == 1)
                            {
                                kisVouchersInfo1.FAcctID = vouchers[i + 1].FAcctID;
                                kisVouchersInfo1.FAttchment = vouchers[i + 1].FAttchment;
                                kisVouchersInfo1.FCredit = vouchers[i + 1].FCredit;
                                kisVouchersInfo1.FCyID = vouchers[i + 1].FCyID;
                                kisVouchersInfo1.FDate = vouchers[i + 1].FDate;
                                kisVouchersInfo1.FDC = vouchers[i + 1].FDC;
                                kisVouchersInfo1.FDebit = vouchers[i + 1].FDebit;
                                kisVouchersInfo1.FDeleted = vouchers[i + 1].FDeleted;
                                kisVouchersInfo1.FEntryID = vouchers[i - 1].FEntryID + vouchers[i - vouchers[i - 1].FEntryID - 2].FEntryID + 3;
                                kisVouchersInfo1.FExchRate = vouchers[i + 1].FExchRate;
                                kisVouchersInfo1.FExp = null;
                                kisVouchersInfo1.FFCyAmt = vouchers[i + 1].FFCyAmt;
                                kisVouchersInfo1.FGroup = vouchers[i + 1].FGroup;
                                kisVouchersInfo1.FNum = vouchers[i + 1].FNum;
                                kisVouchersInfo1.FPeriod = vouchers[i + 1].FPeriod;
                                kisVouchersInfo1.FPosted = vouchers[i + 1].FPosted;
                                kisVouchersInfo1.FPrepare = vouchers[i + 1].FPrepare;
                                kisVouchersInfo1.FPrice = vouchers[i + 1].FPrice;
                                kisVouchersInfo1.FQty = vouchers[i + 1].FQty;
                                kisVouchersInfo1.FSerialNo = vouchers[i + 1].FSerialNo;
                                kisVouchersInfoList.Add(kisVouchersInfo1);

                            }
                            if (i + 3 <= vouchers.Count)
                            {
                                if (vouchers[i + 2].FEntryID == 2)
                                {
                                    kisVouchersInfo2.FAcctID = vouchers[i + 2].FAcctID;
                                    kisVouchersInfo2.FAttchment = vouchers[i + 2].FAttchment;
                                    kisVouchersInfo2.FCredit = vouchers[i + 2].FCredit;
                                    kisVouchersInfo2.FCyID = vouchers[i + 2].FCyID;
                                    kisVouchersInfo2.FDate = vouchers[i + 2].FDate;
                                    kisVouchersInfo2.FDC = vouchers[i + 2].FDC;
                                    kisVouchersInfo2.FDebit = vouchers[i + 2].FDebit;
                                    kisVouchersInfo2.FDeleted = vouchers[i + 2].FDeleted;
                                    kisVouchersInfo2.FEntryID = vouchers[i - 1].FEntryID + vouchers[i - vouchers[i - 1].FEntryID - 2].FEntryID + 4;
                                    kisVouchersInfo2.FExchRate = vouchers[i + 2].FExchRate;
                                    kisVouchersInfo2.FExp = null;
                                    kisVouchersInfo2.FFCyAmt = vouchers[i + 2].FFCyAmt;
                                    kisVouchersInfo2.FGroup = vouchers[i + 2].FGroup;
                                    kisVouchersInfo2.FNum = vouchers[i + 2].FNum;
                                    kisVouchersInfo2.FPeriod = vouchers[i + 2].FPeriod;
                                    kisVouchersInfo2.FPosted = vouchers[i + 2].FPosted;
                                    kisVouchersInfo2.FPrepare = vouchers[i + 2].FPrepare;
                                    kisVouchersInfo2.FPrice = vouchers[i + 2].FPrice;
                                    kisVouchersInfo2.FQty = vouchers[i + 2].FQty;
                                    kisVouchersInfo2.FSerialNo = vouchers[i + 2].FSerialNo;
                                    kisVouchersInfoList.Add(kisVouchersInfo2);
                                }
                            }

                            if (i + 3 <= vouchers.Count)
                            {
                                if (vouchers[i + 3].FEntryID == 3)
                                {
                                    kisVouchersInfo3.FAcctID = vouchers[i + 3].FAcctID;
                                    kisVouchersInfo3.FAttchment = vouchers[i + 3].FAttchment;
                                    kisVouchersInfo3.FCredit = vouchers[i + 3].FCredit;
                                    kisVouchersInfo3.FCyID = vouchers[i + 3].FCyID;
                                    kisVouchersInfo3.FDate = vouchers[i + 3].FDate;
                                    kisVouchersInfo3.FDC = vouchers[i + 3].FDC;
                                    kisVouchersInfo3.FDebit = vouchers[i + 3].FDebit;
                                    kisVouchersInfo3.FDeleted = vouchers[i + 3].FDeleted;
                                    kisVouchersInfo3.FEntryID = vouchers[i - 1].FEntryID + vouchers[i - vouchers[i - 1].FEntryID - 2].FEntryID + 5;
                                    kisVouchersInfo3.FExchRate = vouchers[i + 3].FExchRate;
                                    kisVouchersInfo3.FExp = null;
                                    kisVouchersInfo3.FFCyAmt = vouchers[i + 3].FFCyAmt;
                                    kisVouchersInfo3.FGroup = vouchers[i + 3].FGroup;
                                    kisVouchersInfo3.FNum = vouchers[i + 3].FNum;
                                    kisVouchersInfo3.FPeriod = vouchers[i + 3].FPeriod;
                                    kisVouchersInfo3.FPosted = vouchers[i + 3].FPosted;
                                    kisVouchersInfo3.FPrepare = vouchers[i + 3].FPrepare;
                                    kisVouchersInfo3.FPrice = vouchers[i + 3].FPrice;
                                    kisVouchersInfo3.FQty = vouchers[i + 3].FQty;
                                    kisVouchersInfo3.FSerialNo = vouchers[i + 3].FSerialNo;
                                    kisVouchersInfoList.Add(kisVouchersInfo3);
                                }
                            }
                        }
                    }
                    foreach (KisVouchersInfo kvi in kisVouchersInfoList)
                    {
                        if (kvi.FEntryID == 0)
                        {
                            if (maxFSerialNum < 0)
                            {
                                maxFSerialNum = this.getMaxFSerialNum();
                                maxFSerialNum++;
                            }
                            else
                            {
                                maxFSerialNum++;
                            }

                            if (maxFNum < 0)
                            {
                                maxFNum = this.getMaxFNum(kvi.FPeriod, kvi.FGroup);
                                maxFNum++;
                            }
                            else
                            {
                                maxFNum++;
                            }
                        }
                        String sql = this.build3ItemSql(kvi, maxFSerialNum, maxFNum);
                        if (sql != null && sql != "") sqls.Add(sql);
                    }
                }

                //
                //银行2张凭证合为一张凭证start
                //
                if (vouchernumber == "two")
                {
                    List<KisVouchersInfo> kisVouchersInfoList = new List<KisVouchersInfo>();
                    int number = -1;

                    for (int i = 0; i < vouchers.Count; i++)
                    {

                        if (vouchers[i].FEntryID == 0)
                        {
                            number++;
                            if (number == 2)
                            {
                                number = 0;
                            }
                        }
                        KisVouchersInfo kisVouchersInfo1 = new KisVouchersInfo();
                        KisVouchersInfo kisVouchersInfo2 = new KisVouchersInfo();
                        KisVouchersInfo kisVouchersInfo3 = new KisVouchersInfo();
                        if (vouchers[i].FEntryID == 0 && number == 0)
                        {

                            if (vouchers[i].FEntryID == 0)
                            {

                                KisVouchersInfo kisVouchersInfo = new KisVouchersInfo();
                                kisVouchersInfo.FAcctID = vouchers[i].FAcctID;
                                kisVouchersInfo.FAttchment = vouchers[i].FAttchment;
                                kisVouchersInfo.FCredit = vouchers[i].FCredit;
                                kisVouchersInfo.FCyID = vouchers[i].FCyID;
                                kisVouchersInfo.FDate = vouchers[i].FDate;
                                kisVouchersInfo.FDC = vouchers[i].FDC;
                                kisVouchersInfo.FDebit = vouchers[i].FDebit;
                                kisVouchersInfo.FDeleted = vouchers[i].FDeleted;
                                kisVouchersInfo.FEntryID = 0;
                                kisVouchersInfo.FExchRate = vouchers[i].FExchRate;
                                kisVouchersInfo.FExp = vouchers[i].FExp;
                                kisVouchersInfo.FFCyAmt = vouchers[i].FFCyAmt;
                                kisVouchersInfo.FGroup = vouchers[i].FGroup;
                                kisVouchersInfo.FNum = vouchers[i].FNum;
                                kisVouchersInfo.FPeriod = vouchers[i].FPeriod;
                                kisVouchersInfo.FPosted = vouchers[i].FPosted;
                                kisVouchersInfo.FPrepare = vouchers[i].FPrepare;
                                kisVouchersInfo.FPrice = vouchers[i].FPrice;
                                kisVouchersInfo.FQty = vouchers[i].FQty;
                                kisVouchersInfo.FSerialNo = vouchers[i].FSerialNo;
                                kisVouchersInfoList.Add(kisVouchersInfo);

                            }

                            if (vouchers[i + 1].FEntryID == 1)
                            {
                                kisVouchersInfo1.FAcctID = vouchers[i + 1].FAcctID;
                                kisVouchersInfo1.FAttchment = vouchers[i + 1].FAttchment;
                                kisVouchersInfo1.FCredit = vouchers[i + 1].FCredit;
                                kisVouchersInfo1.FCyID = vouchers[i + 1].FCyID;
                                kisVouchersInfo1.FDate = vouchers[i + 1].FDate;
                                kisVouchersInfo1.FDC = vouchers[i + 1].FDC;
                                kisVouchersInfo1.FDebit = vouchers[i + 1].FDebit;
                                kisVouchersInfo1.FDeleted = vouchers[i + 1].FDeleted;
                                kisVouchersInfo1.FEntryID = 1;
                                kisVouchersInfo1.FExchRate = vouchers[i + 1].FExchRate;
                                kisVouchersInfo1.FExp = null;
                                kisVouchersInfo1.FFCyAmt = vouchers[i + 1].FFCyAmt;
                                kisVouchersInfo1.FGroup = vouchers[i + 1].FGroup;
                                kisVouchersInfo1.FNum = vouchers[i + 1].FNum;
                                kisVouchersInfo1.FPeriod = vouchers[i + 1].FPeriod;
                                kisVouchersInfo1.FPosted = vouchers[i + 1].FPosted;
                                kisVouchersInfo1.FPrepare = vouchers[i + 1].FPrepare;
                                kisVouchersInfo1.FPrice = vouchers[i + 1].FPrice;
                                kisVouchersInfo1.FQty = vouchers[i + 1].FQty;
                                kisVouchersInfo1.FSerialNo = vouchers[i + 1].FSerialNo;
                                kisVouchersInfoList.Add(kisVouchersInfo1);

                            }

                            if (i + 3 <= vouchers.Count)
                            {
                                if (vouchers[i + 2].FEntryID == 2)
                                {
                                    kisVouchersInfo2.FAcctID = vouchers[i + 2].FAcctID;
                                    kisVouchersInfo2.FAttchment = vouchers[i + 2].FAttchment;
                                    kisVouchersInfo2.FCredit = vouchers[i + 2].FCredit;
                                    kisVouchersInfo2.FCyID = vouchers[i + 2].FCyID;
                                    kisVouchersInfo2.FDate = vouchers[i + 2].FDate;
                                    kisVouchersInfo2.FDC = vouchers[i + 2].FDC;
                                    kisVouchersInfo2.FDebit = vouchers[i + 2].FDebit;
                                    kisVouchersInfo2.FDeleted = vouchers[i + 2].FDeleted;
                                    kisVouchersInfo2.FEntryID = 2;
                                    kisVouchersInfo2.FExchRate = vouchers[i + 2].FExchRate;
                                    kisVouchersInfo2.FExp = null;
                                    kisVouchersInfo2.FFCyAmt = vouchers[i + 2].FFCyAmt;
                                    kisVouchersInfo2.FGroup = vouchers[i + 2].FGroup;
                                    kisVouchersInfo2.FNum = vouchers[i + 2].FNum;
                                    kisVouchersInfo2.FPeriod = vouchers[i + 2].FPeriod;
                                    kisVouchersInfo2.FPosted = vouchers[i + 2].FPosted;
                                    kisVouchersInfo2.FPrepare = vouchers[i + 2].FPrepare;
                                    kisVouchersInfo2.FPrice = vouchers[i + 2].FPrice;
                                    kisVouchersInfo2.FQty = vouchers[i + 2].FQty;
                                    kisVouchersInfo2.FSerialNo = vouchers[i + 2].FSerialNo;
                                    kisVouchersInfoList.Add(kisVouchersInfo2);
                                }
                            }

                            if (i + 4 <= vouchers.Count)
                            {
                                if (vouchers[i + 3].FEntryID == 3)
                                {
                                    kisVouchersInfo3.FAcctID = vouchers[i + 3].FAcctID;
                                    kisVouchersInfo3.FAttchment = vouchers[i + 3].FAttchment;
                                    kisVouchersInfo3.FCredit = vouchers[i + 3].FCredit;
                                    kisVouchersInfo3.FCyID = vouchers[i + 3].FCyID;
                                    kisVouchersInfo3.FDate = vouchers[i + 3].FDate;
                                    kisVouchersInfo3.FDC = vouchers[i + 3].FDC;
                                    kisVouchersInfo3.FDebit = vouchers[i + 3].FDebit;
                                    kisVouchersInfo3.FDeleted = vouchers[i + 3].FDeleted;
                                    kisVouchersInfo3.FEntryID = 3;
                                    kisVouchersInfo3.FExchRate = vouchers[i + 3].FExchRate;
                                    kisVouchersInfo3.FExp = null;
                                    kisVouchersInfo3.FFCyAmt = vouchers[i + 3].FFCyAmt;
                                    kisVouchersInfo3.FGroup = vouchers[i + 3].FGroup;
                                    kisVouchersInfo3.FNum = vouchers[i + 3].FNum;
                                    kisVouchersInfo3.FPeriod = vouchers[i + 3].FPeriod;
                                    kisVouchersInfo3.FPosted = vouchers[i + 3].FPosted;
                                    kisVouchersInfo3.FPrepare = vouchers[i + 3].FPrepare;
                                    kisVouchersInfo3.FPrice = vouchers[i + 3].FPrice;
                                    kisVouchersInfo3.FQty = vouchers[i + 3].FQty;
                                    kisVouchersInfo3.FSerialNo = vouchers[i + 3].FSerialNo;
                                    kisVouchersInfoList.Add(kisVouchersInfo3);
                                }
                            }
                        }
                        if (vouchers[i].FEntryID == 0 && number == 1)
                        {

                            if (vouchers[i].FEntryID == 0)
                            {

                                KisVouchersInfo kisVouchersInfo = new KisVouchersInfo();
                                kisVouchersInfo.FAcctID = vouchers[i].FAcctID;
                                kisVouchersInfo.FAttchment = vouchers[i].FAttchment;
                                kisVouchersInfo.FCredit = vouchers[i].FCredit;
                                kisVouchersInfo.FCyID = vouchers[i].FCyID;
                                kisVouchersInfo.FDate = vouchers[i].FDate;
                                kisVouchersInfo.FDC = vouchers[i].FDC;
                                kisVouchersInfo.FDebit = vouchers[i].FDebit;
                                kisVouchersInfo.FDeleted = vouchers[i].FDeleted;
                                kisVouchersInfo.FEntryID = vouchers[i - 1].FEntryID + 1;
                                kisVouchersInfo.FExchRate = vouchers[i].FExchRate;
                                kisVouchersInfo.FExp = vouchers[i].FExp;
                                kisVouchersInfo.FFCyAmt = vouchers[i].FFCyAmt;
                                kisVouchersInfo.FGroup = vouchers[i].FGroup;
                                kisVouchersInfo.FNum = vouchers[i].FNum;
                                kisVouchersInfo.FPeriod = vouchers[i].FPeriod;
                                kisVouchersInfo.FPosted = vouchers[i].FPosted;
                                kisVouchersInfo.FPrepare = vouchers[i].FPrepare;
                                kisVouchersInfo.FPrice = vouchers[i].FPrice;
                                kisVouchersInfo.FQty = vouchers[i].FQty;
                                kisVouchersInfo.FSerialNo = vouchers[i].FSerialNo;
                                kisVouchersInfoList.Add(kisVouchersInfo);

                            }

                            if (vouchers[i + 1].FEntryID == 1)
                            {
                                kisVouchersInfo1.FAcctID = vouchers[i + 1].FAcctID;
                                kisVouchersInfo1.FAttchment = vouchers[i + 1].FAttchment;
                                kisVouchersInfo1.FCredit = vouchers[i + 1].FCredit;
                                kisVouchersInfo1.FCyID = vouchers[i + 1].FCyID;
                                kisVouchersInfo1.FDate = vouchers[i + 1].FDate;
                                kisVouchersInfo1.FDC = vouchers[i + 1].FDC;
                                kisVouchersInfo1.FDebit = vouchers[i + 1].FDebit;
                                kisVouchersInfo1.FDeleted = vouchers[i + 1].FDeleted;
                                kisVouchersInfo1.FEntryID = vouchers[i - 1].FEntryID + 2;
                                kisVouchersInfo1.FExchRate = vouchers[i + 1].FExchRate;
                                kisVouchersInfo1.FExp = null;
                                kisVouchersInfo1.FFCyAmt = vouchers[i + 1].FFCyAmt;
                                kisVouchersInfo1.FGroup = vouchers[i + 1].FGroup;
                                kisVouchersInfo1.FNum = vouchers[i + 1].FNum;
                                kisVouchersInfo1.FPeriod = vouchers[i + 1].FPeriod;
                                kisVouchersInfo1.FPosted = vouchers[i + 1].FPosted;
                                kisVouchersInfo1.FPrepare = vouchers[i + 1].FPrepare;
                                kisVouchersInfo1.FPrice = vouchers[i + 1].FPrice;
                                kisVouchersInfo1.FQty = vouchers[i + 1].FQty;
                                kisVouchersInfo1.FSerialNo = vouchers[i + 1].FSerialNo;
                                kisVouchersInfoList.Add(kisVouchersInfo1);

                            }
                            if (i + 3 <= vouchers.Count)
                            {
                                if (vouchers[i + 2].FEntryID == 2)
                                {
                                    kisVouchersInfo2.FAcctID = vouchers[i + 2].FAcctID;
                                    kisVouchersInfo2.FAttchment = vouchers[i + 2].FAttchment;
                                    kisVouchersInfo2.FCredit = vouchers[i + 2].FCredit;
                                    kisVouchersInfo2.FCyID = vouchers[i + 2].FCyID;
                                    kisVouchersInfo2.FDate = vouchers[i + 2].FDate;
                                    kisVouchersInfo2.FDC = vouchers[i + 2].FDC;
                                    kisVouchersInfo2.FDebit = vouchers[i + 2].FDebit;
                                    kisVouchersInfo2.FDeleted = vouchers[i + 2].FDeleted;
                                    kisVouchersInfo2.FEntryID = vouchers[i - 1].FEntryID + 3;
                                    kisVouchersInfo2.FExchRate = vouchers[i + 2].FExchRate;
                                    kisVouchersInfo2.FExp = null;
                                    kisVouchersInfo2.FFCyAmt = vouchers[i + 2].FFCyAmt;
                                    kisVouchersInfo2.FGroup = vouchers[i + 2].FGroup;
                                    kisVouchersInfo2.FNum = vouchers[i + 2].FNum;
                                    kisVouchersInfo2.FPeriod = vouchers[i + 2].FPeriod;
                                    kisVouchersInfo2.FPosted = vouchers[i + 2].FPosted;
                                    kisVouchersInfo2.FPrepare = vouchers[i + 2].FPrepare;
                                    kisVouchersInfo2.FPrice = vouchers[i + 2].FPrice;
                                    kisVouchersInfo2.FQty = vouchers[i + 2].FQty;
                                    kisVouchersInfo2.FSerialNo = vouchers[i + 2].FSerialNo;
                                    kisVouchersInfoList.Add(kisVouchersInfo2);
                                }
                            }

                            if (i + 4 <= vouchers.Count)
                            {
                                if (vouchers[i + 3].FEntryID == 3)
                                {
                                    kisVouchersInfo3.FAcctID = vouchers[i + 3].FAcctID;
                                    kisVouchersInfo3.FAttchment = vouchers[i + 3].FAttchment;
                                    kisVouchersInfo3.FCredit = vouchers[i + 3].FCredit;
                                    kisVouchersInfo3.FCyID = vouchers[i + 3].FCyID;
                                    kisVouchersInfo3.FDate = vouchers[i + 3].FDate;
                                    kisVouchersInfo3.FDC = vouchers[i + 3].FDC;
                                    kisVouchersInfo3.FDebit = vouchers[i + 3].FDebit;
                                    kisVouchersInfo3.FDeleted = vouchers[i + 3].FDeleted;
                                    kisVouchersInfo3.FEntryID = vouchers[i - 1].FEntryID + 4;
                                    kisVouchersInfo3.FExchRate = vouchers[i + 3].FExchRate;
                                    kisVouchersInfo3.FExp = null;
                                    kisVouchersInfo3.FFCyAmt = vouchers[i + 3].FFCyAmt;
                                    kisVouchersInfo3.FGroup = vouchers[i + 3].FGroup;
                                    kisVouchersInfo3.FNum = vouchers[i + 3].FNum;
                                    kisVouchersInfo3.FPeriod = vouchers[i + 3].FPeriod;
                                    kisVouchersInfo3.FPosted = vouchers[i + 3].FPosted;
                                    kisVouchersInfo3.FPrepare = vouchers[i + 3].FPrepare;
                                    kisVouchersInfo3.FPrice = vouchers[i + 3].FPrice;
                                    kisVouchersInfo3.FQty = vouchers[i + 3].FQty;
                                    kisVouchersInfo3.FSerialNo = vouchers[i + 3].FSerialNo;
                                    kisVouchersInfoList.Add(kisVouchersInfo3);
                                }
                            }
                        }

                    }
                    foreach (KisVouchersInfo kvi in kisVouchersInfoList)
                    {
                        if (kvi.FEntryID == 0)
                        {
                            if (maxFSerialNum < 0)
                            {
                                maxFSerialNum = this.getMaxFSerialNum();
                                maxFSerialNum++;
                            }
                            else
                            {
                                maxFSerialNum++;
                            }

                            if (maxFNum < 0)
                            {
                                maxFNum = this.getMaxFNum(kvi.FPeriod, kvi.FGroup);
                                maxFNum++;
                            }
                            else
                            {
                                maxFNum++;
                            }
                        }
                        String sql = this.build3ItemSql(kvi, maxFSerialNum, maxFNum);
                        if (sql != null && sql != "") sqls.Add(sql);
                    }
                }
            }
            //
            //银行2张凭证合为一张凭证end
            //

            //更新最大凭证序号SQL
            String updateMaxFSerialNumSql = this.getMaxFSerialNumUpdateSql(maxFSerialNum);
            if (updateMaxFSerialNumSql == null || updateMaxFSerialNumSql == "") throw new Exception("无法更新当前最大凭证序号!");
            sqls.Add(updateMaxFSerialNumSql);

            //更新最大凭证号
            String updateMaxFNum = this.getMaxFNumUpdateSql(vouchers[0].FPeriod, vouchers[0].FGroup, maxFNum);
            if (updateMaxFNum == null || updateMaxFNum == "") throw new Exception("无法更新当前最大凭证号!");
            sqls.Add(updateMaxFNum);


            //执行SQL
            AccessDbClass accessDb = new AccessDbClass(this.KdbParams.DbFilePath);
            accessDb.ExecuteSQLNonquery(sqls);
        }

        //
        //修复账套科目长度start
        //
        public void SubjectLength()
        {

            KisDbPref kisDbPref = this.getGLPref();
            string sql = "select FAcctID from GLAcct";
            List<String> sqls = new List<String>();

            AccessDbClass access = new AccessDbClass(this.KdbParams.DbFilePath);
            DataTable dt = access.SelectToDataTable(sql);
            if (kisDbPref.Faclen2 >= 8 || dt.Rows.Count < 0)
            {
                throw new Exception("科目无需修复");
            }
            if (kisDbPref.Faclen2 == 6 && dt.Rows.Count > 0)
            {
                sqls.Add("update GLAcct set FAcctID = Left(FAcctID,4)+'00'+Right(FAcctID,len(FAcctID)-4) where len(FAcctID) > 4 ");
                sqls.Add("update GLPref set FAcLen2 = '8'");
                sqls.Add("update GLPref set FAcLen3 = FAcLen3 + 2 where FAcLen3 <>null ");
                sqls.Add("update GLPref set FAcLen4 = FAcLen4 + 2 where FAcLen4 <>null ");
                sqls.Add("update GLPref set FAcLen5 = FAcLen5 + 2 where FAcLen5 <>null ");
                sqls.Add("update GLPref set FAcLen6 = FAcLen6 + 2 where FAcLen6 <>null ");
                sqls.Add("update GLPref set FAcLen7 = FAcLen7 + 2 where FAcLen7 <>null ");
                sqls.Add("update GLPref set FAcLen8 = FAcLen8 + 2 where FAcLen8 <>null ");
                sqls.Add("update GLPref set FAcLen9 = FAcLen9 + 2 where FAcLen9 <>null ");
                sqls.Add("update GLPref set FAcLen10 = FAcLen10 + 2 where FAcLen10 <>null ");

                try
                {
                    access.ExecuteSQLNonquery(sqls);
                }
                catch (Exception e1)
                {
                    throw e1;
                }
                finally
                {
                    access.Close();
                }
            }
            if (kisDbPref.Faclen2 == 7 && dt.Rows.Count > 0)
            {
                sqls.Add("update GLAcct set FAcctID = Left(FAcctID,4)+'0'+Right(FAcctID,len(FAcctID)-4) where len(FAcctID) > 4 ");
                sqls.Add("update GLPref set FAcLen2 = '8'");
                sqls.Add("update GLPref set FAcLen3 = FAcLen3 + 1 where FAcLen3 <>null ");
                sqls.Add("update GLPref set FAcLen4 = FAcLen4 + 1 where FAcLen4 <>null ");
                sqls.Add("update GLPref set FAcLen5 = FAcLen5 + 1 where FAcLen5 <>null ");
                sqls.Add("update GLPref set FAcLen6 = FAcLen6 + 1 where FAcLen6 <>null ");
                sqls.Add("update GLPref set FAcLen7 = FAcLen7 + 1 where FAcLen7 <>null ");
                sqls.Add("update GLPref set FAcLen8 = FAcLen8 + 1 where FAcLen8 <>null ");
                sqls.Add("update GLPref set FAcLen9 = FAcLen9 + 1 where FAcLen9 <>null ");
                sqls.Add("update GLPref set FAcLen10 = FAcLen10 + 1 where FAcLen10 <>null ");
                try
                {
                    access.ExecuteSQLNonquery(sqls);
                }
                catch (Exception e1)
                {
                    throw e1;
                }
                finally
                {
                    access.Close();
                }
            }
        }
        //
        //修复账套科目长度end
        //
    }
}