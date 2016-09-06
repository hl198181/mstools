using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using MicroServiceApplication.Bean;

namespace MicroServiceApplication
{
    
    class KisVoucherInfo
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
    class ExportKisClass
    {
        private string _ErrInfo = "";

        public string ErrInfo
        {
            get { return _ErrInfo; }
        }

        public bool Create(string filename,string tablename)
        {
            bool r = false;
            string outconnstring = string.Format("Provider = Microsoft.Jet.OLEDB.4.0 ;Data Source ={0};Extended Properties=dBASE IV;", filename);
            OleDbConnection outConn = new OleDbConnection(outconnstring);
            OleDbCommand dc = outConn.CreateCommand();
            try
            {
                outConn.Open();
                dc.CommandType = CommandType.Text;
                dc.CommandText = "CREATE TABLE " + tablename + " (FDate Date,FPeriod Numeric(4,0),FGroup Char(4),FNum Numeric(4,0),FEntryID Numeric(4,0),FExp Char(60),FAcctID Char(30),FClsName1 Char(20),FObjID1 Char(10),FObjName1 Char(20),FClsName2 Char(20),FObjID2 Char(10),FObjName2 Char(20),FClsName3 Char(20),FObjID3 Char(10),FObjName3 Char(20),FClsName4 Char(20),FObjID4 Char(10),FObjName4 Char(20),FTransID Char(10),FCyID Char(3),FExchRate Numeric(19,10),FDC Char(1),FFCyAmt Numeric(14,2),FQty Numeric(8,2),FPrice Numeric(10,7),FDebit Numeric(14,2),FCredit Numeric(14,2),FSettlCode Char(8),FSettleNo Char(8),FPrepare Char(8),FPay Char(8),FCash Char(8),FPoster Char(8),FChecker Char(8),FAttchment Numeric(5,0),FPosted Logical,FModule Char(2),FDeleted Logical,FSerialNo Numeric(10,0))";
                dc.ExecuteNonQuery();
                r = true;
            }
            catch (Exception c)
            {
                _ErrInfo = c.Message;
            }
            finally
            {
                dc.Dispose();
                if (outConn.State == System.Data.ConnectionState.Open)
                    outConn.Close();
                outConn.Dispose();
            }
            return r;
        }

        public bool Save(string filename,string tablename,List<KisVoucherInfo> vouchers)
        {
            bool r=false;
            string outconnstring = string.Format("Provider = Microsoft.Jet.OLEDB.4.0 ;Data Source ={0};Extended Properties=dBASE IV;", filename);
            OleDbConnection outConn=new OleDbConnection(outconnstring);
            
            _ErrInfo="";
            try
            {
                outConn.Open();
                foreach (var rec in vouchers)
                {
                    OleDbCommand dc = outConn.CreateCommand();
                    string tmp = "insert into " + tablename + "(FDate,FPeriod,FGroup,FNum,FEntryID,FExp,FAcctID,FCyID,FExchRate,FDC,FFCyAmt,FQty,FPrice,FDebit,FCredit,FPrepare,FAttchment,FPosted,FDeleted,FSerialNo) values('{0}',{1},'{2}',{3},{4},'{5}','{6}','{7}',{8},'{9}',{10},{11},{12},{13},{14},'{15}',{16},{17},{18},{19})";
                    dc.CommandText = string.Format(tmp, rec.FDate, rec.FPeriod, rec.FGroup, rec.FNum, rec.FEntryID, rec.FExp, rec.FAcctID, rec.FCyID, rec.FExchRate, rec.FDC, rec.FFCyAmt, rec.FQty, rec.FPrice, rec.FDebit, rec.FCredit, rec.FPrepare, rec.FAttchment, rec.FPosted, rec.FDeleted, rec.FSerialNo);
                    dc.ExecuteNonQuery();
                    dc.Dispose();
                }
                r = true;
            }
            catch(Exception err)
            {
                _ErrInfo=err.Message;
            }
            finally
            {
                if(outConn!=null)
                    outConn.Close();
                
                outConn.Dispose();
            }
            return r;
        }

        private DateTime GetTime(string timeStamp)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000");
            //long lTime = long.Parse(timeStamp);
            TimeSpan toNow = new TimeSpan(lTime); 
            return dtStart.Add(toNow);  
        }

        private int GetCreatetime()
        {
            DateTime DateStart = new DateTime(1970, 1, 1, 8, 0, 0);
            return Convert.ToInt32((DateTime.Now - DateStart).TotalSeconds);
        }  
        
