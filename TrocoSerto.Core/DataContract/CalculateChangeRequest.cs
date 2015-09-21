using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoSerto.Core.DataContract {
	public class CalculateChangeRequest : AbstractRequest {

		public CalculateChangeRequest() {

		}
		
		//Valor pago
		public long PaidAmount { get; set; }

		//Valor do Produto
		public long ProductAmount { get; set; }

		protected override void Validate() {

			if (this.PaidAmount < this.ProductAmount) {
				this.AddError("PaidAmount", "Valor pago deve ser maior ou igual ao valor do produto");
			}

			if (this.PaidAmount <= 0) {
				this.AddError("PaidAmount", "Valor pago deve ser maior que 0.");
			}

			if (this.ProductAmount <= 0) {
				this.AddError("ProductAmount", "Valor do produto deve ser maior que 0");
			}
		}
	}
}
