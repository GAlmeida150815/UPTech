
namespace UPTech {
	partial class subcategoria {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subcategoria));
			this.button1 = new System.Windows.Forms.Button();
			this.lblId = new MetroFramework.Controls.MetroLabel();
			this.btnEditar = new MetroFramework.Controls.MetroButton();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.lblName = new MetroFramework.Controls.MetroLabel();
			this.txtNome = new MetroFramework.Controls.MetroTextBox();
			this.txtId = new MetroFramework.Controls.MetroTextBox();
			this.cbEditar = new MetroFramework.Controls.MetroCheckBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.cbCategorias = new MetroFramework.Controls.MetroComboBox();
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
			this.lblId.Location = new System.Drawing.Point(23, 115);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(36, 25);
			this.lblId.TabIndex = 25;
			this.lblId.Text = "ID:";
			this.lblId.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.lblId.UseCustomBackColor = true;
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(23, 277);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(297, 23);
			this.btnEditar.TabIndex = 24;
			this.btnEditar.Text = "Editar sub-categoria";
			this.btnEditar.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.btnEditar.UseSelectable = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
			this.metroLabel2.Location = new System.Drawing.Point(23, 249);
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
			this.lblName.Location = new System.Drawing.Point(23, 182);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(216, 25);
			this.lblName.TabIndex = 22;
			this.lblName.Text = "Nome da sub-categoria:";
			this.lblName.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.lblName.UseCustomBackColor = true;
			// 
			// txtNome
			// 
			// 
			// 
			// 
			this.txtNome.CustomButton.Image = null;
			this.txtNome.CustomButton.Location = new System.Drawing.Point(420, 1);
			this.txtNome.CustomButton.Name = "";
			this.txtNome.CustomButton.Size = new System.Drawing.Size(23, 23);
			this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtNome.CustomButton.TabIndex = 1;
			this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtNome.CustomButton.UseSelectable = true;
			this.txtNome.CustomButton.Visible = false;
			this.txtNome.Lines = new string[0];
			this.txtNome.Location = new System.Drawing.Point(23, 210);
			this.txtNome.MaxLength = 32767;
			this.txtNome.Name = "txtNome";
			this.txtNome.PasswordChar = '\0';
			this.txtNome.PromptText = "Insere o nome da sub-categoria*";
			this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtNome.SelectedText = "";
			this.txtNome.SelectionLength = 0;
			this.txtNome.SelectionStart = 0;
			this.txtNome.ShortcutsEnabled = true;
			this.txtNome.Size = new System.Drawing.Size(444, 25);
			this.txtNome.TabIndex = 20;
			this.txtNome.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtNome.UseCustomBackColor = true;
			this.txtNome.UseSelectable = true;
			this.txtNome.WaterMark = "Insere o nome da sub-categoria*";
			this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
			this.txtId.Location = new System.Drawing.Point(23, 143);
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
			this.txtId.TabIndex = 21;
			this.txtId.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtId.UseCustomBackColor = true;
			this.txtId.UseSelectable = true;
			this.txtId.WaterMark = "Insere o ID da categoria";
			this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			// 
			// cbEditar
			// 
			this.cbEditar.AutoSize = true;
			this.cbEditar.Location = new System.Drawing.Point(414, 249);
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
			this.metroLabel1.Location = new System.Drawing.Point(179, 115);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(147, 25);
			this.metroLabel1.TabIndex = 25;
			this.metroLabel1.Text = "ID da categoria:";
			this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel1.UseCustomBackColor = true;
			// 
			// cbCategorias
			// 
			this.cbCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.cbCategorias.FontSize = MetroFramework.MetroComboBoxSize.Small;
			this.cbCategorias.FormattingEnabled = true;
			this.cbCategorias.ItemHeight = 19;
			this.cbCategorias.Location = new System.Drawing.Point(179, 143);
			this.cbCategorias.Name = "cbCategorias";
			this.cbCategorias.PromptText = "Escolhe a categoria*";
			this.cbCategorias.Size = new System.Drawing.Size(219, 25);
			this.cbCategorias.TabIndex = 29;
			this.cbCategorias.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.cbCategorias.UseCustomBackColor = true;
			this.cbCategorias.UseSelectable = true;
			// 
			// subcategoria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(500, 451);
			this.Controls.Add(this.cbCategorias);
			this.Controls.Add(this.cbEditar);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.lblId);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "subcategoria";
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
		private MetroFramework.Controls.MetroLabel lblName;
		private MetroFramework.Controls.MetroTextBox txtNome;
		private MetroFramework.Controls.MetroTextBox txtId;
		private MetroFramework.Controls.MetroCheckBox cbEditar;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroComboBox cbCategorias;
	}
}