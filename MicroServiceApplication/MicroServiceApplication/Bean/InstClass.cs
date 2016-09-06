using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace MicroServiceApplication.Bean
{
    class InstClass
    {
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
       
        private string _logo;

        public string Logo
        {
            get { return _logo; }
            set { _logo = value; }
        }

        private string logourl;

        public string Logourl
        {
            get { return logourl; }
            set { logourl = value; }
        }
       
        public InstClass(JObject jobject)
        {
            
            this.Name = jobject.GetValue("name").ToString();
            this.Id = jobject.GetValue("id").ToString();

            this.Logo = jobject.GetValue("logo").ToString();
            //this.Logourl = jobject.GetValue("logourl").ToString();
        }
    }

    class InstFactory
    {
        public List<InstClass> queryByUserById(string userid){
            List<InstClass> instList = new List<InstClass>();

            HttpClient httpClient = new HttpClient();
            httpClient.MaxResponseContentBufferSize = 256000;
            httpClient.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)");
            httpClient.DefaultRequestHeaders.Add("Authorization", "Basic c2VydmljZTpjNUNVN0ZBNVZOczdNOXJUZVlHU3pXZGpETzBWZmY=");

            String url = "http://www.yun9.com/service/user/inst?userid=" + userid;
            HttpResponseMessage response = httpClient.GetAsync(url).Result;
            String result = response.Content.ReadAsStringAsync().Result;
            httpClient.Dispose();
            
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
               MessageBox.Show("获取用户机构信息错误："+response.ReasonPhrase);              
               return null;
            }
            
            JArray ja = JArray.Parse(result);

            foreach (var item in ja)
            {
                
                InstClass inst = new InstClass(item.Value<JObject>());
                instList.Add(inst);
            }

            return instList;
        }

    }
}
