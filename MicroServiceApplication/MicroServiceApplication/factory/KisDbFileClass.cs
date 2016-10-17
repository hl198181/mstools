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
            String sql = "select * from GLAcct where FAcctID ='"+ accid+"'";
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
            }else
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
                csl.Subject1 = kisDbPref.Faclen1;
                csl.Subject2 = kisDbPref.Faclen2;
                csl.Subject3 = kisDbPref.Faclen3;
                csl.Subject4 = kisDbPref.Faclen4;
                csl.Subject5 = kisDbPref.Faclen5;
                csl.Subject6 = kisDbPref.Faclen6;
                cslf.add(csl);
            }

        }

        public void exportSubject2Kis(List<ClientSubject> clientSubjects)
        {
            if (clientSubjects == null || clientSubjects.Count <= 0) return;

            //获取配置信息
            KisDbPref  kisDbPref = this.getGLPref();
             
            List<String> sqls = new List<String>();
            foreach(ClientSubject item in clientSubjects)
            {
                //检查是否已经存在于kis;
                KisDbAcct kisAcct = this.getGLAccById(item.Sn);

                if (kisAcct != null)
                {
                    throw new Exception("科目:"+item.Sn+",已经存在于Kis系统中！");
                }

                //获取一级科目
                String leve1Subject = item.Sn.Substring(0, kisDbPref.Faclen1);

                KisDbAcct level1Acct = this.getGLAccById(leve1Subject);

                if (level1Acct == null)
                {
                    throw new Exception("无法获取科目:"+item.Sn+"的一级科目信息！");
                }

                //组合插入SQL
                String sql = "INSERT INTO　GLAcct(FAcctID,FAcctName,FGroup,FDC) VALUES ("+
                    "'" + item.Sn + "'" +
                    "'" + item.Label + "'" +
                    "'" + level1Acct.Fgroup + "'" + //科目分组，需要根据上级象科目确认
                    "'" + (item.Debitcredit == "de" ? "D"  : "C") + "'" +
                    ")";
                sqls.Add(sql);
            }

            //插入数据库
            AccessDbClass access = new AccessDbClass(this.KdbParams.DbFilePath);

            access.ExecuteSQLNonquery(sqls);
        }
    }
}
