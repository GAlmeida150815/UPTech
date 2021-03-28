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
	public partial class utilizador: Form {
		dbConn conn = new dbConn();
		Form parentForm;
		int ID;
		public utilizador (Form parent,int id) {
			InitializeComponent();
			parentForm = parent;
			ID = id;
		}

		private void categoria_Load (object sender, EventArgs e) {
			toggleControls();

			txtId.Text = ID.ToString();
			txtEmail.Text = conn.sqlSelectString($"SELECT * FROM users WHERE id = {ID}", "email");
			int permission = conn.sqlSelectInt($"SELECT * FROM users WHERE id = {ID}", "permissionLevel");
			int state = conn.sqlSelectInt($"SELECT * FROM users WHERE id = {ID}", "idEstado");


			string[] permissions = conn.sqlSelectStringArray($"SELECT * FROM permissions", "name");
			for (int i = 0;i < permissions.Length;i++) {
				cbPermissions.Items.Add(permissions[i]);
				if (conn.sqlSelectInt($"SELECT * FROM permissions WHERE name = '{permissions[i]}'","level") == permission) {
					cbPermissions.SelectedIndex = i;
				}
			}

			string[] states = conn.sqlSelectStringArray($"SELECT * FROM estados", "estado");
			for (int i = 0;i < states.Length;i++) {
				cbStates.Items.Add(states[i]);
				if (conn.sqlSelectInt($"SELECT * FROM estados WHERE estado = '{states[i]}'", "id") == state) {
					cbStates.SelectedIndex = i;
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
				txtId.Enabled = true;
				txtEmail.Enabled = true;
				txtPassword.Enabled = true;
				cbPermissions.Enabled = true;
				cbStates.Enabled = true;
				btnEditar.Enabled = true;
			} else {
				txtId.Enabled = false;
				txtEmail.Enabled = false;
				txtPassword.Enabled = false;
				cbPermissions.Enabled = false;
				cbStates.Enabled = false;
				btnEditar.Enabled = false;
			}
		}

		private void btnEditar_Click (object sender, EventArgs e) {
			int permId = conn.sqlSelectInt($"SELECT * FROM permissions WHERE name = '{cbPermissions.Text}'", "level");
			int stateId = conn.sqlSelectInt($"SELECT * FROM estados WHERE estado = '{cbStates.Text}'", "id");
			int id = 0;
			if (txtId.Text != "") {
				if (Int32.TryParse(txtId.Text, out id)) {
					if (!conn.sqlSelect($"SELECT * FROM users WHERE id = {id}") || ID == id) {
						id = Int32.Parse(txtId.Text);
					} else {
						MetroFramework.MetroMessageBox.Show(parentForm, "Já existe uma categoria com esse ID", "Erro a editar o utilizador", 100);
						return;
					}
				} else {
					MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir um valor númerico no campo ID", "Erro a editar o utilizador", 100);
					return;
				}
			} else {
				MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir um valor númerico no campo ID", "Erro a editar o utilizador", 100);
				return;
			}

			if (txtEmail.Text != "") {
				if (isEmailValid(txtEmail.Text)) {
					if (!conn.sqlSelect($"SELECT * FROM users WHERE email = '{txtEmail.Text}'") || txtEmail.Text == conn.sqlSelectString($"SELECT * FROM users WHERE id = {ID}", "email")) {
						if (id != 0) {
							if (txtPassword.Text != "") {
								if (conn.sqlUpdate($"UPDATE users SET id = {id}, permissionLevel = {permId}, idEstado = {stateId}, email = '{txtEmail.Text}', password = password('{txtPassword.Text}') WHERE id = {ID}")) {
									MetroFramework.MetroMessageBox.Show(parentForm, "Edistaste o utilizador com sucesso", "Sucesso", 100);
									ParentForm.Close();
									return;
								} else {
									MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a editar o utilizador", 100);
									return;
								}
							} else {
								if (conn.sqlUpdate($"UPDATE users SET id = {id}, permissionLevel = {permId}, idEstado = {stateId}, email = '{txtEmail.Text}' WHERE id = {ID}")) {
									MetroFramework.MetroMessageBox.Show(parentForm, "Edistaste o utilizador com sucesso", "Sucesso", 100);
									ParentForm.Close();
									return;
								} else {
									MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a editar o utilizador", 100);
									return;
								}
							}
						} else {
							MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a editar o utilizador", 100);
							return;
						}
					} else {
						MetroFramework.MetroMessageBox.Show(parentForm, "Já existe um utilizador registado com esse email", "Erro a editar o utilizador", 100);
						return;
					}
				} else {
					MetroFramework.MetroMessageBox.Show(parentForm, "Tens de introduzir um email válido", "Erro a editar o utilizador", 100);
					return;
				}
			} else {
				MetroFramework.MetroMessageBox.Show(parentForm, "Tens de introduzir um email", "Erro a editar o utilizador", 100);
				return;
			}
		}


		private bool isEmailValid (string email) {
			try {
				System.Net.Mail.MailAddress m = new System.Net.Mail.MailAddress(email);
				return true;
			} catch (FormatException fe) {
				return false;
			}
		}
	}
}
