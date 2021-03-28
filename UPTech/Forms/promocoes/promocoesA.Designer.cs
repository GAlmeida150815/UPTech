
namespace UPTech {
	partial class promocoesA {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(promocoesA));
			this.button1 = new System.Windows.Forms.Button();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.btnInserir = new MetroFramework.Controls.MetroButton();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.lblName = new MetroFramework.Controls.MetroLabel();
			this.lblId = new MetroFramework.Controls.MetroLabel();
			this.txtPromocao = new MetroFramework.Controls.MetroTextBox();
			this.cbProdutos = new MetroFramework.Controls.MetroComboBox();
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
			this.metroLabel3.Size = new System.Drawing.Size(291, 25);
			this.metroLabel3.TabIndex = 17;
			this.metroLabel3.Text = "Aqui podes adicionar promoções";
			this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel3.UseCustomBackColor = true;
			// 
			// btnInserir
			// 
			this.btnInserir.Location = new System.Drawing.Point(35, 242);
			this.btnInserir.Name = "btnInserir";
			this.btnInserir.Size = new System.Drawing.Size(297, 23);
			this.btnInserir.TabIndex = 18;
			this.btnInserir.Text = "Adicionar promoção";
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
			this.lblName.Location = new System.Drawing.Point(254, 173);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(245, 25);
			this.lblName.TabIndex = 10;
			this.lblName.Text = "Percentagem da promoção:";
			this.lblName.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.lblName.UseCustomBackColor = true;
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.BackColor = System.Drawing.Color.Transparent;
			this.lblId.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblId.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblId.Location = new System.Drawing.Point(35, 173);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(86, 25);
			this.lblId.TabIndex = 19;
			this.lblId.Text = "Produto:";
			this.lblId.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.lblId.UseCustomBackColor = true;
			// 
			// txtPromocao
			// 
			// 
			// 
			// 
			this.txtPromocao.CustomButton.Image = null;
			this.txtPromocao.CustomButton.Location = new System.Drawing.Point(357, 1);
			this.txtPromocao.CustomButton.Name = "";
			this.txtPromocao.CustomButton.Size = new System.Drawing.Size(23, 23);
			this.txtPromocao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtPromocao.CustomButton.TabIndex = 1;
			this.txtPromocao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtPromocao.CustomButton.UseSelectable = true;
			this.txtPromocao.CustomButton.Visible = false;
			this.txtPromocao.Lines = new string[0];
			this.txtPromocao.Location = new System.Drawing.Point(254, 201);
			this.txtPromocao.MaxLength = 32767;
			this.txtPromocao.Name = "txtPromocao";
			this.txtPromocao.PasswordChar = '\0';
			this.txtPromocao.PromptText = "Insere o valor percentual da promoção*";
			this.txtPromocao.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtPromocao.SelectedText = "";
			this.txtPromocao.SelectionLength = 0;
			this.txtPromocao.SelectionStart = 0;
			this.txtPromocao.ShortcutsEnabled = true;
			this.txtPromocao.Size = new System.Drawing.Size(381, 25);
			this.txtPromocao.TabIndex = 7;
			this.txtPromocao.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtPromocao.UseCustomBackColor = true;
			this.txtPromocao.UseSelectable = true;
			this.txtPromocao.WaterMark = "Insere o valor percentual da promoção*";
			this.txtPromocao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtPromocao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			// 
			// cbProdutos
			// 
			this.cbProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.cbProdutos.FontSize = MetroFramework.MetroComboBoxSize.Small;
			this.cbProdutos.FormattingEnabled = true;
			this.cbProdutos.ItemHeight = 19;
			this.cbProdutos.Location = new System.Drawing.Point(35, 201);
			this.cbProdutos.Name = "cbProdutos";
			this.cbProdutos.PromptText = "Escolhe o produto*";
			this.cbProdutos.Size = new System.Drawing.Size(213, 25);
			this.cbProdutos.TabIndex = 35;
			this.cbProdutos.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.cbProdutos.UseCustomBackColor = true;
			this.cbProdutos.UseSelectable = true;
			// 
			// promocoesA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(684, 451);
			this.Controls.Add(this.cbProdutos);
			this.Controls.Add(this.lblId);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.btnInserir);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.txtPromocao);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "promocoesA";
			this.Text = "utilizadoresV";
			this.Load += new System.EventHandler(this.promocoesA_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroButton btnInserir;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel lblName;
		private MetroFramework.Controls.MetroLabel lblId;
		private MetroFramework.Controls.MetroTextBox txtPromocao;
		private MetroFramework.Controls.MetroComboBox cbProdutos;
	}
}