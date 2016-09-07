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

namespace MicroServiceApplication.factory
{
    class Sd3000Voucher
    {
        private List<Sd3000VoucherItem> _items;
        
        public Sd3000Voucher(JObject jobject)
        {
            if (jobject == null) return;

            if (jobject["items"] != null)
            {
                this.Items = new List<Sd3000VoucherItem>();
                foreach (JObject item in jobject["items"])
                {
                    var detail = new Sd3000VoucherItem(item);
                    this.Items.Add(detail);
                }
            }
        }

        internal List<Sd3000VoucherItem> Items
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

    class Sd3000VoucherItem
    {
        private string _id;
        private string _instid;
        private string _clientid;
        private string _accountcyclesn;
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



        public Sd3000VoucherItem(JObject jobject)
        {
            if (jobject != null){
                this.Id = jobject["id"] == null ? null : jobject["id"].ToString();
                this.Instid = jobject["instid"] == null ? null : jobject["instid"].ToString();
                this.Clientid = jobject["clientid"] == null ? null : jobject["clientid"].ToString();
                this.Accountcyclesn = jobject["accountcyclesn"] == null ? null : jobject["accountcyclesn"].ToString();
                this.Libraryid = jobject["libraryid"] == null ? null : jobject["libraryid"].ToString();
                this.Libraryitemid = jobject["libraryitemid"] == null ? null : jobject["libraryitemid"].ToString();
                this.Inputtype = jobject["inputtype"] == null ? null : jobject["inputtype"].ToString();
                this.Bizid = jobject["bizid"] == null ? null : jobject["bizid"].ToString();
                this.Biztype = jobject["biztype"] == null ? null : jobject["biztype"].ToString();
                if (jobject["bizdate"] != null){
                    this.Bizdate = Util.GetTime(jobject["bizdate"].ToString());
                }
                this.Summary = jobject["summary"] == null ? null : jobject["summary"].ToString();
                this.Descr = jobject["descr"] == null ? null : jobject["descr"].ToString();
                this.Subjectno = jobject["subjectno"] == null ? null : jobject["subjectno"].ToString();
                this.Subjectname = jobject["subjectname"] == null ? null : jobject["subjectname"].ToString();
                this.Subjectno1 = jobject["subjectno1"] == null ? null : jobject["subjectno1"].ToString();
                this.Subjectname1 = jobject["subjectname1"] == null ? null : jobject["subjectname1"].ToString();
                this.Subjectno2 = jobject["subjectno2"] == null ? null : jobject["subjectno2"].ToString();
                this.Subjectname2 = jobject["subjectname2"] == null ? null : jobject["subjectname2"].ToString();
                this.Subjectno3 = jobject["subjectno3"] == null ? null : jobject["subjectno3"].ToString();
                this.Subjectname3 = jobject["subjectname3"] == null ? null : jobject["subjectname3"].ToString();
                this.Subjectno4 = jobject["subjectno4"] == null ? null : jobject["subjectno4"].ToString();
                this.Subjectname4 = jobject["subjectname4"] == null ? null : jobject["subjectname4"].ToString();
                this.Subjectno5 = jobject["subjectno5"] == null ? null : jobject["subjectno5"].ToString();
                this.Subjectname5 = jobject["subjectname5"] == null ? null : jobject["subjectname5"].ToString();
                this.Subjectno6 = jobject["subjectno6"] == null ? null : jobject["subjectno6"].ToString();
                this.Subjectname6 = jobject["subjectname6"] == null ? null : jobject["subjectname6"].ToString();

                this.Debitcredit = jobject["debitcredit"] == null ? null : jobject["debitcredit"].ToString();

                if (jobject["debit"] != null)
                {
                    this.Debit = jobject["debit"].ToObject<decimal>();
                }
                if (jobject["credit"] != null)
                {
                    this.Credit = jobject["credit"].ToObject<decimal>();
                }
                if (jobject["sort"] != null)
                {
                    this.Sort = jobject["sort"].ToObject<int>();
                }
                if (jobject["disabled"] != null)
                {
                    this.Disabled = jobject["disabled"].ToObject<int>();
                }
                if (jobject["createdate"] != null)
                {
                    this.Createdate = Util.GetTime(jobject["createdate"].ToString());
                }
                this.Createby = jobject["createby"] == null ? null : jobject["createby"].ToString();
                this.Biztype = jobject["biztype"] == null ? null : jobject["biztype"].ToString();
                if (jobject["warn"] != null)
                {
                    this.Warn = jobject["warn"].ToObject<int>();
                }
                this.Warntext = jobject["warntext"] == null ? null : jobject["warntext"].ToString();
                this.Remark = jobject["remark"] == null ? null : jobject["remark"].ToString();
                this.Librarylabel = jobject["librarylabel"] == null ? null : jobject["librarylabel"].ToString();
                this.Libraryname = jobject["libraryname"] == null ? null : jobject["libraryname"].ToString();
                this.Categoryname = jobject["categoryname"] == null ? null : jobject["categoryname"].ToString();
                this.Categorylabel = jobject["categorylabel"] == null ? null : jobject["categorylabel"].ToString();
                this.Groupname = jobject["groupname"] == null ? null : jobject["groupname"].ToString();
                this.Createbyname = jobject["createbyname"] == null ? null : jobject["createbyname"].ToString();
                this.Createbyheadimgurl = jobject["_createbyheadimgurl"] == null ? null : jobject["_createbyheadimgurl"].ToString();
                if (jobject["voucherNum"] != null)
                {
                    this.VoucherNum = jobject["voucherNum"].ToObject<int>();
                }
            }
        }
    }

