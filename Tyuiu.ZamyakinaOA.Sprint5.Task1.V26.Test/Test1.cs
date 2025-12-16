namespace Tyuiu.ZamyakinaOA.Sprint5.Task1.V26.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Shakal\source\repos\Tyuiu.ZamyakinaOA.Sprint5\Tyuiu.ZamyakinaOA.Sprint5.Task1.V26\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
