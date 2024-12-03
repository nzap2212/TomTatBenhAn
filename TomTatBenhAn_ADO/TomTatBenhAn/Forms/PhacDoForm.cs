using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class PhacDoForm : Form
    {
        public PhacDoForm()
        {
            InitializeComponent();
        }

        private static PhacDoForm instance;
        public static PhacDoForm Instance
        {
            get
            {
                if(instance == null || instance.IsDisposed)
                {
                    instance = new PhacDoForm();
                }
                return instance;
            }
        }

        public System.Windows.Forms.RichTextBox phacdo_result => PhacDo_result;
    }
}
