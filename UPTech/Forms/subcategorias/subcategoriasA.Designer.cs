
namespace UPTech {
	partial class subcategoriasA {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subcategoriasA));
			this.cbCategorias = new MetroFramework.Controls.MetroComboBox();
			this.lblId = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.btnInserir = new MetroFramework.Controls.MetroButton();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.lblCategorias = new MetroFramework.Controls.MetroLabel();
			this.lblSubCategorias = new MetroFramework.Controls.MetroLabel();
			this.txtSubCategoria = new MetroFramework.Controls.MetroTextBox();
			this.txtId = new MetroFramework.Controls.MetroTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cbCategorias
			// 
			this.cbCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.cbCategorias.FontSize = MetroFramework.MetroComboBoxSize.Small;
			this.cbCategorias.FormattingEnabled = true;
			this.cbCategorias.ItemHeight = 19;
			this.cbCategorias.Location = new System.Drawing.Point(191, 201);
			this.cbCategorias.Name = "cbCategorias";
			this.cbCategorias.PromptText = "Escolhe a categoria*";
			this.cbCategorias.Size = new System.Drawing.Size(206, 25);
			this.cbCategorias.TabIndex = 32;
			this.cbCategorias.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.cbCategorias.UseCustomBackColor = true;
			this.cbCategorias.UseSelectable = true;
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.BackColor = System.Drawing.Color.Transparent;
			this.lblId.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblId.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblId.Location = new System.Drawing.Point(35, 173);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(36, 25);
			this.lblId.TabIndex = 31;
			this.lblId.Text = "ID:";
			this.lblId.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.lblId.UseCustomBackColor = true;
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel3.Location = new System.Drawing.Point(181, 12);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(322, 25);
			this.metroLabel3.TabIndex = 29;
			this.metroLabel3.Text = "Aqui podes adicionar sub-categorias";
			this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel3.UseCustomBackColor = true;
			// 
			// btnInserir
			// 
			this.btnInserir.Location = new System.Drawing.Point(35, 242);
			this.btnInserir.Name = "btnInserir";
			this.btnInserir.Size = new System.Drawing.Size(297, 23);
			this.btnInserir.TabIndex = 30;
			this.btnInserir.Text = "Inserir sub-categoria";
			this.btnInserir.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.btnInserir.UseSelectable = true;
			this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
			this.metroLabel2.Location = new System.Drawing.Point(357, 242);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(278, 15);
			this.metroLabel2.TabIndex = 28;
			this.metroLabel2.Text = "Os campos com \'*\' são de preenchimento obrigatório";
			this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel2.UseCustomBackColor = true;
			// 
			// lblCategorias
			// 
			this.lblCategorias.AutoSize = true;
			this.lblCategorias.BackColor = System.Drawing.Color.Transparent;
			this.lblCategorias.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblCategorias.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblCategorias.Location = new System.Drawing.Point(191, 173);
			this.lblCategorias.Name = "lblCategorias";
			this.lblCategorias.Size = new System.Drawing.Size(179, 25);
			this.lblCategorias.TabIndex = 26;
			this.lblCategorias.Text = "Nome da categoria:";
			this.lblCategorias.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.lblCategorias.UseCustomBackColor = true;
			// 
			// lblSubCategorias
			// 
			this.lblSubCategorias.AutoSize = true;
			this.lblSubCategorias.BackColor = System.Drawing.Color.Transparent;
			this.lblSubCategorias.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblSubCategorias.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblSubCategorias.Location = new System.Drawing.Point(403, 173);
			this.lblSubCategorias.Name = "lblSubCategorias";
			this.lblSubCategorias.Size = new System.Drawing.Size(216, 25);
			this.lblSubCategorias.TabIndex = 27;
			this.lblSubCategorias.Text = "Nome da sub-categoria:";
			this.lblSubCategorias.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.lblSubCategorias.UseCustomBackColor = true;
			// 
			// txtSubCategoria
			// 
			// 
			// 
			// 
			this.txtSubCategoria.CustomButton.Image = null;
			this.txtSubCategoria.CustomButton.Location = new System.Drawing.Point(208, 1);
			this.txtSubCategoria.CustomButton.Name = "";
			this.txtSubCategoria.CustomButton.Size = new System.Drawing.Size(23, 23);
			this.txtSubCategoria.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtSubCategoria.CustomButton.TabIndex = 1;
			this.txtSubCategoria.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtSubCategoria.CustomButton.UseSelectable = true;
			this.txtSubCategoria.CustomButton.Visible = false;
			this.txtSubCategoria.Lines = new string[0];
			this.txtSubCategoria.Location = new System.Drawing.Point(403, 201);
			this.txtSubCategoria.MaxLength = 32767;
			this.txtSubCategoria.Name = "txtSubCategoria";
			this.txtSubCategoria.PasswordChar = '\0';
			this.txtSubCategoria.PromptText = "Insere o nome da categoria*";
			this.txtSubCategoria.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtSubCategoria.SelectedText = "";
			this.txtSubCategoria.SelectionLength = 0;
			this.txtSubCategoria.SelectionStart = 0;
			this.txtSubCategoria.ShortcutsEnabled = true;
			this.txtSubCategoria.Size = new System.Drawing.Size(232, 25);
			this.txtSubCategoria.TabIndex = 24;
			this.txtSubCategoria.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtSubCategoria.UseCustomBackColor = true;
			this.txtSubCategoria.UseSelectable = true;
			this.txtSubCategoria.WaterMark = "Insere o nome da categoria*";
			this.txtSubCategoria.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtSubCategoria.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			// 
			// txtId
			// 
			// 
			// 
			// 
			this.txtId.CustomButton.Image = null;
			this.txtId.CustomButton.Location = new System.Drawing.Point(126, 1);
			this.txtId.CustomButton.Name = "";
			this.txtId.CustomButton.Size = new System.Drawing.Size(23, 23);
			this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtId.CustomButton.TabIndex = 1;
			this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtId.CustomButton.UseSelectable = true;
			this.txtId.CustomButton.Visible = false;
			this.txtId.Lines = new string[0];
			this.txtId.Location = new System.Drawing.Point(35, 201);
			this.txtId.MaxLength = 32767;
			this.txtId.Name = "txtId";
			this.txtId.PasswordChar = '\0';
			this.txtId.PromptText = "Insere o ID da categoria";
			this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtId.SelectedText = "";
			this.txtId.SelectionLength = 0;
			this.txtId.SelectionStart = 0;
			this.txtId.ShortcutsEnabled = true;
			this.txtId.Size = new System.Drawing.Size(150, 25);
			this.txtId.TabIndex = 25;
			this.txtId.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtId.UseCustomBackColor = true;
			this.txtId.UseSelectable = true;
			this.txtId.WaterMark = "Insere o ID da categoria";
			this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
			this.button1.TabIndex = 23;
			this.button1.Text = "X";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// subcategoriasA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(684, 451);
			this.Controls.Add(this.cbCategorias);
			this.Controls.Add(this.lblId);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.btnInserir);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.lblCategorias);
			this.Controls.Add(this.lblSubCategorias);
			this.Controls.Add(this.txtSubCategoria);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "subcategoriasA";
			this.Text = "utilizadoresV";
			this.Load += new System.EventHandler(this.subcategoriasA_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroComboBox cbCategorias;
		private MetroFramework.Controls.MetroLabel lblId;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroButton btnInserir;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel lblCategorias;
		private MetroFramework.Controls.MetroLabel lblSubCategorias;
		private MetroFramework.Controls.MetroTextBox txtSubCategoria;
		private MetroFramework.Controls.MetroTextBox txtId;
		private System.Windows.Forms.Button button1;
	}
}