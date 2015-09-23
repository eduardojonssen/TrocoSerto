using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoSerto.Core.Processor {
	public class CandyProcessor : AbstractProcessor {
		internal override string GetName() {
			return "Candies";
		}

		public override IEnumerable<int> GetValues() {
			return new List<int>() { 1, 3 };
		}
	}
}
