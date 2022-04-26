using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_GetName()
        {
            TaskList list = new TaskList("Тест");
            Assert.AreEqual("Тест", list.GetName());
        }
        [TestMethod]
        public void Test_GetTasks()
        {
            TaskList list = new TaskList("Тест");
            list.GetTasks();
        }
    }
}
