
namespace UPTech {
	partial class produto {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(produto));
			this.button1 = new System.Windows.Forms.Button();
			this.lblId = new MetroFramework.Controls.MetroLabel();
			this.btnEditar = new MetroFramework.Controls.MetroButton();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.lblName = new MetroFramework.Controls.MetroLabel();
			this.txtDesc = new MetroFramework.Controls.MetroTextBox();
			this.txtId = new MetroFramework.Controls.MetroTextBox();
			this.cbEditar = new MetroFramework.Controls.MetroCheckBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.txtNome = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.txtPreco = new MetroFramework.Controls.MetroTextBox();
			this.pbImagem = new System.Windows.Forms.PictureBox();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.panelCategories = new System.Windows.Forms.Panel();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
			this.txtPromocao = new MetroFramework.Controls.MetroTextBox();
			this.lblPromocao = new MetroFramework.Controls.MetroLabel();
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
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.BackColor = System.Drawing.Color.Transparent;
			this.lblId.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblId.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblId.Location = new System.Drawing.Point(29, 57);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(36, 25);
			this.lblId.TabIndex = 25;
			this.lblId.Text = "ID:";
			this.lblId.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.lblId.UseCustomBackColor = true;
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(29, 308);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(297, 23);
			this.btnEditar.TabIndex = 24;
			this.btnEditar.Text = "Editar produto";
			this.btnEditar.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.btnEditar.UseSelectable = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
			this.metroLabel2.Location = new System.Drawing.Point(29, 280);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(278, 15);
			this.metroLabel2.TabIndex = 23;
			this.metroLabel2.Text = "Os campos com \'*\' são de preenchimento obrigatório";
			this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel2.UseCustomBackColor = true;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.BackColor = System.Drawing.Color.Transparent;
			this.lblName.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblName.Location = new System.Drawing.Point(29, 195);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(99, 25);
			this.lblName.TabIndex = 22;
			this.lblName.Text = "Descrição:";
			this.lblName.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.lblName.UseCustomBackColor = true;
			// 
			// txtDesc
			// 
			// 
			// 
			// 
			this.txtDesc.CustomButton.Image = null;
			this.txtDesc.CustomButton.Location = new System.Drawing.Point(392, 2);
			this.txtDesc.CustomButton.Name = "";
			this.txtDesc.CustomButton.Size = new System.Drawing.Size(49, 49);
			this.txtDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtDesc.CustomButton.TabIndex = 1;
			this.txtDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtDesc.CustomButton.UseSelectable = true;
			this.txtDesc.CustomButton.Visible = false;
			this.txtDesc.Lines = new string[0];
			this.txtDesc.Location = new System.Drawing.Point(29, 223);
			this.txtDesc.MaxLength = 32767;
			this.txtDesc.Multiline = true;
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.PasswordChar = '\0';
			this.txtDesc.PromptText = "Insere a descrição do produto*";
			this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtDesc.SelectedText = "";
			this.txtDesc.SelectionLength = 0;
			this.txtDesc.SelectionStart = 0;
			this.txtDesc.ShortcutsEnabled = true;
			this.txtDesc.Size = new System.Drawing.Size(444, 54);
			this.txtDesc.TabIndex = 20;
			this.txtDesc.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtDesc.UseCustomBackColor = true;
			this.txtDesc.UseSelectable = true;
			this.txtDesc.WaterMark = "Insere a descrição do produto*";
			this.txtDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			// 
			// txtId
			// 
			// 
			// 
			// 
			this.txtId.CustomButton.Image = null;
			this.txtId.CustomButton.Location = new System.Drawing.Point(108, 1);
			this.txtId.CustomButton.Name = "";
			this.txtId.CustomButton.Size = new System.Drawing.Size(23, 23);
			this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtId.CustomButton.TabIndex = 1;
			this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtId.CustomButton.UseSelectable = true;
			this.txtId.CustomButton.Visible = false;
			this.txtId.Lines = new string[0];
			this.txtId.Location = new System.Drawing.Point(29, 85);
			this.txtId.MaxLength = 32767;
			this.txtId.Name = "txtId";
			this.txtId.PasswordChar = '\0';
			this.txtId.PromptText = "Insere o ID";
			this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtId.SelectedText = "";
			this.txtId.SelectionLength = 0;
			this.txtId.SelectionStart = 0;
			this.txtId.ShortcutsEnabled = true;
			this.txtId.Size = new System.Drawing.Size(132, 25);
			this.txtId.TabIndex = 21;
			this.txtId.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtId.UseCustomBackColor = true;
			this.txtId.UseSelectable = true;
			this.txtId.WaterMark = "Insere o ID";
			this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			// 
			// cbEditar
			// 
			this.cbEditar.AutoSize = true;
			this.cbEditar.Location = new System.Drawing.Point(420, 280);
			this.cbEditar.Name = "cbEditar";
			this.cbEditar.Size = new System.Drawing.Size(53, 15);
			this.cbEditar.TabIndex = 26;
			this.cbEditar.Text = "Editar";
			this.cbEditar.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.cbEditar.UseCustomBackColor = true;
			this.cbEditar.UseSelectable = true;
			this.cbEditar.CheckedChanged += new System.EventHandler(this.cbEditar_CheckedChanged);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
			this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel1.Location = new System.Drawing.Point(254, 138);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(65, 25);
			this.metroLabel1.TabIndex = 27;
			this.metroLabel1.Text = "Preço:";
			this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel1.UseCustomBackColor = true;
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
			this.txtNome.Location = new System.Drawing.Point(29, 166);
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
			this.txtNome.TabIndex = 21;
			this.txtNome.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtNome.UseCustomBackColor = true;
			this.txtNome.UseSelectable = true;
			this.txtNome.WaterMark = "Insere o nome do produto*";
			this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
			this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel3.Location = new System.Drawing.Point(29, 138);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(68, 25);
			this.metroLabel3.TabIndex = 25;
			this.metroLabel3.Text = "Nome:";
			this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel3.UseCustomBackColor = true;
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
			this.txtPreco.Location = new System.Drawing.Point(254, 166);
			this.txtPreco.MaxLength = 32767;
			this.txtPreco.Name = "txtPreco";
			this.txtPreco.PasswordChar = '\0';
			this.txtPreco.PromptText = "Insere o nome do produto*";
			this.txtPreco.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtPreco.SelectedText = "";
			this.txtPreco.SelectionLength = 0;
			this.txtPreco.SelectionStart = 0;
			this.txtPreco.ShortcutsEnabled = true;
			this.txtPreco.Size = new System.Drawing.Size(219, 25);
			this.txtPreco.TabIndex = 21;
			this.txtPreco.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtPreco.UseCustomBackColor = true;
			this.txtPreco.UseSelectable = true;
			this.txtPreco.WaterMark = "Insere o nome do produto*";
			this.txtPreco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtPreco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			// 
			// pbImagem
			// 
			this.pbImagem.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbImagem.Location = new System.Drawing.Point(373, 12);
			this.pbImagem.Name = "pbImagem";
			this.pbImagem.Size = new System.Drawing.Size(100, 100);
			this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbImagem.TabIndex = 28;
			this.pbImagem.TabStop = false;
			this.pbImagem.Click += new System.EventHandler(this.pbImagem_Click);
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
			this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel4.Location = new System.Drawing.Point(178, 57);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(161, 25);
			this.metroLabel4.TabIndex = 25;
			this.metroLabel4.Text = "Escolher imagem:";
			this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel4.UseCustomBackColor = true;
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
			this.metroLabel5.Location = new System.Drawing.Point(194, 82);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(145, 30);
			this.metroLabel5.TabIndex = 23;
			this.metroLabel5.Text = "Para escolher uma imagem \r\nclique na imagem ao lado";
			this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel5.UseCustomBackColor = true;
			// 
			// panelCategories
			// 
			this.panelCategories.AutoScroll = true;
			this.panelCategories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelCategories.Location = new System.Drawing.Point(288, 339);
			this.panelCategories.Name = "panelCategories";
			this.panelCategories.Size = new System.Drawing.Size(200, 100);
			this.panelCategories.TabIndex = 29;
			// 
			// metroLabel6
			// 
			this.metroLabel6.AutoSize = true;
			this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
			this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel6.Location = new System.Drawing.Point(175, 339);
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new System.Drawing.Size(107, 25);
			this.metroLabel6.TabIndex = 25;
			this.metroLabel6.Text = "Categorias:";
			this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel6.UseCustomBackColor = true;
			// 
			// txtPromocao
			// 
			// 
			// 
			// 
			this.txtPromocao.CustomButton.Image = null;
			this.txtPromocao.CustomButton.Location = new System.Drawing.Point(156, 1);
			this.txtPromocao.CustomButton.Name = "";
			this.txtPromocao.CustomButton.Size = new System.Drawing.Size(23, 23);
			this.txtPromocao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtPromocao.CustomButton.TabIndex = 1;
			this.txtPromocao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtPromocao.CustomButton.UseSelectable = true;
			this.txtPromocao.CustomButton.Visible = false;
			this.txtPromocao.Lines = new string[0];
			this.txtPromocao.Location = new System.Drawing.Point(29, 401);
			this.txtPromocao.MaxLength = 32767;
			this.txtPromocao.Name = "txtPromocao";
			this.txtPromocao.PasswordChar = '\0';
			this.txtPromocao.PromptText = "Valor da promoção percentual";
			this.txtPromocao.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtPromocao.SelectedText = "";
			this.txtPromocao.SelectionLength = 0;
			this.txtPromocao.SelectionStart = 0;
			this.txtPromocao.ShortcutsEnabled = true;
			this.txtPromocao.Size = new System.Drawing.Size(180, 25);
			this.txtPromocao.TabIndex = 21;
			this.txtPromocao.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtPromocao.UseCustomBackColor = true;
			this.txtPromocao.UseSelectable = true;
			this.txtPromocao.Visible = false;
			this.txtPromocao.WaterMark = "Valor da promoção percentual";
			this.txtPromocao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtPromocao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			// 
			// lblPromocao
			// 
			this.lblPromocao.AutoSize = true;
			this.lblPromocao.BackColor = System.Drawing.Color.Transparent;
			this.lblPromocao.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblPromocao.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblPromocao.Location = new System.Drawing.Point(29, 373);
			this.lblPromocao.Name = "lblPromocao";
			this.lblPromocao.Size = new System.Drawing.Size(153, 25);
			this.lblPromocao.TabIndex = 25;
			this.lblPromocao.Text = "Promoção Ativa:";
			this.lblPromocao.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.lblPromocao.UseCustomBackColor = true;
			this.lblPromocao.Visible = false;
			// 
			// produto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(500, 451);
			this.Controls.Add(this.panelCategories);
			this.Controls.Add(this.pbImagem);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.cbEditar);
			this.Controls.Add(this.metroLabel6);
			this.Controls.Add(this.lblPromocao);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.metroLabel4);
			this.Controls.Add(this.lblId);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.metroLabel5);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.txtDesc);
			this.Controls.Add(this.txtPromocao);
			this.Controls.Add(this.txtPreco);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "produto";
			this.Text = "utilizadoresV";
			this.Load += new System.EventHandler(this.categoria_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private MetroFramework.Controls.MetroLabel lblId;
		private MetroFramework.Controls.MetroButton btnEditar;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel lblName;
		private MetroFramework.Controls.MetroTextBox txtDesc;
		private MetroFramework.Controls.MetroTextBox txtId;
		private MetroFramework.Controls.MetroCheckBox cbEditar;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroTextBox txtNome;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroTextBox txtPreco;
		private System.Windows.Forms.PictureBox pbImagem;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private System.Windows.Forms.Panel panelCategories;
		private MetroFramework.Controls.MetroLabel metroLabel6;
		private MetroFramework.Controls.MetroTextBox txtPromocao;
		private MetroFramework.Controls.MetroLabel lblPromocao;
	}
}