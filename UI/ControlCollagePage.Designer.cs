namespace UI
{
	partial class ControlCollagePage
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
			this.groupBoxPhotosChooser = new System.Windows.Forms.GroupBox();
			this.albumsPhotosRadioButton = new System.Windows.Forms.RadioButton();
			this.sharedPhotosRadioButton = new System.Windows.Forms.RadioButton();
			this.allPhotosRadioButton = new System.Windows.Forms.RadioButton();
			this.checkedListBoxFilter = new System.Windows.Forms.CheckedListBox();
			this.checkedListBoxPhotos = new System.Windows.Forms.CheckedListBox();
			this.buttonSelectPhotos = new System.Windows.Forms.Button();
			this.pictureBoxImage = new System.Windows.Forms.PictureBox();
			this.buttonSeeCollage = new System.Windows.Forms.Button();
			this.buttonCollageFrame = new System.Windows.Forms.Button();
			this.groupBoxPhotosChooser.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBoxPhotosChooser
			// 
			this.groupBoxPhotosChooser.Controls.Add(this.albumsPhotosRadioButton);
			this.groupBoxPhotosChooser.Controls.Add(this.sharedPhotosRadioButton);
			this.groupBoxPhotosChooser.Controls.Add(this.allPhotosRadioButton);
			this.groupBoxPhotosChooser.Enabled = false;
			this.groupBoxPhotosChooser.Location = new System.Drawing.Point(40, 100);
			this.groupBoxPhotosChooser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBoxPhotosChooser.Name = "groupBoxPhotosChooser";
			this.groupBoxPhotosChooser.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBoxPhotosChooser.Size = new System.Drawing.Size(184, 154);
			this.groupBoxPhotosChooser.TabIndex = 0;
			this.groupBoxPhotosChooser.TabStop = false;
			this.groupBoxPhotosChooser.Text = "Choose An Option:";
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
			// checkedListBoxFilter
			// 
			this.checkedListBoxFilter.FormattingEnabled = true;
			this.checkedListBoxFilter.HorizontalScrollbar = true;
			this.checkedListBoxFilter.Location = new System.Drawing.Point(262, 103);
			this.checkedListBoxFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkedListBoxFilter.Name = "checkedListBoxFilter";
			this.checkedListBoxFilter.Size = new System.Drawing.Size(212, 151);
			this.checkedListBoxFilter.TabIndex = 1;
			this.checkedListBoxFilter.Visible = false;
			this.checkedListBoxFilter.Click += new System.EventHandler(this.checkedListBox_Click);
			this.checkedListBoxFilter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkedListBox_MouseClick);
			// 
			// checkedListBoxPhotos
			// 
			this.checkedListBoxPhotos.FormattingEnabled = true;
			this.checkedListBoxPhotos.HorizontalScrollbar = true;
			this.checkedListBoxPhotos.Location = new System.Drawing.Point(24, 281);
			this.checkedListBoxPhotos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkedListBoxPhotos.Name = "checkedListBoxPhotos";
			this.checkedListBoxPhotos.Size = new System.Drawing.Size(218, 550);
			this.checkedListBoxPhotos.TabIndex = 4;
			this.checkedListBoxPhotos.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.photosCheckedListBox_ItemCheck);
			this.checkedListBoxPhotos.Click += new System.EventHandler(this.checkedListBox_Click);
			this.checkedListBoxPhotos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkedListBox_MouseClick);
			this.checkedListBoxPhotos.SelectedIndexChanged += new System.EventHandler(this.photosCheckedListBox_SelectedIndexChanged);
			// 
			// buttonSelectPhotos
			// 
			this.buttonSelectPhotos.BackColor = System.Drawing.Color.Transparent;
			this.buttonSelectPhotos.BackgroundImage = global::UI.Properties.Resources.orange_button;
			this.buttonSelectPhotos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonSelectPhotos.Enabled = false;
			this.buttonSelectPhotos.FlatAppearance.BorderSize = 0;
			this.buttonSelectPhotos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonSelectPhotos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonSelectPhotos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSelectPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.buttonSelectPhotos.Location = new System.Drawing.Point(510, 219);
			this.buttonSelectPhotos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonSelectPhotos.Name = "buttonSelectPhotos";
			this.buttonSelectPhotos.Size = new System.Drawing.Size(218, 35);
			this.buttonSelectPhotos.TabIndex = 57;
			this.buttonSelectPhotos.Text = "Select Photos";
			this.buttonSelectPhotos.UseVisualStyleBackColor = false;
			this.buttonSelectPhotos.Click += new System.EventHandler(this.selectPhotosButton_Click);
			this.buttonSelectPhotos.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.buttonSelectPhotos.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			// 
			// pictureBoxImage
			// 
			this.pictureBoxImage.Location = new System.Drawing.Point(282, 281);
			this.pictureBoxImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBoxImage.Name = "pictureBoxImage";
			this.pictureBoxImage.Size = new System.Drawing.Size(606, 550);
			this.pictureBoxImage.TabIndex = 7;
			this.pictureBoxImage.TabStop = false;
			this.pictureBoxImage.Visible = false;
			// 
			// buttonSeeCollage
			// 
			this.buttonSeeCollage.BackColor = System.Drawing.Color.Transparent;
			this.buttonSeeCollage.BackgroundImage = global::UI.Properties.Resources.orange_button;
			this.buttonSeeCollage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonSeeCollage.Enabled = false;
			this.buttonSeeCollage.FlatAppearance.BorderSize = 0;
			this.buttonSeeCollage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonSeeCollage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonSeeCollage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSeeCollage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.buttonSeeCollage.Location = new System.Drawing.Point(726, 857);
			this.buttonSeeCollage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonSeeCollage.Name = "buttonSeeCollage";
			this.buttonSeeCollage.Size = new System.Drawing.Size(162, 35);
			this.buttonSeeCollage.TabIndex = 58;
			this.buttonSeeCollage.Text = "See Collage";
			this.buttonSeeCollage.UseVisualStyleBackColor = false;
			this.buttonSeeCollage.Click += new System.EventHandler(this.seeCollageButton_Click);
			this.buttonSeeCollage.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.buttonSeeCollage.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			// 
			// buttonCollageFrame
			// 
			this.buttonCollageFrame.BackColor = System.Drawing.Color.Transparent;
			this.buttonCollageFrame.BackgroundImage = global::UI.Properties.Resources.orange_button;
			this.buttonCollageFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonCollageFrame.FlatAppearance.BorderSize = 0;
			this.buttonCollageFrame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonCollageFrame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonCollageFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCollageFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.buttonCollageFrame.Location = new System.Drawing.Point(24, 39);
			this.buttonCollageFrame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonCollageFrame.Name = "buttonCollageFrame";
			this.buttonCollageFrame.Size = new System.Drawing.Size(218, 35);
			this.buttonCollageFrame.TabIndex = 61;
			this.buttonCollageFrame.Text = "Choose Collage Frame";
			this.buttonCollageFrame.UseVisualStyleBackColor = false;
			this.buttonCollageFrame.Click += new System.EventHandler(this.collageFrameButton_Click);
			this.buttonCollageFrame.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.buttonCollageFrame.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			// 
			// ControlCollagePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.buttonCollageFrame);
			this.Controls.Add(this.buttonSeeCollage);
			this.Controls.Add(this.buttonSelectPhotos);
			this.Controls.Add(this.pictureBoxImage);
			this.Controls.Add(this.checkedListBoxPhotos);
			this.Controls.Add(this.checkedListBoxFilter);
			this.Controls.Add(this.groupBoxPhotosChooser);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ControlCollagePage";
			this.Size = new System.Drawing.Size(954, 966);
			this.groupBoxPhotosChooser.ResumeLayout(false);
			this.groupBoxPhotosChooser.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxPhotosChooser;
		private System.Windows.Forms.RadioButton albumsPhotosRadioButton;
		private System.Windows.Forms.RadioButton sharedPhotosRadioButton;
		private System.Windows.Forms.RadioButton allPhotosRadioButton;
		private System.Windows.Forms.CheckedListBox checkedListBoxFilter;
		private System.Windows.Forms.CheckedListBox checkedListBoxPhotos;
		private System.Windows.Forms.Button buttonSelectPhotos;
		private System.Windows.Forms.PictureBox pictureBoxImage;
		private System.Windows.Forms.Button buttonSeeCollage;
		private System.Windows.Forms.Button buttonCollageFrame;
	}
}
