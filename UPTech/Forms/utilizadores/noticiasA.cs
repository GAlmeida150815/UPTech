using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace UPTech {
	public partial class utilizadoresA: Form {
		dbConn conn = new dbConn();
		Form parentForm;
		public utilizadoresA (Form parent) {
			InitializeComponent();
			parentForm = parent;
		}

		private void button1_Click (object sender, EventArgs e) {
			this.Close();
		}

		private void utilizadoresA_Load (object sender, EventArgs e) {
			getComboBoxValues();
		}

		private void getComboBoxValues () {
			string[] permissions = conn.sqlSelectStringArray($"SELECT * FROM permissions", "name");
			for (int i = 0;i < permissions.Length;i++) {
				cbPermissions.Items.Add(permissions[i]);
			}
			cbPermissions.SelectedIndex = 0;

			string[] state = conn.sqlSelectStringArray($"SELECT * FROM estados", "estado");
			for (int i = 0;i < state.Length;i++) {
				cbStates.Items.Add(state[i]);
			}
			cbStates.SelectedIndex = 0;
		}

		private void btnInserir_Click (object sender, EventArgs e) {
			int permId = conn.sqlSelectInt($"SELECT * FROM permissions WHERE name = '{cbPermissions.SelectedText}'","level");
			int stateId = conn.sqlSelectInt($"SELECT * FROM estados WHERE estado = '{cbStates.SelectedText}'", "id");
			int id = 0;
			if (txtId.Text != "") {
				if (Int32.TryParse(txtId.Text,out id)) {
					if (!conn.sqlSelect($"SELECT * FROM users WHERE id = {id}")) {
						id = Int32.Parse(txtId.Text);
					} else {
						MetroFramework.MetroMessageBox.Show(parentForm, "Já existe um utilizador com esse ID", "Erro a inserir a categoria", 100);
						return;
					}
				} else {
					MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir um valor númerico no campo ID", "Erro a inserir a categoria", 100);
					return;
				}
			}
			if (txtEmail.Text != "") {
				if (isEmailValid(txtEmail.Text)) {
					if (txtPassword.Text != ""){
						if (id == 0) {
							if (conn.sqlInsert($"INSERT INTO users (id,permissionLevel,idEstado,email,password) VALUES (NULL,{permId},{stateId},'{txtEmail.Text}',password('{txtPassword.Text}'))")) {
								MetroFramework.MetroMessageBox.Show(parentForm, "Adicionaste o utilizador com sucesso", "Sucesso", 100);
								return;
							} else {
								MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a inserir a categoria", 100);
								return;
							}
						} else {
							if (conn.sqlInsert($"INSERT INTO users (id,permissionLevel,idEstado,email,password) VALUES ({id},{permId},{stateId},'{txtEmail.Text}',password('{txtPassword.Text}'))")) {
								MetroFramework.MetroMessageBox.Show(parentForm, "Adicionaste o utilizador com sucesso", "Sucesso", MessageBoxButtons.OK ,100);
								return;
							} else {
								MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a inserir a categoria", 100);
								return;
							}
						}
					} else {
						MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir uma password", "Erro a inserir a categoria", 100);
						return;
					}
				} else {
					MetroFramework.MetroMessageBox.Show(parentForm, "Tens de introduzir um email válido", "Erro a inserir a categoria", 100);
					return;
				}
			} else {
				MetroFramework.MetroMessageBox.Show(parentForm, "Tens de introduzir um email", "Erro a inserir a categoria", 100);
				return;
			}
		}

		private bool isEmailValid (string email) {
			try {
				MailAddress m = new MailAddress(email);
				return true;
			} catch (FormatException fe) {
				return false;
			}
		}
	}
}
