using System;
using log4net;
using log4net.Config;

namespace Papertrail_logging
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger("Papertrail logging");
        static void Main(string[] args)
        {
            log.Debug("Did it again!");
        }
    }
}
