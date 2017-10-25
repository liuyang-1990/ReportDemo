using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SqlSugar;
using SyntacticSugar;

namespace ReportDemo.Dao
{
    public class SugarDao
    {
        public static SqlSugarClient GetInstance()
        {
            try
            {
                var db = new SqlSugarClient(new ConnectionConfig()
                {
                    ConnectionString = ConfigSugar.GetConnectionString("DefaultConnection"),
                    IsAutoCloseConnection = true,
                    DbType = DbType.SqlServer
                });
                return db;
            }
            catch (Exception ex)
            {
                throw new Exception("连接数据库出错，请检查您的连接字符串，和网络。 ex:".AppendString(ex.Message));
            }

        }
    }
}