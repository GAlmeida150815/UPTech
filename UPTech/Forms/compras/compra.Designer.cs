
namespace UPTech {
	partial class compra {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(compra));
			this.button1 = new System.Windows.Forms.Button();
			this.lblId = new MetroFramework.Controls.MetroLabel();
			this.btnEditar = new MetroFramework.Controls.MetroButton();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.txtId = new MetroFramework.Controls.MetroTextBox();
			this.cbEditar = new MetroFramework.Controls.MetroCheckBox();
			this.txtEmail = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.txtPreco = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.txtInfo = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.cbMetodo = new MetroFramework.Controls.MetroComboBox();
			this.btnEliminar = new MetroFramework.Controls.MetroButton();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
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
			this.lblId.Location = new System.Drawing.Point(22, 92);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(36, 25);
			this.lblId.TabIndex = 25;
			this.lblId.Text = "ID:";
			this.lblId.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.lblId.UseCustomBackColor = true;
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(22, 345);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(297, 23);
			this.btnEditar.TabIndex = 24;
			this.btnEditar.Text = "Editar compra";
			this.btnEditar.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.btnEditar.UseSelectable = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
			this.metroLabel2.Location = new System.Drawing.Point(22, 317);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(278, 15);
			this.metroLabel2.TabIndex = 23;
			this.metroLabel2.Text = "Os campos com \'*\' são de preenchimento obrigatório";
			this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel2.UseCustomBackColor = true;
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
			this.txtId.Location = new System.Drawing.Point(22, 120);
			this.txtId.MaxLength = 32767;
			this.txtId.Name = "txtId";
			this.txtId.PasswordChar = '\0';
			this.txtId.PromptText = "Insere o ID da compra*";
			this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtId.SelectedText = "";
			this.txtId.SelectionLength = 0;
			this.txtId.SelectionStart = 0;
			this.txtId.ShortcutsEnabled = true;
			this.txtId.Size = new System.Drawing.Size(150, 25);
			this.txtId.TabIndex = 21;
			this.txtId.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtId.UseCustomBackColor = true;
			this.txtId.UseSelectable = true;
			this.txtId.WaterMark = "Insere o ID da compra*";
			this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			// 
			// cbEditar
			// 
			this.cbEditar.AutoSize = true;
			this.cbEditar.Location = new System.Drawing.Point(413, 317);
			this.cbEditar.Name = "cbEditar";
			this.cbEditar.Size = new System.Drawing.Size(53, 15);
			this.cbEditar.TabIndex = 26;
			this.cbEditar.Text = "Editar";
			this.cbEditar.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.cbEditar.UseCustomBackColor = true;
			this.cbEditar.UseSelectable = true;
			this.cbEditar.CheckedChanged += new System.EventHandler(this.cbEditar_CheckedChanged);
			// 
			// txtEmail
			// 
			// 
			// 
			// 
			this.txtEmail.CustomButton.Image = null;
			this.txtEmail.CustomButton.Location = new System.Drawing.Point(264, 1);
			this.txtEmail.CustomButton.Name = "";
			this.txtEmail.CustomButton.Size = new System.Drawing.Size(23, 23);
			this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtEmail.CustomButton.TabIndex = 1;
			this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtEmail.CustomButton.UseSelectable = true;
			this.txtEmail.CustomButton.Visible = false;
			this.txtEmail.Lines = new string[0];
			this.txtEmail.Location = new System.Drawing.Point(178, 120);
			this.txtEmail.MaxLength = 32767;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.PasswordChar = '\0';
			this.txtEmail.PromptText = "Insere o email do comprador*";
			this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtEmail.SelectedText = "";
			this.txtEmail.SelectionLength = 0;
			this.txtEmail.SelectionStart = 0;
			this.txtEmail.ShortcutsEnabled = true;
			this.txtEmail.Size = new System.Drawing.Size(288, 25);
			this.txtEmail.TabIndex = 21;
			this.txtEmail.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtEmail.UseCustomBackColor = true;
			this.txtEmail.UseSelectable = true;
			this.txtEmail.WaterMark = "Insere o email do comprador*";
			this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
			this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel1.Location = new System.Drawing.Point(178, 92);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(63, 25);
			this.metroLabel1.TabIndex = 25;
			this.metroLabel1.Text = "Email:";
			this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel1.UseCustomBackColor = true;
			// 
			// txtPreco
			// 
			// 
			// 
			// 
			this.txtPreco.CustomButton.Image = null;
			this.txtPreco.CustomButton.Location = new System.Drawing.Point(126, 1);
			this.txtPreco.CustomButton.Name = "";
			this.txtPreco.CustomButton.Size = new System.Drawing.Size(23, 23);
			this.txtPreco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtPreco.CustomButton.TabIndex = 1;
			this.txtPreco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtPreco.CustomButton.UseSelectable = true;
			this.txtPreco.CustomButton.Visible = false;
			this.txtPreco.Lines = new string[0];
			this.txtPreco.Location = new System.Drawing.Point(22, 185);
			this.txtPreco.MaxLength = 32767;
			this.txtPreco.Name = "txtPreco";
			this.txtPreco.PasswordChar = '\0';
			this.txtPreco.PromptText = "Preço da compra";
			this.txtPreco.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtPreco.SelectedText = "";
			this.txtPreco.SelectionLength = 0;
			this.txtPreco.SelectionStart = 0;
			this.txtPreco.ShortcutsEnabled = true;
			this.txtPreco.Size = new System.Drawing.Size(150, 25);
			this.txtPreco.TabIndex = 21;
			this.txtPreco.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtPreco.UseCustomBackColor = true;
			this.txtPreco.UseSelectable = true;
			this.txtPreco.WaterMark = "Preço da compra";
			this.txtPreco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtPreco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
			this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel3.Location = new System.Drawing.Point(30, 416);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(155, 25);
			this.metroLabel3.TabIndex = 25;
			this.metroLabel3.Text = "Eliminar compra:";
			this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel3.UseCustomBackColor = true;
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
			this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel4.Location = new System.Drawing.Point(178, 157);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(212, 25);
			this.metroLabel4.TabIndex = 25;
			this.metroLabel4.Text = "Método de pagamento:";
			this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel4.UseCustomBackColor = true;
			// 
			// txtInfo
			// 
			// 
			// 
			// 
			this.txtInfo.CustomButton.Image = null;
			this.txtInfo.CustomButton.Location = new System.Drawing.Point(384, 1);
			this.txtInfo.CustomButton.Name = "";
			this.txtInfo.CustomButton.Size = new System.Drawing.Size(59, 59);
			this.txtInfo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtInfo.CustomButton.TabIndex = 1;
			this.txtInfo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtInfo.CustomButton.UseSelectable = true;
			this.txtInfo.CustomButton.Visible = false;
			this.txtInfo.Lines = new string[0];
			this.txtInfo.Location = new System.Drawing.Point(22, 250);
			this.txtInfo.MaxLength = 32767;
			this.txtInfo.Multiline = true;
			this.txtInfo.Name = "txtInfo";
			this.txtInfo.PasswordChar = '\0';
			this.txtInfo.PromptText = "Insere aqui algumas informações adicionais";
			this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtInfo.SelectedText = "";
			this.txtInfo.SelectionLength = 0;
			this.txtInfo.SelectionStart = 0;
			this.txtInfo.ShortcutsEnabled = true;
			this.txtInfo.Size = new System.Drawing.Size(444, 61);
			this.txtInfo.TabIndex = 21;
			this.txtInfo.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtInfo.UseCustomBackColor = true;
			this.txtInfo.UseSelectable = true;
			this.txtInfo.WaterMark = "Insere aqui algumas informações adicionais";
			this.txtInfo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtInfo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
			this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel5.Location = new System.Drawing.Point(22, 222);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(213, 25);
			this.metroLabel5.TabIndex = 25;
			this.metroLabel5.Text = "Informações adicionais:";
			this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel5.UseCustomBackColor = true;
			// 
			// cbMetodo
			// 
			this.cbMetodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.cbMetodo.FontSize = MetroFramework.MetroComboBoxSize.Small;
			this.cbMetodo.FormattingEnabled = true;
			this.cbMetodo.ItemHeight = 19;
			this.cbMetodo.Location = new System.Drawing.Point(177, 185);
			this.cbMetodo.Name = "cbMetodo";
			this.cbMetodo.PromptText = "Escolhe método de pagamento*";
			this.cbMetodo.Size = new System.Drawing.Size(289, 25);
			this.cbMetodo.TabIndex = 40;
			this.cbMetodo.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.cbMetodo.UseCustomBackColor = true;
			this.cbMetodo.UseSelectable = true;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(191, 416);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(297, 23);
			this.btnEliminar.TabIndex = 24;
			this.btnEliminar.Text = "Eliminar compra";
			this.btnEliminar.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.btnEliminar.UseSelectable = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// metroLabel6
			// 
			this.metroLabel6.AutoSize = true;
			this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
			this.metroLabel6.Location = new System.Drawing.Point(187, 383);
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new System.Drawing.Size(301, 30);
			this.metroLabel6.TabIndex = 23;
			this.metroLabel6.Text = "Ao eliminar a compra os produtos comprados associados \r\nà mesma serão apagados da" +
    " mesma forma";
			this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel6.UseCustomBackColor = true;
			// 
			// compra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(500, 451);
			this.Controls.Add(this.cbMetodo);
			this.Controls.Add(this.cbEditar);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.metroLabel4);
			this.Controls.Add(this.metroLabel5);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.lblId);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.metroLabel6);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtInfo);
			this.Controls.Add(this.txtPreco);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "compra";
			this.Text = "utilizadoresV";
			this.Load += new System.EventHandler(this.categoria_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private MetroFramework.Controls.MetroLabel lblId;
		private MetroFramework.Controls.MetroButton btnEditar;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroTextBox txtId;
		private MetroFramework.Controls.MetroCheckBox cbEditar;
		private MetroFramework.Controls.MetroTextBox txtEmail;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroTextBox txtPreco;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroTextBox txtInfo;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private MetroFramework.Controls.MetroComboBox cbMetodo;
		private MetroFramework.Controls.MetroButton btnEliminar;
		private MetroFramework.Controls.MetroLabel metroLabel6;
	}
}