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
        public List<int> Usages()
        {
            List<int> usages = new List<int>();
            usages.Add(GetCPUUsage());
            usages.Add(GetRAMUsage());
            usages.Add((int)GetGPUUsage().Result);

            return usages;
        }

        private List<PerformanceCounter> GetGPUCounters()
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


        //Records the avg of the GPU usage for 10 seconds
        public async Task<int> GetGpuUsageAvg()
        {
            var gpuCounters = GetGPUCounters();

            var gpuUsages = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                gpuUsages.Add((int)gpuCounters.Sum(counter => counter.NextValue()));
                await Task.Delay(1000);
            }

            return (int)gpuUsages.Average();
        }

        private void SetGPUUsage(int average)
        {

            var gpuCounters = GetGPUCounters();

            foreach (var counter in gpuCounters)
            {
                counter.RawValue = average;
            }
        }

        private void SetRAMUsage(int average)
        {

            var ramCounter = new PerformanceCounter("Memory", "Available Memory");

            ramCounter.RawValue = average;
        }

        private void SetCPUUsage(int average)
        {

            var cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");

            cpuCounter.RawValue = average;
        }

        //Returns current CPU from 0-100 as an int
        private int GetCPUUsage()
        {
            var cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            cpuCounter.NextValue();
            Thread.Sleep(1000);
            var cpuUsage = cpuCounter.NextValue();
            return (int)cpuUsage;
        }

        //Returns current RAM usage from 0-100 as an int
        private int GetRAMUsage()
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

        private async Task<float> GetGPUUsage()
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
