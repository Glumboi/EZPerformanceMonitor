using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;

namespace EZPerformanceMonitor.Core
{
    public class ExtraFunctions
    {
        public void CloseAll()
        {
            Environment.Exit(0);
        }

        public object CalculateAvg(ListBox.ObjectCollection listBox1Items)
        {
            //Gets all items in the listbox and looks for ints in it and returns the average of all ints
            var ints = new List<int>();
            foreach (var item in listBox1Items)
            {
                if (item is int)
                {
                    ints.Add((int)item);
                }
            }
            return ints.Average();
            
        }

        public void WriteToFile(string content, string fileName)
        {
            //Writes the content to a file
            var file = new System.IO.StreamWriter(fileName);
            file.WriteLine(content);
            file.Close();
        }
    }
}