using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace bdb
{
	[TestClass]
	public class AbzacTest
	{
		static char[] delim = { ' ' };
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
			Assert.IsTrue(a2.contains("* any 3".Split(delim)));
		}

		[TestMethod]
		public void testCreateAll()
		{
			IEnumerable<Abzac> aa;
			Paket p = new Paket(Paket.fileFake);
			p.load(lines);
			Assert.IsTrue(p.size == 3);

			aa = p.findAll("* 3 1".Split(delim));
			Assert.IsTrue(aa.Count() == 2);

			aa = p.findAll("* BUBU".Split(delim));
			Assert.IsTrue(aa.Count() == 0);

			aa = p.findAll("* 2".Split(delim));
			Assert.IsTrue(aa.Count() == 3);
		}
	}
}
