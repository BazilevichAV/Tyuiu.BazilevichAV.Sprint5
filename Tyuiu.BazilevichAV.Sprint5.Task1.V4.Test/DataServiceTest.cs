using Tyuiu.BazilevichAV.Sprint5.Task1.V4.Lib;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.BazilevichAV.Sprint5.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultEvenArrEl()
        {
            DataService ds = new DataService();
            
            int startValue = -5;
            int stopValue = 5;
            string path = ds.SaveToFileTextData(startValue, stopValue);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}