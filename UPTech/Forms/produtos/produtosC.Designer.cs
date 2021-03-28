
namespace UPTech {
	partial class produtosC {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent () {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(produtosC));
			this.button1 = new System.Windows.Forms.Button();
			this.btnInserir = new MetroFramework.Controls.MetroButton();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.cbProdutos = new MetroFramework.Controls.MetroComboBox();
			this.lblCategorias = new MetroFramework.Controls.MetroLabel();
			this.cbCategorias = new MetroFramework.Controls.MetroComboBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.LightGray;
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(25, 25);
			this.button1.TabIndex = 0;
			this.button1.Text = "X";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnInserir
			// 
			this.btnInserir.Location = new System.Drawing.Point(194, 265);
			this.btnInserir.Name = "btnInserir";
			this.btnInserir.Size = new System.Drawing.Size(297, 23);
			this.btnInserir.TabIndex = 5;
			this.btnInserir.Text = "Adicionar categoria";
			this.btnInserir.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.btnInserir.UseSelectable = true;
			this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel3.Location = new System.Drawing.Point(134, 12);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(401, 25);
			this.metroLabel3.TabIndex = 6;
			this.metroLabel3.Text = "Aqui podes adicionar categorias aos produtos";
			this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel3.UseCustomBackColor = true;
			// 
			// cbProdutos
			// 
			this.cbProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.cbProdutos.FontSize = MetroFramework.MetroComboBoxSize.Small;
			this.cbProdutos.FormattingEnabled = true;
			this.cbProdutos.ItemHeight = 19;
			this.cbProdutos.Location = new System.Drawing.Point(31, 217);
			this.cbProdutos.Name = "cbProdutos";
			this.cbProdutos.PromptText = "Escolhe a produto*";
			this.cbProdutos.Size = new System.Drawing.Size(297, 25);
			this.cbProdutos.TabIndex = 34;
			this.cbProdutos.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.cbProdutos.UseCustomBackColor = true;
			this.cbProdutos.UseSelectable = true;
			// 
			// lblCategorias
			// 
			this.lblCategorias.AutoSize = true;
			this.lblCategorias.BackColor = System.Drawing.Color.Transparent;
			this.lblCategorias.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblCategorias.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblCategorias.Location = new System.Drawing.Point(31, 189);
			this.lblCategorias.Name = "lblCategorias";
			this.lblCategorias.Size = new System.Drawing.Size(169, 25);
			this.lblCategorias.TabIndex = 33;
			this.lblCategorias.Text = "Nome do produto:";
			this.lblCategorias.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.lblCategorias.UseCustomBackColor = true;
			// 
			// cbCategorias
			// 
			this.cbCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.cbCategorias.FontSize = MetroFramework.MetroComboBoxSize.Small;
			this.cbCategorias.FormattingEnabled = true;
			this.cbCategorias.ItemHeight = 19;
			this.cbCategorias.Location = new System.Drawing.Point(334, 217);
			this.cbCategorias.Name = "cbCategorias";
			this.cbCategorias.PromptText = "Escolhe a categoria*";
			this.cbCategorias.Size = new System.Drawing.Size(297, 25);
			this.cbCategorias.TabIndex = 36;
			this.cbCategorias.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.cbCategorias.UseCustomBackColor = true;
			this.cbCategorias.UseSelectable = true;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
			this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel1.Location = new System.Drawing.Point(334, 189);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(179, 25);
			this.metroLabel1.TabIndex = 35;
			this.metroLabel1.Text = "Nome da categoria:";
			this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel1.UseCustomBackColor = true;
			// 
			// produtosC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(684, 451);
			this.Controls.Add(this.cbCategorias);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.cbProdutos);
			this.Controls.Add(this.lblCategorias);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.btnInserir);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "produtosC";
			this.Text = "utilizadoresV";
			this.Load += new System.EventHandler(this.utilizadoresA_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private MetroFramework.Controls.MetroButton btnInserir;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroComboBox cbProdutos;
		private MetroFramework.Controls.MetroLabel lblCategorias;
		private MetroFramework.Controls.MetroComboBox cbCategorias;
		private MetroFramework.Controls.MetroLabel metroLabel1;
	}
}