namespace UI
{
    public partial class PhacDoForm : Form
    {
        public PhacDoForm()
        {
            InitializeComponent();
        }

        // Tạo các thuộc tính public cho các control cần chia sẻ
        public RichTextBox phacdo_result => PhacDo_result;
    }
}
