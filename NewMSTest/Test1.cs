﻿namespace NewMSTest
{
	[TestClass]
	public sealed class Test1
	{
		[TestMethod]
		public void TestMethod1()
		{
			Assert.AreEqual(2, 2);
		}

		[TestMethod]
		public void TestMethod2()
		{
			Assert.AreNotEqual(4, 2);
		}
	}
}
