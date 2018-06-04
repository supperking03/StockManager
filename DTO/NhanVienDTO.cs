using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        private string _strMaNhanVien;
        private string _strTenNhanVien;
        public string MaNhanVien
        {
            get
            {
                return _strMaNhanVien;
            }
            set
            {
                _strMaNhanVien = value;
            }
        }

        public string TenNhanVien
        {
            get
            {
                return _strTenNhanVien;
            }
            set
            {
                _strTenNhanVien = value;
            }
        }

        public NhanVienDTO()
        {
            _strMaNhanVien = "";
            _strTenNhanVien = "";
        }

        public NhanVienDTO(string MaNhanVien, string TenNhanVien)
        {
            _strMaNhanVien = MaNhanVien;
            _strTenNhanVien = TenNhanVien;
        }

        public NhanVienDTO(NhanVienDTO nvDTO)
        {
            _strMaNhanVien = nvDTO.MaNhanVien;
            _strTenNhanVien = nvDTO.TenNhanVien;
        }
    }
}
