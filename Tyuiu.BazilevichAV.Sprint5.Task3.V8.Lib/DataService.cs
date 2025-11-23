using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BazilevichAV.Sprint5.Task3.V8.Lib
{
    public class DataService : ISprint5Task3V8
    {

        public string SaveToFileTextData(int x)
        {
            string tempPath = Path.GetTempPath();
            string path = Path.Combine(tempPath, "OutPutFileTask3.bin");

            double y = Math.Round((Math.Pow(x, 2) + 1) / (3 * x + 4), 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(y);
            }

            return path;
        }
    }
}

