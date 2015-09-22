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

		public override IDictionary<int, long> CalculateChange(long changeAmount) {
			IEnumerable<int> types = this.GetValues();

			IDictionary<int, long> response = new Dictionary<int, long>();

			long quantity;

			foreach (int value in types) {
				quantity = changeAmount / value;
				if (quantity != 0) {
					changeAmount = changeAmount % value;
					response.Add(value, quantity);
				}
				quantity = 0;
			}

			return response;
		}

		internal override string GetName() {
			return "Bills";
		}
	}
}
