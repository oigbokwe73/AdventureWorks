using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using System.Data;
using System.Configuration;
using System.IO;

namespace AdventureWorksDAL.DataContext
{
    public class BaseContext
    {
        static string _connectionString = "";
        /// <summary>
        ///  connection string can be passed in here from a configuration files
        /// </summary>
        /// <param name="connection_string"></param>
        public void Initialize(string connection_string)
        {
            _connectionString = connection_string;
        }

        public DALDataContext DAL
        {
            get
            {
                try
                {
                    SqlConnection conn = null;
                    if (SqlContext.IsAvailable)
                    {
                        conn = new SqlConnection("Context connection = true");
                    }
                    else
                    {
                        conn = new SqlConnection(_connectionString);
                    }
                    conn.Open();
                    DALDataContext ctx = new DALDataContext(conn);
                    return ctx;
                }
                catch (Exception ex)
                {
                    using(StreamWriter sw = new StreamWriter(string.Format("{0}logs.txt",AppDomain.CurrentDomain.BaseDirectory)))
                    {
                       sw.WriteLine(ex.ToString());
                    }
                    return null;
                }

            }
        }

        protected void Execute(Action<DALDataContext> work)
        {
            DALDataContext ctx = DAL;
            using (IDbConnection conn = ctx.Connection)
            {
                work(ctx);
            }
        }

        protected T Execute<T>(Func<DALDataContext, T> work)
        {
            try
            {
            DALDataContext ctx = DAL;
            T retval = default(T);
            using (IDbConnection connection = ctx.Connection)
            {
                retval = work(ctx);
            }
            return retval;

            }
            catch (Exception ex )
            {
                using (StreamWriter sw = new StreamWriter(string.Format("{0}logs.txt", AppDomain.CurrentDomain.BaseDirectory)))
                {
                    sw.WriteLine(ex.ToString());
                }
                
                throw;
            }
        }

        protected T ExecuteNoLock<T>(Func<DALDataContext, T> work)
        {
            DALDataContext ctx = DAL;
            T retval = default(T);
            using (IDbConnection connection = ctx.Connection)
            {
                ctx.ExecuteCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;");
                retval = work(ctx);
            }
            return retval;
        }
    }
}
