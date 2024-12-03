using DTO;
using DAL_.ObjectDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_.ObjectBUS
{
    public class SoBenhAnBUS
    {
        private SoBenhAnDAL soBenhAnDAL = new SoBenhAnDAL();

        public List<SoBenhAnDTO> GetSoBenhAn(string ID)
        {
            return soBenhAnDAL.GetSoBenhAnInfo(ID);
        }
    }
}
