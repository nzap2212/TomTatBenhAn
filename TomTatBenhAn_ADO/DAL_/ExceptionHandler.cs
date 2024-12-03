using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_
{
    public class GetBenhAnErr : Exception
    {
        public GetBenhAnErr() : base("Lỗi khi kết nối với cơ sở dữ liệu") { } 
        public GetBenhAnErr(string message) : base(message) { }
        public GetBenhAnErr(string message, Exception innerException) : base(message, innerException) { }
    }
}
