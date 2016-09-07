using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace MicroServiceApplication.Bean
{
    class ClientSubject
    {
        private string _id;
        private string _clientid;
        private string _sn;
        private string _label;
        private string _debitcredit;
        private int _isnew;

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

        public string Sn
        {
            get
            {
                return _sn;
            }

            set
            {
                _sn = value;
            }
        }

        public string Label
        {
            get
            {
                return _label;
            }

            set
            {
                _label = value;
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

        public int Isnew
        {
            get
            {
                return _isnew;
            }

            set
            {
                _isnew = value;
            }
        }

        public ClientSubject() { }

        public ClientSubject(JObject jobject)
        {
            this.Id = jobject["id"] == null ? null : jobject["id"].ToString();
            this.Sn = jobject["sn"] == null ? null : jobject["sn"].ToString();
            this.Label = jobject["label"] == null ? null : jobject["label"].ToString();
            this.Isnew = jobject["isnew"].ToObject<int>();
            this.Debitcredit = jobject["debitcredit"] == null ? null : jobject["debitcredit"].ToString();
            this.Clientid = jobject["clientid"] == null ? null : jobject["clientid"].ToString();
        }
    }

    class ClientSubjectFactory
    {
        public List<ClientSubject> query(string clientid,int isnew)
        {
            HttpClient httpClient = AppConfig.GetInstance().crateHttpClient();

            String url = AppConfig.GetInstance().BaseUrl + "/client/subject?clientid="+clientid+"&isnew="+isnew+"&disabled=0";
            HttpResponseMessage response = httpClient.GetAsync(url).Result;
            String result = response.Content.ReadAsStringAsync().Result;
            httpClient.Dispose();

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception("查询客户科目信息错误." + response.RequestMessage.ToString());
            }

            List<ClientSubject> clientSubjectList = new List<ClientSubject>();

            JArray ja = JArray.Parse(result);

            foreach (var item in ja)
            {
                ClientSubject clientSubject = new ClientSubject(item.Value<JObject>());
                clientSubjectList.Add(clientSubject);
            }

            return clientSubjectList;
        }
    }
}
