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
                DataTable dt  = access.SelectToDataTable(sql);
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

        private int getMaxFNum(int accountcyclenum,String fgroup)
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
                    updateSql = "Insert into GLVchMaxNum(FPeriod,FGroup,FNum) values ("+ accountcyclenum +",'"+fgroup+"',"+(currNum)+ ")";
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
                String sql = "INSERT INTO GLAcct(FAcctID,FAcctName,FGroup,FDC) VALUES ("+
                    "'" + item.Sn + "'," +
                    "'" + item.Label + "'," +
                    "'" + level1Acct.Fgroup + "'," + //科目分组，需要根据上级象科目确认
                    "'" + (item.Debitcredit == "de" ? "D"  : "C") + "'" +
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

            if (kda == null) throw new Exception("科目:"+item.FAcctID+",在财务系统中不存在！");

            String sql = "INSERT INTO GLVch(FSerialNum,FDate,FPeriod,FGroup,FNum,FEntryID,FAcctID,FCyID,FExchRate,FFcyAmt,FDebit,FCredit,FPreparer,FExp) VALUES (" +
                    "" + fSerialNum + "," +
                    "'" + item.FDate + "'," +
                    ""  + item.FPeriod + "," + 
                    "'" + item.FGroup  + "'," +
                    ""  + fNum + "," +
                    ""  + item.FEntryID + "," +
                    "'" + item.FAcctID + "'," +
                    "'" + item.FCyID + "'," +
                    ""  + item.FExchRate + "," +
                    ""  + item.FFCyAmt + "," +
                    ""  + item.FDebit + "," +
                    ""  + item.FCredit + "," +
                    "'" + item.FPrepare + "'," +
                    "'" + item.FExp + "'" +
                    ")";

            return sql;
        }

        public void exportVoucher(Inst inst, Client client, Accountcycle accountcycle, User user, String categoryname)
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
   
            foreach (KisVoucherInfo kvi in vouchers){
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
                        maxFNum = this.getMaxFNum(kvi.FPeriod,kvi.FGroup);
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

            //更新最大凭证序号SQL
            String updateMaxFSerialNumSql  = this.getMaxFSerialNumUpdateSql(maxFSerialNum);
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
    }
}
