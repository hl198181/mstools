using System;
using System.Collections.Generic;

using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using MicroServiceApplication.Bean;

namespace MicroServiceApplication
{
   
    class ExportKisClass
    {
        public void Create(string filename,string tablename)
        {
            string outconnstring = string.Format("Provider = Microsoft.Jet.OLEDB.4.0 ;Data Source ={0};Extended Properties=dBASE IV;", filename);
            OleDbConnection outConn = new OleDbConnection(outconnstring);
            OleDbCommand dc = outConn.CreateCommand();
            try
            {
                outConn.Open();
                dc.CommandType = CommandType.Text;
                dc.CommandText = "CREATE TABLE " + tablename + " (FDate Date,FPeriod Numeric(4,0),FGroup Char(4),FNum Numeric(4,0),FEntryID Numeric(4,0),FExp Char(60),FAcctID Char(30),FClsName1 Char(20),FObjID1 Char(10),FObjName1 Char(20),FClsName2 Char(20),FObjID2 Char(10),FObjName2 Char(20),FClsName3 Char(20),FObjID3 Char(10),FObjName3 Char(20),FClsName4 Char(20),FObjID4 Char(10),FObjName4 Char(20),FTransID Char(10),FCyID Char(3),FExchRate Numeric(19,10),FDC Char(1),FFCyAmt Numeric(14,2),FQty Numeric(8,2),FPrice Numeric(10,7),FDebit Numeric(14,2),FCredit Numeric(14,2),FSettlCode Char(8),FSettleNo Char(8),FPrepare Char(8),FPay Char(8),FCash Char(8),FPoster Char(8),FChecker Char(8),FAttchment Numeric(5,0),FPosted Logical,FModule Char(2),FDeleted Logical,FSerialNo Numeric(10,0))";
                dc.ExecuteNonQuery();
            }
            catch (Exception c)
            {
                throw c;
            }
            finally
            {
                dc.Dispose();
                if (outConn.State == System.Data.ConnectionState.Open)
                    outConn.Close();
                outConn.Dispose();
            }
        }

        public void Save(string filename,string tablename,List<KisVoucherInfo> vouchers)
        {
            string outconnstring = string.Format("Provider = Microsoft.Jet.OLEDB.4.0 ;Data Source ={0};Extended Properties=dBASE IV;", filename);
            OleDbConnection outConn=new OleDbConnection(outconnstring);
            
            try
            {
                outConn.Open();
                foreach (var rec in vouchers)
                {
                    OleDbCommand dc = outConn.CreateCommand();
                    string tmp = "insert into " + tablename + "(FDate,FPeriod,FGroup,FNum,FEntryID,FExp,FAcctID,FCyID,FExchRate,FDC,FFCyAmt,FQty,FPrice,FDebit,FCredit,FPrepare,FAttchment,FPosted,FDeleted,FSerialNo) values('{0}',{1},'{2}',{3},{4},'{5}','{6}','{7}',{8},'{9}',{10},{11},{12},{13},{14},'{15}',{16},{17},{18},{19})";
                    dc.CommandText = string.Format(tmp, rec.FDate, rec.FPeriod, rec.FGroup, rec.FNum, rec.FEntryID, rec.FExp, rec.FAcctID, rec.FCyID, rec.FExchRate, rec.FDC, rec.FFCyAmt, rec.FQty, rec.FPrice, rec.FDebit, rec.FCredit, rec.FPrepare, rec.FAttchment, rec.FPosted, rec.FDeleted, rec.FSerialNo);
                    dc.ExecuteNonQuery();
                    dc.Dispose();
                }
            }
            catch(Exception err)
            {
                throw err;
            }
            finally
            {
                if(outConn!=null)
                    outConn.Close();
                
                outConn.Dispose();
            }
        }
       
        public void exports(ExportBean exportBean)
        {
            try
            {
                KisVoucherFactory kvf = new KisVoucherFactory();
                List<KisVoucherInfo> vouchers = kvf.getKisVoucher(exportBean.Instid, exportBean.Clientid, exportBean.Accountcyclesn, exportBean.Createby, exportBean.Categoryname);
                
                this.Create(exportBean.Path, exportBean.FileName);
                this.Save(exportBean.Path, exportBean.FileName, vouchers);

                MessageBox.Show("导出成功!");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                MessageBox.Show("导出错误:"+e.Message);
            }
        }

    }
}
