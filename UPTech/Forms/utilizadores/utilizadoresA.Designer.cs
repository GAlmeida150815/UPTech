
namespace UPTech {
	partial class utilizadoresA {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(utilizadoresA));
			this.button1 = new System.Windows.Forms.Button();
			this.txtId = new MetroFramework.Controls.MetroTextBox();
			this.lblId = new MetroFramework.Controls.MetroLabel();
			this.lblPerm = new MetroFramework.Controls.MetroLabel();
			this.cbPermissions = new MetroFramework.Controls.MetroComboBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.cbStates = new MetroFramework.Controls.MetroComboBox();
			this.txtEmail = new MetroFramework.Controls.MetroTextBox();
			this.lblEmail = new MetroFramework.Controls.MetroLabel();
			this.txtPassword = new MetroFramework.Controls.MetroTextBox();
			this.lblPass = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.btnInserir = new MetroFramework.Controls.MetroButton();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
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
			this.txtId.Location = new System.Drawing.Point(39, 174);
			this.txtId.MaxLength = 32767;
			this.txtId.Name = "txtId";
			this.txtId.PasswordChar = '\0';
			this.txtId.PromptText = "Insere o ID da conta";
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
			this.txtId.WaterMark = "Insere o ID da conta";
			this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.BackColor = System.Drawing.Color.Transparent;
			this.lblId.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblId.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblId.Location = new System.Drawing.Point(39, 146);
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
			this.lblPerm.Location = new System.Drawing.Point(195, 146);
			this.lblPerm.Name = "lblPerm";
			this.lblPerm.Size = new System.Drawing.Size(178, 25);
			this.lblPerm.TabIndex = 2;
			this.lblPerm.Text = "Nivel de permissão:";
			this.lblPerm.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.lblPerm.UseCustomBackColor = true;
			// 
			// cbPermissions
			// 
			this.cbPermissions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.cbPermissions.FontSize = MetroFramework.MetroComboBoxSize.Small;
			this.cbPermissions.FormattingEnabled = true;
			this.cbPermissions.ItemHeight = 19;
			this.cbPermissions.Location = new System.Drawing.Point(195, 174);
			this.cbPermissions.Name = "cbPermissions";
			this.cbPermissions.PromptText = "Escolhe o nivel de permissão*";
			this.cbPermissions.Size = new System.Drawing.Size(219, 25);
			this.cbPermissions.TabIndex = 2;
			this.cbPermissions.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.cbPermissions.UseCustomBackColor = true;
			this.cbPermissions.UseSelectable = true;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
			this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel1.Location = new System.Drawing.Point(420, 146);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(74, 25);
			this.metroLabel1.TabIndex = 2;
			this.metroLabel1.Text = "Estado:";
			this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel1.UseCustomBackColor = true;
			// 
			// cbStates
			// 
			this.cbStates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.cbStates.FontSize = MetroFramework.MetroComboBoxSize.Small;
			this.cbStates.FormattingEnabled = true;
			this.cbStates.ItemHeight = 19;
			this.cbStates.Location = new System.Drawing.Point(420, 174);
			this.cbStates.Name = "cbStates";
			this.cbStates.PromptText = "Escolhe o estado da conta*";
			this.cbStates.Size = new System.Drawing.Size(219, 25);
			this.cbStates.TabIndex = 3;
			this.cbStates.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.cbStates.UseCustomBackColor = true;
			this.cbStates.UseSelectable = true;
			// 
			// txtEmail
			// 
			// 
			// 
			// 
			this.txtEmail.CustomButton.Image = null;
			this.txtEmail.CustomButton.Location = new System.Drawing.Point(273, 1);
			this.txtEmail.CustomButton.Name = "";
			this.txtEmail.CustomButton.Size = new System.Drawing.Size(23, 23);
			this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtEmail.CustomButton.TabIndex = 1;
			this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtEmail.CustomButton.UseSelectable = true;
			this.txtEmail.CustomButton.Visible = false;
			this.txtEmail.Lines = new string[0];
			this.txtEmail.Location = new System.Drawing.Point(39, 247);
			this.txtEmail.MaxLength = 32767;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.PasswordChar = '\0';
			this.txtEmail.PromptText = "Insere o email da conta*";
			this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtEmail.SelectedText = "";
			this.txtEmail.SelectionLength = 0;
			this.txtEmail.SelectionStart = 0;
			this.txtEmail.ShortcutsEnabled = true;
			this.txtEmail.Size = new System.Drawing.Size(297, 25);
			this.txtEmail.TabIndex = 4;
			this.txtEmail.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtEmail.UseCustomBackColor = true;
			this.txtEmail.UseSelectable = true;
			this.txtEmail.WaterMark = "Insere o email da conta*";
			this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.BackColor = System.Drawing.Color.Transparent;
			this.lblEmail.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblEmail.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblEmail.Location = new System.Drawing.Point(39, 219);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(63, 25);
			this.lblEmail.TabIndex = 2;
			this.lblEmail.Text = "Email:";
			this.lblEmail.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.lblEmail.UseCustomBackColor = true;
			// 
			// txtPassword
			// 
			// 
			// 
			// 
			this.txtPassword.CustomButton.Image = null;
			this.txtPassword.CustomButton.Location = new System.Drawing.Point(273, 1);
			this.txtPassword.CustomButton.Name = "";
			this.txtPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
			this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtPassword.CustomButton.TabIndex = 1;
			this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtPassword.CustomButton.UseSelectable = true;
			this.txtPassword.CustomButton.Visible = false;
			this.txtPassword.Lines = new string[0];
			this.txtPassword.Location = new System.Drawing.Point(342, 247);
			this.txtPassword.MaxLength = 32767;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '\0';
			this.txtPassword.PromptText = "Insere a password da conta*";
			this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtPassword.SelectedText = "";
			this.txtPassword.SelectionLength = 0;
			this.txtPassword.SelectionStart = 0;
			this.txtPassword.ShortcutsEnabled = true;
			this.txtPassword.Size = new System.Drawing.Size(297, 25);
			this.txtPassword.TabIndex = 5;
			this.txtPassword.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtPassword.UseCustomBackColor = true;
			this.txtPassword.UseSelectable = true;
			this.txtPassword.WaterMark = "Insere a password da conta*";
			this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			// 
			// lblPass
			// 
			this.lblPass.AutoSize = true;
			this.lblPass.BackColor = System.Drawing.Color.Transparent;
			this.lblPass.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblPass.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblPass.Location = new System.Drawing.Point(342, 219);
			this.lblPass.Name = "lblPass";
			this.lblPass.Size = new System.Drawing.Size(97, 25);
			this.lblPass.TabIndex = 2;
			this.lblPass.Text = "Password:";
			this.lblPass.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.lblPass.UseCustomBackColor = true;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
			this.metroLabel2.Location = new System.Drawing.Point(361, 292);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(278, 15);
			this.metroLabel2.TabIndex = 4;
			this.metroLabel2.Text = "Os campos com \'*\' são de preenchimento obrigatório";
			this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel2.UseCustomBackColor = true;
			// 
			// btnInserir
			// 
			this.btnInserir.Location = new System.Drawing.Point(39, 292);
			this.btnInserir.Name = "btnInserir";
			this.btnInserir.Size = new System.Drawing.Size(297, 23);
			this.btnInserir.TabIndex = 6;
			this.btnInserir.Text = "Inserir utilizador";
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
			this.metroLabel3.Size = new System.Drawing.Size(296, 25);
			this.metroLabel3.TabIndex = 6;
			this.metroLabel3.Text = "Aqui podes adicionar utilizadores";
			this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel3.UseCustomBackColor = true;
			// 
			// utilizadoresA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(684, 451);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.btnInserir);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.cbStates);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.cbPermissions);
			this.Controls.Add(this.lblPerm);
			this.Controls.Add(this.lblPass);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.lblId);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "utilizadoresA";
			this.Text = "utilizadoresV";
			this.Load += new System.EventHandler(this.utilizadoresA_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private MetroFramework.Controls.MetroTextBox txtId;
		private MetroFramework.Controls.MetroLabel lblId;
		private MetroFramework.Controls.MetroLabel lblPerm;
		private MetroFramework.Controls.MetroComboBox cbPermissions;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroComboBox cbStates;
		private MetroFramework.Controls.MetroTextBox txtEmail;
		private MetroFramework.Controls.MetroLabel lblEmail;
		private MetroFramework.Controls.MetroTextBox txtPassword;
		private MetroFramework.Controls.MetroLabel lblPass;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroButton btnInserir;
		private MetroFramework.Controls.MetroLabel metroLabel3;
	}
}