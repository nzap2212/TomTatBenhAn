using DAL_.ObjectDAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_.ObjectBUS
{
    public class TinhTrangNguoiBenhRaVienBUS
    {
        private static TinhTrangNguoiBenhRaVienBUS instance;
        public static TinhTrangNguoiBenhRaVienBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TinhTrangNguoiBenhRaVienBUS();   
                }
                return instance;
            }
        }
        private TinhTrangNguoiBenhRaVienBUS() { }

        private TinhTrangNguoiBenhRaVienDAL tinhTrangNguoiBenhRaVien = new TinhTrangNguoiBenhRaVienDAL();

        public List<TinhTrangNguoiBenhRaVienDTO> GetTinhTrangNguoiBenhRaVien(string ID)
        {
            return tinhTrangNguoiBenhRaVien.GetTinhTrangNguoiBenhRaVienInfo(ID);
        }
    }
}
