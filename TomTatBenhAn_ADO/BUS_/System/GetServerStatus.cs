using Microsoft.IdentityModel.Tokens;
using RestSharp;
using System.Net;


namespace BUS_.System
{
    public class GetServerStatus
    {
        // Mô hình Singleton
        private static GetServerStatus instance;
        public static GetServerStatus Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GetServerStatus();
                }
                return instance;
            }
        }

        private GetServerStatus() { }

        public bool IsConnected = false;

        // Hàm lấy trạng thái của Server
        public async Task get_server_status(Dictionary<string, string> envData)
        {
            try
            {
                // Đảm bảo sử dụng TLS 1.2 để tránh trường hợp kết nối SSL bị chặn
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                // Sử dụng HttpClientHandler để bỏ qua xác thực SSL 
                var handler = new HttpClientHandler
                {
                    ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) => true
                };

                // Truyền tham số handler để cấu hình httpclient bỏ qua kiểm tra xác thực SSL
                var httpClient = new HttpClient(handler);

                // Truyền HttpClient vào RestSharp RestClient
                var test_client = new RestClient(new RestClientOptions
                {
                    BaseUrl = new Uri("https://hospital.zigisoft.com/"),
                    ConfigureMessageHandler = _ => handler // Gắn handler vào RestClient
                });

                var test_request = new RestRequest("", Method.Get);
                test_request.AddHeader("Content-Type", "application/json");

                RestResponse test_response = await test_client.ExecuteAsync(test_request);

                if (test_response.IsSuccessful)
                {
                    string status_response = test_response.Content.Trim().ToString();
                    if (!status_response.IsNullOrEmpty())
                    {
                        envData["API_KEY_1"] = status_response;
                        IsConnected = true;
                    }
                }
                else
                {
                    IsConnected = false;
                    throw new GetStatusErr("Không nhận được phản hồi từ máy chủ");
                }
            }
            catch (Exception ex)
            {
                IsConnected = false;
                throw new GetStatusErr("Không thể kết nối với máy chủ: " + ex.Message);
            }
        }
    }
}
