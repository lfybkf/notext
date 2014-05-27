using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace bdb
{
	[TestClass]
	public class AbzacTest
	{
		static string[] lines = { 
															"asd"
															, "something1"
															, "something2" 
															, "something3" 
															, "================"
															, "any1"
															, "any2"
															, "any3"
															, "================"
															, "dop1"
															, "dop2"
														};

		[TestMethod]
		public void testCreate()
		{
			Abzac a = Abzac.create(lines, 0);
			//Assert.IsTrue(a.lineFirst == 0);
			//Assert.IsTrue(a.lineLast == 3);
			Assert.IsTrue(a.size == 4);

			Abzac a2 = Abzac.create(lines, a.lineLast + 1);
			//Assert.IsTrue(a2.lineFirst == 5);
			//Assert.IsTrue(a2.lineLast == 7);
			Assert.IsTrue(a2.size == 3);
		}

		[TestMethod]
		public void testCreateAll()
		{
			Paket p = new Paket();
			p.init(lines);
			Assert.IsTrue(p.size == 3);
		}
	}
}
