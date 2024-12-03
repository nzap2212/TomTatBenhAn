using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServicesErr : Exception
    {
        public ServicesErr() : base("Lỗi khi thực hiện") { }
        public ServicesErr(string message) : base(message) { }
        public ServicesErr(string message, Exception innerException) : base(message, innerException) { }
    }
}
