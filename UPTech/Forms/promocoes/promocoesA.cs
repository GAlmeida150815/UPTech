using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPTech {
	public partial class promocoesA: Form {
		dbConn conn = new dbConn();
		Form parentForm;
		public promocoesA (Form parent) {
			InitializeComponent();
			parentForm = parent;
		}

		private void promocoesA_Load (object sender, EventArgs e) {
			string[] products = conn.sqlSelectStringArray($"SELECT * FROM produtos", "nome");
			for (int i = 0;i < products.Length;i++) {
				cbProdutos.Items.Add(products[i]);
			}
			cbProdutos.SelectedIndex = 0;
		}

		private void button1_Click (object sender, EventArgs e) {
			this.Close();
		}

		private void btnInserir_Click (object sender, EventArgs e) {
			int id = conn.sqlSelectInt($"SELECT * FROM produtos WHERE nome = '{cbProdutos.Text}'","id");
			int pPercentage = 0;

			if (txtPromocao.Text != "") {
				if (Int32.TryParse(txtPromocao.Text, out pPercentage)) {
					pPercentage = Int32.Parse(txtPromocao.Text);
				} else {
					MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir um valor percentual no campo \"Promoção\" (sem o simbolo \'%\')", "Erro a inserir a promoção", 100);
					return;
				}
			} else {
				MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir um valor percentual no campo \"Promoção\" (sem o simbolo \'%\')", "Erro a inserir a promoção", 100);
				return;
			}

			if (conn.sqlSelect($"SELECT * FROM produtos WHERE id = {id} AND isOnSale = 1")) {
				MetroFramework.MetroMessageBox.Show(parentForm, "O produto selecionado já tem uma promoção ativa, remova-a primeiro para adicionar uma nova", "Erro a inserir a promoção", 100);
				return;
			}

			if (pPercentage != 0) {
				if (conn.sqlUpdate($"UPDATE produtos SET isOnSale = 1, discount = {pPercentage} WHERE id = {id}")) {
					MetroFramework.MetroMessageBox.Show(parentForm, $"Adicionaste uma promoção de {pPercentage}% ao artigo \"{cbProdutos.Text}\"", "Sucesso", 100);
					return;
				} else {
					MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a inserir a promoção", 100);
					return;
				}
			} else {
				MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir um valor percentual diferente de 0 no campo \"Promoção\" (sem o simbolo \'%\')", "Erro a inserir a promoção", 100);
				return;
			}
		}
	}
}
