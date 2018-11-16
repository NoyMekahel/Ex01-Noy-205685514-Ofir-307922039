namespace UI
{
	partial class controlAlbum
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
			this.flowLayoutPanelUserAlbums = new System.Windows.Forms.FlowLayoutPanel();
			this.userAlbumsPhotosFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.albumsNameLabel = new System.Windows.Forms.Label();
			this.buttonAlbums = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// flowLayoutPanelUserAlbums
			// 
			this.flowLayoutPanelUserAlbums.AutoScroll = true;
			this.flowLayoutPanelUserAlbums.BackColor = System.Drawing.Color.Transparent;
			this.flowLayoutPanelUserAlbums.BackgroundImage = global::UI.Properties.Resources.facebook_widescreen_navy_background_image;
			this.flowLayoutPanelUserAlbums.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.flowLayoutPanelUserAlbums.Location = new System.Drawing.Point(4, 60);
			this.flowLayoutPanelUserAlbums.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.flowLayoutPanelUserAlbums.Name = "flowLayoutPanelUserAlbums";
			this.flowLayoutPanelUserAlbums.Size = new System.Drawing.Size(486, 288);
			this.flowLayoutPanelUserAlbums.TabIndex = 15;
			this.flowLayoutPanelUserAlbums.Visible = false;
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
			this.albumsNameLabel.Location = new System.Drawing.Point(208, 18);
			this.albumsNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.albumsNameLabel.Name = "albumsNameLabel";
			this.albumsNameLabel.Size = new System.Drawing.Size(0, 20);
			this.albumsNameLabel.TabIndex = 17;
			// 
			// buttonAlbums
			// 
			this.buttonAlbums.BackColor = System.Drawing.Color.Transparent;
			this.buttonAlbums.BackgroundImage = global::UI.Properties.Resources.orange_button;
			this.buttonAlbums.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonAlbums.FlatAppearance.BorderSize = 0;
			this.buttonAlbums.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonAlbums.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.buttonAlbums.Location = new System.Drawing.Point(4, 15);
			this.buttonAlbums.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonAlbums.Name = "buttonAlbums";
			this.buttonAlbums.Size = new System.Drawing.Size(162, 35);
			this.buttonAlbums.TabIndex = 58;
			this.buttonAlbums.Text = "Albums";
			this.buttonAlbums.UseVisualStyleBackColor = false;
			this.buttonAlbums.Click += new System.EventHandler(this.albumsButton_Click);
			this.buttonAlbums.MouseEnter += new System.EventHandler(this.albumsButton_MouseEnter);
			this.buttonAlbums.MouseLeave += new System.EventHandler(this.albumsButton_MouseLeave);
			// 
			// controlAlbum
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonAlbums);
			this.Controls.Add(this.albumsNameLabel);
			this.Controls.Add(this.flowLayoutPanelUserAlbums);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "controlAlbum";
			this.Size = new System.Drawing.Size(496, 358);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelUserAlbums;
		private System.Windows.Forms.Label albumsNameLabel;
		private System.Windows.Forms.FlowLayoutPanel userAlbumsPhotosFlowLayoutPanel;
		private System.Windows.Forms.Button buttonAlbums;
	}
}
