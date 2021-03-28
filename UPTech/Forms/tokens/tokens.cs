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
	public partial class tokens: Form {
		dbConn conn = new dbConn();
		Form parentForm;
		public tokens (Form parent) {
			InitializeComponent();
			parentForm = parent;
		}

		private void categoriasV_Load (object sender, EventArgs e) {
			spawnButtons();
		}

		private void button1_Click (object sender, EventArgs e) {
			this.Close();
		}

		private void spawnButtons () {
			int[] tokensUserId = conn.sqlSelectIntArray($"SELECT * FROM tokens GROUP BY idUser ","idUser");
			int[] tokenTypes = conn.sqlSelectIntArray($"SELECT * FROM tokentypes", "id");

			for (int i = 0;i < tokensUserId.Length; i++) {
				for (int x = 0;x < tokenTypes.Length; x++) {
					if (conn.sqlSelect($"SELECT * FROM tokens WHERE idUser = {tokensUserId[i]} AND idTokenType = {tokenTypes[x]}")) {
						string tokenType = conn.sqlSelectString($"SELECT * FROM tokentypes WHERE id = {tokenTypes[x]}", "type");
						string email = conn.sqlSelectString($"SELECT * FROM users WHERE id = {tokensUserId[i]}", "email");

						Button but = new Button();
						panelSideVisualizer.Controls.Add(but);
						but.BringToFront();
						but.Height = 40;
						but.FlatStyle = FlatStyle.Flat;
						but.Dock = DockStyle.Top;
						but.ForeColor = Color.LightGray;
						but.FlatAppearance.BorderSize = 0;
						but.BackColor = Color.FromArgb(255, 30, 30, 45);
						but.Text = $"{email} - {tokenType}";
						but.Click += new EventHandler(visualizeInfos);
						but.TextAlign = ContentAlignment.MiddleLeft;
					}
				}
			}
		}

		private void visualizeInfos(object sender, EventArgs e) {
			string buttonText = (sender as Button).Text;

			string email= buttonText.Substring(0, buttonText.IndexOf("-")).Trim();
			string type = buttonText.Substring(buttonText.IndexOf("-")+1, buttonText.Length-1-buttonText.IndexOf("-")).Trim();

			openChildForm(new token(parentForm,email,type));
		}


		Form activeForm = null;
		public void openChildForm (Form childForm) {
			if (activeForm != null) {
				activeForm.Close();
			}

			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelMainVisualizer.Controls.Add(childForm);
			panelMainVisualizer.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}
	}
}
