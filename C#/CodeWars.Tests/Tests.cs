using System.Numerics;
using NUnit.Framework;

namespace CodeWars.Tests
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            
            //Assert.AreEqual(" example.", Kata.Rot13(" rknzcyr."));
            Assert.AreEqual("AdZHVWdC)UFKsy'B-gosxnz0SLCveTffnnHoAeeZnGK`_EzlUx", Kata.Rot13("NqMUIJqP)HSXfl'O-tbfkam0FYPirGssaaUbNrrM{TX`_RmyHk"));
        }
    }
}