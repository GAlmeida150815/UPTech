
namespace UPTech {
	partial class subcategoriaR {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subcategoriaR));
			this.button1 = new System.Windows.Forms.Button();
			this.lblConfirm = new MetroFramework.Controls.MetroLabel();
			this.btnEliminar = new MetroFramework.Controls.MetroButton();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
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
			// lblConfirm
			// 
			this.lblConfirm.AutoSize = true;
			this.lblConfirm.BackColor = System.Drawing.Color.Transparent;
			this.lblConfirm.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblConfirm.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblConfirm.Location = new System.Drawing.Point(34, 146);
			this.lblConfirm.Name = "lblConfirm";
			this.lblConfirm.Size = new System.Drawing.Size(429, 25);
			this.lblConfirm.TabIndex = 25;
			this.lblConfirm.Text = "Pretende realmente eliminar esta sub-categoria ?";
			this.lblConfirm.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.lblConfirm.UseCustomBackColor = true;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(85, 245);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(297, 23);
			this.btnEliminar.TabIndex = 24;
			this.btnEliminar.Text = "Eliminar sub-categoria";
			this.btnEliminar.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.btnEliminar.UseSelectable = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(51, 184);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(361, 57);
			this.metroLabel2.TabIndex = 23;
			this.metroLabel2.Text = "Ao eliminar esta sub-categoria as relações com os produtos\r\nserão eliminadas tamb" +
    "ém\r\n";
			this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel2.UseCustomBackColor = true;
			// 
			// subcategoriaR
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(500, 451);
			this.Controls.Add(this.lblConfirm);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "subcategoriaR";
			this.Text = "utilizadoresV";
			this.Load += new System.EventHandler(this.categoria_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private MetroFramework.Controls.MetroLabel lblConfirm;
		private MetroFramework.Controls.MetroButton btnEliminar;
		private MetroFramework.Controls.MetroLabel metroLabel2;
	}
}