using Dlp.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoSerto.Core.Log {
	internal sealed class SystemLogProcessor : AbstractLog {

		public SystemLogProcessor() { }

		internal override void Save(LogData logData) {

			EventLog log = new EventLog();

			log.Source = "Troco$erto";

			string logMessage = Serializer.JsonSerialize(logData.ObjectToLog);

			log.WriteEntry(logMessage, EventLogEntryType.Information);

		}

	}
}
