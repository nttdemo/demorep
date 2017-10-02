using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestConsole.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestConsole.Common.Tests
{
    [TestClass()]
    public class UtilityTests
    {
        [TestMethod()]
        public void InitLogTest()
        {
            Assert.IsNotNull(Utility.InitLog());
        }

        [TestMethod()]
        public void SetLogPathTest()
        {
            Utility.SetLogPath("");

            Assert.IsTrue(File.Exists(@"C:\LogFiles\TestConsole\TestConsole.txt"));
           
            
        }
    }
}