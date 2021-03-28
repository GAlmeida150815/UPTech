using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UPTech {
	public partial class produto: Form {
		dbConn conn = new dbConn();
		Form parentForm;
		int ID;
		public produto (Form parent,int id) {
			InitializeComponent();
			parentForm = parent;
			ID = id;
		}

		private void categoria_Load (object sender, EventArgs e) {
			toggleControls();

			txtId.Text = ID.ToString();
			txtNome.Text = conn.sqlSelectString($"SELECT * FROM produtos WHERE id = {ID}", "nome");
			txtPreco.Text = conn.sqlSelectString($"SELECT * FROM produtos WHERE id = {ID}", "preco");
			txtDesc.Text = conn.sqlSelectString($"SELECT * FROM produtos WHERE id = {ID}", "descri");

			if (hasImage(ID)) {
				pbImagem.Image = Image.FromFile(@"C:\xampp\htdocs\PAP\images\products\" + ID + ".jpg");
			} else {
				pbImagem.Image = Image.FromFile(@"C:\xampp\htdocs\PAP\images\products\default.png");
			}

			int[] subcategoriesID = conn.sqlSelectIntArray($"SELECT * FROM produtoscategorias WHERE idProduto = {ID}", "idCategoria");

			for (int i = 0;i < subcategoriesID.Length;i++) {
				string categorie = conn.sqlSelectString($"SELECT * FROM subcategorias WHERE id = {subcategoriesID[i]} ", "subCategoria");
				Button but = new Button();
				panelCategories.Controls.Add(but);
				but.BringToFront();
				but.Height = 20;
				but.FlatStyle = FlatStyle.Flat;
				but.Dock = DockStyle.Top;
				but.ForeColor = Color.LightGray;
				but.FlatAppearance.BorderSize = 0;
				but.BackColor = Color.FromArgb(255, 30, 30, 45);
				but.Text = $"{subcategoriesID[i]} - {categorie}";
				but.TextAlign = ContentAlignment.MiddleLeft;
			}

			if (conn.sqlSelect($"SELECT * FROM produtos WHERE id = {ID} and isOnSale = 1")) {
				txtPromocao.Text = conn.sqlSelectInt($"SELECT * FROM produtos WHERE id = {ID}", "discount").ToString() + "%";

				txtPromocao.Enabled = false;
				lblPromocao.Visible = true;
				txtPromocao.Visible = true;
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
				txtNome.Enabled = true;
				txtPreco.Enabled = true;
				txtDesc.Enabled = true;
				pbImagem.Enabled = true;
				pbImagem.Cursor = Cursors.Hand;
				btnEditar.Enabled = true;
			} else {
				txtId.Enabled = false;
				txtNome.Enabled = false;
				txtPreco.Enabled = false;
				txtDesc.Enabled = false;
				pbImagem.Enabled = false;
				pbImagem.Cursor = Cursors.Default;
				btnEditar.Enabled = false;
			}
		}

		private void btnEditar_Click (object sender, EventArgs e) {
			int id = 0;
			decimal preco;
			bool precoCerto = false;
			if (txtId.Text != "") {
				if (Int32.TryParse(txtId.Text, out id)) {
					if (!conn.sqlSelect($"SELECT * FROM users WHERE id = {id}") || ID == id) {
						id = Int32.Parse(txtId.Text);
					} else {
						MetroFramework.MetroMessageBox.Show(parentForm, "Já existe uma categoria com esse ID", "Erro a editar o produto", 100);
						return;
					}
				} else {
					MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir um valor númerico no campo ID", "Erro a editar o produto", 100);
					return;
				}
			} else {
				MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir um valor númerico no campo ID", "Erro a editar o produto", 100);
				return;
			}

			if (txtPreco.Text != "") {
				if (decimal.TryParse(txtPreco.Text, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo, out preco)) {
					precoCerto = true;
				} else {
					MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir um valor númerico no campo \'Preço\', no formato XX.XX", "Erro a editar o produto", 100);
					return;
				}
			}

			if (txtDesc.Text != "") {
				if (id != 0) {
					if (txtNome.Text != "") {
						if (txtPreco.Text != "") {
							if (precoCerto) {
								if (conn.sqlUpdate($"UPDATE produtos SET id = {id}, nome = '{txtNome.Text}', preco = '{txtPreco.Text}', descri = '{txtDesc.Text}' WHERE id = {ID}")) {
									if (pImage != null) {
										try {
											if (hasImage(id)) {
												File.Delete(@"C:\xampp\htdocs\PAP\images\products\" + id + ".jpg");
											}
											pImage.Save(@"C:\xampp\htdocs\PAP\images\products\" + id + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
										} catch (Exception ex) {
											MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a editar o produto", 100);
											return;
										}
									}
									MetroFramework.MetroMessageBox.Show(parentForm, "Edistaste o produto com sucesso", "Sucesso", 100);
									ParentForm.Close();
									return;
								} else {
									MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a editar o produto", 100);
									return;
								}
							}
						} else {
							MetroFramework.MetroMessageBox.Show(parentForm, "Tem de inserir um preço para o produto", "Erro a editar o produto", 100);
							return;
						}
					} else {
						MetroFramework.MetroMessageBox.Show(parentForm, "Tem de inserir um nome para o produto", "Erro a editar o produto", 100);
						return;
					}
				} else {
					MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a editar o produto", 100);
					return;
				}
			} else {
				MetroFramework.MetroMessageBox.Show(parentForm, "Tens de introduzir um descrição", "Erro a editar o produto", 100);
				return;
			}
		}

		private bool hasImage (int id) {
			string path = @"C:\xampp\htdocs\PAP\images\products\" + id + ".jpg";

			if (File.Exists(path)) {
				return true;
			} else {
				return false;
			}
		}

		public Bitmap pImage;
		private void pbImagem_Click (object sender, EventArgs e) {
			OpenFileDialog open = new OpenFileDialog();
			open.DefaultExt = "jpg";
			open.Filter = "JPG images (*.jpg)|*.jpg";

			if (open.ShowDialog() == DialogResult.OK) {
				pImage = new Bitmap(open.FileName);

				pbImagem.Image = pImage;
			}
		}
	}
}
