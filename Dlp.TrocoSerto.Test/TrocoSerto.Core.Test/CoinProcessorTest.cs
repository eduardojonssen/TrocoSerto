using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrocoSerto.Core.Processor;
using System.Collections.Generic;
using System.Linq;

namespace Dlp.TrocoSerto.Test.TrocoSerto.Core.Test {

	[TestClass]
	public class CoinProcessorTest {

		[TestMethod]
		public void CalculateChange_ChangeFor15Cents_Test() {

			CoinProcessor processor = new CoinProcessor();
			Dictionary<int, long> result = processor.CalculateChange(15);

			Assert.IsNotNull(result);
			Assert.AreEqual(2, result.Count);
			Assert.IsTrue(result.ContainsKey(10) && result[10] == 1);
			Assert.IsTrue(result.ContainsKey(5) && result[5] == 1);
		}

		[TestMethod]
		public void CalculateChange_ChangeForMinus7Cents_Test() {
			CoinProcessor processor = new CoinProcessor();
			Dictionary<int, long> result = processor.CalculateChange(-7);

			Assert.IsNotNull(result);
			Assert.IsTrue(result.Any() == false);
		}
	}
}
