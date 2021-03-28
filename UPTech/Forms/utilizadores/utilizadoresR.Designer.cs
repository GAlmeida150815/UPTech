
namespace UPTech {
	partial class utilizadoresR {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(categoriasV));
			this.button1 = new System.Windows.Forms.Button();
			this.panelSideVisualizer = new System.Windows.Forms.Panel();
			this.panelCloseVisualizer = new System.Windows.Forms.Panel();
			this.panelMainVisualizer = new System.Windows.Forms.Panel();
			this.panelSideVisualizer.SuspendLayout();
			this.panelCloseVisualizer.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.LightGray;
			this.button1.Location = new System.Drawing.Point(11, 11);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(25, 25);
			this.button1.TabIndex = 0;
			this.button1.Text = "X";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panelSideVisualizer
			// 
			this.panelSideVisualizer.AutoScroll = true;
			this.panelSideVisualizer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
			this.panelSideVisualizer.Controls.Add(this.panelCloseVisualizer);
			this.panelSideVisualizer.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelSideVisualizer.Location = new System.Drawing.Point(0, 0);
			this.panelSideVisualizer.Name = "panelSideVisualizer";
			this.panelSideVisualizer.Size = new System.Drawing.Size(184, 451);
			this.panelSideVisualizer.TabIndex = 1;
			// 
			// panelCloseVisualizer
			// 
			this.panelCloseVisualizer.Controls.Add(this.button1);
			this.panelCloseVisualizer.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelCloseVisualizer.Location = new System.Drawing.Point(0, 0);
			this.panelCloseVisualizer.Name = "panelCloseVisualizer";
			this.panelCloseVisualizer.Size = new System.Drawing.Size(184, 47);
			this.panelCloseVisualizer.TabIndex = 1;
			// 
			// panelMainVisualizer
			// 
			this.panelMainVisualizer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMainVisualizer.Location = new System.Drawing.Point(184, 0);
			this.panelMainVisualizer.Name = "panelMainVisualizer";
			this.panelMainVisualizer.Size = new System.Drawing.Size(500, 451);
			this.panelMainVisualizer.TabIndex = 2;
			// 
			// categoriasV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(684, 451);
			this.Controls.Add(this.panelMainVisualizer);
			this.Controls.Add(this.panelSideVisualizer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "categoriasV";
			this.Text = "utilizadoresV";
			this.Load += new System.EventHandler(this.categoriasV_Load);
			this.panelSideVisualizer.ResumeLayout(false);
			this.panelCloseVisualizer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panelSideVisualizer;
		private System.Windows.Forms.Panel panelCloseVisualizer;
		private System.Windows.Forms.Panel panelMainVisualizer;
	}
}