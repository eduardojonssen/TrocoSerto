using Dlp.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrocoSerto.Core.Utility;

namespace TrocoSerto.Core.Log {
	internal sealed class SystemLogProcessor : ILog {

		public SystemLogProcessor() { }

		public void Save(LogData logData) {

			EventLog log = new EventLog();

			log.Source = "Troco$erto";

			string logMessage = Serializer.JsonSerialize(logData.ObjectToLog);

			log.WriteEntry(logMessage, EventLogEntryType.Information);

		}

	}
}
