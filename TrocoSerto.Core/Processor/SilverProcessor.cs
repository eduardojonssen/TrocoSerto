﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoSerto.Core.Processor {
	public class SilverProcessor : AbstractProcessor {

		internal override string GetName() {
			return "Silver";
		}

		public override IEnumerable<int> GetValues() {
			return new List<int>() { 100000, 50000 };
		}
	}
}
