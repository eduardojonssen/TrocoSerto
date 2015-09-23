using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoSerto.Core.Processor {
	public class BillProcessor : AbstractProcessor {

		public override IEnumerable<int> GetValues() {
			int[] typesCoins = new int[] { 10000, 5000, 2000, 1000, 500, 200 };

			return typesCoins;
		}

		internal override string GetName() {
			return "Bills";
		}
	}
}
