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
	public partial class main: Form {
		public main () {
			InitializeComponent();
			hideMenus();
		}

		private void main_Load (object sender, EventArgs e) {
			this.TopMost = true;
			this.Focus();
		}

		private void hideMenus () {
			panelCategorias.Visible = false;
			panelPromocoes.Visible = false;
			panelProdutos.Visible = false;
			panelUtilizadores.Visible = false;
			panelSubCategorias.Visible = false;
			panelPromocoes.Visible = false;
		}

		private void hideSubMenu(bool hideCategorias) {
			if (panelCategorias.Visible && hideCategorias) {
				panelCategorias.Visible = false;
			}
			
			if (panelPromocoes.Visible) {
				panelPromocoes.Visible = false;
			}

			if (panelProdutos.Visible) {
				panelProdutos.Visible = false;
			}
			
			if (panelUtilizadores.Visible) {
				panelUtilizadores.Visible = false;
			}

			if (panelSubCategorias.Visible) {
				panelSubCategorias.Visible = false;
			}
		}

		private void showSubMenu(Panel subMenu) {
			if (!subMenu.Visible && subMenu != panelSubCategorias) {
				hideSubMenu(true);
				subMenu.Visible = true;
			} else if (!subMenu.Visible && subMenu == panelSubCategorias) {
				hideSubMenu(false);
				subMenu.Visible = true;
			} else {
				subMenu.Visible = false;
			}
		}

		#region Botoes
		private void btnUtilizadores_Click (object sender, EventArgs e) {
			showSubMenu(panelUtilizadores);
		}

		private void btnCategorias_Click (object sender, EventArgs e) {
			showSubMenu(panelCategorias);
		}

		private void btnNoticias_Click (object sender, EventArgs e) {
			showSubMenu(panelPromocoes);
		}

		private void btnProdutos_Click (object sender, EventArgs e) {
			showSubMenu(panelProdutos);
		}

		private void btnSubCategorias_Click (object sender, EventArgs e) {
			showSubMenu(panelSubCategorias);
		}
		#endregion Botoes

		#region SubBotoes
		private void btnUtilizadoresV_Click (object sender, EventArgs e) {
			openChildForm(new utilizadoresV(this));
			/*
			 * Código
			 */
			hideSubMenu(true);
		}

		private void brnUtilizadoresA_Click (object sender, EventArgs e) {
			openChildForm(new utilizadoresA(this));
			/*
			 * Código
			 */
			hideSubMenu(true);
		}

		private void brnUtilizadoresR_Click (object sender, EventArgs e) {
			openChildForm(new utilizadoresR(this));
			/*
			 * Código
			 */
			hideSubMenu(true);
		}

		private void btnCategoriasV_Click (object sender, EventArgs e) {
			openChildForm(new categoriasV(this));
			/*
			 * Código
			 */
			hideSubMenu(true);
		}

		private void btnCategoriasA_Click (object sender, EventArgs e) {
			openChildForm(new categoriasA(this));
			/*
			 * Código
			 */
			hideSubMenu(true);
		}

		private void btnCategoriasR_Click (object sender, EventArgs e) {
			openChildForm(new categoriasR(this));
			/*
			 * Código
			 */
			hideSubMenu(true);
		}

		private void btnNoticiasV_Click (object sender, EventArgs e) {
			openChildForm(new promocoesV(this));
			/*
			 * Código
			 */
			hideSubMenu(true);
		}

		private void btnNoticiasA_Click (object sender, EventArgs e) {
			openChildForm(new promocoesA(this));
			/*
			 * Código
			 */
			hideSubMenu(true);
		}

		private void btnNoticiasR_Click (object sender, EventArgs e) {
			openChildForm(new promocoesR(this)); 
			/*
			 * Código
			 */
			hideSubMenu(true);
		}

		private void btnProdutosV_Click (object sender, EventArgs e) {
			openChildForm(new produtosV(this));
			/*
			 * Código
			 */
			hideSubMenu(true);
		}

		private void btnProdutosA_Click (object sender, EventArgs e) {
			openChildForm(new produtosA(this));
			/*
			 * Código
			 */
			hideSubMenu(true);
		}

		private void btnProdutosR_Click (object sender, EventArgs e) {
			openChildForm(new produtosR(this));
			/*
			 * Código
			 */
			hideSubMenu(true);
		}

		private void btnProdutosCat_Click (object sender, EventArgs e) {
			openChildForm(new produtosC(this));
			/*
			 * Código
			 */
			hideSubMenu(true);
		}

		private void btnSubCategoriasR_Click (object sender, EventArgs e) {
			openChildForm(new subcategoriasR(this));
			/*
			 * Código
			 */
			hideSubMenu(true);
		}

		private void btnSubCategoriasA_Click (object sender, EventArgs e) {
			openChildForm(new subcategoriasA(this));
			/*
			 * Código
			 */
			hideSubMenu(true);
		}

		private void btnSubCategoriasV_Click (object sender, EventArgs e) {
			openChildForm(new subcategoriasV(this));
			/*
			 * Código
			 */
			hideSubMenu(true);
		}
		private void btnCompras_Click (object sender, EventArgs e) {
			openChildForm(new compras(this));
			/*
			 * Código
			 */
			hideSubMenu(true);
		}

		private void btnTokens_Click (object sender, EventArgs e) {
			openChildForm(new tokens(this));
			/*
			 * Código
			 */
			hideSubMenu(true);
		}
		#endregion SubBotoes

		#region Dragbar
		int mov;
		int movX;
		int movY;

		private void panelDragbar_MouseDown (object sender, MouseEventArgs e) {
			mov = 1;
			movX = e.X;
			movY = e.Y;
		}

		private void panelDragbar_MouseMove (object sender, MouseEventArgs e) {
			if (mov == 1) {
				this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
			}
		}

		private void panelDragbar_MouseUp (object sender, MouseEventArgs e) {
			mov = 0;
		}
		#endregion Dragbar

		private Form activeForm = null;
		private void openChildForm(Form childForm) {
			if (activeForm!=null) {
				activeForm.Close();
			}

			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelChildForm.Controls.Add(childForm);
			panelChildForm.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		private void btnLeave_Click (object sender, EventArgs e) {
			Application.Exit();
		}
	}
}
