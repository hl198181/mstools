using MicroServiceApplication.Bean;
using MicroServiceApplication.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MicroServiceApplication.Factory
{
    class KisDbFileParams
    {
        private string _dbFilePath;
        private string _dbFileName;

        public string DbFilePath
        {
            get
            {
                return _dbFilePath;
            }

            set
            {
                _dbFilePath = value;
            }
        }

        public string DbFileName
        {
            get
            {
                return _dbFileName;
            }

            set
            {
                _dbFileName = value;
            }
        }
    }

    class KisDbFileExportContext
    {
        private KisDbFileParams _params;

        internal KisDbFileParams Params
        {
            get
            {
                return _params;
            }

            set
            {
                _params = value;
            }
        }
    }

    class KisDbAcct
    {
        private String _fcctid;

        public string Fcctid
        {
            get
            {
                return _fcctid;
            }

            set
            {
                _fcctid = value;
            }
        }
    }

    class KisDbFileFactory
    {

        private KisDbFileParams _kdbParams;

        public KisDbFileFactory(KisDbFileParams param)
        {
            this.KdbParams = param;
        }

        internal KisDbFileParams KdbParams
        {
            get
            {
                return _kdbParams;
            }

            set
            {
                _kdbParams = value;
            }
        }

        public List<KisDbAcct> getGLAcct()
        {
            AccessDbClass access = new AccessDbClass(this.KdbParams.DbFilePath);
            String sql = "select * from GLAcct";
            List<KisDbAcct> kisDbAcctList = new List<KisDbAcct>();
            try
            {
                DataTable acctdt = access.SelectToDataTable(sql);

                if (acctdt.Rows.Count > 0)
                {
                    foreach (DataRow row in acctdt.Rows)
                    {
                        KisDbAcct kisDbAcctItem = new KisDbAcct();
                        kisDbAcctItem.Fcctid = row[0].ToString();
                        kisDbAcctList.Add(kisDbAcctItem);
                    }
                }

            }
            catch (Exception e)
            {
                throw (new Exception("数据库出错:" + e.Message));
            }
            finally
            {
                access.Close();
            }
            return kisDbAcctList;
        }
    }

    class KisDbFileExportFactory{
        public void export(KisDbFileParams param)
        {
            KisDbFileExportContext context = new KisDbFileExportContext();

            context.Params = param;

            KisDbFileFactory kdbff = new KisDbFileFactory(context.Params);
            List<KisDbAcct> kisDbAcctList=kdbff.getGLAcct();

            //将数据发送到后台服务器

            //清理现有科目
            //ClientSubjectFactory csf = new ClientSubjectFactory();
            //csf.clean(client.Id);

            //写入科目
            //foreach (KisDbAcct item in kisDbAcctList)
            //{
            //    ClientSubject subject = new ClientSubject();
            //    subject.Sn = item.Subcode;
            //    subject.Label = item.Name;
            //    subject.Fullname = item.Fullname;
            //    subject.Debitcredit = (item.Dcflag == true ? "de" : "cr");
            //    csf.add(subject, client, user);
            //}


        }
    }
}
