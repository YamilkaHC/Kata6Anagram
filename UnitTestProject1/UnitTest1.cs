using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata6Anagrama;
using System;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            var instance = new Program.Anagram();

            TimeSpan result = instance.Read("C:\\Users\\maria\\Desktop\\wordlist.txt");
            TimeSpan Test = new TimeSpan(0, 0, 0, 2);
            Assert.IsTrue(TimeSpan.Compare(result, Test) < 1);
        }

        public void TestMethod2()
        {
            var instance = new Program.Anagram();
            instance.Read("C:\\Users\\maria\\Desktop\\wordlist.txt");
            Assert.AreEqual(instance.Index.Count, 20683);
        }
    }
}
