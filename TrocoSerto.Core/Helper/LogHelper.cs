using Dlp.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoSerto.Core.Helper {
	public static class LogHelper {
		public static void CreateLog(LogData logData) {
			// TODO: Log 

			string fileName = "TrocoSertoLog.txt";
			string filePath = @"C:\Logs";


			if (Directory.Exists(filePath) == false) {
				Directory.CreateDirectory(filePath);
			}

			string log = string.Format("[{0}] {1} | {2} | {3} | {4} \r\n",
				DateTime.Now, logData.LogType, logData.MethodName, logData.Category, Serializer.JsonSerialize(logData.ObjectToLog));

			string fullPath = Path.Combine(filePath, fileName);

			FileStream logFile = File.Open(fullPath, FileMode.Append, FileAccess.Write);

			byte[] logByteArray = log.GetBytes();

			logFile.Write(logByteArray, 0, logByteArray.Length);

			logFile.Close();
		}
	}
}
