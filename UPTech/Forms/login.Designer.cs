
namespace UPTech
{
	partial class login
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.txtID = new MetroFramework.Controls.MetroTextBox();
			this.txtPass = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.buttonLogin = new MetroFramework.Controls.MetroButton();
			this.cbPasswordVis = new MetroFramework.Controls.MetroCheckBox();
			this.SuspendLayout();
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
			this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel1.ForeColor = System.Drawing.Color.Transparent;
			this.metroLabel1.Location = new System.Drawing.Point(133, 103);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(36, 25);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "ID:";
			this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel1.UseCustomBackColor = true;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
			this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel2.ForeColor = System.Drawing.Color.Transparent;
			this.metroLabel2.Location = new System.Drawing.Point(72, 145);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(97, 25);
			this.metroLabel2.TabIndex = 1;
			this.metroLabel2.Text = "Password:";
			this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel2.UseCustomBackColor = true;
			// 
			// txtID
			// 
			// 
			// 
			// 
			this.txtID.CustomButton.Image = null;
			this.txtID.CustomButton.Location = new System.Drawing.Point(128, 1);
			this.txtID.CustomButton.Name = "";
			this.txtID.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtID.CustomButton.TabIndex = 1;
			this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtID.CustomButton.UseSelectable = true;
			this.txtID.CustomButton.Visible = false;
			this.txtID.Lines = new string[0];
			this.txtID.Location = new System.Drawing.Point(175, 105);
			this.txtID.MaxLength = 32767;
			this.txtID.Name = "txtID";
			this.txtID.PasswordChar = '\0';
			this.txtID.PromptText = "Introduz o teu ID";
			this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtID.SelectedText = "";
			this.txtID.SelectionLength = 0;
			this.txtID.SelectionStart = 0;
			this.txtID.ShortcutsEnabled = true;
			this.txtID.Size = new System.Drawing.Size(150, 23);
			this.txtID.TabIndex = 0;
			this.txtID.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtID.UseSelectable = true;
			this.txtID.WaterMark = "Introduz o teu ID";
			this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// txtPass
			// 
			// 
			// 
			// 
			this.txtPass.CustomButton.Image = null;
			this.txtPass.CustomButton.Location = new System.Drawing.Point(128, 1);
			this.txtPass.CustomButton.Name = "";
			this.txtPass.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtPass.CustomButton.TabIndex = 1;
			this.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtPass.CustomButton.UseSelectable = true;
			this.txtPass.CustomButton.Visible = false;
			this.txtPass.Lines = new string[0];
			this.txtPass.Location = new System.Drawing.Point(175, 147);
			this.txtPass.MaxLength = 32767;
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '*';
			this.txtPass.PromptText = "Introduz a tua password";
			this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtPass.SelectedText = "";
			this.txtPass.SelectionLength = 0;
			this.txtPass.SelectionStart = 0;
			this.txtPass.ShortcutsEnabled = true;
			this.txtPass.Size = new System.Drawing.Size(150, 23);
			this.txtPass.TabIndex = 1;
			this.txtPass.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtPass.UseSelectable = true;
			this.txtPass.WaterMark = "Introduz a tua password";
			this.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
			this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
			this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel4.ForeColor = System.Drawing.Color.Transparent;
			this.metroLabel4.Location = new System.Drawing.Point(23, 235);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(335, 45);
			this.metroLabel4.TabIndex = 3;
			this.metroLabel4.Text = "Esta aplicação é de uso exclusivo de funcionários da empresa. \r\nNão tentes entrar" +
    " se não fores autorizado.\r\n";
			this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel4.UseCustomBackColor = true;
			// 
			// buttonLogin
			// 
			this.buttonLogin.Location = new System.Drawing.Point(200, 197);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(100, 20);
			this.buttonLogin.TabIndex = 4;
			this.buttonLogin.Text = "Iniciar Sessão";
			this.buttonLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.buttonLogin.UseSelectable = true;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// cbPasswordVis
			// 
			this.cbPasswordVis.AutoSize = true;
			this.cbPasswordVis.Location = new System.Drawing.Point(175, 176);
			this.cbPasswordVis.Name = "cbPasswordVis";
			this.cbPasswordVis.Size = new System.Drawing.Size(92, 15);
			this.cbPasswordVis.TabIndex = 5;
			this.cbPasswordVis.Text = "Ver password";
			this.cbPasswordVis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.cbPasswordVis.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.cbPasswordVis.UseSelectable = true;
			this.cbPasswordVis.CheckedChanged += new System.EventHandler(this.cbPasswordVis_CheckedChanged);
			// 
			// login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 300);
			this.Controls.Add(this.cbPasswordVis);
			this.Controls.Add(this.buttonLogin);
			this.Controls.Add(this.metroLabel4);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.metroLabel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "login";
			this.Resizable = false;
			this.Style = MetroFramework.MetroColorStyle.Purple;
			this.Text = "UPTech";
			this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
			this.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Load += new System.EventHandler(this.login_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroTextBox txtID;
		private MetroFramework.Controls.MetroTextBox txtPass;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroButton buttonLogin;
		private MetroFramework.Controls.MetroCheckBox cbPasswordVis;
	}
}