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
        public void addBySd3000Accoptions(string clientid,string createby, Dictionary<string, Sd3000Accoptions> accoptions)
        {
            if (clientid == null || clientid == "") throw new ArgumentException("添加客户科目长度参数错误!");
            if (createby == null || createby == "") throw new ArgumentException("添加客户科目长度参数错误!");
            if (accoptions == null) throw new ArgumentException("添加客户科目长度参数错误!");
            
            JObject jo = new JObject();
            jo.Add("clientid", clientid);
            jo.Add("createby", createby);
            for (int i = 1; i <= 10; i++)
            {
                string tempValue = accoptions["SC"+i+"LENGTH"].Optionvalue;
                if (tempValue == null || tempValue == "") throw new Exception("无法获取财务账套的"+i+"级科目长度配置信息!");
                jo.Add("subject"+i, int.Parse(tempValue));
            }
          
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
