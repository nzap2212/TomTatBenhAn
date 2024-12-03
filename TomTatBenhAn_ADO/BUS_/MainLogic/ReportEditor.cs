using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
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
                if(instance == null)
                {
                    instance = new ReportEditor();  
                }
                return instance;
            }
        }
        private ReportEditor() { }

        // Hàm tạo bản sao template và đổ dữ liệu ra file word đó
        public void GenFileAndPrintData(string filePath, Dictionary<string, string> allData)
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
                string tempFilePath = Path.Combine(folderPath, $"{allData["BN_MaYTe"]}_HoSoTomTat.doc");

                // Sao chép file template vào file tạm
                File.Copy(filePath, tempFilePath, overwrite: true);

                // Tiếp tục xử lý file tại đây...
                printDataToWord(tempFilePath, allData);

                OpenWordDocument(tempFilePath);

                Console.WriteLine("Báo cáo đã được tạo thành công tại: " + tempFilePath);
            }
            catch (Exception ex)
            {
                // Ghi log lỗi và thông báo cụ thể
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
                throw;
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
            if (document.Bookmarks.Exists(bookmarkName))
            {
                var bookmark = document.Bookmarks[bookmarkName];
                var range = bookmark.Range;

                // Thay thế nội dung trong bookmark
                range.Text = newText;
                range.Font.Name = "Times New Roman";
                range.Font.Size = 13;
                range.Font.Bold = 0;


                // Đặt lại bookmark sau khi thay thế
                document.Bookmarks.Add(bookmarkName, range);
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
