using DAL_.ObjectDAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_.ObjectBUS
{
    public class KetQuaXetNghiemclsBUS
    {
        private static KetQuaXetNghiemclsBUS instance;

        public static KetQuaXetNghiemclsBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KetQuaXetNghiemclsBUS();
                }
                return instance;
            }
        }

        private KetQuaXetNghiemclsBUS() { }

        private KetQuaXetNghiemclsDAL ketQuaXetNghiemclsDAL = new KetQuaXetNghiemclsDAL();

        public List<KetQuaXetNghiemclsDTO> GetKetQuaXetNghiem(string ID)
        {
            if (ketQuaXetNghiemclsDAL.GetKetQuaXetNghiemInfo(ID).Count == 0)
            {
                return null;
            }
            else
            {
                return ketQuaXetNghiemclsDAL.GetKetQuaXetNghiemInfo(ID);
            }
        }
    }
}
