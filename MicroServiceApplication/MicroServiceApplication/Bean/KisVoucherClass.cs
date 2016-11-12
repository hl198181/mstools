using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace MicroServiceApplication.Bean
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

    class KisVoucherFactory
    {
     
        private List<KisVoucherInfo> buildData(JObject resultObject)
        {
            if (resultObject == null) throw new ArgumentException("构建凭证参数不能为空!");
            List<KisVoucherInfo> vouchers = new List<KisVoucherInfo>();

            var joDatas = resultObject["datas"];
            if (joDatas == null) throw new Exception("服务器返回数据错误。无法获取datas属性");

            var joResult = joDatas["result"];
            if (joResult == null) throw new Exception("当月无导出数据!");

            var jaVoucherItems = joResult["voucherItems"];
            if (jaVoucherItems == null) throw new Exception("当月无凭证分录数据！");

            foreach (JObject item in jaVoucherItems)
            {
                KisVoucherInfo voucherItem = new KisVoucherInfo();

                DateTime bizDate = MicroServiceApplication.Common.Util.GetTime(item["FDate"].ToString());

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
                voucherItem.FPrice = item.GetValue("FPrice").ToObject<int>();
                vouchers.Add(voucherItem);
            }
            return vouchers;
        }

        public List<KisVoucherInfo> getKisVoucher(string instid, string clientid, string accountcyclesn, string createby, string categoryname)
        {
            HttpClient httpClient = AppConfig.GetInstance().crateHttpClient();
            String url = AppConfig.GetInstance().BaseUrl + "/voucher/instance/exports";

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

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                JObject results = JObject.Parse(result);
                List<KisVoucherInfo> vouchers = buildData(results);
                return vouchers;
            }
            else
            {
                JObject jo = JObject.Parse(result);
                if (jo != null && jo["statusCode"].ToString() == "500" && jo["message"] != null)
                {
                    throw new Exception(jo["message"].ToString());
                }else
                {
                    throw new Exception("获取凭证数据错误!" + response.ReasonPhrase.ToString());
                }

            }
        }
    }
}