    class Sd3000Currency
    {
        private int _moneyid;
        private string _name;
        private decimal _rate;
        private int _upflag;
        private int _shopid;

        public int Moneyid
        {
            get
            {
                return _moneyid;
            }

            set
            {
                _moneyid = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public decimal Rate
        {
            get
            {
                return _rate;
            }

            set
            {
                _rate = value;
            }
        }

        public int Upflag
        {
            get
            {
                return _upflag;
            }

            set
            {
                _upflag = value;
            }
        }

        public int Shopid
        {
            get
            {
                return _shopid;
            }

            set
            {
                _shopid = value;
            }
        }
    }

    class Sd3000Subject
    {
        private int _subid;
        private string _subcode;
        private int _moneyid;
        private string _name;
        private string _fullname;

        public int Subid
        {
            get
            {
                return _subid;
            }

            set
            {
                _subid = value;
            }
        }

        public string Subcode
        {
            get
            {
                return _subcode;
            }

            set
            {
                _subcode = value;
            }
        }

        public int Moneyid
        {
            get
            {
                return _moneyid;
            }

            set
            {
                _moneyid = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Fullname
        {
            get
            {
                return _fullname;
            }

            set
            {
                _fullname = value;
            }
        }
    }
    class Sd3000Factory
    {
        class ExportSd3000Context
        {
            private ExportBean _exportBean;

            private List<Sd3000Voucher> _vouchers;

            private List<string> _sqls = new List<string>();

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

            private int _maxCredno;

       
            internal List<Sd3000Voucher> Vouchers
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

            public int MaxCredno
            {
                get
                {
                    return _maxCredno;
                }

                set
                {
                    _maxCredno = value;
                }
            }
        }

        string connurl = "Data Source=192.168.31.185;Initial Catalog=SD11001N_Sample;Persist Security Info=True;User ID=sa;Password=sybase12";

        private SqlConnection createConnection()
        {
            SqlConnection connection = new SqlConnection(connurl);
            return connection;
        }

        public void exports(ExportBean exportBean)
        {
            ExportSd3000Context context = new ExportSd3000Context();
            context.ExportBean = exportBean;


            try
            {
                //查询凭证数据
                this.getData(context);

                //获取当前Credid
                this.getCredid(context);
                this.getCredcode(context);
                this.getCredno(context);

                this.execute(context);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw e;
            }
            finally
            {
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

        private void getData(ExportSd3000Context context)
        {
            HttpClient httpClient = AppConfig.GetInstance().crateHttpClient();
            String url = AppConfig.GetInstance().BaseUrl + "/voucher/instance/exports";

            List<KeyValuePair<String, String>> paramList = new List<KeyValuePair<String, String>>();
            paramList.Add(new KeyValuePair<string, string>("instid", context.ExportBean.Instid));
            paramList.Add(new KeyValuePair<string, string>("clientid", context.ExportBean.Clientid));
            paramList.Add(new KeyValuePair<string, string>("accountcyclesn", context.ExportBean.Accountcyclesn));
            paramList.Add(new KeyValuePair<string, string>("categoryname", context.ExportBean.Categoryname));
            paramList.Add(new KeyValuePair<string, string>("createby", context.ExportBean.Createby));
            paramList.Add(new KeyValuePair<string, string>("type", "sd3000"));
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

        private List<Sd3000Voucher> buildData(JObject resultObject)
        {
            if (resultObject == null) throw new ArgumentException("构建凭证参数不能为空!");
            List<Sd3000Voucher> vouchers = new List<Sd3000Voucher>();

            var joDatas = resultObject["datas"];
            if (joDatas == null) throw new Exception("服务器返回数据错误。无法获取datas属性");

            var joResult = joDatas["result"];
            if (joResult == null) throw new Exception("当月无导出数据!");

            var jaVoucherItems = joResult["voucherItems"];
            if (jaVoucherItems == null) throw new Exception("当月无凭证分录数据！");

            foreach (JObject item in jaVoucherItems)
            {
                Sd3000Voucher voucherItem = new Sd3000Voucher(item);
                vouchers.Add(voucherItem);
            }
            return vouchers;
        }

        private void execute(ExportSd3000Context context)
        {

            SqlConnection connection = this.createConnection();
            connection.Open();
            SqlTransaction tr = connection.BeginTransaction();

            try
            {
                //开始构建SQL
                foreach (Sd3000Voucher item in context.Vouchers)
                {
                    this.buildCredence(context, item, connection,tr);
                }

                //提交事物
                tr.Commit();
            }catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                //回滚事物
                tr.Rollback();
                throw e;
            }
            finally
            {
                connection.Close();
            }
           
        }

        private void buildCredence(ExportSd3000Context context,Sd3000Voucher voucher,SqlConnection connection, SqlTransaction tr)
        {
            if (voucher == null || voucher.Items == null || voucher.Items.Count <= 0) return;

            //credid 凭证id 月份+序号递增
            //shopid 分支机构id 暂时取0 总部
            //rptid 凭证样式id 暂时取 20
            //credtype 未知 取0
            //credcode 凭证字号 每月从1递增
            //credno 凭证序号 每月从1递增
            //creddate 编制日期 取值业务日期
            //billnumber 附件张数 取值0
            //billmaker 制单人 取值当前操作人名称
            //relevantbillid 相关单据，取0
            //updatetime 当前日期
            //credtypeid 凭证字ID
            //printcount 打印次数

            //this.getGroupNameId("记", context);

            //生成凭证id
            context.MaxCredid++;
            var credid = "000000" + context.MaxCredid;
            credid = credid.Substring(credid.Length - 6);
            credid = context.ExportBean.Accountcyclesn + credid;

            //获取凭证字id
            string credtypeid = this.getGroupNameId(voucher.Items[0].Groupname, context);
            if (credtypeid == null || credtypeid == "") throw new Exception("无法获取凭证字："+ voucher.Items[0].Groupname+",对应的ID!");

            context.MaxCredno++;
            context.MaxCredcode++;

            //凭证表头
            SqlCommand credenceCmd = connection.CreateCommand();
            credenceCmd.Transaction = tr;

            string credenceSql = "insert into credence (credid,shopid,rptid,credtype,credcode,credno,creddate,billnumber,billmaker,relevantbillid,updatetime,credtypeid,printcount) values (@credid,@shopid,@rptid,@credtype,@credcode,@credno,@creddate,@billnumber,@billmaker,@relevantbillid,@updatetime,@credtypeid,@printcount)";
            credenceCmd.CommandText = credenceSql;

            credenceCmd.Parameters.Add("@credid",SqlDbType.VarChar);
            credenceCmd.Parameters.Add("@shopid", SqlDbType.Int);
            credenceCmd.Parameters.Add("@rptid", SqlDbType.Int);
            credenceCmd.Parameters.Add("@credtype", SqlDbType.Int);
            credenceCmd.Parameters.Add("@credcode", SqlDbType.Int);
            credenceCmd.Parameters.Add("@credno", SqlDbType.Int);
            credenceCmd.Parameters.Add("@creddate", SqlDbType.DateTime);
            credenceCmd.Parameters.Add("@billnumber", SqlDbType.Int);
            credenceCmd.Parameters.Add("@billmaker", SqlDbType.VarChar);
            credenceCmd.Parameters.Add("@relevantbillid", SqlDbType.Int);
            credenceCmd.Parameters.Add("@updatetime", SqlDbType.DateTime);
            credenceCmd.Parameters.Add("@credtypeid", SqlDbType.Int);
            credenceCmd.Parameters.Add("@printcount", SqlDbType.Int);

            credenceCmd.Parameters["@credid"].Value = credid;
            credenceCmd.Parameters["@shopid"].Value = 0;
            credenceCmd.Parameters["@rptid"].Value = 20;
            credenceCmd.Parameters["@credtype"].Value = 0;
            credenceCmd.Parameters["@credcode"].Value = context.MaxCredcode;
            credenceCmd.Parameters["@credno"].Value = context.MaxCredno;
            credenceCmd.Parameters["@creddate"].Value = voucher.Items[0].Bizdate;
            credenceCmd.Parameters["@billnumber"].Value = 0;
            credenceCmd.Parameters["@billmaker"].Value = voucher.Items[0].Createbyname;
            credenceCmd.Parameters["@relevantbillid"].Value = 0;
            credenceCmd.Parameters["@updatetime"].Value = voucher.Items[0].Createdate;
            credenceCmd.Parameters["@credtypeid"].Value = credtypeid;
            credenceCmd.Parameters["@printcount"].Value = 0;

            int result = credenceCmd.ExecuteNonQuery();

            //凭证明细
            foreach(Sd3000VoucherItem item in voucher.Items)
            {
                this.buildCreditem(context, credid, item, connection, tr);
            }
        }

        private void buildCreditem(ExportSd3000Context context,string credid, Sd3000VoucherItem voucherItem, SqlConnection connection, SqlTransaction tr)
        {

            //查找货币id
            Sd3000Currency currency =  this.getCurrency("人民币");
            //查找科目id
            Sd3000Subject subject = this.getSubject(voucherItem.Subjectno);

            SqlCommand creditemCmd = connection.CreateCommand();
            creditemCmd.Transaction = tr;

            string credenceSql = "insert into creditem (credid,fenluno,rate,rawdebit,rawcredit,debit,credit,moneyid,subid,brief) values (@credid,@fenluno,@rate,@rawdebit,@rawcredit,@debit,@credit,@moneyid,@subid,@brief)";
            creditemCmd.CommandText = credenceSql;

            creditemCmd.Parameters.Add("@credid", SqlDbType.VarChar);
            creditemCmd.Parameters.Add("@fenluno", SqlDbType.Int);
            creditemCmd.Parameters.Add("@rate", SqlDbType.Decimal);
            creditemCmd.Parameters.Add("@rawdebit", SqlDbType.Money);
            creditemCmd.Parameters.Add("@rawcredit", SqlDbType.Money);
            creditemCmd.Parameters.Add("@debit", SqlDbType.Money);
            creditemCmd.Parameters.Add("@credit", SqlDbType.Money);
            creditemCmd.Parameters.Add("@moneyid", SqlDbType.Int);
            creditemCmd.Parameters.Add("@subid", SqlDbType.Int);
            creditemCmd.Parameters.Add("@brief", SqlDbType.VarChar);

            creditemCmd.Parameters["@credid"].Value = credid;
            creditemCmd.Parameters["@fenluno"].Value = voucherItem.Sort;
            creditemCmd.Parameters["@rate"].Value = 20;
            creditemCmd.Parameters["@rawdebit"].Value = 0;
            creditemCmd.Parameters["@rawcredit"].Value = 0;
            creditemCmd.Parameters["@debit"].Value = voucherItem.Debit;
            creditemCmd.Parameters["@credit"].Value = voucherItem.Credit;
            creditemCmd.Parameters["@moneyid"].Value = currency.Moneyid;
            creditemCmd.Parameters["@subid"].Value = subject.Subid;
            creditemCmd.Parameters["@brief"].Value = voucherItem.Summary;

            int result = creditemCmd.ExecuteNonQuery();
        }

        //获取凭证字id
        private string getGroupNameId(string groupname,ExportSd3000Context context)
        {
            SqlConnection connection = this.createConnection();

            string sql = "select * from credtype where name = '"+groupname+"'";

            SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, connection);
            DataSet myDataSet = new DataSet();      // 创建DataSet

            try
            {
                myDataAdapter.Fill(myDataSet, "credtype");
                DataTable myTable = myDataSet.Tables["credtype"];
                if (myTable.Rows.Count <= 0) throw new Exception("无法找到名称为："+ groupname+",凭证字信息!");
                string typeid = myTable.Rows[0][myTable.Columns["typeid"]].ToString();
                return typeid;
            }
            finally
            {
                myDataSet.Dispose();
                myDataAdapter.Dispose();
                connection.Close();
            }
           
        }

        //获取凭证最大序号
        private void getCredid(ExportSd3000Context context)
        {
            SqlConnection connection = this.createConnection();

            string sql = "select max(credid) as credid from credence where credid like '" + context.ExportBean.Accountcyclesn + "%'";
            
            SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, connection);
            DataSet myDataSet = new DataSet();      // 创建DataSet

            try
            {
                myDataAdapter.Fill(myDataSet, "credence");
                DataTable myTable = myDataSet.Tables["credence"];

                string credid = myTable.Rows[0][myTable.Columns["credid"]].ToString();

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
            }
            finally
            {
                myDataSet.Dispose();
                myDataAdapter.Dispose();
                connection.Close();
            }
          
        }

        private void getCredcode(ExportSd3000Context context)
        {
            SqlConnection connection = this.createConnection();

            string sql = "select max(credcode) as credcode from credence where credid like '" + context.ExportBean.Accountcyclesn + "%'";

            SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, connection);
            DataSet myDataSet = new DataSet();      // 创建DataSet

            try
            {
                myDataAdapter.Fill(myDataSet, "credence");
                DataTable myTable = myDataSet.Tables["credence"];

                string credcode = myTable.Rows[0][myTable.Columns["credcode"]].ToString();
                
                if (credcode == "" || credcode == null)
                {
                    context.MaxCredcode = 0;
                }
                else
                {
                    context.MaxCredcode = int.Parse(credcode);
                }
            }
            finally
            {
                myDataSet.Dispose();
                myDataAdapter.Dispose();
                connection.Close();
            }

        }

        private void getCredno(ExportSd3000Context context)
        {
            SqlConnection connection = this.createConnection();

            string sql = "select max(credno) as credno from credence where credid like '" + context.ExportBean.Accountcyclesn + "%'";

            SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, connection);
            DataSet myDataSet = new DataSet();      // 创建DataSet

            try
            {
                myDataAdapter.Fill(myDataSet, "credence");
                DataTable myTable = myDataSet.Tables["credence"];

                string credno = myTable.Rows[0][myTable.Columns["credno"]].ToString();

                if (credno == "" || credno == null)
                {
                    context.MaxCredno = 0;
                }
                else
                {
                    context.MaxCredno = int.Parse(credno);
                }
            }
            finally
            {
                myDataSet.Dispose();
                myDataAdapter.Dispose();
                connection.Close();
            }

        }

        private Sd3000Currency getCurrency(string name)
        {
            SqlConnection connection = this.createConnection();

            string sql = "select moneyid,rate,upflag,shopid,name from currency where name = '" + name+"'";

            SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, connection);
            DataSet myDataSet = new DataSet();      // 创建DataSet

            try
            {
                myDataAdapter.Fill(myDataSet, "currency");
                DataTable myTable = myDataSet.Tables["currency"];
                if (myTable.Rows.Count <= 0) throw new Exception("无法找到名称为：" + name + "的币种!");

                Sd3000Currency currency = new Sd3000Currency();
                currency.Moneyid = int.Parse(myTable.Rows[0][myTable.Columns["moneyid"]].ToString());
                currency.Name = myTable.Rows[0][myTable.Columns["name"]].ToString();
                currency.Rate = decimal.Parse(myTable.Rows[0][myTable.Columns["rate"]].ToString());

                return currency;
            }
            finally
            {
                myDataSet.Dispose();
                myDataAdapter.Dispose();
                connection.Close();
            }

        }

        private Sd3000Subject getSubject(string code)
        {
            SqlConnection connection = this.createConnection();

            string sql = "select subid,subcode,moneyid,name,fullname from subject where subcode = '" + code + "'";

            SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, connection);
            DataSet myDataSet = new DataSet();      // 创建DataSet

            try
            {
                myDataAdapter.Fill(myDataSet, "subject");
                DataTable myTable = myDataSet.Tables["subject"];

                if (myTable.Rows.Count<=0) throw new Exception("无法找到编号为：" + code + "的科目信息!");

                Sd3000Subject subject = new Sd3000Subject();
                subject.Subid = int.Parse(myTable.Rows[0][myTable.Columns["subid"]].ToString());
                subject.Subcode = myTable.Rows[0][myTable.Columns["subcode"]].ToString();
                subject.Moneyid = int.Parse(myTable.Rows[0][myTable.Columns["moneyid"]].ToString());
                subject.Name = myTable.Rows[0][myTable.Columns["name"]].ToString();
                subject.Fullname = myTable.Rows[0][myTable.Columns["fullname"]].ToString();
                return subject;
            }
            finally
            {
                myDataSet.Dispose();
                myDataAdapter.Dispose();
                connection.Close();
            }

        }
    }
}
