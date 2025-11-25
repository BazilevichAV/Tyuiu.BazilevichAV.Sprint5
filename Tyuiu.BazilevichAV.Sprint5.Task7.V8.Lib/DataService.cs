using System.Globalization;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BazilevichAV.Sprint5.Task7.V8.Lib
{
    public class DataService : ISprint5Task7V8
    {
        public string LoadDataAndSave(string path)
        {
            string tempPath = Path.GetTempPath();
            string outputpath = Path.Combine(tempPath, "OutPutFileTask7V8.txt");

            StringBuilder result = new StringBuilder();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        char currentChar = line[i];

                        if (currentChar >= 'А' && currentChar <= 'Я')
                        {
                            result.Append(char.ToLower(currentChar));
                        }
                        else
                        {
                            result.Append(currentChar);
                        }
                    }
                    result.AppendLine();
                }
            }
            File.WriteAllText(outputpath, result.ToString());
            return outputpath;
        }
    }
}

