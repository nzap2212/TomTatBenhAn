using BUS_.ObjectBUS;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_.MainLogic
{
    public class AskAIa
    {
        private static AskAIa instance;
        public static AskAIa Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AskAIa();
                }
                return instance;
            }
        }

        private AskAIa() { }

        private Dictionary<string,string> envData = ReadFileEnv.Instance.envData;

        //Hàm tóm tắt quá trình bệnh lý và dấu hiệu lâm sàng
        public async Task<string> TomTatBenhLy(string data)
        {
            string question = ReadFileEnv.Instance.envData["PROMT_BENHAN"];
            string result_question = question.Replace("@QuaTrinhBenhLy", data);

            var requestData = new
            {
                contents = new[] {
                    new {
                        parts = new[] {
                            new {
                                text = result_question
                            }
                        }
                    }
                }
            };

            try
            {
                // gửi request đi
                var client = new RestClient(envData["API_URL"] + envData["API_KEY_1"]);
                var request = new RestRequest("", Method.Post);
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(requestData);

                RestResponse response = await client.ExecuteAsync(request);
                if (response.IsSuccessful)
                {
                    var jsonResponse = JObject.Parse(response.Content);
                    var result_text = jsonResponse["candidates"][0]["content"]["parts"][0]["text"].ToString();
                    return result_text;
                }
                else
                {
                    throw new AskAiErr("Lỗi khi nhận phản hồi tóm tắt");
                }
            }
            catch (Exception ex)
            {
                throw new AskAiErr(ex.Message);
            }
        }

        // Hàm tóm tắt kết quả xét nghiệm cận lâm sàng 
        public async Task<string> TomTatKetQuaXN(string ID, string ChanDoanChinh)
        {
            try
            {
                var list_kqxn = KetQuaXetNghiemclsBUS.Instance.GetKetQuaXetNghiem(ID);
                if (list_kqxn != null)
                {
                    string kqxn_json = JsonConvert.SerializeObject(list_kqxn, Formatting.Indented);
                    string question = envData["PROMT_KQXN"];
                    question = question.Replace("@ChanDoanChinh", ChanDoanChinh);
                    question = question.Replace("@DanhSachKQXN", kqxn_json);

                    var requestData = new
                    {
                        contents = new[] {
                    new {
                        parts = new[] {
                            new {
                                text = question
                            }
                        }
                    }
                }
                    };

                    // gửi request đi
                    var client = new RestClient(envData["API_URL"] + envData["API_KEY_2"]);
                    var request = new RestRequest("", Method.Post);
                    request.AddHeader("Content-Type", "application/json");
                    request.AddJsonBody(requestData);

                    RestResponse response = await client.ExecuteAsync(request);
                    if (response.IsSuccessful)
                    {
                        var jsonResponse = JObject.Parse(response.Content);
                        var result_text = jsonResponse["candidates"][0]["content"]["parts"][0]["text"].ToString();
                        return result_text;
                    }
                    else
                    {
                        throw new AskAiErr("Lỗi khi nhận phản hồi tóm tắt");
                    }
                }
                else
                {
                    return "Bệnh nhân chưa sử dụng dịch vụ xét nghiệm nào";
                }
            }
            catch(Exception ex)
            {
                throw new AskAiErr("Lỗi tại hàm tóm tắt kết quả xét nghiệm: " + ex.Message);
            }
        }

        //Hàm tóm tắt tình trạng người bệnh ra viện
        public async Task<string> TomTatTTNBRaVien(string ID)
        {
            try
            {
                var dienBienNB = TinhTrangNguoiBenhRaVienBUS.Instance.GetTinhTrangNguoiBenhRaVien(ID);
                string dienbien_json = JsonConvert.SerializeObject(dienBienNB, Formatting.Indented);
                string question = envData["PROMT_TTNB"].Replace("@DienBien", dienbien_json);

                var requestData = new
                {
                    contents = new[] {
                    new {
                        parts = new[] {
                            new {
                                text = question
                            }
                        }
                    }
                }
                };

                // gửi request đi
                var client = new RestClient(envData["API_URL"] + envData["API_KEY_3"]);
                var request = new RestRequest("", Method.Post);
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(requestData);

                RestResponse response = await client.ExecuteAsync(request);
                if (response.IsSuccessful)
                {
                    var jsonResponse = JObject.Parse(response.Content);
                    var result_text = jsonResponse["candidates"][0]["content"]["parts"][0]["text"].ToString();
                    return result_text;
                }
                else
                {
                    throw new AskAiErr("Lỗi khi nhận phản hồi tóm tắt");
                }
            }
            catch (Exception ex)
            {
                throw new AskAiErr("Lỗi tại hàm Tóm Tắt: " + ex.Message);
            }

        }
    }
}
