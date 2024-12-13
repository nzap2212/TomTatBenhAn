using word = Microsoft.Office.Interop.Word;
using System.Runtime.InteropServices;



namespace BUS_.MainLogic
{
    public class ReportEditor
    {
        private static ReportEditor instance;
        public static ReportEditor Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReportEditor();
                }
                return instance;
            }
        }
        private ReportEditor() { }

        // Hàm tạo bản sao template và đổ dữ liệu ra file word đó
        public async void GenFileAndPrintData(string filePath, Dictionary<string, string> allData)
        {
            try
            {
                // Đảm bảo đường dẫn thư mục Desktop tồn tại
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string folderPath = Path.Combine(desktopPath, "HoSoTomTat");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                // Kiểm tra sự tồn tại của file template
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException($"Không tìm thấy file template tại đường dẫn: {filePath}");
                }

                // Tạo đường dẫn file tạm
                string tempFilePath = Path.Combine(folderPath, $"{allData["BN_SoBenhAn"]}_HoSoTomTat.doc");

                // Sao chép file template vào file tạm
                File.Copy(filePath, tempFilePath, overwrite: true);

                // Tiếp tục xử lý file tại đây...
                printDataToWord(tempFilePath, allData);
                
                await Task.Delay(2000);
                OpenWordDocument(tempFilePath);

                Console.WriteLine("Báo cáo đã được tạo thành công tại: " + tempFilePath);
            }
            catch (Exception ex)
            {
                throw new GetStatusErr("Hãy đóng file word Hồ sơ tóm tắt hiện tại trước khi chỉnh sửa hồ sơ mới!!", ex);
            }
        }


        private void printDataToWord(string filePath, Dictionary<string, string> data)
        {
            var wordApp = new word.Application();
            var wordDoc = new word.Document();

            try
            {
                wordDoc = wordApp.Documents.Open(filePath);

                foreach (var entry in data)
                {
                    ReplaceBookmarkText(wordDoc, entry.Key, entry.Value);
                }

                wordDoc.Save();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi tại hàm in dữ liệu ra Word: {ex.Message}");
            }
            finally
            {
                if (wordDoc != null)
                {
                    wordDoc.Close(false);
                    Marshal.ReleaseComObject(wordDoc);
                }
                if (wordApp != null)
                {
                    wordApp.Quit();
                    Marshal.ReleaseComObject(wordApp);
                }
            }
        }


        private void ReplaceBookmarkText(word.Document document, string bookmarkName, string newText)
        {

            //Xử lý trường hợp "BN_KetQuaDieuTri"
            if (bookmarkName == "BN_KetQuaDieuTri")
            {
                var resultBookmarkMapping = new Dictionary<string, string>
                {
                    { "Khỏi", "BN_Khoi" },
                    { "Đỡ", "BN_Do" },
                    { "Không thay đổi", "BN_KhongThayDoi" },
                    { "Tiên lượng nặng xin về", "BN_NangHonXinVe" },
                    { "Tử vong", "BN_TuVong" },
                    { "Chưa xác định", "BN_ChuaXacDinh" },
                    { "Nặng hơn", "BN_NangHon" }
                };

                foreach (var item in resultBookmarkMapping)
                {
                    foreach (word.ContentControl control in document.ContentControls)
                    {
                        // Kiểm tra nếu Content Control là checkbox và có tag khớp
                        if (control.Type == word.WdContentControlType.wdContentControlCheckBox && control.Tag == item.Value && item.Key == newText)
                        {
                            // Đánh dấu checkbox
                            control.Checked = true; // Đánh dấu
                        }
                    }
                }
                return;
            }

            // Xử lý trường hợp bookmark "BN_Name"
            if (bookmarkName == "BN_Name" || bookmarkName == "DoctorName")
            {
                var bookmark = document.Bookmarks[bookmarkName];
                var range = bookmark.Range;
                range.Text = newText;
                range.Font.Name = "Times New Roman";
                range.Font.Size = 14f;
                range.Font.Bold = 1;
                // Đặt lại bookmark sau khi thay thế
                document.Bookmarks.Add(bookmarkName, range);
                return;
            }
            // Xử lý các bookmark khác
            else 
            {
                var genericBookmark = document.Bookmarks[bookmarkName];
                var genericRange = genericBookmark.Range;
                genericRange.Text = newText;
                genericRange.Font.Name = "Times New Roman";
                genericRange.Font.Size = 14f;
                genericRange.Font.Bold = 0;

                // Đặt lại bookmark sau khi thay thế
                document.Bookmarks.Add(bookmarkName, genericRange);
                return;
            }
        }



        private void OpenWordDocument(string filePath)
        {
            global::System.Diagnostics.Process.Start(new global::System.Diagnostics.ProcessStartInfo
            {
                FileName = filePath,
                UseShellExecute = true
            });
        }
    }
}