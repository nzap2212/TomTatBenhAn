using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_
{
    public class GetStatusErr : Exception
    {
        public GetStatusErr() : base("Lỗi khi kiểm tra kết nối máy chủ") { }
        public GetStatusErr(string message) : base(message) { }
        public GetStatusErr(string message,Exception innerException) : base(message, innerException) { }
    }

    public class AskAiErr : Exception
    {
        public AskAiErr() : base("Lỗi khi kết nối với AI") { }
        public AskAiErr(string message) : base(message) { }
        public AskAiErr(string message, Exception innerException) : base(message, innerException) { }
    }

    public class ValidateErr : Exception
    {
        public ValidateErr() : base("Lỗi khi nhập mã y tế") { }
        public ValidateErr(string message) : base(message) { }
        public ValidateErr(string message, Exception innerException) : base(message, innerException) { }
    }

    public class GenFileErr : Exception
    {
        public GenFileErr() : base("Lỗi khi tạo file tóm tắt") { }
        public GenFileErr(string message) : base(message) { }
        public GenFileErr(string message, Exception innerException) : base(message, innerException) { }

    }

}
