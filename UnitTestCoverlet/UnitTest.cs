using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestCoverlet;

namespace UnitTestCoverlet
{
	[TestClass]
	public class UnitTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			new ClassUnderTest().TestMethod(true);
			Assert.IsTrue(true);
		}
	}
}
