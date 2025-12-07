using Tyuiu.ZamyakinaOA.Sprint5.Task0.V30.Lib;

namespace Tyuiu.ZamyakinaOA.Sprint5.Task0.V30.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Shakal\source\repos\Tyuiu.ZamyakinaOA.Sprint5\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
