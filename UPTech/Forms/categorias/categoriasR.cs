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
	public partial class categoriasR: Form {
		dbConn conn = new dbConn();
		Form parentForm;
		public categoriasR (Form parent) {
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
			string[] categoriasID = conn.sqlSelectStringArray($"SELECT * FROM categorias","id");
			string[] categorias = conn.sqlSelectStringArray($"SELECT * FROM categorias","categoria");

			for (int i = 0;i < categoriasID.Length;i++) {
				Button but = new Button();
				panelSideVisualizer.Controls.Add(but);
				but.BringToFront();
				but.Height = 40;
				but.FlatStyle = FlatStyle.Flat;
				but.Dock = DockStyle.Top;
				but.ForeColor = Color.LightGray;
				but.FlatAppearance.BorderSize = 0;
				but.BackColor = Color.FromArgb(255, 30, 30, 45);
				but.Text = $"{categoriasID[i]} - {categorias[i]}";
				but.Click += new EventHandler(visualizeInfos);
				but.TextAlign = ContentAlignment.MiddleLeft;
			}
		}

		private void visualizeInfos(object sender, EventArgs e) {
			int id = Convert.ToInt32((sender as Button).Text.Substring(0, (sender as Button).Text.IndexOf("-")).Trim());

			openChildForm(new categoriaR(parentForm,id));
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