        private List<KisVoucherInfo> buildData(JObject resultObject)
        {
            if (resultObject == null) throw new ArgumentException("构建凭证参数不能为空!");
            List<KisVoucherInfo> vouchers = new List<KisVoucherInfo>();

            var joDatas = resultObject["datas"];
            if (joDatas == null) throw new Exception("服务器返回数据错误。无法获取datas属性");

            var joResult = joDatas["result"];
            if (joResult == null) throw new Exception("服务器返回数据错误，无法获取result属性。");
            
            var jaVoucherItems = joResult["voucherItems"];
            if (jaVoucherItems == null) throw new Exception("服务器返回数据错误，无法获取凭证结果。");

            foreach (JObject item in jaVoucherItems)
            {
                KisVoucherInfo voucherItem = new KisVoucherInfo();
                
                DateTime bizDate = GetTime(item["FDate"].ToString());

                voucherItem.FDate = bizDate;
                voucherItem.FPeriod = item.GetValue("FPeriod").ToObject<int>();
                voucherItem.FGroup = item.GetValue("FGroup").ToString();
                voucherItem.FNum = item.GetValue("FNum").ToObject<int>();
                voucherItem.FEntryID = item.GetValue("FEntryID").ToObject<int>();
                voucherItem.FExp = item.GetValue("FExp").ToString();
                voucherItem.FAcctID = item.GetValue("FAcctID").ToString();
                voucherItem.FCyID = item.GetValue("FCyID").ToString();
                voucherItem.FExchRate = item.GetValue("FExchRate").ToObject<int>();
                voucherItem.FDC = item.GetValue("FDC").ToString();
                voucherItem.FFCyAmt = item.GetValue("FFCyAmt").ToObject<decimal>();
                voucherItem.FQty = item.GetValue("FQty").ToObject<decimal>();
                voucherItem.FDebit = item.GetValue("FDebit").ToObject<decimal>();
                voucherItem.FCredit = item.GetValue("FCredit").ToObject<decimal>();
                voucherItem.FPrepare = item.GetValue("FPrepare").ToString();
                voucherItem.FSerialNo = item.GetValue("FSerialNo").ToObject<int>();
                vouchers.Add(voucherItem);
            }
            return vouchers;
        }

        public JObject getData(string instid, string clientid, string accountcyclesn, string createby, string categoryname)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.MaxResponseContentBufferSize = 256000;
            httpClient.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)");
            httpClient.DefaultRequestHeaders.Add("Authorization", "Basic c2VydmljZTpjNUNVN0ZBNVZOczdNOXJUZVlHU3pXZGpETzBWZmY=");

            String url = "http://www.yun9.com/service/voucher/instance/exports";

            List<KeyValuePair<String, String>> paramList = new List<KeyValuePair<String, String>>();
            paramList.Add(new KeyValuePair<string, string>("instid", instid));
            paramList.Add(new KeyValuePair<string, string>("clientid", clientid));
            paramList.Add(new KeyValuePair<string, string>("accountcyclesn", accountcyclesn));
            paramList.Add(new KeyValuePair<string, string>("categoryname", categoryname));
            paramList.Add(new KeyValuePair<string, string>("createby", createby));
            paramList.Add(new KeyValuePair<string, string>("type", "kis"));
            HttpResponseMessage response = httpClient.PostAsync(new Uri(url), new FormUrlEncodedContent(paramList)).Result;
            String result = response.Content.ReadAsStringAsync().Result;
            httpClient.Dispose();


            JObject jo = JObject.Parse(result);
            int stateCode = jo.GetValue("statusCode").ToObject<int>();
            string message = jo.GetValue("message").ToString();
            if (stateCode == 200)
            {
                return jo;
            }
            else
            {
                MessageBox.Show(message);
                return null;
            }
        }

        public void exports(ExportBean exportBean)
        {
            
            JObject results = getData(exportBean.Instid, exportBean.Clientid, exportBean.Accountcyclesn, exportBean.Createby, exportBean.Categoryname);

            JObject datas = results.GetValue("datas").ToObject<JObject>();

            Accountcycle accountcycle = new Accountcycle(datas.GetValue("accountcycle").ToObject<JObject>());

            List<KisVoucherInfo> vouchers = buildData(results);

            if (!this.Create(exportBean.Path, exportBean.FileName))
            {
                MessageBox.Show("创建数据文件错误:" + this.ErrInfo);
                return;
            }

            if (!this.Save(exportBean.Path, exportBean.FileName, vouchers))
            {
                MessageBox.Show("写入数据文件错误:" + this.ErrInfo);
                return;
            }
            else
            {
                MessageBox.Show("导出成功!");
            }
        }

    }
}
