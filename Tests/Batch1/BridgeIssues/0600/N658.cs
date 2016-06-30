using System;
using System.Collections.Generic;
using Bridge;
using Bridge.Test;

namespace Bridge.ClientTest.BridgeIssues
{
    // Bridge[#658]
    [Category(Constants.MODULE_ISSUES)]
    [TestFixture(TestNameFormat = "#658 - {0}")]
    public class Bridge658
    {
        [Test(ExpectedCount = 2)]
        public static void TestUseCase()
        {
            var d = new Bridge634D();
            var d1 = new Bridge634D.Nested();

            Assert.AreEqual("Bridge634D", d.GetClassName(), "Bridge634 D d");
            Assert.AreEqual("Bridge634D.Nested", d1.GetClassName(), "Bridge634 D d1");
        }
    }
}