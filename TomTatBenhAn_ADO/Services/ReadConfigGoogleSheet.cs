using Newtonsoft.Json.Linq;

namespace Services
{
    public class ReadConfigGoogleSheet
    {
        private static ReadConfigGoogleSheet instance;

        public static ReadConfigGoogleSheet Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReadConfigGoogleSheet();
                }
                return instance;
            }
        }

        private ReadConfigGoogleSheet() { }

        public Dictionary<string, string> APIConfig = new Dictionary<string, string>();

        public async Task GetConfig()
        {
            try
            {
                JObject data = await GetSheetData();

                if (data != null && data.ContainsKey("values"))
                {
                    APIConfig.Clear(); // Xóa dữ liệu cũ trước khi cập nhật mới

                    foreach (var row in data["values"])
                    {
                        if (row is JArray rowArray && rowArray.Count >= 2)
                        {
                            string key = rowArray[0]?.ToString().Trim();
                            string value = rowArray[1]?.ToString().Trim();

                            if (!string.IsNullOrEmpty(key))
                            {
                                APIConfig[key] = value;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("⚠️ Không có dữ liệu trong Google Sheets!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Lỗi khi lấy dữ liệu Google Sheets: {ex.Message}");
            }
        }

        private async Task<JObject> GetSheetData()
        {
            string url = $"https://sheets.googleapis.com/v4/spreadsheets/133jgLYeYdIeRf4ynqoI9uwxBhvQq6p4bUwuad_H26LU/values/manage_api!A1:B10?key=AIzaSyDuHpXoR-1YP3zEHWTEVtBUTl6YSSToBGQ";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    return JObject.Parse(json);
                }
                else
                {
                    throw new Exception($"Lỗi API Google Sheets: {response.StatusCode}");
                }
            }
        }
    }
}
