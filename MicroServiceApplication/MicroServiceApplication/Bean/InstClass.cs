﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace MicroServiceApplication.Bean
{
    class Inst
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
       
        public Inst(JObject jobject)
        {
            
            this.Name = jobject.GetValue("name").ToString();
            this.Id = jobject.GetValue("id").ToString();

            this.Logo = jobject.GetValue("logo").ToString();
            //this.Logourl = jobject.GetValue("logourl").ToString();
        }
    }

    class InstFactory
    {
        public List<Inst> queryByUserById(string userid){
            List<Inst> instList = new List<Inst>();

            HttpClient httpClient = AppConfig.GetInstance().crateHttpClient();
            String url = AppConfig.GetInstance().BaseUrl+"/user/inst?userid=" + userid;
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

                Inst inst = new Inst(item.Value<JObject>());
                instList.Add(inst);
            }

            return instList;
        }

    }
}
