using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoSerto.Core.Utility {
	public class ConfigurationUtility : IConfigurationUtility {

		public string LogType {
			get {
				return ConfigurationManager.AppSettings["LogType"];
			} 
		}

		public string LogPath {
			get {
				 return ConfigurationManager.AppSettings["LogPath"];
			}
		}
	}
}
