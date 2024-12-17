using Project.V15.Lib;
namespace Project.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestValidGetID()
        {
            string path = @"C:\Users\evseevegor709icloud\source\repos\Tyuiu.EvseevEI.Sprint7\egor.json";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
