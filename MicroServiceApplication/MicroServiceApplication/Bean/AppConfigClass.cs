using System;
using System.Collections.Generic;
using System.Configuration;
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
            this.loadConfig();
        }

        private void loadConfig()
        {
            foreach(String key in ConfigurationManager.AppSettings)
            {
                if(key == "baseurl")
                {
                    this.BaseUrl = ConfigurationManager.AppSettings[key];
                }
                if (key == "loginurl")
                {
                    this.LoginUrl = ConfigurationManager.AppSettings[key];
                }
                if (key == "kissecurityfile")
                {
                    this.Kissecurityfile = ConfigurationManager.AppSettings[key];
                }
                Console.WriteLine(key);
            }
        }

        public  void updateAppConfig(string newKey, string newValue)
        {
            bool isModified = false;
            foreach (string key in ConfigurationManager.AppSettings)
            {
                if (key == newKey)
                {
                    isModified = true;
                }
            }

            // Open App.Config of executable   
            Configuration config =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // You need to remove the old settings object before you can replace it   
            if (isModified)
            {
                config.AppSettings.Settings.Remove(newKey);
            }
            // Add an Application Setting.   
            config.AppSettings.Settings.Add(newKey, newValue);
            // Save the changes in App.config file.   
            config.Save(ConfigurationSaveMode.Modified);
            // Force a reload of a changed section.   
            ConfigurationManager.RefreshSection("appSettings");
        }

        public void reLoadConfig()
        {
            this.loadConfig();
        }

        public HttpClient crateHttpClient()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.MaxResponseContentBufferSize = 25600000;
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

        private string _baseUrl;

        private string _loginUrl;


        private String _kissecurityfile;

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

        public string Kissecurityfile
        {
            get
            {
                return _kissecurityfile;
            }

            set
            {
                _kissecurityfile = value;
            }
        }
    }
}
