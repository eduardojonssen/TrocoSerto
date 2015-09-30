using Dlp.Framework;
using Dlp.Framework.Container;
using System;
using System.Configuration;
using System.IO;
using TrocoSerto.Core.Utility;

namespace TrocoSerto.Core.Log {
	public class FileLogProcessor: ILog {

		public FileLogProcessor() { } 

		public void Save(LogData logData) {

			IConfigurationUtility configurationUtility = IocFactory.Resolve<IConfigurationUtility>();

			string fileName = DateTime.Now.ToString("yyyy-MM-dd") + ".log";
			string filePath = configurationUtility.LogPath; 
			
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
