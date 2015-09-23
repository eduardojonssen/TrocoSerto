using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrocoSerto.Core.Enum;

namespace TrocoSerto.Core.DataContract {

	public class CalculateChangeResponse : AbstractResponse {

		public CalculateChangeResponse() {
			this.MonetaryDataCollection = new List<MonetaryData>();
		}

		public List<MonetaryData> MonetaryDataCollection { get; set; }

		public Nullable<long> ChangeAmountInCents { get; set; }
	}
}
