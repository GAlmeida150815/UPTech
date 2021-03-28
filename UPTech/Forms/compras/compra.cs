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
	public partial class compra: Form {
		dbConn conn = new dbConn();
		Form parentForm;
		int ID;
		public compra (Form parent,int id) {
			InitializeComponent();
			parentForm = parent;
			ID = id;
		}

		private void categoria_Load (object sender, EventArgs e) {
			toggleControls();

			txtId.Text = ID.ToString();
			int buyerId = conn.sqlSelectInt($"SELECT * FROM orders WHERE id = {ID}","idUser");
			txtEmail.Text = conn.sqlSelectString($"SELECT * FROM users WHERE id = {buyerId}", "email");
			txtPreco.Text = conn.sqlSelectString($"SELECT * FROM orders WHERE id = {ID}", "price") + "€";

			string[] pMethods = conn.sqlSelectStringArray($"SELECT * FROM paymentmethods", "method");
			for (int i = 0;i < pMethods.Length;i++) {
				cbMetodo.Items.Add(pMethods[i]);
				int pMethodId = conn.sqlSelectInt($"SELECT * FROM paymentmethods WHERE method = '{pMethods[i]}'", "id");

				if (conn.sqlSelectInt($"SELECT * FROM orders WHERE id = {ID}", "pMethod") == pMethodId) {
					cbMetodo.SelectedIndex = i;
				}
			}

			txtInfo.Text = conn.sqlSelectString($"SELECT * FROM orders WHERE id = {ID}", "addInfo");
		}

		private void button1_Click (object sender, EventArgs e) {
			this.Close();
		}

		private void cbEditar_CheckedChanged (object sender, EventArgs e) {
			toggleControls();
		}

		private void toggleControls () {
			if (cbEditar.Checked) {
				txtId.Enabled = true;
				cbMetodo.Enabled = true;
				txtInfo.Enabled = true;
				btnEditar.Enabled = true;
			} else {
				txtId.Enabled = false;
				txtEmail.Enabled = false;
				txtPreco.Enabled = false;
				cbMetodo.Enabled = false;
				txtInfo.Enabled = false;
				btnEditar.Enabled = false;
			}
		}

		private void btnEditar_Click (object sender, EventArgs e) {
			int pMethodID = conn.sqlSelectInt($"SELECT * FROM paymentmethods WHERE method = '{cbMetodo.Text}'", "id");
			int id = 0;
			if (txtId.Text != "") {
				if (Int32.TryParse(txtId.Text, out id)) {
					if (!conn.sqlSelect($"SELECT * FROM orders WHERE id = {id}") || ID == id) {
						id = Int32.Parse(txtId.Text);
					} else {
						MetroFramework.MetroMessageBox.Show(parentForm, "Já existe uma compra com esse ID", "Erro a editar a compra", 100);
						return;
					}
				} else {
					MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir um valor númerico no campo ID", "Erro a editar a compra", 100);
					return;
				}
			} else {
				MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir um valor númerico no campo ID", "Erro a editar a compra", 100);
				return;
			}

			if (txtEmail.Text != "") {
				if (id != 0) {
					if (txtInfo.Text != "") {
						if (conn.sqlUpdate($"UPDATE orders SET id = {id}, pMethod = {pMethodID}, addInfo = '{txtInfo.Text}', datahora = NOW() WHERE id = {ID}")) {
							MetroFramework.MetroMessageBox.Show(parentForm, $"Editaste a compra Nº{ID} com sucesso", "Sucesso", 100);
							ParentForm.Close();
							return;
						} else {
							MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a editar a compra", 100);
							return;
						}
					} else {
						if (conn.sqlUpdate($"UPDATE orders SET id = {id}, pMethod = {pMethodID}, datahora = NOW() WHERE id = {ID}")) {
							MetroFramework.MetroMessageBox.Show(parentForm, $"Editaste a compra Nº{ID} com sucesso", "Sucesso", 100);
							ParentForm.Close();
							return;
						} else {
							MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a editar a compra", 100);
							return;
						}
					}
				} else {
					MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a editar a compra", 100);
					return;
				}
			} else {
				MetroFramework.MetroMessageBox.Show(parentForm, "Tens de adicionar um email à compra", "Erro a editar a compra", 100);
				return;
			}
		}

		private void btnEliminar_Click (object sender, EventArgs e) {
			if (conn.sqlDelete($"DELETE FROM orders WHERE id = {ID}")) {
				MetroFramework.MetroMessageBox.Show(parentForm, "A compra foi eliminada com sucesso", "Sucesso", 100);
				ParentForm.Close();
				return;
			} else {
				MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a eliminar a compra", 100);
				return;
			}
		}
	}
}
