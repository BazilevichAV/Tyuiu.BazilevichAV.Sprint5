using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BazilevichAV.Sprint5.Task1.V4.Lib
{
    public class DataService : ISprint5Task1V4
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string tempPath = Path.GetTempPath();
            string path = Path.Combine(tempPath, "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == -1)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Round((Math.Cos(x) / (x + 1)) - (Math.Cos(x) * 1.3) + (3 * x), 2);
                }

                strY = Convert.ToString(y);

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }

            }
        return path;
        }
    }
}

