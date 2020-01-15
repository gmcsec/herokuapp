using log4net;
using System;
using System.Collections.Generic;
using System.Text;

namespace herokuapp.Utilities
{
    public static class Logger
    {
        public static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    }
}
