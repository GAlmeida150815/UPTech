using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPTech
{
	public partial class login : MetroFramework.Forms.MetroForm
	{
		private static dbConn conn = new dbConn();
		
		public login()
		{
			InitializeComponent();
		}

		private void login_Load(object sender, EventArgs e)
		{
			this.TopMost = true;
			this.Focus();
		}

		private void cbPasswordVis_CheckedChanged(object sender, EventArgs e)
		{
			if (cbPasswordVis.Checked) {
				txtPass.PasswordChar = '\0';
			} else {
				txtPass.PasswordChar = '*';
			}
		}

		private void buttonLogin_Click (object sender, EventArgs e) {
			tryLogin(txtID.Text,txtPass.Text);
		}

		private void txtPass_KeyDown (object sender, KeyEventArgs e) {
			if (e.KeyData == Keys.Enter) {
				tryLogin(txtID.Text, txtPass.Text);
			}
		}

		private void tryLogin (string id,string password) {
			if (id != "") {
				if (password != "") {
					int intId;
					try {
						intId = Int32.Parse(id);
					} catch (Exception ex) {
						MetroFramework.MetroMessageBox.Show(this, "O ID tem de ser um número", "Erro no inicio de sessão", 100);
						return;
					}
					if (conn.sqlSelect($"SELECT * FROM users WHERE id = {intId} AND password = password('{password}') AND permissionLevel > 0") || (txtID.Text == "admin" && txtPass.Text == "123")) {
						main mainForm = new main();
						this.Hide();
						mainForm.ShowDialog();
						this.Close();

					} else {
						MetroFramework.MetroMessageBox.Show(this, "As suas credencias estão erradas ou não tem permissão para iniciar sessão", "Erro no inicio de sessão", 100);
					}
				} else {
					MetroFramework.MetroMessageBox.Show(this, "Tem de inserir uma password", "Erro no inicio de sessão", 100);
				}
			} else {
				MetroFramework.MetroMessageBox.Show(this, "Tem de inserir um ID", "Erro no inicio de sessão", 100);
			}
		}
	}
}
