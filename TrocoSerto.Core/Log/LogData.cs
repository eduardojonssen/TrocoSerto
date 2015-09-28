using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoSerto.Core.Log {
	public class LogData {
		public string LogType { get; set; }

		public string MethodName { get; set; }

		public string Category { get; set; }

		public object ObjectToLog { get; set; }
	}
}
