using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace BUS_.MainLogic
{
    public class CheckUpdate
    {
        private static CheckUpdate instance;
        public static CheckUpdate Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CheckUpdate();
                }
                return instance;
            }
        }

        private CheckUpdate() { }

        // Hàm check update
        public async Task<string> CheckForUpdate(string crVersion, string Url = "http://api-hospital.zigisoft.com/api/version/check")
        {
            try
            {
                var requestData = new
                {
                    currentVersion = crVersion,
                };

                var client = new RestClient(Url);
                var request = new RestRequest("", Method.Post);
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(requestData);

                RestResponse response = await client.ExecuteAsync(request);
                if (response.IsSuccessful)
                {
                    var jsonResponse = JObject.Parse(response.Content);
                    if (jsonResponse["message"].ToString() == "Có bản cập nhật mới.")
                    {
                        return jsonResponse["data"]["url"].ToString();
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra cập nhật: " + ex.Message);
            }
        }

        // Hàm tải về update và mở file
        public async Task<string> DownloadAndOpenAsync(string url)
        {
            try
            {
                // Tạo đường dẫn tạm để lưu file tải về
                string tempFilePath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                    "Downloads",
                    $"update_installer_{Guid.NewGuid()}.msi"
                );

                using (var httpClient = new HttpClient())
                {
                    // Thêm User-Agent để tránh lỗi GitHub chặn request
                    httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64)");


                    // Gửi yêu cầu GET
                    var response = await httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception($"Không thể tải tệp. Mã trạng thái: {response.StatusCode}");
                    }

                    // Tải xuống dữ liệu
                    using (var stream = await response.Content.ReadAsStreamAsync())
                    using (var fileStream = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        await stream.CopyToAsync(fileStream);
                    }

                    Console.WriteLine($"Tệp đã tải về: {tempFilePath}");

                    // Kiểm tra kích thước file
                    FileInfo fileInfo = new FileInfo(tempFilePath);
                    if (fileInfo.Length == 0)
                    {
                        throw new Exception("Tệp tải về bị rỗng hoặc không hợp lệ.");
                    }

                    return tempFilePath;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tải và mở tệp: {ex.Message}");
                throw;
            }
        }

    }
}
