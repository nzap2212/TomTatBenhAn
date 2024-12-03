using DAL_.ObjectDAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_.ObjectBUS
{
    public class ChanDoanVaoVienBUS
    {
        private ChanDoanVaoVienDAL chanDoanVaoVien = new ChanDoanVaoVienDAL();

        public List<ChanDoanVaoVienDTO> GetChanDoanVaoVien(string ID)
        {
            return chanDoanVaoVien.GetChanDoanVaoVienInfo(ID);
        }
    }
}
