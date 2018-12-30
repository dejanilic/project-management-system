using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.Tests
{
    [TestFixture]
    public class UtilTest
    {
        [TestCase]
        public void parseStringTest()
        {
            Assert.AreEqual(1, Util.parseString("1"));
            Assert.AreEqual(10, Util.parseString("10"));
            Assert.AreEqual(100, Util.parseString("100"));
        }

        [TestCase]
        public void splitTest()
        {
            Assert.AreEqual("three", Util.split("one two three"));
            Assert.AreEqual("3", Util.split("1 2 3"));
        }
    }
}
