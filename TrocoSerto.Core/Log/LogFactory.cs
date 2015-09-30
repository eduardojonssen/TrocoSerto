using Dlp.Framework.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrocoSerto.Core.Utility;

namespace TrocoSerto.Core.Log {
	public static class LogFactory {

		internal static ILog Create(string logType) {

			return IocFactory.ResolveByName<ILog>(logType);
		}
	}
}
