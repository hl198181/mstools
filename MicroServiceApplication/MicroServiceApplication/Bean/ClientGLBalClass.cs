using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MicroServiceApplication.Bean
{
    class ClientGLBal
    {
        private int _fPeriod;
        private string _fAcctID;
        private int _fClsID;
        private string _fObjID;
        private string _fCyID;
        private bool _fBase;
        private decimal _fDebit;
        private decimal _fCredit;
        private decimal _fYtdDebit;
        private decimal _fYtdCredit;
        private decimal _fEndBal;
        private decimal _fBegBal;
        private string _clientid;

        public int FPeriod
        {
            get
            {
                return _fPeriod;
            }

            set
            {
                _fPeriod = value;
            }
        }

        public string FAcctID
        {
            get
            {
                return _fAcctID;
            }

            set
            {
                _fAcctID = value;
            }
        }

        public int FClsID
        {
            get
            {
                return _fClsID;
            }

            set
            {
                _fClsID = value;
            }
        }

        public string FObjID
        {
            get
            {
                return _fObjID;
            }

            set
            {
                _fObjID = value;
            }
        }

        public string FCyID
        {
            get
            {
                return _fCyID;
            }

            set
            {
                _fCyID = value;
            }
        }

        public bool FBase
        {
            get
            {
                return _fBase;
            }

            set
            {
                _fBase = value;
            }
        }

        public decimal FDebit
        {
            get
            {
                return _fDebit;
            }

            set
            {
                _fDebit = value;
            }
        }

        public decimal FCredit
        {
            get
            {
                return _fCredit;
            }

            set
            {
                _fCredit = value;
            }
        }

        public decimal FYtdDebit
        {
            get
            {
                return _fYtdDebit;
            }

            set
            {
                _fYtdDebit = value;
            }
        }

        public decimal FYtdCredit
        {
            get
            {
                return _fYtdCredit;
            }

            set
            {
                _fYtdCredit = value;
            }
        }

        public decimal FEndBal
        {
            get
            {
                return _fEndBal;
            }

            set
            {
                _fEndBal = value;
            }
        }

        public decimal FBegBal
        {
            get
            {
                return _fBegBal;
            }

            set
            {
                _fBegBal = value;
            }
        }

        public string Clientid
        {
            get
            {
                return _clientid;
            }

            set
            {
                _clientid = value;
            }
        }
    }
    class ClientGLBalClass
    {

    }
}
