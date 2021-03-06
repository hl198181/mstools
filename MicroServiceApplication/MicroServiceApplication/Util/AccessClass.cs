﻿using MicroServiceApplication.Bean;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace MicroServiceApplication.Util
{
    public class AccessDbClass
    {

        #region 变量声明处   
        public OleDbConnection Conn;
        public string ConnString;//连接字符串  
        #endregion


        #region 构造函数与连接关闭数据库   
        /**//// <summary>   
                    /// 构造函数   
                    /// </summary>   
                    /// <param name="Dbpath">ACCESS数据库路径</param>   
        public AccessDbClass(string dbFilePath)
        {
            String strDbUser = "morningstar";
            String strDBPass = "ypbwkfyjhyhgzj";
            String securityPath = AppConfig.GetInstance().Kissecurityfile;


            if (securityPath == null || securityPath== "")
            {
                throw new Exception("请先设置金蝶KIS安全文件路径!");
            }
            
            ConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbFilePath + ";User ID=" + strDbUser + ";Password=" + strDBPass + ";Jet OLEDB:Database Password=1;Jet OLEDB:System database="+ securityPath;
            Conn = new OleDbConnection(ConnString);
            Conn.Open();
        }

        /**//// <summary>   
                    /// 打开数据源链接   
                    /// </summary>   
                    /// <returns></returns>   
        public OleDbConnection DbConn()
        {
            Conn.Open();
            return Conn;
        }

        /**//// <summary>   
                    /// 请在数据传递完毕后调用该函数，关闭数据链接。   
                    /// </summary>   
        public void Close()
        {
            Conn.Close();
        }
        #endregion


        #region 数据库基本操作   
        /**//// <summary>   
                    /// 根据SQL命令返回数据DataTable数据表,   
                    /// 可直接作为dataGridView的数据源   
                    /// </summary>   
                    /// <param name="SQL"></param>   
                    /// <returns></returns>   
        public DataTable SelectToDataTable(string SQL)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            OleDbCommand command = new OleDbCommand(SQL, Conn);
            adapter.SelectCommand = command;
            DataTable Dt = new DataTable();
            adapter.Fill(Dt);
            return Dt;
        }

        /**//// <summary>   
                    /// 根据SQL命令返回数据DataSet数据集，其中的表可直接作为dataGridView的数据源。   
                    /// </summary>   
                    /// <param name="SQL"></param>   
                    /// <param name="subtableName">在返回的数据集中所添加的表的名称</param>   
                    /// <returns></returns>   
        public DataSet SelectToDataSet(string SQL, string subtableName)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            OleDbCommand command = new OleDbCommand(SQL, Conn);
            adapter.SelectCommand = command;
            DataSet Ds = new DataSet();
            Ds.Tables.Add(subtableName);
            adapter.Fill(Ds, subtableName);
            return Ds;
        }

        /**//// <summary>   
                    /// 在指定的数据集中添加带有指定名称的表，由于存在覆盖已有名称表的危险，返回操作之前的数据集。   
                    /// </summary>   
                    /// <param name="SQL"></param>   
                    /// <param name="subtableName">添加的表名</param>   
                    /// <param name="DataSetName">被添加的数据集名</param>   
                    /// <returns></returns>   
        public DataSet SelectToDataSet(string SQL, string subtableName, DataSet DataSetName)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            OleDbCommand command = new OleDbCommand(SQL, Conn);
            adapter.SelectCommand = command;
            DataTable Dt = new DataTable();
            DataSet Ds = new DataSet();
            Ds = DataSetName;
            adapter.Fill(DataSetName, subtableName);
            return Ds;
        }

        /**//// <summary>   
                    /// 根据SQL命令返回OleDbDataAdapter，   
                    /// 使用前请在主程序中添加命名空间System.Data.OleDb   
                    /// </summary>   
                    /// <param name="SQL"></param>   
                    /// <returns></returns>   
        public OleDbDataAdapter SelectToOleDbDataAdapter(string SQL)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            OleDbCommand command = new OleDbCommand(SQL, Conn);
            adapter.SelectCommand = command;
            return adapter;
        }

        public bool ExecuteSQLNonqueryone(string sql)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = Conn;
            OleDbTransaction tx = Conn.BeginTransaction();
            cmd.Transaction = tx;
            try
            {
                string strsql = sql.ToString();
                if (strsql.Trim().Length > 1)
                {
                    cmd.CommandText = strsql;
                    cmd.ExecuteNonQuery();
                }
                tx.Commit();
                return true;
<<<<<<< HEAD
            } 
=======
            }
>>>>>>> yyt3
            catch (Exception e)
            {
                tx.Rollback();
                throw e;
            }
<<<<<<< HEAD
=======

            //List<String> sqls = new List<string>();
            //sqls.Add(sql);
>>>>>>> yyt3
        }
        /**//// <summary>   
                    /// 执行SQL命令，不需要返回数据的修改，删除可以使用本函数   
                    /// </summary>   
                    /// <param name="SQL"></param>   
                    /// <returns></returns>   
        public bool ExecuteSQLNonquery(List<String> sqls)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = Conn;
            OleDbTransaction tx = Conn.BeginTransaction();
            cmd.Transaction = tx;
            try
            {
                for (int n = 0; n < sqls.Count; n++)
                {
                    string strsql = sqls[n].ToString();
                    if (strsql.Trim().Length > 1)
                    {
                        cmd.CommandText = strsql;
                        cmd.ExecuteNonQuery();
                    }
                }
                tx.Commit();
                return true;
            }
            catch(Exception e)
            {
                tx.Rollback();
                throw e;
            }
        }
        #endregion
    }
}
