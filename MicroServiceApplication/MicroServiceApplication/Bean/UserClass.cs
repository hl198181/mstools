using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace MicroServiceApplication.Bean
{
    class UserClass
    {
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


        public UserClass(JObject jobject)
        {
            this.Name = jobject.GetValue("name").ToString();
            this.No = jobject.GetValue("no").ToString();
            this.Id = jobject.GetValue("id").ToString();
        }
    }

}
