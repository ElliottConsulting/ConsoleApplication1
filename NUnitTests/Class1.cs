using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using NUnit.Framework;



namespace ConsoleApplication1
{
    [TestFixture]

    public class NUnitTests

    {

        [Test]

        public void SumOfTwoNumbers()

        {

            Assert.AreEqual(10, 5 + 5);

        }



        [Test]

        public void TestForDivBy3And5()

        {
            // don't know how to reference FizzBuzz...
            //FizzBuzz fb = new FizzBuzz();
            Assert.AreSame(10, 5 + 6);

        }

    }
}
