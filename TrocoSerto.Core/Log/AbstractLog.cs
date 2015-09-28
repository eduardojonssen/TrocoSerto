using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoSerto.Core.Log {

	internal abstract class AbstractLog {

		internal abstract void Save(LogData logData);

	}
}
