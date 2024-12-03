using DAL_.ObjectDAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_.ObjectBUS
{
    public class MainDataBUS
    {
        private MainDataDAL mainDataDAL = new MainDataDAL();
        public List<MainDataDTO> GetMainData(string ID, string query)
        {
            return mainDataDAL.GetMainDataInfo(ID, query);  
        }
    }
}
