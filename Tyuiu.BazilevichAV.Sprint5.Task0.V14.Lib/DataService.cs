using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BazilevichAV.Sprint5.Task0.V14.Lib
{
    public class DataService : ISprint5Task0V14
    {
        public string SaveToFileTextData(int x)
        {
            string tempPath = Path.GetTempPath();
            string path = Path.Combine(tempPath, "OutPutFileTask0.txt");
            double z = (4 * Math.Pow(x, 3.0 / 2.0)) / (Math.Pow(x, 3.0 / 2.0) - 1);
            z = Math.Round(z, 3);
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}

