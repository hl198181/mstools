using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace MicroServiceApplication.Bean
{
    class Client
    {
        private string _id;
        private string _instid;
        private string _sn;
        private string _name;
        private string _fullname;
        private string _state;
        private string _taxno;
        private string _taxtype;
        private string _boxno;
        private string _taxtypeccname;
        private string _stateccname;

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

        public string State
        {
            get
            {
                return _state;
            }

            set
            {
                _state = value;
            }
        }

        public string Taxno
        {
            get
            {
                return _taxno;
            }

            set
            {
                _taxno = value;
            }
        }

        public string Taxtype
        {
            get
            {
                return _taxtype;
            }

            set
            {
                _taxtype = value;
            }
        }

        public string Boxno
        {
            get
            {
                return _boxno;
            }

            set
            {
                _boxno = value;
            }
        }

        public string Taxtypeccname
        {
            get
            {
                return _taxtypeccname;
            }

            set
            {
                _taxtypeccname = value;
            }
        }

        public string Stateccname
        {
            get
            {
                return _stateccname;
            }

            set
            {
                _stateccname = value;
            }
        }

        public Client()
        {

        }

        public Client(JObject joClient)
        {
            if (joClient != null)
            {
                this.Id = joClient["id"] == null ? null : joClient["id"].ToString();
                this.Sn = joClient["sn"] == null ? null : joClient["sn"].ToString();
                this.Name = joClient["name"] == null ? null : joClient["name"].ToString();
                this.Fullname = joClient["fullname"] == null ? null : joClient["fullname"].ToString();
                this.State = joClient["state"] == null ? null : joClient["state"].ToString();
                this.Stateccname = joClient["stateccname"] == null ? null : joClient["stateccname"].ToString();
                this.Taxno = joClient["taxno"] == null ? null : joClient["taxno"].ToString();
                this.Taxtype = joClient["taxtype"] == null ? null : joClient["taxtype"].ToString();
                this.Taxtypeccname = joClient["taxtypeccname"] == null ? null : joClient["taxtypeccname"].ToString();
                this.Boxno = joClient["boxno"] == null ? null : joClient["boxno"].ToString();
                this.Instid = joClient["instid"] == null ? null : joClient["instid"].ToString();
            }
          
        }
    }

    class ClientFactory
    {
        public List<Client> queryByInst(string instid)
        {
            HttpClient httpClient = AppConfig.GetInstance().crateHttpClient();

            String url = AppConfig.GetInstance().BaseUrl + "/client?instid="+instid;
            HttpResponseMessage response = httpClient.GetAsync(url).Result;
            String result = response.Content.ReadAsStringAsync().Result;
            httpClient.Dispose();

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception("查询客户信息错误."+response.RequestMessage.ToString());
            }

            List<Client> clientList = new List<Client>();

            JArray ja = JArray.Parse(result);

            foreach (var item in ja)
            {
                Client client = new Client(item.Value<JObject>());
                clientList.Add(client);
            }

            return clientList;
        }
    }
}
