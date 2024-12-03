using DAL_.ObjectDAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_.ObjectBUS
{
    public class HanhChinhBUS
    {
        private HanhChinhDAL hanhChinhDAL = new HanhChinhDAL();
        
        public List<HanhChinhDTO> GetHanhChinh(string ID)
        {
            return hanhChinhDAL.GetHanhChinhInfo(ID);
        }
    }
}
