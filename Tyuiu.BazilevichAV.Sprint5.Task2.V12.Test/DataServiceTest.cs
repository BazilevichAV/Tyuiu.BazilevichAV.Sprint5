using Microsoft.ApplicationInsights;
using Tyuiu.BazilevichAV.Sprint5.Task2.V12.Lib;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.BazilevichAV.Sprint5.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultEvenArrEl()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[3, 3] { { -5, -5, 9 },
                                            { -7, 3, -4 },
                                            { 8, 7, 9 }, };

            string path = ds.SaveToFileTextData(matrix);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}