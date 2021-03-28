
namespace UPTech {
	partial class categoriasA {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(categoriasA));
			this.button1 = new System.Windows.Forms.Button();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.btnInserir = new MetroFramework.Controls.MetroButton();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.lblName = new MetroFramework.Controls.MetroLabel();
			this.txtId = new MetroFramework.Controls.MetroTextBox();
			this.lblId = new MetroFramework.Controls.MetroLabel();
			this.txtNome = new MetroFramework.Controls.MetroTextBox();
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
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel3.Location = new System.Drawing.Point(181, 12);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(285, 25);
			this.metroLabel3.TabIndex = 17;
			this.metroLabel3.Text = "Aqui podes adicionar categorias";
			this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel3.UseCustomBackColor = true;
			// 
			// btnInserir
			// 
			this.btnInserir.Location = new System.Drawing.Point(35, 242);
			this.btnInserir.Name = "btnInserir";
			this.btnInserir.Size = new System.Drawing.Size(297, 23);
			this.btnInserir.TabIndex = 18;
			this.btnInserir.Text = "Inserir categoria";
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
			this.metroLabel2.TabIndex = 14;
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
			this.lblName.Location = new System.Drawing.Point(191, 173);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(179, 25);
			this.lblName.TabIndex = 10;
			this.lblName.Text = "Nome da categoria:";
			this.lblName.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.lblName.UseCustomBackColor = true;
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
			this.txtId.TabIndex = 7;
			this.txtId.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtId.UseCustomBackColor = true;
			this.txtId.UseSelectable = true;
			this.txtId.WaterMark = "Insere o ID da categoria";
			this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
			this.lblId.TabIndex = 19;
			this.lblId.Text = "ID:";
			this.lblId.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.lblId.UseCustomBackColor = true;
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
			this.txtNome.Location = new System.Drawing.Point(191, 201);
			this.txtNome.MaxLength = 32767;
			this.txtNome.Name = "txtNome";
			this.txtNome.PasswordChar = '\0';
			this.txtNome.PromptText = "Insere o nome da categoria*";
			this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtNome.SelectedText = "";
			this.txtNome.SelectionLength = 0;
			this.txtNome.SelectionStart = 0;
			this.txtNome.ShortcutsEnabled = true;
			this.txtNome.Size = new System.Drawing.Size(444, 25);
			this.txtNome.TabIndex = 7;
			this.txtNome.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtNome.UseCustomBackColor = true;
			this.txtNome.UseSelectable = true;
			this.txtNome.WaterMark = "Insere o nome da categoria*";
			this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			// 
			// categoriasA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(684, 451);
			this.Controls.Add(this.lblId);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.btnInserir);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "categoriasA";
			this.Text = "utilizadoresV";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroButton btnInserir;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel lblName;
		private MetroFramework.Controls.MetroTextBox txtId;
		private MetroFramework.Controls.MetroLabel lblId;
		private MetroFramework.Controls.MetroTextBox txtNome;
	}
}