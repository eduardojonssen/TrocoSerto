using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoSerto.Core.Processor {
	public class SilverProcessor: AbstractProcessor {

		internal override string GetName() {
			return "Silver";
		}

		public override IEnumerable<int> GetValues() {
			return new List<int>() { 100000, 50000 };
		}

		public override IDictionary<int, long> CalculateChange(long changeAmount) {
			IEnumerable<int> typesCoins = this.GetValues();
			IDictionary<int, long> response = new Dictionary<int, long>();

			long quantityCoins;

			foreach (int value in typesCoins) {
				quantityCoins = changeAmount / value;
				if (quantityCoins != 0) {
					changeAmount = changeAmount % value;
					response.Add(value, quantityCoins);
				}
				quantityCoins = 0;
			}

			return response;
		}
	}
}
