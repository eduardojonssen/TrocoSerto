using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoSerto.Core.DataContract {
	public class MonetaryData {
		public string MonetaryName { get; set; }

		public IDictionary<int, long> MonetaryValues { get; set; }

		public long TotalAmount { get; set; }

	}
}
