using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BUS
{
    public class ThamSoBUS
    {
        public static bool UpdateSoTienTrenKm(double sotientrenkm)
        {
            return ThamSoDAL.UpdateSoTienTrenKm(sotientrenkm);
        }

        public static bool UpdatePhiThuHo(double phithuho)
        {
            return ThamSoDAL.UpdatePhiThuHo(phithuho);
        }

        public static double GetSoTienTrenKm()
        {
            return ThamSoDAL.GetSoTienTrenKm();
        }

        public static double GetPhiThuHo()
        {
            return ThamSoDAL.GetPhiThuHo();
        }

    }
}
