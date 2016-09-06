using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MicroServiceApplication.Bean;

namespace MicroServiceApplication
{
    class SessionClass
    {
        private static SessionClass instance;
        private static object _lock = new object();

        private UserClass _user;

        internal UserClass User
        {
            get { return _user; }
            set { _user = value; }
        }

        private InstClass _inst;

        internal InstClass Inst
        {
            get { return _inst; }
            set { _inst = value; }
        }

        private SessionClass()
        {

        }

        public static SessionClass GetInstance()
        {
            if (instance == null)
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new SessionClass();
                    }
                }
            }
            return instance;
        }
    }
}
