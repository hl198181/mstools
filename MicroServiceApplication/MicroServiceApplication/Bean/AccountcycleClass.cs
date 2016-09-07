using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
using MicroServiceApplication.Bean;
using System.Net.Http;

namespace MicroServiceApplication
{
    class Accountcycle
    {
        private string _id;

        private int _quarter;

        private int _year;

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _sn;

        public string Sn
        {
            get { return _sn; }
            set { _sn = value; }
        }
        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

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

        public int Quarter
        {
            get
            {
                return _quarter;
            }

            set
            {
                _quarter = value;
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }

            set
            {
                _year = value;
            }
        }

        public Accountcycle(JObject jobject)
        {
            this.Name = jobject["name"] == null ? null : jobject["name"].ToString();
            this.Sn = jobject["sn"] == null ? null : jobject["sn"].ToString();
            this.Id = jobject["id"] == null ? null : jobject["id"].ToString();
            this.Type = jobject["type"] == null ? null : jobject["type"].ToString();
            this.Quarter = jobject["quarter"].ToObject<int>();
            this.Year = jobject["year"].ToObject<int>();
        }
    }

    class AccountcycleFactory
    {
        public List<Accountcycle> query(int lastmonth,int aftermonth)
        {
            HttpClient httpClient = AppConfig.GetInstance().crateHttpClient();

            String url = AppConfig.GetInstance().BaseUrl + "/accountcycle?lastmonth=" + lastmonth + "&aftermonth=" + aftermonth;
            HttpResponseMessage response = httpClient.GetAsync(url).Result;
            String result = response.Content.ReadAsStringAsync().Result;
            httpClient.Dispose();

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception("查询客户信息错误." + response.RequestMessage.ToString());
            }

            List<Accountcycle> accountcycleList = new List<Accountcycle>();

            JArray ja = JArray.Parse(result);

            foreach (var item in ja)
            {
                Accountcycle accountcycle = new Accountcycle(item.Value<JObject>());
                accountcycleList.Add(accountcycle);
            }

            return accountcycleList;
        }
    }
}
