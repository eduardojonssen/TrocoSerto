using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrocoSerto.Core.Utility;

namespace Dlp.TrocoSerto.Test.TrocoSerto.Core.Test.Mocks {
	public class ConfigurationUtilityMock : IConfigurationUtility {

		public string LogPath { get; set; }

		public string LogType { get; set; }
	}
}
