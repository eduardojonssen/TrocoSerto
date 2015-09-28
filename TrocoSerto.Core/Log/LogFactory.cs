using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoSerto.Core.Log {
	public static class LogFactory {

		internal static AbstractLog Create(string logType) {

			switch (logType) {
				case "System":
					return new SystemLogProcessor();
				case "File":
					return new FileLogProcessor();
				default:
					return null;

			}
		}
	}
}
