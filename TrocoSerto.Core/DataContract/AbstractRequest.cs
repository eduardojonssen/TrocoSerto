using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoSerto.Core.DataContract {

	public abstract class AbstractRequest {

		public AbstractRequest() {
			this._operationReportList = new List<OperationReport>();
		}

		public bool IsValid {
			get {
				this._operationReportList.Clear();
				this.Validate();
				return (this._operationReportList.Any() == false);
			}
		}

		private List<OperationReport> _operationReportList { get; set; }

		public List<OperationReport> OperationReportList { get { return this._operationReportList.ToList(); } }

		protected abstract void Validate();

		protected void AddError(string propertyName, string message) {

			// Obtém o tipo da classe que esta sendo executada no momento.
			Type currentType = this.GetType();

			// Obtém o nome da classe para ser utilizada no retorno do erro.
			string currentTypeName = currentType.Name;

			this._operationReportList.Add(new OperationReport(string.Format("{0}.{1}", currentTypeName, propertyName), message));
		}
	}
}
