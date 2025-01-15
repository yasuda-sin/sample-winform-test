using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleFormsApp;
using System.Windows.Forms;

namespace SampleFormApp_Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestSum()
        {
            int expected = 7;
            var main = new MainForm();
            var actual = main.Sum(5, 2);
            Assert.AreEqual(expected, actual);
        }
    }
}
