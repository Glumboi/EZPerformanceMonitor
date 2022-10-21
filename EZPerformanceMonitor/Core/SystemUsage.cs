using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Threading;
using System.Threading.Tasks;

namespace EZPerformanceMonitor.Core
{
    internal class SystemUsage
    {
        public List<int> Usages() => new List<int>()
        {
            GetCPUUsage(),
            GetRAMUsage(),
            (int)GetGPUUsage().Result
        };

        public List<PerformanceCounter> GetGPUCounters()
        {
            var category = new PerformanceCounterCategory("GPU Engine");
            var counterNames = category.GetInstanceNames();

            var gpuCounters = counterNames
                                .Where(counterName => counterName.EndsWith("engtype_3D"))
                                .SelectMany(counterName => category.GetCounters(counterName))
                                .Where(counter => counter.CounterName.Equals("Utilization Percentage"))
                                .ToList();

            return gpuCounters;
        }

        //Returns current CPU from 0-100 as an int
        public int GetCPUUsage()
        {   
            //Alternative method
            //var cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");

            var cpuCounter = new PerformanceCounter("Processor Information", "% Processor Utility", "_Total");
            cpuCounter.NextValue();
            Thread.Sleep(1000);
            var cpuUsage = cpuCounter.NextValue();
            return (int)cpuUsage;
        }

        //Returns current RAM usage from 0-100 as an int
        public int GetRAMUsage()
        {
            var wmiObject = new ManagementObjectSearcher("select * from Win32_OperatingSystem");

            var memoryValues = wmiObject.Get().Cast<ManagementObject>().Select(mo => new
            {
                FreePhysicalMemory = Double.Parse(mo["FreePhysicalMemory"].ToString()),
                TotalVisibleMemorySize = Double.Parse(mo["TotalVisibleMemorySize"].ToString())
            }).FirstOrDefault();

            if (memoryValues != null)
            {
                var percent = ((memoryValues.TotalVisibleMemorySize - memoryValues.FreePhysicalMemory) / memoryValues.TotalVisibleMemorySize) * 100;
                return (int)percent;
            }
            return 0;
        }

        public async Task<float> GetGPUUsage()
        {
            try
            {
                var category = new PerformanceCounterCategory("GPU Engine");
                var counterNames = category.GetInstanceNames();
                var gpuCounters = new List<PerformanceCounter>();
                var result = 0f;

                foreach (string counterName in counterNames)
                {
                    if (counterName.EndsWith("engtype_3D"))
                    {
                        foreach (PerformanceCounter counter in category.GetCounters(counterName))
                        {
                            if (counter.CounterName == "Utilization Percentage")
                            {
                                gpuCounters.Add(counter);
                            }
                        }
                    }
                }

                gpuCounters.ForEach(x =>
                {
                    _ = x.NextValue();
                });

                await Task.Delay(1000);

                gpuCounters.ForEach(x =>
                {
                    result += x.NextValue();
                });

                return result;
            }
            catch
            {
                return 0f;
            }
        }
    }
}
