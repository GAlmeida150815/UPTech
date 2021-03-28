
namespace UPTech {
	partial class token {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(token));
			this.button1 = new System.Windows.Forms.Button();
			this.lblId = new MetroFramework.Controls.MetroLabel();
			this.btnEditar = new MetroFramework.Controls.MetroButton();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.cbEditar = new MetroFramework.Controls.MetroCheckBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.txtToken = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.btnEliminar = new MetroFramework.Controls.MetroButton();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.cbUsers = new MetroFramework.Controls.MetroComboBox();
			this.cbType = new MetroFramework.Controls.MetroComboBox();
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
			this.lblId.Size = new System.Drawing.Size(135, 25);
			this.lblId.TabIndex = 25;
			this.lblId.Text = "Tipo de token:";
			this.lblId.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.lblId.UseCustomBackColor = true;
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(22, 250);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(297, 23);
			this.btnEditar.TabIndex = 24;
			this.btnEditar.Text = "Editar token";
			this.btnEditar.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.btnEditar.UseSelectable = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
			this.metroLabel2.Location = new System.Drawing.Point(22, 222);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(278, 15);
			this.metroLabel2.TabIndex = 23;
			this.metroLabel2.Text = "Os campos com \'*\' são de preenchimento obrigatório";
			this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel2.UseCustomBackColor = true;
			// 
			// cbEditar
			// 
			this.cbEditar.AutoSize = true;
			this.cbEditar.Location = new System.Drawing.Point(413, 222);
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
			this.metroLabel1.Location = new System.Drawing.Point(193, 92);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(63, 25);
			this.metroLabel1.TabIndex = 25;
			this.metroLabel1.Text = "Email:";
			this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel1.UseCustomBackColor = true;
			// 
			// txtToken
			// 
			// 
			// 
			// 
			this.txtToken.CustomButton.Image = null;
			this.txtToken.CustomButton.Location = new System.Drawing.Point(420, 1);
			this.txtToken.CustomButton.Name = "";
			this.txtToken.CustomButton.Size = new System.Drawing.Size(23, 23);
			this.txtToken.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtToken.CustomButton.TabIndex = 1;
			this.txtToken.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtToken.CustomButton.UseSelectable = true;
			this.txtToken.CustomButton.Visible = false;
			this.txtToken.Lines = new string[0];
			this.txtToken.Location = new System.Drawing.Point(22, 185);
			this.txtToken.MaxLength = 32767;
			this.txtToken.Name = "txtToken";
			this.txtToken.PasswordChar = '\0';
			this.txtToken.PromptText = "Insere o token*";
			this.txtToken.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtToken.SelectedText = "";
			this.txtToken.SelectionLength = 0;
			this.txtToken.SelectionStart = 0;
			this.txtToken.ShortcutsEnabled = true;
			this.txtToken.Size = new System.Drawing.Size(444, 25);
			this.txtToken.TabIndex = 21;
			this.txtToken.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtToken.UseCustomBackColor = true;
			this.txtToken.UseSelectable = true;
			this.txtToken.WaterMark = "Insere o token*";
			this.txtToken.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtToken.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
			this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel3.Location = new System.Drawing.Point(30, 321);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(140, 25);
			this.metroLabel3.TabIndex = 25;
			this.metroLabel3.Text = "Eliminar token:";
			this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel3.UseCustomBackColor = true;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(191, 321);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(297, 23);
			this.btnEliminar.TabIndex = 24;
			this.btnEliminar.Text = "Eliminar token";
			this.btnEliminar.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.btnEliminar.UseSelectable = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// metroLabel6
			// 
			this.metroLabel6.AutoSize = true;
			this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
			this.metroLabel6.Location = new System.Drawing.Point(178, 303);
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new System.Drawing.Size(317, 15);
			this.metroLabel6.TabIndex = 23;
			this.metroLabel6.Text = "Ao eliminar o token, o token será apagado permanentemente";
			this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel6.UseCustomBackColor = true;
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
			this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel4.Location = new System.Drawing.Point(22, 157);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(68, 25);
			this.metroLabel4.TabIndex = 25;
			this.metroLabel4.Text = "Token:";
			this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel4.UseCustomBackColor = true;
			// 
			// cbUsers
			// 
			this.cbUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.cbUsers.FontSize = MetroFramework.MetroComboBoxSize.Small;
			this.cbUsers.FormattingEnabled = true;
			this.cbUsers.ItemHeight = 19;
			this.cbUsers.Location = new System.Drawing.Point(193, 120);
			this.cbUsers.Name = "cbUsers";
			this.cbUsers.PromptText = "Escolhe o email*";
			this.cbUsers.Size = new System.Drawing.Size(273, 25);
			this.cbUsers.TabIndex = 30;
			this.cbUsers.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.cbUsers.UseCustomBackColor = true;
			this.cbUsers.UseSelectable = true;
			// 
			// cbType
			// 
			this.cbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.cbType.FontSize = MetroFramework.MetroComboBoxSize.Small;
			this.cbType.FormattingEnabled = true;
			this.cbType.ItemHeight = 19;
			this.cbType.Location = new System.Drawing.Point(22, 120);
			this.cbType.Name = "cbType";
			this.cbType.PromptText = "Escolhe o tipo de token*";
			this.cbType.Size = new System.Drawing.Size(165, 25);
			this.cbType.TabIndex = 30;
			this.cbType.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.cbType.UseCustomBackColor = true;
			this.cbType.UseSelectable = true;
			// 
			// token
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(500, 451);
			this.Controls.Add(this.cbType);
			this.Controls.Add(this.cbUsers);
			this.Controls.Add(this.cbEditar);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.metroLabel4);
			this.Controls.Add(this.lblId);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.metroLabel6);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.txtToken);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "token";
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
		private MetroFramework.Controls.MetroCheckBox cbEditar;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroTextBox txtToken;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroButton btnEliminar;
		private MetroFramework.Controls.MetroLabel metroLabel6;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroComboBox cbUsers;
		private MetroFramework.Controls.MetroComboBox cbType;
	}
}