using MicroServiceApplication.factory;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace MicroServiceApplication.Bean
{
    class ClientSubject
    {
        private string _id;
        private string _clientid;
        private string _sn;
        private string _label;
        private string _fullname;
        private string _debitcredit;
        private int _isnew;
        private string unit;

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

        public string Unit
        {
            get
            {
                return unit;
            }

            set
            {
                unit = value;
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
            this.Unit = jobject["unit"] == null ? null : jobject["unit"].ToString();
        }
    }

    class ClientSubjectFactory
    {
        public List<ClientSubject> query(string clientid,int isnew,int audit)
        {

            HttpClient httpClient = AppConfig.GetInstance().crateHttpClient();

            String url = AppConfig.GetInstance().BaseUrl + "/client/subject?clientid="+clientid+"&isnew="+isnew+"&audit="+ audit + "&disabled=0";
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

        public void updateIsNew(List<ClientSubject> clientSubjects,int isNew)
        {

            HttpClient httpClient = AppConfig.GetInstance().crateHttpClient();

            String url = AppConfig.GetInstance().BaseUrl + "/client/subject";

            JArray ja = new JArray();

            foreach (ClientSubject item in clientSubjects)
            {
                JObject jo = new JObject();

                jo.Add("id", item.Id);
                jo.Add("isnew", isNew);
                ja.Add(jo);
            }

            string requestJson = ja.ToString();

            HttpContent httpContent = new StringContent(requestJson);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = httpClient.PostAsync(new Uri(url), httpContent).Result;
            String result = response.Content.ReadAsStringAsync().Result;
            httpClient.Dispose();

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
               
            }
            else
            {
                throw new Exception("设置科目状态错误." + response.RequestMessage.ToString());
            }

        
        }

        public void add(ClientSubject subject,Client client,User user)
        {

            JObject jo = new JObject();

            jo.Add("clientid", client.Id);
            jo.Add("sn", subject.Sn);
            jo.Add("label", subject.Label);
            jo.Add("fullname", subject.Fullname);
            jo.Add("debitcredit", subject.Debitcredit);
            jo.Add("isnew", 0);
            jo.Add("createby", user.Id);

            string requestJson = jo.ToString();
            string url = AppConfig.GetInstance().BaseUrl + "/client/subject/";

            HttpClient httpClient = AppConfig.GetInstance().crateHttpClient();

            HttpContent httpContent = new StringContent(requestJson);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = httpClient.PostAsync(new Uri(url), httpContent).Result;
            String result = response.Content.ReadAsStringAsync().Result;
            httpClient.Dispose();

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {

            }
            else
            {
                throw new Exception("添加科目错误！" + response.RequestMessage.ToString());
            }

        }

        public void clean(string clientid)
        {

            HttpClient httpClient = AppConfig.GetInstance().crateHttpClient();

            String url = AppConfig.GetInstance().BaseUrl + "/client/subject/clean";

            JObject jo = new JObject();
            jo.Add("clientid", clientid);

            string requestJson = jo.ToString();

            HttpContent httpContent = new StringContent(requestJson);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = httpClient.PostAsync(new Uri(url), httpContent).Result;
            String result = response.Content.ReadAsStringAsync().Result;
            httpClient.Dispose();

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {

            }
            else
            {
                throw new Exception("清理科目错误." + response.RequestMessage.ToString());
            }
        }
    }
}
