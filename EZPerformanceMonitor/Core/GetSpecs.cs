using System;
using System.Management;

namespace EZPerformanceMonitor.Core
{
    internal class GetSpecs
    {
        //Gets ram name
        public string GetRamClock()
        {
            string ramName = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                ramName = queryObj["Name"].ToString();
            }
            return ramName + " " + GetRamSpeed() + " MHz";
        }

        //Gets the ram speed in MHz
        public string GetRamSpeed()
        {
            string ramSpeed = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                ramSpeed = queryObj["Speed"].ToString();
            }
            return ramSpeed;
        }

        //Gets the GPU name
        public string GetGpuName()
        {
            string gpuName = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                gpuName = queryObj["Name"].ToString();
            }
            return gpuName;
        }

        //Gets the installed cpu name from the regestry example: Ryzen 7 3700x
        public string GetCpuName()
        {
            string cpuName = "";
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0");
            if (key != null)
            {
                cpuName = key.GetValue("ProcessorNameString").ToString();
            }
            return cpuName;
        }

        //Returns the size of the RAM in GB example: 8GB
        public string GetRamSize()
        {
            return (new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / 1024 / 1024 / 1024).ToString() + "GB";
        }
        
        //Returns Connected usb devices as a list example: ["USB Stick (Kingston)", "USB Stick (Kingston)"]
        public string[] GetUsbDevices()
        {
            string[] usbDevices = new string[0];
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PnPEntity");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                if (queryObj["Name"].ToString().Contains("USB"))
                {
                    Array.Resize(ref usbDevices, usbDevices.Length + 1);
                    usbDevices[usbDevices.Length - 1] = queryObj["Name"].ToString();
                }
            }
            return usbDevices;
        }
    }
}
