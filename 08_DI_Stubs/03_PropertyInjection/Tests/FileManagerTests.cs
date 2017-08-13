using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_PropertyInjection.Tests
{
    [TestClass]
    public class FileManagerTests
    {
        [TestMethod]
        public void FileManager_FindFileLogByName_3()
        {
            IDataAccessObject accessObject = new StubFileDataObject();
            FileManager fileManager = new FileManager();
            fileManager.DataAccessObject = accessObject;// Dependency Injection
            string fileName = "main.log";

            bool exists = fileManager.FindLogFile(fileName);

            Assert.IsTrue(exists, "File {0} was not found.", fileName);
        }
    }
}
