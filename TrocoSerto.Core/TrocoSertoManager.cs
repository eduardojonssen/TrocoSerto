using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrocoSerto.Core.DataContract;
using TrocoSerto.Core.Enum;
using TrocoSerto.Core.Processor;

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
				
				response.MonetaryDataCollection = CalculateMonetaryChange((long)response.ChangeAmountInCents);
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
		private List<MonetaryData> CalculateMonetaryChange(long changeAmount) {
			List<MonetaryData> response = new List<MonetaryData>();
			
			BillProcessor billProcessor = new BillProcessor();

			MonetaryData billMonetaryData = new MonetaryData();
			billMonetaryData.MonetaryName = billProcessor.GetName();

			// Calcula o troco em cedulas
			billMonetaryData.MonetaryValues = billProcessor.CalculateChange(changeAmount);

			billMonetaryData.TotalAmount = billMonetaryData.MonetaryValues.Sum(change => change.Key * change.Value);

			response.Add(billMonetaryData);

			// Verifica o restante do troco
			long remainingAmount = changeAmount - billMonetaryData.TotalAmount;

			CoinProcessor coinProcessor = new CoinProcessor();

			MonetaryData coinMonetaryData = new MonetaryData();

			coinMonetaryData.MonetaryValues = coinProcessor.CalculateChange(remainingAmount);
			coinMonetaryData.MonetaryName = coinProcessor.GetName();
			coinMonetaryData.TotalAmount = coinMonetaryData.MonetaryValues.Sum(change => change.Key * change.Value);

			response.Add(coinMonetaryData);

			return response;
		}
		

		#endregion
	}
}
