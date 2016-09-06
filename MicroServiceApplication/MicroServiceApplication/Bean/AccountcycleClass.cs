using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace MicroServiceApplication
{
    class Accountcycle
    {
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

        public Accountcycle(JObject jobject)
        {
            this.Name = jobject.GetValue("name").ToString();
            this.Sn = jobject.GetValue("sn").ToString();
        }
    }
}
