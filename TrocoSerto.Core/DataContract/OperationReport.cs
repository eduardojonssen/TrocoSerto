using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoSerto.Core.DataContract {

	public class OperationReport {

		public OperationReport() {

		}
		public OperationReport(string propertyName, string message) {
			this.Message = message;
			this.PropertyName = propertyName;
		}

		public string PropertyName { get; set; }
		public string Message { get; set; }
	}
}
