using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace BUS_.MainLogic
{
    public class ValidateInput
    {
        private static ValidateInput instance;
        public static ValidateInput Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ValidateInput();
                }
                return instance;
            }
        }
        private ValidateInput() { }

        // Hàm validate dữ liệu được nhập vào ô input
        public bool ValidateInputData(string txt_box_name, string value)
        {
            switch (txt_box_name)
            {
                case "MaYTe_input":
                    string pattern_mayte = @"^\d{8}$";
                    if (Regex.IsMatch(value, pattern_mayte))
                    {
                        return true;
                    }
                    break;
                case "SoBenhAn_input":
                    string pattern_sobenhan = @"^\d{2}\.\d{6}$";
                    if (Regex.IsMatch(value, pattern_sobenhan))
                    {
                        return true;
                    }
                    break;
            }
            return false;
        }
    }
}
