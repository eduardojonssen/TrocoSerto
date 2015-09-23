using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoSerto.Core.Processor {
	public abstract class AbstractProcessor {
		internal abstract string GetName();

		public abstract IEnumerable<int> GetValues();

		public virtual Dictionary<int, long> CalculateChange(long changeAmount)
		{
			IEnumerable<int> types = this.GetValues();

			Dictionary<int, long> response = new Dictionary<int, long>();

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
	}
}
