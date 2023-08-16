using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLog.UI.Models
{
    public interface INLogManager
    {
        void LogError(string message);
        void LogInfo(string message);
        void LogLimit(string message);
    }
}
