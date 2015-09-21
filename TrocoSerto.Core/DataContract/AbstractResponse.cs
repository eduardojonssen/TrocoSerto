using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoSerto.Core.DataContract {
	
	public abstract class AbstractResponse {

		public AbstractResponse() {
			this.OperationReportList = new List<OperationReport>();
		}

		public bool Success { get; set; }

		public List<OperationReport> OperationReportList { get; set; }
	}
}
