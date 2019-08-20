using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSOFT.Log.API.ViewObject
{
    public class LogRequest
    {
        public bool IsError { get; set; }
        public string Message { get; set; }
    }
}
