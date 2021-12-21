using NUnit.Framework;

namespace Nunitfram
{   [TestFixture]
    public class Tests
    {
        [OneTimeSetUp]
        public void Setup()
        {
            System.Console.WriteLine("inside setup");
        }

        [Test,Category("Sanity")]
        public void Test1()
        {
            System.Console.WriteLine("inside Test1"); ;
        }
        [Test, Category("Regresion")]
        public void Test2()
        {
            System.Console.WriteLine("inside Test2"); ;
        }

        [Test, Category("Sanity")]
        public void Test3()
        {
            System.Console.WriteLine("inside Test3"); ;
        }
        [Test, Category("Regression")]
        public void Test4()
        {
            System.Console.WriteLine("inside Test4"); ;
        }

        [OneTimeTearDown]
        public void Teeardown()
        {
            System.Console.WriteLine("Inside teardown");
        }
    }
}