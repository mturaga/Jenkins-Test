using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace jenkins_test.Tests
{
    //Comments
    [TestFixture]
    public class CalcTests
    {

        [Test]
        public void Calc_Add_Test()
        {
            var actual = jenkins_test.Program.Add(1,1);
            Assert.AreEqual(2, actual);
        }
    }
}
