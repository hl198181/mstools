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
    class ClientSubjectLength
    {
        private string _clientid;
        private int _subject1;
        private int _subject2;
        private int _subject3;
        private int _subject4;
        private int _subject5;
        private int _subject6;
        private int _subject7;
        private int _subject8;
        private int _subject9;
        private int _subject10;
        private string _createby;
        private string _remark;

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

        public int Subject1
        {
            get
            {
                return _subject1;
            }

            set
            {
                _subject1 = value;
            }
        }

        public int Subject2
        {
            get
            {
                return _subject2;
            }

            set
            {
                _subject2 = value;
            }
        }

        public int Subject3
        {
            get
            {
                return _subject3;
            }

            set
            {
                _subject3 = value;
            }
        }

        public int Subject4
        {
            get
            {
                return _subject4;
            }

            set
            {
                _subject4 = value;
            }
        }

        public int Subject5
        {
            get
            {
                return _subject5;
            }

            set
            {
                _subject5 = value;
            }
        }

        public int Subject6
        {
            get
            {
                return _subject6;
            }

            set
            {
                _subject6 = value;
            }
        }

        public int Subject7
        {
            get
            {
                return _subject7;
            }

            set
            {
                _subject7 = value;
            }
        }

        public int Subject8
        {
            get
            {
                return _subject8;
            }

            set
            {
                _subject8 = value;
            }
        }

        public int Subject9
        {
            get
            {
                return _subject9;
            }

            set
            {
                _subject9 = value;
            }
        }

        public int Subject10
        {
            get
            {
                return _subject10;
            }

            set
            {
                _subject10 = value;
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

    class ClientSubjectLengthFactory
    {
        public void add(ClientSubjectLength csl)
        {
            if (csl == null) throw new ArgumentException("添加客户科目长度参数错误!");
            
            JObject jo = new JObject();
            jo.Add("clientid", csl.Clientid);
            jo.Add("createby", csl.Createby);
            jo.Add("subject1", csl.Subject1);
            jo.Add("subject2", csl.Subject2);
            jo.Add("subject3", csl.Subject3);
            jo.Add("subject4", csl.Subject4);
            jo.Add("subject5", csl.Subject5);
            jo.Add("subject6", csl.Subject6);
            jo.Add("subject7", csl.Subject7);
            jo.Add("subject8", csl.Subject8);
            jo.Add("subject9", csl.Subject9);
            jo.Add("subject10", csl.Subject10);

            string requestJson = jo.ToString();
            string url = AppConfig.GetInstance().BaseUrl + "/client/subject/length";
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
    }
}
