using DAL_.ObjectDAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_.ObjectBUS
{
    public class BenhNhanBUS
    {
        private BenhNhanDAL _BenhNhanDAL = new BenhNhanDAL();

        public List<BenhNhanDTO> GetBenhNhanBUS(string ID)
        {
            return _BenhNhanDAL.GetBenhNhan(ID);
        }
    }
}
