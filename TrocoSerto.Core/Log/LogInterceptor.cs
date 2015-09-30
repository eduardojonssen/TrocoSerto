using Dlp.Framework.Container.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoSerto.Core.Log {
	
	public class LogInterceptor : IInterceptor {

		public void Intercept(IInvocation invocation) {

			// Verifica se o metodo chamado é o metodo Save.
			if (invocation.MethodInvocationTarget.Name.Equals("Save") == true) {

				LogData logData = invocation.Arguments[0] as LogData;
				logData.Category += "_banana";
			}

			invocation.Proceed();
		}
	}
}
