using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;

namespace MessageUnitTests
{
    [TestClass]
    public class MessageTests
    {
        [TestMethod]
        public void TestConsoleMessage()
        {
            string actual, expected;
            MessageBL messageBL = new MessageBL();

            actual = messageBL.GetMessage();
            expected = "Hello World";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestMobileMessage()
        {
            string actual, expected;
            MobileMessageBL mobileMessageBL = new MobileMessageBL();

            actual = mobileMessageBL.GetMessage();
            expected = "Mobile Message";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestServiceMessage()
        {
            string actual, expected;
            ServiceMessageBL serviceMessageBL = new ServiceMessageBL();

            actual = serviceMessageBL.GetMessage();
            expected = "Service Message";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestWebMessage()
        {
            string actual, expected;
            WebMessageBL webMessageBL = new WebMessageBL();

            actual = webMessageBL.GetMessage();
            expected = "Web Message";

            Assert.AreEqual(actual, expected);
        }
    }
}
