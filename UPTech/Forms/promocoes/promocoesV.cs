﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPTech {
	public partial class promocoesV: Form {
		dbConn conn = new dbConn();
		Form parentForm;
		public promocoesV (Form parent) {
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
			int[] produtosID = conn.sqlSelectIntArray($"SELECT * FROM produtos WHERE isOnSale = 1", "id");

			for (int i = 0;i < produtosID.Length;i++) {
				string productName = conn.sqlSelectString($"SELECT * FROM produtos WHERE id = {produtosID[i]}", "nome");
				int pPercentage = conn.sqlSelectInt($"SELECT * FROM produtos WHERE id = {produtosID[i]}", "discount");

				Button but = new Button();
				panelSideVisualizer.Controls.Add(but);
				but.BringToFront();
				but.Height = 40;
				but.FlatStyle = FlatStyle.Flat;
				but.Dock = DockStyle.Top;
				but.ForeColor = Color.LightGray;
				but.FlatAppearance.BorderSize = 0;
				but.BackColor = Color.FromArgb(255, 30, 30, 45);
				but.Text = $"{productName} - {pPercentage}%";
				but.Click += new EventHandler(visualizeInfos);
				but.TextAlign = ContentAlignment.MiddleLeft;
			}
		}

		private void visualizeInfos (object sender, EventArgs e) {
			string nome = (sender as Button).Text.Substring(0, (sender as Button).Text.IndexOf("-")).Trim();

			openChildForm(new promocoes(parentForm, nome));
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
