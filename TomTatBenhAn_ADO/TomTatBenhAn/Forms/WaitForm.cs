using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        // Tạo các thuộc tính public cho các control cần chia sẻ
        public System.Windows.Forms.ProgressBar PublicProgressBar => tomtat_status;
    }
}
