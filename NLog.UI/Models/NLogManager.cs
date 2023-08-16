using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLog.UI.Models
{
    public class NLogManager : INLogManager
    {
        Logger log = NLog.LogManager.GetCurrentClassLogger();
        public void LogError(string message)
        {
            log.Error(message);
        }
        public void LogInfo(string message)
        {
            log.Info(message);
        }

        public void LogLimit(string message)
        {
            log.Warn(message);
        }
    }
}
