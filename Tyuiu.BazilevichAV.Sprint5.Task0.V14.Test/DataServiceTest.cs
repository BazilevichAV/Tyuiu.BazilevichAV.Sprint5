using Tyuiu.BazilevichAV.Sprint5.Task0.V14.Lib;
namespace Tyuiu.BazilevichAV.Sprint5.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultEvenArrEl()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\dory\OneDrive\Документы\ТИУ\source\repos\Tyuiu.BazilevichAV.Sprint5\Tyuiu.BazilevichAV.Sprint5.Task0.V14\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}