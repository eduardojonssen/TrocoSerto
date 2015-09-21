using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrocoSerto.Core;
using TrocoSerto.Core.DataContract;

namespace trocoSerto.Desktop {
	public partial class Form1 : Form {

		TrocoSertoManager trocoSertoManager;
		public Form1() {

			trocoSertoManager = new TrocoSertoManager();

			InitializeComponent();
		}

		private void UxBtnCalculateChange_Click(object sender, EventArgs e) {
			this.DoTheJob();

		}

		private void UxTxtChangeAmountInCents_TextChanged(object sender, EventArgs e) {

		}

		private void DoTheJob(){
 
			this.UxTxtChangeAmountInCents.Clear();

			//Verifica se os campos 'Valor do Produto' e 'Valor Pago' foram preenchidos
			if (string.IsNullOrEmpty(this.UxTxtProductAmountInCents.Text) == true || string.IsNullOrEmpty(this.UxTxtPaidAmountInCents.Text) == true ) {
				this.UxTxtChangeAmountInCents.Text = "Campos informados não podem ser nulos!";
				return;
			}
			try {
				long paidAmountInCents = Convert.ToInt64(this.UxTxtPaidAmountInCents.Text);
				long productAmontInCents = Convert.ToInt64(this.UxTxtProductAmountInCents.Text);

				//Executa a função de calcular o troco
				CalculateChangeRequest changeRequest = new CalculateChangeRequest();

				changeRequest.ProductAmount = productAmontInCents;
				changeRequest.PaidAmount = paidAmountInCents;

				CalculateChangeResponse changeResponse = trocoSertoManager.GetChange(changeRequest);

				if (changeResponse.Success == true && changeResponse.ChangeAmountInCents != null) {
					foreach (KeyValuePair<int, long> item in changeResponse.CoinsCountCollection) {
						this.UxTxtChangeAmountInCents.Text += string.Format("Coin:{0} Count:{1} \r\n",
																			item.Key.ToString(), item.Value.ToString());
					}
					this.UxTxtChangeAmountInCents.Text += "Change amount:" + changeResponse.ChangeAmountInCents.ToString();
				}
				else {
					foreach (OperationReport operationReport in changeResponse.OperationReportList) {
						this.UxTxtChangeAmountInCents.Text += operationReport.PropertyName + ": "+ operationReport.Message + Environment.NewLine;
					}
				}
			}
			catch (Exception ex) {

				this.UxTxtChangeAmountInCents.Text = ex.Message;
			}
}
	}
}
