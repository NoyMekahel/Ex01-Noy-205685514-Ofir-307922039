namespace UI
{
	partial class VideoCreatorControl
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
			this.allPhotosRadioButton = new System.Windows.Forms.RadioButton();
			this.sharedPhotosRadioButton = new System.Windows.Forms.RadioButton();
			this.albumsPhotosRadioButton = new System.Windows.Forms.RadioButton();
			this.friendsCheckedListBox = new System.Windows.Forms.CheckedListBox();
			this.albumsCheckedListBox = new System.Windows.Forms.CheckedListBox();
			this.selectPhotosButton = new System.Windows.Forms.Button();
			this.photosCheckedListBox = new System.Windows.Forms.CheckedListBox();
			this.photoPictureBox1 = new UI.PhotoPictureBox();
			this.createVideoButton = new System.Windows.Forms.Button();
			this.photosChooserGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.photoPictureBox1)).BeginInit();
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
			// friendsCheckedListBox
			// 
			this.friendsCheckedListBox.FormattingEnabled = true;
			this.friendsCheckedListBox.Location = new System.Drawing.Point(158, 63);
			this.friendsCheckedListBox.Name = "friendsCheckedListBox";
			this.friendsCheckedListBox.Size = new System.Drawing.Size(120, 19);
			this.friendsCheckedListBox.TabIndex = 1;
			// 
			// albumsCheckedListBox
			// 
			this.albumsCheckedListBox.FormattingEnabled = true;
			this.albumsCheckedListBox.Location = new System.Drawing.Point(158, 88);
			this.albumsCheckedListBox.Name = "albumsCheckedListBox";
			this.albumsCheckedListBox.Size = new System.Drawing.Size(120, 19);
			this.albumsCheckedListBox.TabIndex = 2;
			// 
			// selectPhotosButton
			// 
			this.selectPhotosButton.Enabled = false;
			this.selectPhotosButton.Location = new System.Drawing.Point(20, 119);
			this.selectPhotosButton.Name = "selectPhotosButton";
			this.selectPhotosButton.Size = new System.Drawing.Size(98, 23);
			this.selectPhotosButton.TabIndex = 3;
			this.selectPhotosButton.Text = "Select Photos";
			this.selectPhotosButton.UseVisualStyleBackColor = true;
			// 
			// photosCheckedListBox
			// 
			this.photosCheckedListBox.FormattingEnabled = true;
			this.photosCheckedListBox.Location = new System.Drawing.Point(16, 176);
			this.photosCheckedListBox.Name = "photosCheckedListBox";
			this.photosCheckedListBox.Size = new System.Drawing.Size(147, 364);
			this.photosCheckedListBox.TabIndex = 4;
			// 
			// photoPictureBox1
			// 
			this.photoPictureBox1.Location = new System.Drawing.Point(182, 176);
			this.photoPictureBox1.Name = "photoPictureBox1";
			this.photoPictureBox1.Photo = null;
			this.photoPictureBox1.Size = new System.Drawing.Size(416, 364);
			this.photoPictureBox1.TabIndex = 5;
			this.photoPictureBox1.TabStop = false;
			// 
			// createVideoButton
			// 
			this.createVideoButton.Enabled = false;
			this.createVideoButton.Location = new System.Drawing.Point(41, 556);
			this.createVideoButton.Name = "createVideoButton";
			this.createVideoButton.Size = new System.Drawing.Size(98, 23);
			this.createVideoButton.TabIndex = 6;
			this.createVideoButton.Text = "Create Video";
			this.createVideoButton.UseVisualStyleBackColor = true;
			this.createVideoButton.Click += new System.EventHandler(this.createVideoButton_Click);
			// 
			// VideoCreatorControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.createVideoButton);
			this.Controls.Add(this.photoPictureBox1);
			this.Controls.Add(this.photosCheckedListBox);
			this.Controls.Add(this.selectPhotosButton);
			this.Controls.Add(this.albumsCheckedListBox);
			this.Controls.Add(this.friendsCheckedListBox);
			this.Controls.Add(this.photosChooserGroupBox);
			this.Name = "VideoCreatorControl";
			this.Size = new System.Drawing.Size(636, 628);
			this.photosChooserGroupBox.ResumeLayout(false);
			this.photosChooserGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.photoPictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox photosChooserGroupBox;
		private System.Windows.Forms.RadioButton albumsPhotosRadioButton;
		private System.Windows.Forms.RadioButton sharedPhotosRadioButton;
		private System.Windows.Forms.RadioButton allPhotosRadioButton;
		private System.Windows.Forms.CheckedListBox friendsCheckedListBox;
		private System.Windows.Forms.CheckedListBox albumsCheckedListBox;
		private System.Windows.Forms.Button selectPhotosButton;
		private System.Windows.Forms.CheckedListBox photosCheckedListBox;
		private PhotoPictureBox photoPictureBox1;
		private System.Windows.Forms.Button createVideoButton;
	}
}
