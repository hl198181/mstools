using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace MicroServiceApplication.Bean
{
    class AuthClass
    {

        public Boolean checkIn(String userNo, String password)
        {
            HttpClient httpClient = AppConfig.GetInstance().crateHttpClient();
            String url = AppConfig.GetInstance().LoginUrl;

            List<KeyValuePair<String,String>> paramList = new List<KeyValuePair<String,String>>();
            paramList.Add(new KeyValuePair<string, string>("userno",userNo));
            paramList.Add(new KeyValuePair<string, string>("password",password));
            HttpResponseMessage response = httpClient.PostAsync(new Uri(url), new FormUrlEncodedContent(paramList)).Result;
            String result = response.Content.ReadAsStringAsync().Result;
            httpClient.Dispose();

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                JObject jo = JObject.Parse(result);

                //设置登录环境变量
                Session.GetInstance().User = new Bean.User(jo.ToObject<JObject>());
                return true;
            }
            else
            {
                MessageBox.Show("登录错误,请检查用户名以及密码.");
                return false;
            }

            

            //string id = jo.GetValue("id").ToString();
            //string[] values = jo.Properties().Select(item => item.Value.ToString()).ToArray();
        }
    }
}
