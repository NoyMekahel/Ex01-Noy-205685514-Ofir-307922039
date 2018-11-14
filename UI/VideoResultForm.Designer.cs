namespace UI
{
	public partial class VideoResultForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoResultForm));
			this.videoResultWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
			((System.ComponentModel.ISupportInitialize)(this.videoResultWindowsMediaPlayer)).BeginInit();
			this.SuspendLayout();
			// 
			// videoResultWindowsMediaPlayer
			// 
			this.videoResultWindowsMediaPlayer.Enabled = true;
			this.videoResultWindowsMediaPlayer.Location = new System.Drawing.Point(12, 12);
			this.videoResultWindowsMediaPlayer.Name = "videoResultWindowsMediaPlayer";
			this.videoResultWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoResultWindowsMediaPlayer.OcxState")));
			this.videoResultWindowsMediaPlayer.Size = new System.Drawing.Size(514, 388);
			this.videoResultWindowsMediaPlayer.TabIndex = 2;
			// 
			// VideoResultForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(538, 410);
			this.Controls.Add(this.videoResultWindowsMediaPlayer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "VideoResultForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Video Result";
			((System.ComponentModel.ISupportInitialize)(this.videoResultWindowsMediaPlayer)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private AxWMPLib.AxWindowsMediaPlayer videoResultWindowsMediaPlayer;
	}
}