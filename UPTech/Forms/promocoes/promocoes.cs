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
	public partial class promocoes: Form {
		dbConn conn = new dbConn();
		Form parentForm;
		int ID;
		public promocoes (Form parent,string nome) {
			InitializeComponent();
			parentForm = parent;
			ID = conn.sqlSelectInt($"SELECT * FROM produtos WHERE nome = '{nome}'", "id");
		}

		private void categoria_Load (object sender, EventArgs e) {
			toggleControls();

			txtPromocao.Text = conn.sqlSelectInt($"SELECT * FROM produtos WHERE id = {ID}","discount").ToString();

			string[] products = conn.sqlSelectStringArray($"SELECT * FROM produtos", "nome");
			for (int i = 0;i < products.Length;i++) {
				cbProdutos.Items.Add(products[i]);

				if (conn.sqlSelectInt($"SELECT * FROM produtos WHERE nome = '{products[i]}'","id") == ID ) {
					cbProdutos.SelectedIndex = i;
				}
			}
		}

		private void button1_Click (object sender, EventArgs e) {
			this.Close();
		}

		private void cbEditar_CheckedChanged (object sender, EventArgs e) {
			toggleControls();
		}

		private void toggleControls () {
			if (cbEditar.Checked) {
				cbProdutos.Enabled = false;
				txtPromocao.Enabled = true;
				btnEditar.Enabled = true;
			} else {
				cbProdutos.Enabled = false;
				txtPromocao.Enabled = false;
				btnEditar.Enabled = false;
			}
		}

		private void btnEditar_Click (object sender, EventArgs e) {
			int pPercentage = 0;

			if (txtPromocao.Text != "") {
				if (Int32.TryParse(txtPromocao.Text, out pPercentage)) {
					pPercentage = Int32.Parse(txtPromocao.Text);
				} else {
					MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir um valor percentual no campo \"Promoção\" (sem o simbolo \'%\')", "Erro a editar a promoção", 100);
					return;
				}
			} else {
				MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir um valor percentual no campo \"Promoção\" (sem o simbolo \'%\')", "Erro a editar a promoção", 100);
				return;
			}

			if (pPercentage != 0) {
				if (conn.sqlUpdate($"UPDATE produtos SET discount = {pPercentage} WHERE id = {ID}")) {
					MetroFramework.MetroMessageBox.Show(parentForm, $"Editaste uma promoção: {pPercentage}% no artigo \"{cbProdutos.Text}\"", "Sucesso", 100);
					ParentForm.Close();
					return;
				} else {
					MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a editar a promoção", 100);
					return;
				}
			} else {
				MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir um valor percentual diferente de 0 no campo \"Promoção\" (sem o simbolo \'%\')", "Erro a editar a promoção", 100);
				return;
			}
		}
	}
}
