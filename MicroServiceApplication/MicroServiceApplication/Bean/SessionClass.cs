using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MicroServiceApplication.Bean;

namespace MicroServiceApplication
{
    class Session
    {
        private static Session instance;
        private static object _lock = new object();

        private User _user;

        internal User User
        {
            get { return _user; }
            set { _user = value; }
        }

        private Inst _inst;

        internal Inst Inst
        {
            get { return _inst; }
            set { _inst = value; }
        }

        private Session()
        {

        }

        public static Session GetInstance()
        {
            if (instance == null)
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new Session();
                    }
                }
            }
            return instance;
        }
    }
}
