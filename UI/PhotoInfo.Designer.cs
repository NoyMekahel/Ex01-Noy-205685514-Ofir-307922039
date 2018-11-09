namespace UI
{
	partial class PhotoInfo
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
			this.likesLabel = new System.Windows.Forms.Label();
			this.photoPictureBox = new System.Windows.Forms.PictureBox();
			this.likesPictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.likesPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// likesLabel
			// 
			this.likesLabel.AutoSize = true;
			this.likesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.likesLabel.Location = new System.Drawing.Point(45, 241);
			this.likesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.likesLabel.Name = "likesLabel";
			this.likesLabel.Size = new System.Drawing.Size(23, 17);
			this.likesLabel.TabIndex = 2;
			this.likesLabel.Text = "...";
			// 
			// photoPictureBox
			// 
			this.photoPictureBox.Location = new System.Drawing.Point(16, 16);
			this.photoPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.photoPictureBox.Name = "photoPictureBox";
			this.photoPictureBox.Size = new System.Drawing.Size(314, 223);
			this.photoPictureBox.TabIndex = 1;
			this.photoPictureBox.TabStop = false;
			// 
			// likesPictureBox
			// 
			this.likesPictureBox.Image = global::UI.Properties.Resources.like;
			this.likesPictureBox.InitialImage = null;
			this.likesPictureBox.Location = new System.Drawing.Point(16, 239);
			this.likesPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.likesPictureBox.Name = "likesPictureBox";
			this.likesPictureBox.Size = new System.Drawing.Size(25, 19);
			this.likesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.likesPictureBox.TabIndex = 3;
			this.likesPictureBox.TabStop = false;
			// 
			// PhotoInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(348, 354);
			this.Controls.Add(this.likesPictureBox);
			this.Controls.Add(this.likesLabel);
			this.Controls.Add(this.photoPictureBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "PhotoInfo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "PhotoInfo";
			((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.likesPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox photoPictureBox;
		private System.Windows.Forms.Label likesLabel;
		private System.Windows.Forms.PictureBox likesPictureBox;
	}
}