using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrocoSerto.Core.DataContract;
using TrocoSerto.Core.Enum;

namespace TrocoSerto.Core {
	public class TrocoSertoManager {

		#region Constructor
		public TrocoSertoManager() { }

		#endregion

		#region Methods

		public CalculateChangeResponse GetChange(CalculateChangeRequest request) {

			CalculateChangeResponse response = new CalculateChangeResponse();
			
			try {
				// TODO: Log

				if (request.IsValid == false) {
					response.OperationReportList = request.OperationReportList;
					return response;
				}

				response.ChangeAmountInCents = request.PaidAmount - request.ProductAmount;
				response.CoinsCountCollection = CalculateCoins((long)response.ChangeAmountInCents);
				response.Success = true;

				//TODO: Log
			}
			catch (Exception ex) {
				//TODO: Log
				OperationReport operationReport = new OperationReport();
				operationReport.Message = ("Não foi possível processar a sua requisição. Por favor, tente novamente mais tarde.");
				response.OperationReportList.Add(operationReport);
			}
			return response;
		}
		private IDictionary<int, long> CalculateCoins(long changeAmount) {
			IDictionary<int, long> response = new Dictionary<int, long>();
			int[] typesCoins = new int[6] { 100, 50, 25, 10, 5, 1 };
			long quantityCoins;
			for (int i = 0; i < typesCoins.Length; i++) {
				quantityCoins = changeAmount / typesCoins[i];
				if (quantityCoins != 0) {
					changeAmount = changeAmount % typesCoins[i];
					response.Add(typesCoins[i], quantityCoins);
				}
				quantityCoins = 0;
			}
			return response;
		}
		

		#endregion
	}
}
