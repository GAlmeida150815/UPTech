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
	public partial class token: Form {
		dbConn conn = new dbConn();
		Form parentForm;
		int IDUser;
		int IDType;
		public token (Form parent,string email, string type) {
			InitializeComponent();
			parentForm = parent;
			IDUser = conn.sqlSelectInt($"SELECT * FROM users WHERE email = '{email}'", "id");
			IDType = conn.sqlSelectInt($"SELECT * FROM tokentypes WHERE type = '{type}'", "id");
		}

		private void categoria_Load (object sender, EventArgs e) {
			toggleControls();

			string[] emails = conn.sqlSelectStringArray($"SELECT * FROM users", "email");
			for (int i = 0;i < emails.Length;i++) {
				cbUsers.Items.Add(emails[i]);
				if (conn.sqlSelectInt($"SELECT * FROM users WHERE email = '{emails[i]}'", "id") == IDUser) {
					cbUsers.SelectedIndex = i;
				}
			}

			string[] tTypes = conn.sqlSelectStringArray($"SELECT * FROM tokentypes", "type");
			for (int i = 0;i < tTypes.Length;i++) {
				cbType.Items.Add(tTypes[i]);
				if (conn.sqlSelectInt($"SELECT * FROM tokentypes WHERE type = '{tTypes[i]}'", "id") == IDType) {
					cbType.SelectedIndex = i;
				}
			}

			txtToken.Text = conn.sqlSelectString($"SELECT * FROM tokens WHERE idUser = {IDUser} AND idTokenType = {IDType}", "token");
		}

		private void button1_Click (object sender, EventArgs e) {
			this.Close();
		}

		private void cbEditar_CheckedChanged (object sender, EventArgs e) {
			toggleControls();
		}

		private void toggleControls () {
			if (cbEditar.Checked) {
				cbType.Enabled = true;
				cbUsers.Enabled = true;
				txtToken.Enabled = true;
				btnEditar.Enabled = true;
			} else {
				cbType.Enabled = false;
				cbUsers.Enabled = false;
				txtToken.Enabled = false;
				btnEditar.Enabled = false;
			}
		}

		private void btnEditar_Click (object sender, EventArgs e) {
			int idUser = conn.sqlSelectInt($"SELECT * FROM users WHERE email = '{cbUsers.Text}'", "id");
			int idTokenType = conn.sqlSelectInt($"SELECT * FROM tokentypes WHERE type = '{cbType.Text}'", "id");

			if (txtToken.Text != "") {
				if (conn.sqlUpdate($"UPDATE tokens SET idUser = {idUser}, idTokenType = {idTokenType}, token = {txtToken.Text}, dataToken = NOW() WHERE idUser = {IDUser} AND idTokenType = {IDType}")) {
					MetroFramework.MetroMessageBox.Show(parentForm, "O token foi editado com sucesso", "Sucesso", 100);
					ParentForm.Close();
					return;
				} else {
					MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a editar o token", 100);
					return;
				}
			} else {
				MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir um token", "Erro a editar o token", 100);
				return;
			}
		}

		private void btnEliminar_Click (object sender, EventArgs e) {
			if (conn.sqlDelete($"DELETE FROM tokens WHERE idUser = {IDUser} AND idTokenType = {IDType}")) {
				MetroFramework.MetroMessageBox.Show(parentForm, "O token foi eliminado com sucesso", "Sucesso", 100);
				ParentForm.Close();
				return;
			} else {
				MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a eliminar o token", 100);
				return;
			}
		}
	}
}
