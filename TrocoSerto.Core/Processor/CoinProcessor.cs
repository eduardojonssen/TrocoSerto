using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoSerto.Core.Processor {
	public class CoinProcessor : AbstractProcessor {
		public override IEnumerable<int> GetValues() {
			int[] typesCoins = new int[] { 100, 50, 25, 10, 5 };

			return typesCoins;
		}

		internal override string GetName() {
			return "Coins";
		}
	}
}
