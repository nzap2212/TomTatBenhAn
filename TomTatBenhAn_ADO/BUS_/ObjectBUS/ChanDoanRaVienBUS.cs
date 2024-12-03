using DAL_.ObjectDAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_.ObjectBUS
{
    public class ChanDoanRaVienBUS
    {
        private ChanDoanRaVienDAL chanDoanRaVien = new ChanDoanRaVienDAL();

        public List<ChanDoanRaVienDTO> GetChanDoanRaVien(string ID)
        {
            return chanDoanRaVien.GetChanDoanRaVienInfo(ID);
        }
    }
}
