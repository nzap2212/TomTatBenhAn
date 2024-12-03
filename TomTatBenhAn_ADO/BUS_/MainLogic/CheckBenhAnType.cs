using BUS_.ObjectBUS;
using DAL_;
using DAL_.ObjectDAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_.MainLogic
{
    public class CheckBenhAnType
    {
        private static CheckBenhAnType instance;
        public static CheckBenhAnType Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new CheckBenhAnType();
                }
                return instance;
            }
        }

        private CheckBenhAnType() { }

        private BenhAnTypeDAL benhAnTypeDAL = new BenhAnTypeDAL();

        public async Task<object> CheckBenhAn(string ID)
        {
            List<BenhAnTypeDTO> benhAnType = benhAnTypeDAL.GetBenhAnTypeInfo(ID);
            Dictionary<string, object> queryStorage = QueryStorage.Instance.Storage;
            MainDataBUS mainDataBUS = new MainDataBUS();
            Dictionary<string, string> resultDict = new Dictionary<string, string>();

            foreach (var item in queryStorage) 
            {
                if(item.Key == benhAnType[0].LoaiBenhAn)
                {
                    var query_result = mainDataBUS.GetMainData(benhAnType[0].BenhAnTongQuatId, item.Value.ToString())[0];
                    string lyDoVaoVien_result = query_result.LyDoVaoVien;
                    string quaTrinhBenhLy_result = await AskAIa.Instance.TomTatBenhLy(query_result.QuaTrinhBenhLy);
                    string tienSuBenh_result = query_result.TienSuBenh;
                    string phuongPhapDieuTri_result = query_result.PhuongPhapDieuTri;
                    resultDict.Add("lyDoVaoVien", lyDoVaoVien_result);
                    resultDict.Add("quaTrinhBenhLy", quaTrinhBenhLy_result);
                    resultDict.Add("tienSuBenh", tienSuBenh_result);
                    resultDict.Add("phuongPhapDieuTri", phuongPhapDieuTri_result);
                    return resultDict;
                }
            }
            return false;
        }
    }
}
