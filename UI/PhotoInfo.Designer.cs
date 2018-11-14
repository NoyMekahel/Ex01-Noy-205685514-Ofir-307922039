namespace UI
{
	public partial class PhotoInfo
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
			this.commentsListBox = new System.Windows.Forms.ListBox();
			this.likesPictureBox = new System.Windows.Forms.PictureBox();
			this.photoPictureBox = new System.Windows.Forms.PictureBox();
			this.commentsPictureBox = new System.Windows.Forms.PictureBox();
			this.commentsLabel = new System.Windows.Forms.Label();
			this.commentsPictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.likesPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.commentsPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.commentsPictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// likesLabel
			// 
			this.likesLabel.AutoSize = true;
			this.likesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.likesLabel.Location = new System.Drawing.Point(68, 371);
			this.likesLabel.Name = "likesLabel";
			this.likesLabel.Size = new System.Drawing.Size(30, 25);
			this.likesLabel.TabIndex = 2;
			this.likesLabel.Text = "...";
			// 
			// commentsListBox
			// 
			this.commentsListBox.FormattingEnabled = true;
			this.commentsListBox.ItemHeight = 20;
			this.commentsListBox.Location = new System.Drawing.Point(24, 460);
			this.commentsListBox.Name = "commentsListBox";
			this.commentsListBox.Size = new System.Drawing.Size(471, 144);
			this.commentsListBox.TabIndex = 4;
			// 
			// likesPictureBox
			// 
			this.likesPictureBox.Image = global::UI.Properties.Resources.like;
			this.likesPictureBox.InitialImage = null;
			this.likesPictureBox.Location = new System.Drawing.Point(24, 368);
			this.likesPictureBox.Name = "likesPictureBox";
			this.likesPictureBox.Size = new System.Drawing.Size(38, 29);
			this.likesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.likesPictureBox.TabIndex = 3;
			this.likesPictureBox.TabStop = false;
			// 
			// photoPictureBox
			// 
			this.photoPictureBox.Location = new System.Drawing.Point(24, 25);
			this.photoPictureBox.Name = "photoPictureBox";
			this.photoPictureBox.Size = new System.Drawing.Size(471, 343);
			this.photoPictureBox.TabIndex = 1;
			this.photoPictureBox.TabStop = false;
			// 
			// commentsPictureBox
			// 
			this.commentsPictureBox.Image = global::UI.Properties.Resources.comments;
			this.commentsPictureBox.InitialImage = null;
			this.commentsPictureBox.Location = new System.Drawing.Point(24, 414);
			this.commentsPictureBox.Name = "commentsPictureBox";
			this.commentsPictureBox.Size = new System.Drawing.Size(47, 40);
			this.commentsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.commentsPictureBox.TabIndex = 5;
			this.commentsPictureBox.TabStop = false;
			// 
			// commentsLabel
			// 
			this.commentsLabel.AutoSize = true;
			this.commentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.commentsLabel.Location = new System.Drawing.Point(77, 429);
			this.commentsLabel.Name = "commentsLabel";
			this.commentsLabel.Size = new System.Drawing.Size(122, 25);
			this.commentsLabel.TabIndex = 6;
			this.commentsLabel.Text = "Comments:";
			// 
			// commentsPictureBox2
			// 
			this.commentsPictureBox2.Image = global::UI.Properties.Resources.comments;
			this.commentsPictureBox2.InitialImage = null;
			this.commentsPictureBox2.Location = new System.Drawing.Point(218, 414);
			this.commentsPictureBox2.Name = "commentsPictureBox2";
			this.commentsPictureBox2.Size = new System.Drawing.Size(47, 40);
			this.commentsPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.commentsPictureBox2.TabIndex = 7;
			this.commentsPictureBox2.TabStop = false;
			// 
			// PhotoInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(516, 624);
			this.Controls.Add(this.commentsPictureBox2);
			this.Controls.Add(this.commentsLabel);
			this.Controls.Add(this.commentsPictureBox);
			this.Controls.Add(this.commentsListBox);
			this.Controls.Add(this.likesPictureBox);
			this.Controls.Add(this.likesLabel);
			this.Controls.Add(this.photoPictureBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "PhotoInfo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "PhotoInfo";
			((System.ComponentModel.ISupportInitialize)(this.likesPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.commentsPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.commentsPictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox photoPictureBox;
		private System.Windows.Forms.Label likesLabel;
		private System.Windows.Forms.PictureBox likesPictureBox;
		private System.Windows.Forms.ListBox commentsListBox;
		private System.Windows.Forms.PictureBox commentsPictureBox;
		private System.Windows.Forms.Label commentsLabel;
		private System.Windows.Forms.PictureBox commentsPictureBox2;
	}
}