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
			this.components = new System.ComponentModel.Container();
			this.photosChooserGroupBox = new System.Windows.Forms.GroupBox();
			this.albumsPhotosRadioButton = new System.Windows.Forms.RadioButton();
			this.sharedPhotosRadioButton = new System.Windows.Forms.RadioButton();
			this.allPhotosRadioButton = new System.Windows.Forms.RadioButton();
			this.filterCheckedListBox = new System.Windows.Forms.CheckedListBox();
			this.selectPhotosButton = new System.Windows.Forms.Button();
			this.photosCheckedListBox = new System.Windows.Forms.CheckedListBox();
			this.saveAsButton = new System.Windows.Forms.Button();
			this.addSongButton = new System.Windows.Forms.Button();
			this.SongNameLabel = new System.Windows.Forms.Label();
			this.imagePictureBox = new System.Windows.Forms.PictureBox();
			this.photoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.watchVideoButton = new System.Windows.Forms.Button();
			this.photosChooserGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// photosChooserGroupBox
			// 
			this.photosChooserGroupBox.Controls.Add(this.albumsPhotosRadioButton);
			this.photosChooserGroupBox.Controls.Add(this.sharedPhotosRadioButton);
			this.photosChooserGroupBox.Controls.Add(this.allPhotosRadioButton);
			this.photosChooserGroupBox.Location = new System.Drawing.Point(16, 13);
			this.photosChooserGroupBox.Name = "photosChooserGroupBox";
			this.photosChooserGroupBox.Size = new System.Drawing.Size(123, 100);
			this.photosChooserGroupBox.TabIndex = 0;
			this.photosChooserGroupBox.TabStop = false;
			this.photosChooserGroupBox.Text = "Choose An Option:";
			// 
			// albumsPhotosRadioButton
			// 
			this.albumsPhotosRadioButton.AutoSize = true;
			this.albumsPhotosRadioButton.Location = new System.Drawing.Point(7, 75);
			this.albumsPhotosRadioButton.Name = "albumsPhotosRadioButton";
			this.albumsPhotosRadioButton.Size = new System.Drawing.Size(97, 17);
			this.albumsPhotosRadioButton.TabIndex = 2;
			this.albumsPhotosRadioButton.Text = "Album\'s Photos";
			this.albumsPhotosRadioButton.UseVisualStyleBackColor = true;
			this.albumsPhotosRadioButton.CheckedChanged += new System.EventHandler(this.albumsPhotosRadioButton_CheckedChanged);
			// 
			// sharedPhotosRadioButton
			// 
			this.sharedPhotosRadioButton.AutoSize = true;
			this.sharedPhotosRadioButton.Location = new System.Drawing.Point(7, 52);
			this.sharedPhotosRadioButton.Name = "sharedPhotosRadioButton";
			this.sharedPhotosRadioButton.Size = new System.Drawing.Size(95, 17);
			this.sharedPhotosRadioButton.TabIndex = 1;
			this.sharedPhotosRadioButton.Text = "Shared Photos";
			this.sharedPhotosRadioButton.UseVisualStyleBackColor = true;
			this.sharedPhotosRadioButton.CheckedChanged += new System.EventHandler(this.sharedPhotosRadioButton_CheckedChanged);
			// 
			// allPhotosRadioButton
			// 
			this.allPhotosRadioButton.AutoSize = true;
			this.allPhotosRadioButton.Checked = true;
			this.allPhotosRadioButton.Location = new System.Drawing.Point(7, 29);
			this.allPhotosRadioButton.Name = "allPhotosRadioButton";
			this.allPhotosRadioButton.Size = new System.Drawing.Size(72, 17);
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
			this.filterCheckedListBox.Location = new System.Drawing.Point(156, 13);
			this.filterCheckedListBox.Name = "filterCheckedListBox";
			this.filterCheckedListBox.Size = new System.Drawing.Size(143, 94);
			this.filterCheckedListBox.TabIndex = 1;
			this.filterCheckedListBox.Visible = false;
			this.filterCheckedListBox.Click += new System.EventHandler(this.checkedListBox_Click);
			this.filterCheckedListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkedListBox_MouseClick);
			// 
			// selectPhotosButton
			// 
			this.selectPhotosButton.Location = new System.Drawing.Point(41, 119);
			this.selectPhotosButton.Name = "selectPhotosButton";
			this.selectPhotosButton.Size = new System.Drawing.Size(98, 23);
			this.selectPhotosButton.TabIndex = 3;
			this.selectPhotosButton.Text = "Select Photos";
			this.selectPhotosButton.UseVisualStyleBackColor = true;
			this.selectPhotosButton.Click += new System.EventHandler(this.selectPhotosButton_Click);
			// 
			// photosCheckedListBox
			// 
			this.photosCheckedListBox.FormattingEnabled = true;
			this.photosCheckedListBox.HorizontalScrollbar = true;
			this.photosCheckedListBox.Location = new System.Drawing.Point(16, 176);
			this.photosCheckedListBox.Name = "photosCheckedListBox";
			this.photosCheckedListBox.Size = new System.Drawing.Size(147, 364);
			this.photosCheckedListBox.TabIndex = 4;
			this.photosCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.photosCheckedListBox_ItemCheck);
			this.photosCheckedListBox.Click += new System.EventHandler(this.checkedListBox_Click);
			this.photosCheckedListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkedListBox_MouseClick);
			this.photosCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.photosCheckedListBox_SelectedIndexChanged);
			// 
			// saveAsButton
			// 
			this.saveAsButton.Enabled = false;
			this.saveAsButton.Location = new System.Drawing.Point(494, 574);
			this.saveAsButton.Name = "saveAsButton";
			this.saveAsButton.Size = new System.Drawing.Size(98, 23);
			this.saveAsButton.TabIndex = 6;
			this.saveAsButton.Text = "Save As";
			this.saveAsButton.UseVisualStyleBackColor = true;
			this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
			// 
			// addSongButton
			// 
			this.addSongButton.Location = new System.Drawing.Point(494, 545);
			this.addSongButton.Name = "addSongButton";
			this.addSongButton.Size = new System.Drawing.Size(98, 23);
			this.addSongButton.TabIndex = 8;
			this.addSongButton.Text = "Add Song";
			this.addSongButton.UseVisualStyleBackColor = true;
			this.addSongButton.Click += new System.EventHandler(this.addSongButton_Click);
			// 
			// SongNameLabel
			// 
			this.SongNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.SongNameLabel.AutoEllipsis = true;
			this.SongNameLabel.Location = new System.Drawing.Point(188, 550);
			this.SongNameLabel.MaximumSize = new System.Drawing.Size(300, 13);
			this.SongNameLabel.Name = "SongNameLabel";
			this.SongNameLabel.Size = new System.Drawing.Size(300, 13);
			this.SongNameLabel.TabIndex = 9;
			this.SongNameLabel.Visible = false;
			// 
			// imagePictureBox
			// 
			this.imagePictureBox.Location = new System.Drawing.Point(188, 176);
			this.imagePictureBox.Name = "imagePictureBox";
			this.imagePictureBox.Size = new System.Drawing.Size(404, 364);
			this.imagePictureBox.TabIndex = 7;
			this.imagePictureBox.TabStop = false;
			this.imagePictureBox.Visible = false;
			// 
			// photoBindingSource
			// 
			this.photoBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Photo);
			// 
			// watchVideoButton
			// 
			this.watchVideoButton.Location = new System.Drawing.Point(494, 603);
			this.watchVideoButton.Name = "watchVideoButton";
			this.watchVideoButton.Size = new System.Drawing.Size(98, 23);
			this.watchVideoButton.TabIndex = 10;
			this.watchVideoButton.Text = "Watch Video";
			this.watchVideoButton.UseVisualStyleBackColor = true;
			this.watchVideoButton.Visible = false;
			this.watchVideoButton.Click += new System.EventHandler(this.watchVideoButton_Click);
			// 
			// VideoCreatorPageControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.watchVideoButton);
			this.Controls.Add(this.SongNameLabel);
			this.Controls.Add(this.addSongButton);
			this.Controls.Add(this.imagePictureBox);
			this.Controls.Add(this.saveAsButton);
			this.Controls.Add(this.photosCheckedListBox);
			this.Controls.Add(this.selectPhotosButton);
			this.Controls.Add(this.filterCheckedListBox);
			this.Controls.Add(this.photosChooserGroupBox);
			this.Name = "VideoCreatorPageControl";
			this.Size = new System.Drawing.Size(636, 628);
			this.photosChooserGroupBox.ResumeLayout(false);
			this.photosChooserGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox photosChooserGroupBox;
		private System.Windows.Forms.RadioButton albumsPhotosRadioButton;
		private System.Windows.Forms.RadioButton sharedPhotosRadioButton;
		private System.Windows.Forms.RadioButton allPhotosRadioButton;
		private System.Windows.Forms.CheckedListBox filterCheckedListBox;
		private System.Windows.Forms.Button selectPhotosButton;
		private System.Windows.Forms.CheckedListBox photosCheckedListBox;
		private System.Windows.Forms.Button saveAsButton;
		private System.Windows.Forms.PictureBox imagePictureBox;
		private System.Windows.Forms.BindingSource photoBindingSource;
		private System.Windows.Forms.Button addSongButton;
		private System.Windows.Forms.Label SongNameLabel;
		private System.Windows.Forms.Button watchVideoButton;
	}
}
