namespace UI
{
	partial class VideoCreatorPageControl
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
			this.photosChooserGroupBox = new System.Windows.Forms.GroupBox();
			this.albumsPhotosRadioButton = new System.Windows.Forms.RadioButton();
			this.sharedPhotosRadioButton = new System.Windows.Forms.RadioButton();
			this.allPhotosRadioButton = new System.Windows.Forms.RadioButton();
			this.filterCheckedListBox = new System.Windows.Forms.CheckedListBox();
			this.photosCheckedListBox = new System.Windows.Forms.CheckedListBox();
			this.SongNameLabel = new System.Windows.Forms.Label();
			this.createVideoLabel = new System.Windows.Forms.Label();
			this.selectPhotosButton = new System.Windows.Forms.Button();
			this.imagePictureBox = new System.Windows.Forms.PictureBox();
			this.watchVideoButton = new System.Windows.Forms.Button();
			this.saveAsButton = new System.Windows.Forms.Button();
			this.addSongButton = new System.Windows.Forms.Button();
			this.photosChooserGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// photosChooserGroupBox
			// 
			this.photosChooserGroupBox.Controls.Add(this.albumsPhotosRadioButton);
			this.photosChooserGroupBox.Controls.Add(this.sharedPhotosRadioButton);
			this.photosChooserGroupBox.Controls.Add(this.allPhotosRadioButton);
			this.photosChooserGroupBox.Location = new System.Drawing.Point(24, 20);
			this.photosChooserGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.photosChooserGroupBox.Name = "photosChooserGroupBox";
			this.photosChooserGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.photosChooserGroupBox.Size = new System.Drawing.Size(184, 154);
			this.photosChooserGroupBox.TabIndex = 0;
			this.photosChooserGroupBox.TabStop = false;
			this.photosChooserGroupBox.Text = "Choose An Option:";
			// 
			// albumsPhotosRadioButton
			// 
			this.albumsPhotosRadioButton.AutoSize = true;
			this.albumsPhotosRadioButton.Location = new System.Drawing.Point(10, 115);
			this.albumsPhotosRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.albumsPhotosRadioButton.Name = "albumsPhotosRadioButton";
			this.albumsPhotosRadioButton.Size = new System.Drawing.Size(144, 24);
			this.albumsPhotosRadioButton.TabIndex = 2;
			this.albumsPhotosRadioButton.Text = "Album\'s Photos";
			this.albumsPhotosRadioButton.UseVisualStyleBackColor = true;
			this.albumsPhotosRadioButton.CheckedChanged += new System.EventHandler(this.albumsPhotosRadioButton_CheckedChanged);
			// 
			// sharedPhotosRadioButton
			// 
			this.sharedPhotosRadioButton.AutoSize = true;
			this.sharedPhotosRadioButton.Location = new System.Drawing.Point(10, 80);
			this.sharedPhotosRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.sharedPhotosRadioButton.Name = "sharedPhotosRadioButton";
			this.sharedPhotosRadioButton.Size = new System.Drawing.Size(140, 24);
			this.sharedPhotosRadioButton.TabIndex = 1;
			this.sharedPhotosRadioButton.Text = "Shared Photos";
			this.sharedPhotosRadioButton.UseVisualStyleBackColor = true;
			this.sharedPhotosRadioButton.CheckedChanged += new System.EventHandler(this.sharedPhotosRadioButton_CheckedChanged);
			// 
			// allPhotosRadioButton
			// 
			this.allPhotosRadioButton.AutoSize = true;
			this.allPhotosRadioButton.Checked = true;
			this.allPhotosRadioButton.Location = new System.Drawing.Point(10, 45);
			this.allPhotosRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.allPhotosRadioButton.Name = "allPhotosRadioButton";
			this.allPhotosRadioButton.Size = new System.Drawing.Size(105, 24);
			this.allPhotosRadioButton.TabIndex = 0;
			this.allPhotosRadioButton.TabStop = true;
			this.allPhotosRadioButton.Text = "All Photos";
			this.allPhotosRadioButton.UseVisualStyleBackColor = true;
			this.allPhotosRadioButton.CheckedChanged += new System.EventHandler(this.allPhotosRadioButton_CheckedChanged);
			// 
			// filterCheckedListBox
			// 
			this.filterCheckedListBox.FormattingEnabled = true;
			this.filterCheckedListBox.HorizontalScrollbar = true;
			this.filterCheckedListBox.Location = new System.Drawing.Point(237, 29);
			this.filterCheckedListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.filterCheckedListBox.Name = "filterCheckedListBox";
			this.filterCheckedListBox.Size = new System.Drawing.Size(212, 130);
			this.filterCheckedListBox.TabIndex = 1;
			this.filterCheckedListBox.Visible = false;
			this.filterCheckedListBox.Click += new System.EventHandler(this.checkedListBox_Click);
			this.filterCheckedListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkedListBox_MouseClick);
			// 
			// photosCheckedListBox
			// 
			this.photosCheckedListBox.FormattingEnabled = true;
			this.photosCheckedListBox.HorizontalScrollbar = true;
			this.photosCheckedListBox.Location = new System.Drawing.Point(24, 271);
			this.photosCheckedListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.photosCheckedListBox.Name = "photosCheckedListBox";
			this.photosCheckedListBox.Size = new System.Drawing.Size(218, 550);
			this.photosCheckedListBox.TabIndex = 4;
			this.photosCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.photosCheckedListBox_ItemCheck);
			this.photosCheckedListBox.Click += new System.EventHandler(this.checkedListBox_Click);
			this.photosCheckedListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkedListBox_MouseClick);
			this.photosCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.photosCheckedListBox_SelectedIndexChanged);
			// 
			// SongNameLabel
			// 
			this.SongNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.SongNameLabel.AutoEllipsis = true;
			this.SongNameLabel.Location = new System.Drawing.Point(282, 846);
			this.SongNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.SongNameLabel.MaximumSize = new System.Drawing.Size(450, 20);
			this.SongNameLabel.Name = "SongNameLabel";
			this.SongNameLabel.Size = new System.Drawing.Size(450, 20);
			this.SongNameLabel.TabIndex = 9;
			this.SongNameLabel.Visible = false;
			// 
			// createVideoLabel
			// 
			this.createVideoLabel.AutoSize = true;
			this.createVideoLabel.Location = new System.Drawing.Point(566, 891);
			this.createVideoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.createVideoLabel.Name = "createVideoLabel";
			this.createVideoLabel.Size = new System.Drawing.Size(13, 20);
			this.createVideoLabel.TabIndex = 11;
			this.createVideoLabel.Text = " ";
			// 
			// selectPhotosButton
			// 
			this.selectPhotosButton.BackColor = System.Drawing.Color.Transparent;
			this.selectPhotosButton.BackgroundImage = global::UI.Properties.Resources.orange_button;
			this.selectPhotosButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.selectPhotosButton.FlatAppearance.BorderSize = 0;
			this.selectPhotosButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.selectPhotosButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.selectPhotosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.selectPhotosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.selectPhotosButton.Location = new System.Drawing.Point(34, 183);
			this.selectPhotosButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.selectPhotosButton.Name = "selectPhotosButton";
			this.selectPhotosButton.Size = new System.Drawing.Size(162, 35);
			this.selectPhotosButton.TabIndex = 57;
			this.selectPhotosButton.Text = "Select Photos";
			this.selectPhotosButton.UseVisualStyleBackColor = false;
			this.selectPhotosButton.Click += new System.EventHandler(this.selectPhotosButton_Click);
			this.selectPhotosButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.selectPhotosButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			// 
			// imagePictureBox
			// 
			this.imagePictureBox.Location = new System.Drawing.Point(282, 271);
			this.imagePictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.imagePictureBox.Name = "imagePictureBox";
			this.imagePictureBox.Size = new System.Drawing.Size(606, 560);
			this.imagePictureBox.TabIndex = 7;
			this.imagePictureBox.TabStop = false;
			this.imagePictureBox.Visible = false;
			// 
			// watchVideoButton
			// 
			this.watchVideoButton.BackColor = System.Drawing.Color.Transparent;
			this.watchVideoButton.BackgroundImage = global::UI.Properties.Resources.orange_button;
			this.watchVideoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.watchVideoButton.FlatAppearance.BorderSize = 0;
			this.watchVideoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.watchVideoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.watchVideoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.watchVideoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.watchVideoButton.Location = new System.Drawing.Point(726, 928);
			this.watchVideoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.watchVideoButton.Name = "watchVideoButton";
			this.watchVideoButton.Size = new System.Drawing.Size(162, 35);
			this.watchVideoButton.TabIndex = 58;
			this.watchVideoButton.Text = "Watch Video";
			this.watchVideoButton.UseVisualStyleBackColor = false;
			this.watchVideoButton.Visible = false;
			this.watchVideoButton.Click += new System.EventHandler(this.watchVideoButton_Click);
			this.watchVideoButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.watchVideoButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			// 
			// saveAsButton
			// 
			this.saveAsButton.BackColor = System.Drawing.Color.Transparent;
			this.saveAsButton.BackgroundImage = global::UI.Properties.Resources.orange_button;
			this.saveAsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.saveAsButton.Enabled = false;
			this.saveAsButton.FlatAppearance.BorderSize = 0;
			this.saveAsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.saveAsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.saveAsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.saveAsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.saveAsButton.Location = new System.Drawing.Point(726, 883);
			this.saveAsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.saveAsButton.Name = "saveAsButton";
			this.saveAsButton.Size = new System.Drawing.Size(162, 35);
			this.saveAsButton.TabIndex = 59;
			this.saveAsButton.Text = "Save As";
			this.saveAsButton.UseVisualStyleBackColor = false;
			this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
			this.saveAsButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.saveAsButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			// 
			// addSongButton
			// 
			this.addSongButton.BackColor = System.Drawing.Color.Transparent;
			this.addSongButton.BackgroundImage = global::UI.Properties.Resources.orange_button;
			this.addSongButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.addSongButton.FlatAppearance.BorderSize = 0;
			this.addSongButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.addSongButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.addSongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addSongButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.addSongButton.Location = new System.Drawing.Point(726, 838);
			this.addSongButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.addSongButton.Name = "addSongButton";
			this.addSongButton.Size = new System.Drawing.Size(162, 35);
			this.addSongButton.TabIndex = 60;
			this.addSongButton.Text = "Add Song";
			this.addSongButton.UseVisualStyleBackColor = false;
			this.addSongButton.Click += new System.EventHandler(this.addSongButton_Click);
			this.addSongButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.addSongButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			// 
			// VideoCreatorPageControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.addSongButton);
			this.Controls.Add(this.saveAsButton);
			this.Controls.Add(this.watchVideoButton);
			this.Controls.Add(this.selectPhotosButton);
			this.Controls.Add(this.createVideoLabel);
			this.Controls.Add(this.SongNameLabel);
			this.Controls.Add(this.imagePictureBox);
			this.Controls.Add(this.photosCheckedListBox);
			this.Controls.Add(this.filterCheckedListBox);
			this.Controls.Add(this.photosChooserGroupBox);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "VideoCreatorPageControl";
			this.Size = new System.Drawing.Size(954, 966);
			this.photosChooserGroupBox.ResumeLayout(false);
			this.photosChooserGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox photosChooserGroupBox;
		private System.Windows.Forms.RadioButton albumsPhotosRadioButton;
		private System.Windows.Forms.RadioButton sharedPhotosRadioButton;
		private System.Windows.Forms.RadioButton allPhotosRadioButton;
		private System.Windows.Forms.CheckedListBox filterCheckedListBox;
		private System.Windows.Forms.CheckedListBox photosCheckedListBox;
		private System.Windows.Forms.Label SongNameLabel;
		private System.Windows.Forms.Label createVideoLabel;
		private System.Windows.Forms.Button selectPhotosButton;
		private System.Windows.Forms.PictureBox imagePictureBox;
		private System.Windows.Forms.Button watchVideoButton;
		private System.Windows.Forms.Button saveAsButton;
		private System.Windows.Forms.Button addSongButton;
	}
}
