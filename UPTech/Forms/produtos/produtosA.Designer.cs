
namespace UPTech {
	partial class produtosA {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(produtosA));
			this.button1 = new System.Windows.Forms.Button();
			this.txtId = new MetroFramework.Controls.MetroTextBox();
			this.lblId = new MetroFramework.Controls.MetroLabel();
			this.lblPerm = new MetroFramework.Controls.MetroLabel();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.txtDescricao = new MetroFramework.Controls.MetroTextBox();
			this.lblEmail = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.btnInserir = new MetroFramework.Controls.MetroButton();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.txtNome = new MetroFramework.Controls.MetroTextBox();
			this.txtPreco = new MetroFramework.Controls.MetroTextBox();
			this.pbImagem = new System.Windows.Forms.PictureBox();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
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
			this.txtId.Location = new System.Drawing.Point(33, 220);
			this.txtId.MaxLength = 32767;
			this.txtId.Name = "txtId";
			this.txtId.PasswordChar = '\0';
			this.txtId.PromptText = "Insere o ID da produto";
			this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtId.SelectedText = "";
			this.txtId.SelectionLength = 0;
			this.txtId.SelectionStart = 0;
			this.txtId.ShortcutsEnabled = true;
			this.txtId.Size = new System.Drawing.Size(150, 25);
			this.txtId.TabIndex = 1;
			this.txtId.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtId.UseCustomBackColor = true;
			this.txtId.UseSelectable = true;
			this.txtId.WaterMark = "Insere o ID da produto";
			this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.BackColor = System.Drawing.Color.Transparent;
			this.lblId.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblId.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblId.Location = new System.Drawing.Point(33, 192);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(36, 25);
			this.lblId.TabIndex = 2;
			this.lblId.Text = "ID:";
			this.lblId.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.lblId.UseCustomBackColor = true;
			// 
			// lblPerm
			// 
			this.lblPerm.AutoSize = true;
			this.lblPerm.BackColor = System.Drawing.Color.Transparent;
			this.lblPerm.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblPerm.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblPerm.Location = new System.Drawing.Point(189, 192);
			this.lblPerm.Name = "lblPerm";
			this.lblPerm.Size = new System.Drawing.Size(68, 25);
			this.lblPerm.TabIndex = 2;
			this.lblPerm.Text = "Nome:";
			this.lblPerm.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.lblPerm.UseCustomBackColor = true;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
			this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel1.Location = new System.Drawing.Point(414, 192);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(65, 25);
			this.metroLabel1.TabIndex = 2;
			this.metroLabel1.Text = "Preço:";
			this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel1.UseCustomBackColor = true;
			// 
			// txtDescricao
			// 
			// 
			// 
			// 
			this.txtDescricao.CustomButton.Image = null;
			this.txtDescricao.CustomButton.Location = new System.Drawing.Point(560, 2);
			this.txtDescricao.CustomButton.Name = "";
			this.txtDescricao.CustomButton.Size = new System.Drawing.Size(37, 37);
			this.txtDescricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtDescricao.CustomButton.TabIndex = 1;
			this.txtDescricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtDescricao.CustomButton.UseSelectable = true;
			this.txtDescricao.CustomButton.Visible = false;
			this.txtDescricao.Lines = new string[0];
			this.txtDescricao.Location = new System.Drawing.Point(33, 293);
			this.txtDescricao.MaxLength = 32767;
			this.txtDescricao.Multiline = true;
			this.txtDescricao.Name = "txtDescricao";
			this.txtDescricao.PasswordChar = '\0';
			this.txtDescricao.PromptText = "Insere a descrição do produto*";
			this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtDescricao.SelectedText = "";
			this.txtDescricao.SelectionLength = 0;
			this.txtDescricao.SelectionStart = 0;
			this.txtDescricao.ShortcutsEnabled = true;
			this.txtDescricao.Size = new System.Drawing.Size(600, 42);
			this.txtDescricao.TabIndex = 4;
			this.txtDescricao.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtDescricao.UseCustomBackColor = true;
			this.txtDescricao.UseSelectable = true;
			this.txtDescricao.WaterMark = "Insere a descrição do produto*";
			this.txtDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtDescricao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.BackColor = System.Drawing.Color.Transparent;
			this.lblEmail.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblEmail.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblEmail.Location = new System.Drawing.Point(33, 265);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(99, 25);
			this.lblEmail.TabIndex = 2;
			this.lblEmail.Text = "Descrição:";
			this.lblEmail.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.lblEmail.UseCustomBackColor = true;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
			this.metroLabel2.Location = new System.Drawing.Point(355, 341);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(278, 15);
			this.metroLabel2.TabIndex = 4;
			this.metroLabel2.Text = "Os campos com \'*\' são de preenchimento obrigatório";
			this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel2.UseCustomBackColor = true;
			// 
			// btnInserir
			// 
			this.btnInserir.Location = new System.Drawing.Point(33, 341);
			this.btnInserir.Name = "btnInserir";
			this.btnInserir.Size = new System.Drawing.Size(297, 23);
			this.btnInserir.TabIndex = 5;
			this.btnInserir.Text = "Inserir produto";
			this.btnInserir.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.btnInserir.UseSelectable = true;
			this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel3.Location = new System.Drawing.Point(183, 12);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(274, 25);
			this.metroLabel3.TabIndex = 6;
			this.metroLabel3.Text = "Aqui podes adicionar produtos";
			this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel3.UseCustomBackColor = true;
			// 
			// txtNome
			// 
			// 
			// 
			// 
			this.txtNome.CustomButton.Image = null;
			this.txtNome.CustomButton.Location = new System.Drawing.Point(195, 1);
			this.txtNome.CustomButton.Name = "";
			this.txtNome.CustomButton.Size = new System.Drawing.Size(23, 23);
			this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtNome.CustomButton.TabIndex = 1;
			this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtNome.CustomButton.UseSelectable = true;
			this.txtNome.CustomButton.Visible = false;
			this.txtNome.Lines = new string[0];
			this.txtNome.Location = new System.Drawing.Point(189, 220);
			this.txtNome.MaxLength = 32767;
			this.txtNome.Name = "txtNome";
			this.txtNome.PasswordChar = '\0';
			this.txtNome.PromptText = "Insere o nome do produto*";
			this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtNome.SelectedText = "";
			this.txtNome.SelectionLength = 0;
			this.txtNome.SelectionStart = 0;
			this.txtNome.ShortcutsEnabled = true;
			this.txtNome.Size = new System.Drawing.Size(219, 25);
			this.txtNome.TabIndex = 2;
			this.txtNome.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtNome.UseCustomBackColor = true;
			this.txtNome.UseSelectable = true;
			this.txtNome.WaterMark = "Insere o nome do produto*";
			this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			// 
			// txtPreco
			// 
			// 
			// 
			// 
			this.txtPreco.CustomButton.Image = null;
			this.txtPreco.CustomButton.Location = new System.Drawing.Point(195, 1);
			this.txtPreco.CustomButton.Name = "";
			this.txtPreco.CustomButton.Size = new System.Drawing.Size(23, 23);
			this.txtPreco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtPreco.CustomButton.TabIndex = 1;
			this.txtPreco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtPreco.CustomButton.UseSelectable = true;
			this.txtPreco.CustomButton.Visible = false;
			this.txtPreco.Lines = new string[0];
			this.txtPreco.Location = new System.Drawing.Point(414, 220);
			this.txtPreco.MaxLength = 32767;
			this.txtPreco.Name = "txtPreco";
			this.txtPreco.PasswordChar = '\0';
			this.txtPreco.PromptText = "Insere o preço do produto*";
			this.txtPreco.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtPreco.SelectedText = "";
			this.txtPreco.SelectionLength = 0;
			this.txtPreco.SelectionStart = 0;
			this.txtPreco.ShortcutsEnabled = true;
			this.txtPreco.Size = new System.Drawing.Size(219, 25);
			this.txtPreco.TabIndex = 3;
			this.txtPreco.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtPreco.UseCustomBackColor = true;
			this.txtPreco.UseSelectable = true;
			this.txtPreco.WaterMark = "Insere o preço do produto*";
			this.txtPreco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtPreco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			// 
			// pbImagem
			// 
			this.pbImagem.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbImagem.Location = new System.Drawing.Point(533, 51);
			this.pbImagem.Name = "pbImagem";
			this.pbImagem.Size = new System.Drawing.Size(100, 100);
			this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbImagem.TabIndex = 31;
			this.pbImagem.TabStop = false;
			this.pbImagem.Click += new System.EventHandler(this.pbImagem_Click);
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
			this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel4.Location = new System.Drawing.Point(338, 96);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(161, 25);
			this.metroLabel4.TabIndex = 30;
			this.metroLabel4.Text = "Escolher imagem:";
			this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel4.UseCustomBackColor = true;
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
			this.metroLabel5.Location = new System.Drawing.Point(354, 121);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(145, 30);
			this.metroLabel5.TabIndex = 29;
			this.metroLabel5.Text = "Para escolher uma imagem \r\nclique na imagem ao lado";
			this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel5.UseCustomBackColor = true;
			// 
			// produtosA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(684, 451);
			this.Controls.Add(this.pbImagem);
			this.Controls.Add(this.metroLabel4);
			this.Controls.Add(this.metroLabel5);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.btnInserir);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.lblPerm);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.txtPreco);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.txtDescricao);
			this.Controls.Add(this.lblId);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "produtosA";
			this.Text = "utilizadoresV";
			this.Load += new System.EventHandler(this.utilizadoresA_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private MetroFramework.Controls.MetroTextBox txtId;
		private MetroFramework.Controls.MetroLabel lblId;
		private MetroFramework.Controls.MetroLabel lblPerm;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroTextBox txtDescricao;
		private MetroFramework.Controls.MetroLabel lblEmail;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroButton btnInserir;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroTextBox txtNome;
		private MetroFramework.Controls.MetroTextBox txtPreco;
		private System.Windows.Forms.PictureBox pbImagem;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroLabel metroLabel5;
	}
}