using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebAppRazor
{
    public class MyLog : ILog
    {
        public string Info(string msg1)
        {
            return msg1;
        }

    }
}
