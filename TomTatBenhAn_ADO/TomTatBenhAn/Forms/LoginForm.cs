using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_;
using BUS_.MainLogic;

namespace UI.Forms
{
    public partial class LoginForm : Form
    {
        private static LoginForm instance;
        public static LoginForm Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new LoginForm();
                }
                return instance;
            }
        }

        private LoginForm()
        {
            InitializeComponent();
        }

        public string userName = "";
        public string userDepartment = "";
        public string empCode = "";

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                userName = userInputLogin.Text;
                userDepartment = departmentLogin.Text;
                empCode = empCodeInput.Text;
                // Lấy MainForm từ Singleton
                MainForm mainForm = MainForm.Instance;

                // Truyền LoginForm hiện tại cho MainForm
                mainForm.SetLoginForm(this);

                if (await HandleLogin.Instance.updateUser(userInputLogin.Text, departmentLogin.Text, empCodeInput.Text))
                {
                    // Hiển thị MainForm và ẩn LoginForm
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hãy nhập đủ thông tin!!");
                }
            }
            catch (GetStatusErr ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
