using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace DAL
{
    public static class ThamSoDAL
    {
        public static bool UpdateSoTienTrenKm(double sotientrenkm)
        {
            var result = false;
            try
            {
                var parameters = new List<SQLiteParameter>
                {
                    new SQLiteParameter ( "@SoTienTrenKm", sotientrenkm )
                };
                var n = DataAccessHelper.ExecuteNonQuery(
                    "Update THAMSO Set SoTienTrenKm = @SoTienTrenKm", parameters);
                if (n == 1)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public static bool UpdatePhiThuHo(double phithuho)
        {
            var result = false;
            try
            {
                var parameters = new List<SQLiteParameter>
                {
                    new SQLiteParameter ( "@PhiThuHo", phithuho )
                };
                var n = DataAccessHelper.ExecuteNonQuery(
                    "Update THAMSO Set PhiThuHo = @PhiThuHo", parameters);
                if (n == 1)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }


        public static double GetSoTienTrenKm()
        {
            var sotientrenkm = 0;
            try
            {
                var dt = DataAccessHelper.ExecuteQuery("Select SoTienTrenKm from THAMSO");
                var dr = dt.Rows[0];
                sotientrenkm = int.Parse(dr["SoTienTrenKm"].ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return sotientrenkm;
        }

        public static double GetPhiThuHo()
        {
            double phithuho = 0;
            try
            {
                var dt = DataAccessHelper.ExecuteQuery("Select PhiThuHo from THAMSO");
                var dr = dt.Rows[0];
                phithuho = double.Parse(dr["PhiThuHo"].ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return phithuho;
        }
    }
}
