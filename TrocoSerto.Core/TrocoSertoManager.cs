using Dlp.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrocoSerto.Core.DataContract;
using TrocoSerto.Core.Enum;
using TrocoSerto.Core.Log;
using TrocoSerto.Core.Processor;

namespace TrocoSerto.Core {
	public class TrocoSertoManager {

		#region Constructor

		/// <summary>
		/// Construtor básico
		/// </summary>
		public TrocoSertoManager() { }

		#endregion

		#region Methods

		public CalculateChangeResponse GetChange(CalculateChangeRequest request) {

			CalculateChangeResponse response = new CalculateChangeResponse();

			try {
				LogManager.WriteLog(new LogData() {
					Category = "Request",
					ObjectToLog = request,
					LogType = "Informacao",
					MethodName = "GetChange"
				});


				if (request.IsValid == false) {
					response.OperationReportList = request.OperationReportList;
					return response;
				}

				response.ChangeAmountInCents = request.PaidAmount - request.ProductAmount;

				response.MonetaryDataCollection = CalculateMonetaryChange((long)response.ChangeAmountInCents);

				if (response.MonetaryDataCollection == null) {
					response.OperationReportList.Add(new OperationReport() {
						Message = "Não foi possível retornar o troco."
					});
					return response;
				}

				response.Success = true;
			}
			catch (Exception ex) {
				OperationReport operationReport = new OperationReport();
				operationReport.Message = ("Não foi possível processar a sua requisição. Por favor, tente novamente mais tarde.");
				response.OperationReportList.Add(operationReport);

				LogManager.WriteLog(new LogData() {
					Category = "EXCEPTION",
					ObjectToLog = ex.ToString(),
					LogType = "ERROR",
					MethodName = "GetChange"
				});

			}
			finally {
				LogManager.WriteLog(new LogData() {
					Category = "Response",
					ObjectToLog = response,
					LogType = "Informacao",
					MethodName = "GetChange"
				});
			}

			return response;
		}

		private List<MonetaryData> CalculateMonetaryChange(long changeAmount) {
			List<MonetaryData> response = new List<MonetaryData>();

			long remainingAmount = changeAmount;

			while (remainingAmount > 0) {
				AbstractProcessor processor = ProcessorFactory.Create(remainingAmount);

				if (processor == null) {
					return null;
				}

				MonetaryData monetaryData = new MonetaryData();
				monetaryData.MonetaryName = processor.GetName();

				// Calcula o troco em cedulas
				monetaryData.MonetaryValues = processor.CalculateChange(remainingAmount);

				monetaryData.TotalAmount = monetaryData.MonetaryValues.Sum(change => change.Key * change.Value);

				response.Add(monetaryData);

				remainingAmount -= monetaryData.TotalAmount;
			}

			return response;
		}

		#endregion
	}
}
