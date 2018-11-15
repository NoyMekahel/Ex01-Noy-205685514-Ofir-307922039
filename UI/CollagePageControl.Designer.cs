namespace UI
{
	partial class CollagePageControl
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
			this.selectPhotosButton = new System.Windows.Forms.Button();
			this.imagePictureBox = new System.Windows.Forms.PictureBox();
			this.seeCollageButton = new System.Windows.Forms.Button();
			this.collageFrameButton = new System.Windows.Forms.Button();
			this.photosChooserGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
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
			this.filterCheckedListBox.Location = new System.Drawing.Point(158, 19);
			this.filterCheckedListBox.Name = "filterCheckedListBox";
			this.filterCheckedListBox.Size = new System.Drawing.Size(143, 94);
			this.filterCheckedListBox.TabIndex = 1;
			this.filterCheckedListBox.Visible = false;
			this.filterCheckedListBox.Click += new System.EventHandler(this.checkedListBox_Click);
			this.filterCheckedListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkedListBox_MouseClick);
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
			// selectPhotosButton
			// 
			this.selectPhotosButton.BackColor = System.Drawing.Color.Transparent;
			this.selectPhotosButton.BackgroundImage = global::UI.Properties.Resources.orange_button;
			this.selectPhotosButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.selectPhotosButton.Enabled = false;
			this.selectPhotosButton.FlatAppearance.BorderSize = 0;
			this.selectPhotosButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.selectPhotosButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.selectPhotosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.selectPhotosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.selectPhotosButton.Location = new System.Drawing.Point(18, 147);
			this.selectPhotosButton.Name = "selectPhotosButton";
			this.selectPhotosButton.Size = new System.Drawing.Size(145, 23);
			this.selectPhotosButton.TabIndex = 57;
			this.selectPhotosButton.Text = "Select Photos";
			this.selectPhotosButton.UseVisualStyleBackColor = false;
			this.selectPhotosButton.Click += new System.EventHandler(this.selectPhotosButton_Click);
			this.selectPhotosButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.selectPhotosButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
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
			// seeCollageButton
			// 
			this.seeCollageButton.BackColor = System.Drawing.Color.Transparent;
			this.seeCollageButton.BackgroundImage = global::UI.Properties.Resources.orange_button;
			this.seeCollageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.seeCollageButton.Enabled = false;
			this.seeCollageButton.FlatAppearance.BorderSize = 0;
			this.seeCollageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.seeCollageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.seeCollageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.seeCollageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.seeCollageButton.Location = new System.Drawing.Point(484, 557);
			this.seeCollageButton.Name = "seeCollageButton";
			this.seeCollageButton.Size = new System.Drawing.Size(108, 23);
			this.seeCollageButton.TabIndex = 58;
			this.seeCollageButton.Text = "See Collage";
			this.seeCollageButton.UseVisualStyleBackColor = false;
			this.seeCollageButton.Click += new System.EventHandler(this.seeCollageButton_Click);
			this.seeCollageButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.seeCollageButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			// 
			// collageFrameButton
			// 
			this.collageFrameButton.BackColor = System.Drawing.Color.Transparent;
			this.collageFrameButton.BackgroundImage = global::UI.Properties.Resources.orange_button;
			this.collageFrameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.collageFrameButton.FlatAppearance.BorderSize = 0;
			this.collageFrameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.collageFrameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.collageFrameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.collageFrameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.collageFrameButton.Location = new System.Drawing.Point(16, 119);
			this.collageFrameButton.Name = "collageFrameButton";
			this.collageFrameButton.Size = new System.Drawing.Size(145, 23);
			this.collageFrameButton.TabIndex = 61;
			this.collageFrameButton.Text = "Choose Collage Frame";
			this.collageFrameButton.UseVisualStyleBackColor = false;
			this.collageFrameButton.Click += new System.EventHandler(this.collageFrameButton_Click);
			this.collageFrameButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.collageFrameButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			// 
			// CollagePageControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.collageFrameButton);
			this.Controls.Add(this.seeCollageButton);
			this.Controls.Add(this.selectPhotosButton);
			this.Controls.Add(this.imagePictureBox);
			this.Controls.Add(this.photosCheckedListBox);
			this.Controls.Add(this.filterCheckedListBox);
			this.Controls.Add(this.photosChooserGroupBox);
			this.Name = "CollagePageControl";
			this.Size = new System.Drawing.Size(636, 628);
			this.photosChooserGroupBox.ResumeLayout(false);
			this.photosChooserGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox photosChooserGroupBox;
		private System.Windows.Forms.RadioButton albumsPhotosRadioButton;
		private System.Windows.Forms.RadioButton sharedPhotosRadioButton;
		private System.Windows.Forms.RadioButton allPhotosRadioButton;
		private System.Windows.Forms.CheckedListBox filterCheckedListBox;
		private System.Windows.Forms.CheckedListBox photosCheckedListBox;
		private System.Windows.Forms.Button selectPhotosButton;
		private System.Windows.Forms.PictureBox imagePictureBox;
		private System.Windows.Forms.Button seeCollageButton;
		private System.Windows.Forms.Button collageFrameButton;
	}
}
