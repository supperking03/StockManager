using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using DAL.Properties;
 

namespace DAL
{
    public class DataAccessHelper
    {
        #region ConnectionString

        public static string ConnectionString
        {
            get
            {
                return Settings.Default.ConnectionString;
            }
        }


        #endregion
        #region ExecuteQuery

        public static DataTable ExecuteQuery(string query, List<SQLiteParameter> parameters = null)
        {
            var dt = new DataTable();
            try
            {
                var connect = new SQLiteConnection(ConnectionString);
                connect.Open();
                try
                {
                    var ds = new DataSet();
                    ds.Reset();
                    var adapter = new SQLiteDataAdapter(query, connect);
                    if (parameters != null)
                    {
                        adapter.SelectCommand.Parameters.AddRange(parameters.ToArray());
                    }
                    adapter.Fill(ds);
                    dt = ds.Tables[0];
                }

                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    connect.Close();
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        #endregion
        #region ExecuteNonQuery

        public static int ExecuteNonQuery(string query, List<SQLiteParameter> parameters = null)
        {
            int n;
            try
            {
                var connect = new SQLiteConnection(ConnectionString);
                connect.Open();
                try
                {
                    var command = connect.CreateCommand();
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters.ToArray());
                    }
                    command.CommandText = query;
                    n = command.ExecuteNonQuery();
                }

                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    connect.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return n;
        }

        #endregion
    }
}