using System.Numerics;
using NUnit.Framework;

namespace CodeWars.Tests
{
    public class Tests
    {
        private static void Tester(int inp, BigInteger exp)
        {
            Assert.AreEqual(exp, TotalIncreasingOrDecreasingNumbers.TotalIncDec(inp), "Should return the total below 10<sup>" + inp + "</sup>");
        }

        [Test]
        public void BasicTests()
        {
            // Check(100, 200, 47);
            // Check(201, 300, 41);
            // Check(301, 400, 37);
            // Check(401, 500, 35);
            // Check(501, 600, 35);
            // Check(601, 700, 37);
            // Check(701, 800, 41);
            // Check(801, 900, 47);
            // Check(901, 1000, 55);

            // Tester(0, BigInteger.Parse("1"));
            //Tester(1, BigInteger.Parse("10"));
            //Tester(2, BigInteger.Parse("100"));
            //Tester(3, BigInteger.Parse("475"));
           //  Tester(4, BigInteger.Parse("1675"));
             Tester(287, BigInteger.Parse("1305173325339115385"));
        }

        [Test]
        public void TestIncrease() {
            // //Assert.AreEqual(1, TotalIncreasingOrDecreasingNumbers.TotalIncrease(1, 0));
            // Assert.AreEqual(BigInteger.Parse("8"), TotalIncreasingOrDecreasingNumbers.TotalIncrease(1, 2));
            // Assert.AreEqual(BigInteger.Parse("7"), TotalIncreasingOrDecreasingNumbers.TotalIncrease(2, 2));
            // Assert.AreEqual(BigInteger.Parse("0"), TotalIncreasingOrDecreasingNumbers.TotalIncrease(9, 2));
            //Assert.AreEqual(BigInteger.Parse("45"), TotalIncreasingOrDecreasingNumbers.TotalDecrease(9, 3));
            //Assert.AreEqual(BigInteger.Parse("1"), TotalIncreasingOrDecreasingNumbers.TotalDecrease(1, 3));
            //Assert.AreEqual(BigInteger.Parse("45"), TotalIncreasingOrDecreasingNumbers.TotalIncrease(1, 3));
            //Assert.AreEqual(BigInteger.Parse("36"), TotalIncreasingOrDecreasingNumbers.TotalIncrease(2, 3));
        }
    }
}