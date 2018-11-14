namespace UI
{
	partial class MapForm
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
			this.googleMapWebBrowser = new System.Windows.Forms.WebBrowser();
			this.SuspendLayout();
			// 
			// googleMapWebBrowser
			// 
			this.googleMapWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.googleMapWebBrowser.Location = new System.Drawing.Point(0, 0);
			this.googleMapWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.googleMapWebBrowser.Name = "googleMapWebBrowser";
			this.googleMapWebBrowser.Size = new System.Drawing.Size(704, 488);
			this.googleMapWebBrowser.TabIndex = 0;
			// 
			// MapForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(704, 488);
			this.Controls.Add(this.googleMapWebBrowser);
			this.Name = "MapForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Map";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.WebBrowser googleMapWebBrowser;
	}
}