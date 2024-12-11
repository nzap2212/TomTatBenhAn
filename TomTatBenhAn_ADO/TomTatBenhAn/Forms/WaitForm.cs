using System;
using System.Windows.Forms;

namespace UI
{
    public partial class WaitForm : Form
    {
        private static WaitForm _instance;

        // Constructor private để ngăn người khác tạo instance trực tiếp từ bên ngoài
        private WaitForm()
        {
            InitializeComponent();
        }

        // Thuộc tính static để lấy instance duy nhất của FormPhu
        public static WaitForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) // Kiểm tra xem form có bị dispose không
                {
                    _instance = new WaitForm();
                }
                return _instance;
            }
        }

        // Phương thức hiển thị form
        public void ShowForm()
        {
            if (this.IsDisposed)
            {
                throw new ObjectDisposedException("WaitForm đã bị disposed.");
            }

            if (!this.Visible)
            {
                this.Show();
            }
        }

        // Phương thức đóng form nhưng không dispose
        public void CloseForm()
        {
            if (!this.IsDisposed && this.Visible)
            {
                this.Hide(); // Ẩn form thay vì dispose
            }
        }

        // Tạo các thuộc tính public cho các control cần chia sẻ
        public ProgressBar PublicProgressBar => tomtat_status;
    }
}
