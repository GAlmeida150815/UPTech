
namespace UPTech
{
	partial class loader
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loader));
			this.pbLogo = new System.Windows.Forms.PictureBox();
			this.loaderSpinner = new MetroFramework.Controls.MetroProgressSpinner();
			this.leavePage = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// pbLogo
			// 
			this.pbLogo.Image = global::UPTech.Properties.Resources.uptechlogo2;
			this.pbLogo.Location = new System.Drawing.Point(195, 50);
			this.pbLogo.Name = "pbLogo";
			this.pbLogo.Size = new System.Drawing.Size(300, 300);
			this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbLogo.TabIndex = 0;
			this.pbLogo.TabStop = false;
			// 
			// loaderSpinner
			// 
			this.loaderSpinner.Location = new System.Drawing.Point(300, 356);
			this.loaderSpinner.Maximum = 100;
			this.loaderSpinner.Name = "loaderSpinner";
			this.loaderSpinner.Size = new System.Drawing.Size(100, 100);
			this.loaderSpinner.Style = MetroFramework.MetroColorStyle.Purple;
			this.loaderSpinner.TabIndex = 1;
			this.loaderSpinner.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.loaderSpinner.UseSelectable = true;
			// 
			// leavePage
			// 
			this.leavePage.Interval = 2000;
			this.leavePage.Tick += new System.EventHandler(this.leavePage_Tick);
			// 
			// loader
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 500);
			this.Controls.Add(this.loaderSpinner);
			this.Controls.Add(this.pbLogo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "loader";
			this.Resizable = false;
			this.Style = MetroFramework.MetroColorStyle.Black;
			this.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Load += new System.EventHandler(this.loader_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pbLogo;
		private MetroFramework.Controls.MetroProgressSpinner loaderSpinner;
		private System.Windows.Forms.Timer leavePage;
	}
}

