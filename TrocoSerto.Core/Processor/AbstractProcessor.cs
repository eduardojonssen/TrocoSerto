using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoSerto.Core.Processor {
	public abstract class AbstractProcessor {

		internal abstract string GetName();

		public abstract IEnumerable<int> GetValues();

		public abstract IDictionary<int, long> CalculateChange(long changeAmount);
	}
}
