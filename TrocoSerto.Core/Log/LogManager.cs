using Dlp.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoSerto.Core.Log {
	public static class LogManager {

		public static void WriteLog(LogData logData){
			string logType = ConfigurationManager.AppSettings["logType"];
			AbstractLog abstractlog = LogFactory.Create(logType);
			abstractlog.Save(logData);
		}

	}
}
