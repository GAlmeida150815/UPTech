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
using System.IO;

namespace UPTech {
	public partial class produtosA: Form {
		dbConn conn = new dbConn();
		Form parentForm;
		public produtosA (Form parent) {
			InitializeComponent();
			parentForm = parent;
		}

		private void button1_Click (object sender, EventArgs e) {
			this.Close();
		}

		private void utilizadoresA_Load (object sender, EventArgs e) {
			pbImagem.Image = Image.FromFile(@"C:\xampp\htdocs\PAP\images\products\default.png");
		}

		private void btnInserir_Click (object sender, EventArgs e) {
			int id = 0;
			decimal preco;
			bool precoCerto = false;
			if (txtId.Text != "") {
				if (Int32.TryParse(txtId.Text,out id)) {
					if (!conn.sqlSelect($"SELECT * FROM users WHERE id = {id}")) {
						id = Int32.Parse(txtId.Text);
					} else {
						MetroFramework.MetroMessageBox.Show(parentForm, "Já existe um produto com esse ID", "Erro a inserir o produto", 100);
						return;
					}
				} else {
					MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir um valor númerico no campo ID", "Erro a inserir o produto", 100);
					return;
				}
			}

			if (txtPreco.Text != "") {
				if (decimal.TryParse(txtPreco.Text, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo ,out preco))  {
					precoCerto = true;
				} else {
					MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir um valor númerico no campo \'Preço\', no formato XX.XX", "Erro a inserir o produto", 100);
					return;
				}
			}

			if (txtNome.Text != "") {
				if (txtDescricao.Text != "") {
					if (id == 0) {
						if (txtPreco.Text != "") {
							if (precoCerto) {
								if (conn.sqlInsert($"INSERT INTO produtos (id,nome,preco,descri,isOnSale,discount) VALUES (NULL,'{txtNome.Text}','{txtPreco.Text}','{txtDescricao.Text}',0,0)")) {
									MetroFramework.MetroMessageBox.Show(parentForm, $"Adicionaste o produto \"{txtNome.Text}\" com sucesso", "Sucesso", 100);
									try {
										int pId = conn.sqlSelectInt($"SELECT * FROM produtos WHERE nome = '{txtNome.Text}' ORDER BY id DESC LIMIT 1","id");
										if (hasImage(pId)) {
											File.Delete(@"C:\xampp\htdocs\PAP\images\products\" + pId + ".jpg");
										}
										pImage.Save(@"C:\xampp\htdocs\PAP\images\products\" + pId + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
									} catch (Exception ex) {
										MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a editar o produto", 100);
										return;
									}
									return;
								} else {
									MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a inserir o produto", 100);
									return;
								}
							} 
						} else {
							MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir um preço ao produto", "Erro a inserir o produto", 100);
							return;
						}
					} else {
						if (txtPreco.Text != "") {
							if (precoCerto) {
								if (conn.sqlInsert($"INSERT INTO produtos (id,nome,preco,descri,isOnSale,discount) VALUES ({id},'{txtNome.Text}','{txtPreco.Text}','{txtDescricao.Text}',0,0)")) {
									MetroFramework.MetroMessageBox.Show(parentForm, $"Adicionaste o produto \"{txtNome.Text}\" com sucesso", "Sucesso", 100);
									try {
										int pId = conn.sqlSelectInt($"SELECT * FROM produtos WHERE nome = '{txtNome.Text}' ORDER BY id DESC LIMIT 1", "id");
										if (hasImage(pId)) {
											File.Delete(@"C:\xampp\htdocs\PAP\images\products\" + pId + ".jpg");
										}
										pImage.Save(@"C:\xampp\htdocs\PAP\images\products\" + pId + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
									} catch (Exception ex) {
										MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a editar o produto", 100);
										return;
									}
									return;
								} else {
									MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a inserir o produto", 100);
									return;
								}
							}
						} else {
							MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir um preço ao produto", "Erro a inserir o produto", 100);
							return;
						}
					}
				} else {
					MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir uma descrição ao produto", "Erro a inserir o produto", 100);
					return;
				}
			} else {
				MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir um nome ao produto", "Erro a inserir o produto", 100);
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
