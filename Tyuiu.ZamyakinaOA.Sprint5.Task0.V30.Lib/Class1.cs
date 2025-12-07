using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZamyakinaOA.Sprint5.Task0.V30.Lib
{
    public class Class1 : ISprint5Task0V30
    {
        public string SaveToFileTextData(int x)
        {
            double y = (Math.Pow(x, 2) + 1) / (3 * x + 4);
            y = Math.Round(y, 3);
            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            File.WriteAllText(filePath, y.ToString());
            return filePath;
        }
    }
}
