using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BazilevichAV.Sprint5.Task6.V28.Lib
{
    public class DataService : ISprint5Task6V28
    {

        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] tokens = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    foreach (string token in tokens)
                    {
                        if (int.TryParse(token, out int num))
                        {
                            if (num >= 1000 && num <= 9999)
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            return count;
        }
    }
}

