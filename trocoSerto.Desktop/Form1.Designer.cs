namespace trocoSerto.Desktop {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.UxTxtProductAmountInCents = new System.Windows.Forms.TextBox();
			this.lblValor = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.UxTxtPaidAmountInCents = new System.Windows.Forms.TextBox();
			this.UxTxtChangeAmountInCents = new System.Windows.Forms.TextBox();
			this.UxBtnCalculateChange = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// UxTxtProductAmountInCents
			// 
			this.UxTxtProductAmountInCents.Location = new System.Drawing.Point(30, 57);
			this.UxTxtProductAmountInCents.Name = "UxTxtProductAmountInCents";
			this.UxTxtProductAmountInCents.Size = new System.Drawing.Size(124, 26);
			this.UxTxtProductAmountInCents.TabIndex = 0;
			// 
			// lblValor
			// 
			this.lblValor.AutoSize = true;
			this.lblValor.Location = new System.Drawing.Point(26, 22);
			this.lblValor.Name = "lblValor";
			this.lblValor.Size = new System.Drawing.Size(128, 20);
			this.lblValor.TabIndex = 1;
			this.lblValor.Text = "Valor do Produto";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(235, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Valor Pago";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 144);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Resultado";
			// 
			// UxTxtPaidAmountInCents
			// 
			this.UxTxtPaidAmountInCents.Location = new System.Drawing.Point(239, 57);
			this.UxTxtPaidAmountInCents.Name = "UxTxtPaidAmountInCents";
			this.UxTxtPaidAmountInCents.Size = new System.Drawing.Size(130, 26);
			this.UxTxtPaidAmountInCents.TabIndex = 4;
			// 
			// UxTxtChangeAmountInCents
			// 
			this.UxTxtChangeAmountInCents.Location = new System.Drawing.Point(30, 181);
			this.UxTxtChangeAmountInCents.Multiline = true;
			this.UxTxtChangeAmountInCents.Name = "UxTxtChangeAmountInCents";
			this.UxTxtChangeAmountInCents.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.UxTxtChangeAmountInCents.Size = new System.Drawing.Size(494, 121);
			this.UxTxtChangeAmountInCents.TabIndex = 5;
			this.UxTxtChangeAmountInCents.TextChanged += new System.EventHandler(this.UxTxtChangeAmountInCents_TextChanged);
			// 
			// UxBtnCalculateChange
			// 
			this.UxBtnCalculateChange.Location = new System.Drawing.Point(398, 50);
			this.UxBtnCalculateChange.Name = "UxBtnCalculateChange";
			this.UxBtnCalculateChange.Size = new System.Drawing.Size(126, 40);
			this.UxBtnCalculateChange.TabIndex = 6;
			this.UxBtnCalculateChange.Text = "Calcular Troco";
			this.UxBtnCalculateChange.UseVisualStyleBackColor = true;
			this.UxBtnCalculateChange.Click += new System.EventHandler(this.UxBtnCalculateChange_Click);
			// 
			// Form1
			// 
			this.AcceptButton = this.UxBtnCalculateChange;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(536, 323);
			this.Controls.Add(this.UxBtnCalculateChange);
			this.Controls.Add(this.UxTxtChangeAmountInCents);
			this.Controls.Add(this.UxTxtPaidAmountInCents);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblValor);
			this.Controls.Add(this.UxTxtProductAmountInCents);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Troco$erto";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox UxTxtProductAmountInCents;
		private System.Windows.Forms.Label lblValor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox UxTxtPaidAmountInCents;
		private System.Windows.Forms.TextBox UxTxtChangeAmountInCents;
		private System.Windows.Forms.Button UxBtnCalculateChange;
	}
}

