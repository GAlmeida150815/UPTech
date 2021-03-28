
namespace UPTech {
	partial class utilizador {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(utilizador));
			this.button1 = new System.Windows.Forms.Button();
			this.lblId = new MetroFramework.Controls.MetroLabel();
			this.btnEditar = new MetroFramework.Controls.MetroButton();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.lblName = new MetroFramework.Controls.MetroLabel();
			this.txtEmail = new MetroFramework.Controls.MetroTextBox();
			this.txtId = new MetroFramework.Controls.MetroTextBox();
			this.cbEditar = new MetroFramework.Controls.MetroCheckBox();
			this.cbStates = new MetroFramework.Controls.MetroComboBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.cbPermissions = new MetroFramework.Controls.MetroComboBox();
			this.lblPerm = new MetroFramework.Controls.MetroLabel();
			this.txtPassword = new MetroFramework.Controls.MetroTextBox();
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
			this.btnEditar.Location = new System.Drawing.Point(23, 333);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(297, 23);
			this.btnEditar.TabIndex = 24;
			this.btnEditar.Text = "Editar categoria";
			this.btnEditar.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.btnEditar.UseSelectable = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
			this.metroLabel2.Location = new System.Drawing.Point(23, 305);
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
			this.lblName.Location = new System.Drawing.Point(23, 238);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(63, 25);
			this.lblName.TabIndex = 22;
			this.lblName.Text = "Email:";
			this.lblName.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.lblName.UseCustomBackColor = true;
			// 
			// txtEmail
			// 
			// 
			// 
			// 
			this.txtEmail.CustomButton.Image = null;
			this.txtEmail.CustomButton.Location = new System.Drawing.Point(420, 1);
			this.txtEmail.CustomButton.Name = "";
			this.txtEmail.CustomButton.Size = new System.Drawing.Size(23, 23);
			this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtEmail.CustomButton.TabIndex = 1;
			this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtEmail.CustomButton.UseSelectable = true;
			this.txtEmail.CustomButton.Visible = false;
			this.txtEmail.Lines = new string[0];
			this.txtEmail.Location = new System.Drawing.Point(23, 266);
			this.txtEmail.MaxLength = 32767;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.PasswordChar = '\0';
			this.txtEmail.PromptText = "Insere o email*";
			this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtEmail.SelectedText = "";
			this.txtEmail.SelectionLength = 0;
			this.txtEmail.SelectionStart = 0;
			this.txtEmail.ShortcutsEnabled = true;
			this.txtEmail.Size = new System.Drawing.Size(444, 25);
			this.txtEmail.TabIndex = 20;
			this.txtEmail.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtEmail.UseCustomBackColor = true;
			this.txtEmail.UseSelectable = true;
			this.txtEmail.WaterMark = "Insere o email*";
			this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			// 
			// txtId
			// 
			// 
			// 
			// 
			this.txtId.CustomButton.Image = null;
			this.txtId.CustomButton.Location = new System.Drawing.Point(195, 1);
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
			this.txtId.PromptText = "Insere o ID";
			this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtId.SelectedText = "";
			this.txtId.SelectionLength = 0;
			this.txtId.SelectionStart = 0;
			this.txtId.ShortcutsEnabled = true;
			this.txtId.Size = new System.Drawing.Size(219, 25);
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
			this.cbEditar.Location = new System.Drawing.Point(414, 305);
			this.cbEditar.Name = "cbEditar";
			this.cbEditar.Size = new System.Drawing.Size(53, 15);
			this.cbEditar.TabIndex = 26;
			this.cbEditar.Text = "Editar";
			this.cbEditar.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.cbEditar.UseCustomBackColor = true;
			this.cbEditar.UseSelectable = true;
			this.cbEditar.CheckedChanged += new System.EventHandler(this.cbEditar_CheckedChanged);
			// 
			// cbStates
			// 
			this.cbStates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.cbStates.FontSize = MetroFramework.MetroComboBoxSize.Small;
			this.cbStates.FormattingEnabled = true;
			this.cbStates.ItemHeight = 19;
			this.cbStates.Location = new System.Drawing.Point(248, 209);
			this.cbStates.Name = "cbStates";
			this.cbStates.PromptText = "Escolhe o estado da conta*";
			this.cbStates.Size = new System.Drawing.Size(219, 25);
			this.cbStates.TabIndex = 30;
			this.cbStates.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.cbStates.UseCustomBackColor = true;
			this.cbStates.UseSelectable = true;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
			this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel1.Location = new System.Drawing.Point(248, 181);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(74, 25);
			this.metroLabel1.TabIndex = 27;
			this.metroLabel1.Text = "Estado:";
			this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel1.UseCustomBackColor = true;
			// 
			// cbPermissions
			// 
			this.cbPermissions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.cbPermissions.FontSize = MetroFramework.MetroComboBoxSize.Small;
			this.cbPermissions.FormattingEnabled = true;
			this.cbPermissions.ItemHeight = 19;
			this.cbPermissions.Location = new System.Drawing.Point(248, 143);
			this.cbPermissions.Name = "cbPermissions";
			this.cbPermissions.PromptText = "Escolhe o nivel de permissão*";
			this.cbPermissions.Size = new System.Drawing.Size(219, 25);
			this.cbPermissions.TabIndex = 28;
			this.cbPermissions.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.cbPermissions.UseCustomBackColor = true;
			this.cbPermissions.UseSelectable = true;
			// 
			// lblPerm
			// 
			this.lblPerm.AutoSize = true;
			this.lblPerm.BackColor = System.Drawing.Color.Transparent;
			this.lblPerm.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblPerm.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblPerm.Location = new System.Drawing.Point(248, 115);
			this.lblPerm.Name = "lblPerm";
			this.lblPerm.Size = new System.Drawing.Size(178, 25);
			this.lblPerm.TabIndex = 29;
			this.lblPerm.Text = "Nivel de permissão:";
			this.lblPerm.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.lblPerm.UseCustomBackColor = true;
			// 
			// txtPassword
			// 
			// 
			// 
			// 
			this.txtPassword.CustomButton.Image = null;
			this.txtPassword.CustomButton.Location = new System.Drawing.Point(195, 1);
			this.txtPassword.CustomButton.Name = "";
			this.txtPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
			this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtPassword.CustomButton.TabIndex = 1;
			this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtPassword.CustomButton.UseSelectable = true;
			this.txtPassword.CustomButton.Visible = false;
			this.txtPassword.Lines = new string[0];
			this.txtPassword.Location = new System.Drawing.Point(23, 209);
			this.txtPassword.MaxLength = 32767;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '\0';
			this.txtPassword.PromptText = "Insere a password";
			this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtPassword.SelectedText = "";
			this.txtPassword.SelectionLength = 0;
			this.txtPassword.SelectionStart = 0;
			this.txtPassword.ShortcutsEnabled = true;
			this.txtPassword.Size = new System.Drawing.Size(219, 25);
			this.txtPassword.TabIndex = 21;
			this.txtPassword.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtPassword.UseCustomBackColor = true;
			this.txtPassword.UseSelectable = true;
			this.txtPassword.WaterMark = "Insere a password";
			this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
			this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel3.Location = new System.Drawing.Point(23, 181);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(97, 25);
			this.metroLabel3.TabIndex = 25;
			this.metroLabel3.Text = "Password:";
			this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel3.UseCustomBackColor = true;
			// 
			// utilizador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(500, 451);
			this.Controls.Add(this.cbStates);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.cbPermissions);
			this.Controls.Add(this.lblPerm);
			this.Controls.Add(this.cbEditar);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.lblId);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "utilizador";
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
		private MetroFramework.Controls.MetroTextBox txtEmail;
		private MetroFramework.Controls.MetroTextBox txtId;
		private MetroFramework.Controls.MetroCheckBox cbEditar;
		private MetroFramework.Controls.MetroComboBox cbStates;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroComboBox cbPermissions;
		private MetroFramework.Controls.MetroLabel lblPerm;
		private MetroFramework.Controls.MetroTextBox txtPassword;
		private MetroFramework.Controls.MetroLabel metroLabel3;
	}
}