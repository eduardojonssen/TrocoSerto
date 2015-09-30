using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrocoSerto.Core.Log;
using Dlp.TrocoSerto.Test.TrocoSerto.Core.Test.Mocks;
using Dlp.Framework.Container;
using TrocoSerto.Core.Utility;

namespace Dlp.TrocoSerto.Test.TrocoSerto.Core.Test {
	[TestClass]
	public class FileLogProcessorTest {

		[TestMethod]
		public void Save_WriteBananaToFile_Test() {

			LogData logData = new LogData();
			logData.Category = "Fruta";
			logData.LogType = "Erro";
			logData.ObjectToLog = "Banana";
			logData.MethodName = "Save_WriteBanana_To_File";

			ConfigurationUtilityMock mock = new ConfigurationUtilityMock();
			mock.LogPath = "c:/BananaDePijama";
			mock.LogType = "File";

			IocFactory.Register(
					Component.For<IConfigurationUtility>()
					.Instance(mock),

					Component.For<ILog>()
					.ImplementedBy<FileLogProcessor>()
					.Interceptor<LogInterceptor>()
				);



			ILog log = IocFactory.Resolve<ILog>();

			log.Save(logData);
		}
	}
}
