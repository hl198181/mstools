using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace MicroServiceApplication.Bean
{
    class AppConfig
    {

        private static AppConfig instance;
        private static object _lock = new object();

        private AppConfig()
        {

        }

        public HttpClient crateHttpClient()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.MaxResponseContentBufferSize = 256000;
            httpClient.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)");
            httpClient.DefaultRequestHeaders.Add("Authorization", "Basic c2VydmljZTpjNUNVN0ZBNVZOczdNOXJUZVlHU3pXZGpETzBWZmY=");
            return httpClient;
        }

        public static AppConfig GetInstance()
        {
            if (instance == null)
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new AppConfig();
                    }
                }
            }
            return instance;
        }

        private string _baseUrl = "http://www.yun9.com/service";

        public string BaseUrl
        {
            get
            {
                return _baseUrl;
            }

            set
            {
                _baseUrl = value;
            }
        }

        public string LoginUrl
        {
            get
            {
                return _loginUrl;
            }

            set
            {
                _loginUrl = value;
            }
        }

        private string _loginUrl = "http://www.yun9.com/auth";


    }
}
