namespace TerminalApp.Forms
{
	partial class Providers
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
			this.Grbx_providers = new System.Windows.Forms.GroupBox();
			this.grbx_pagination = new System.Windows.Forms.GroupBox();
			this.SuspendLayout();
			// 
			// Grbx_providers
			// 
			this.Grbx_providers.Location = new System.Drawing.Point(13, 13);
			this.Grbx_providers.Name = "Grbx_providers";
			this.Grbx_providers.Size = new System.Drawing.Size(697, 364);
			this.Grbx_providers.TabIndex = 0;
			this.Grbx_providers.TabStop = false;
			this.Grbx_providers.Text = "Providers";
			// 
			// grbx_pagination
			// 
			this.grbx_pagination.Location = new System.Drawing.Point(13, 383);
			this.grbx_pagination.Name = "grbx_pagination";
			this.grbx_pagination.Size = new System.Drawing.Size(697, 57);
			this.grbx_pagination.TabIndex = 1;
			this.grbx_pagination.TabStop = false;
			this.grbx_pagination.Text = "Pagination";
			// 
			// Providers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(722, 443);
			this.Controls.Add(this.grbx_pagination);
			this.Controls.Add(this.Grbx_providers);
			this.Name = "Providers";
			this.Text = "Providers";
			this.Load += new System.EventHandler(this.Providers_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox Grbx_providers;
		private System.Windows.Forms.GroupBox grbx_pagination;
	}
}