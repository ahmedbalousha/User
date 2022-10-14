using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users.Core.ViewModels
{
    public class APIResponseViewModel
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

        public APIResponseViewModel(bool status, string message,object data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
    }
}
