using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZPerformanceMonitor.Core
{
    internal class CheckUsageTooHigh
    {
        public static bool ComprareUsageToWarning(int currentUsage, int warningMark)
        {
            return currentUsage >= warningMark;
        }

    }
}
