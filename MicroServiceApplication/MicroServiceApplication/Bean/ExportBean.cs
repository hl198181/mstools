using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MicroServiceApplication.Bean
{
    class ExportBean
    {
        private string _instid;

        public string Instid
        {
            get { return _instid; }
            set { _instid = value; }
        }

        private string _clientid;

        public string Clientid
        {
            get { return _clientid; }
            set { _clientid = value; }
        }

        private string _accountcyclesn;

        public string Accountcyclesn
        {
            get { return _accountcyclesn; }
            set { _accountcyclesn = value; }
        }

        private string _createby;

        public string Createby
        {
            get { return _createby; }
            set { _createby = value; }
        }

        private string _categoryname;

        public string Categoryname
        {
            get { return _categoryname; }
            set { _categoryname = value; }
        }

        private string _path;

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        private string _fileName;

        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }
    }
}
