namespace UI
{
	public partial class AlbumControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.userAlbumsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.userAlbumsPhotosFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.albumsNameLabel = new System.Windows.Forms.Label();
			this.albumsButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// userAlbumsFlowLayoutPanel
			// 
			this.userAlbumsFlowLayoutPanel.AutoScroll = true;
			this.userAlbumsFlowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
			this.userAlbumsFlowLayoutPanel.BackgroundImage = global::UI.Properties.Resources.facebook_widescreen_navy_background_image;
			this.userAlbumsFlowLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.userAlbumsFlowLayoutPanel.Location = new System.Drawing.Point(3, 39);
			this.userAlbumsFlowLayoutPanel.Name = "userAlbumsFlowLayoutPanel";
			this.userAlbumsFlowLayoutPanel.Size = new System.Drawing.Size(324, 187);
			this.userAlbumsFlowLayoutPanel.TabIndex = 15;
			this.userAlbumsFlowLayoutPanel.Visible = false;
			// 
			// userAlbumsPhotosFlowLayoutPanel
			// 
			this.userAlbumsPhotosFlowLayoutPanel.AutoScroll = true;
			this.userAlbumsPhotosFlowLayoutPanel.Location = new System.Drawing.Point(3, 39);
			this.userAlbumsPhotosFlowLayoutPanel.Name = "userAlbumsPhotosFlowLayoutPanel";
			this.userAlbumsPhotosFlowLayoutPanel.Size = new System.Drawing.Size(324, 187);
			this.userAlbumsPhotosFlowLayoutPanel.TabIndex = 13;
			// 
			// albumsNameLabel
			// 
			this.albumsNameLabel.AutoSize = true;
			this.albumsNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
			this.albumsNameLabel.ForeColor = System.Drawing.Color.AntiqueWhite;
			this.albumsNameLabel.Location = new System.Drawing.Point(139, 12);
			this.albumsNameLabel.Name = "albumsNameLabel";
			this.albumsNameLabel.Size = new System.Drawing.Size(0, 13);
			this.albumsNameLabel.TabIndex = 17;
			// 
			// albumsButton
			// 
			this.albumsButton.BackColor = System.Drawing.Color.Transparent;
			this.albumsButton.BackgroundImage = global::UI.Properties.Resources.orange_button;
			this.albumsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.albumsButton.FlatAppearance.BorderSize = 0;
			this.albumsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.albumsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.albumsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.albumsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.albumsButton.Location = new System.Drawing.Point(3, 10);
			this.albumsButton.Name = "albumsButton";
			this.albumsButton.Size = new System.Drawing.Size(108, 23);
			this.albumsButton.TabIndex = 58;
			this.albumsButton.Text = "Albums";
			this.albumsButton.UseVisualStyleBackColor = false;
			this.albumsButton.Click += new System.EventHandler(this.albumsButton_Click);
			this.albumsButton.MouseEnter += new System.EventHandler(this.albumsButton_MouseEnter);
			this.albumsButton.MouseLeave += new System.EventHandler(this.albumsButton_MouseLeave);
			// 
			// AlbumControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.albumsButton);
			this.Controls.Add(this.albumsNameLabel);
			this.Controls.Add(this.userAlbumsFlowLayoutPanel);
			this.Name = "AlbumControl";
			this.Size = new System.Drawing.Size(331, 233);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.FlowLayoutPanel userAlbumsFlowLayoutPanel;
		private System.Windows.Forms.Label albumsNameLabel;
		private System.Windows.Forms.FlowLayoutPanel userAlbumsPhotosFlowLayoutPanel;
		private System.Windows.Forms.Button albumsButton;
	}
}
