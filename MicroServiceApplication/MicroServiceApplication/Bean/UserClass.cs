using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace MicroServiceApplication.Bean
{
    class User
    {
        private string _baseauth;
        private string _baseauthappid;
        private string _baseauthappsecret;
        private string _baseauthid;
<<<<<<< HEAD
        private string _baseauthtoken;
=======
        private string baseauthtoken;
>>>>>>> yyt3
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _no;

        public string No
        {
            get { return _no; }
            set { _no = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Baseauth
        {
            get
            {
                return _baseauth;
            }

            set
            {
                _baseauth = value;
            }
        }

        public string Baseauthappid
        {
            get
            {
                return _baseauthappid;
            }

            set
            {
                _baseauthappid = value;
            }
        }

        public string Baseauthappsecret
        {
            get
            {
                return _baseauthappsecret;
            }

            set
            {
                _baseauthappsecret = value;
            }
        }

        public string Baseauthid
        {
            get
            {
                return _baseauthid;
            }

            set
            {
                _baseauthid = value;
            }
        }

        public string Baseauthtoken
        {
            get
            {
<<<<<<< HEAD
                return _baseauthtoken;
=======
                return baseauthtoken;
>>>>>>> yyt3
            }

            set
            {
<<<<<<< HEAD
                _baseauthtoken = value;
=======
                baseauthtoken = value;
>>>>>>> yyt3
            }
        }

        public User(JObject jobject)
        {
            this.Name = jobject.GetValue("name").ToString();
            this.No = jobject.GetValue("no").ToString();
            this.Id = jobject.GetValue("id").ToString();
            this.Baseauth = jobject.GetValue("baseauth").ToString();
            this.Baseauthappid = jobject.GetValue("baseauth")["appid"].ToString();
            this.Baseauthappsecret = jobject.GetValue("baseauth")["appsecret"].ToString();
            this.Baseauthid = jobject.GetValue("baseauth")["id"].ToString();
            this.Baseauthtoken = jobject.GetValue("baseauth")["token"].ToString();
        }
    }

}
