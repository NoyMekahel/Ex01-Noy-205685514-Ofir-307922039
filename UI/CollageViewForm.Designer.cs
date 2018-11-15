namespace UI
{
	partial class CollageViewForm
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
			this.saveAsButton = new System.Windows.Forms.Button();
			this.collageViewPictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.collageViewPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// saveAsButton
			// 
			this.saveAsButton.BackColor = System.Drawing.Color.Transparent;
			this.saveAsButton.BackgroundImage = global::UI.Properties.Resources.orange_button;
			this.saveAsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.saveAsButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.saveAsButton.FlatAppearance.BorderSize = 0;
			this.saveAsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.saveAsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.saveAsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.saveAsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.saveAsButton.Location = new System.Drawing.Point(758, 957);
			this.saveAsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.saveAsButton.Name = "saveAsButton";
			this.saveAsButton.Size = new System.Drawing.Size(162, 35);
			this.saveAsButton.TabIndex = 60;
			this.saveAsButton.Text = "Save As";
			this.saveAsButton.UseVisualStyleBackColor = false;
			this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
			// 
			// collageViewPictureBox
			// 
			this.collageViewPictureBox.Location = new System.Drawing.Point(20, 20);
			this.collageViewPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.collageViewPictureBox.Name = "collageViewPictureBox";
			this.collageViewPictureBox.Size = new System.Drawing.Size(900, 923);
			this.collageViewPictureBox.TabIndex = 0;
			this.collageViewPictureBox.TabStop = false;
			// 
			// CollageViewForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(940, 1011);
			this.Controls.Add(this.saveAsButton);
			this.Controls.Add(this.collageViewPictureBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "CollageViewForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "CollageViewForm";
			((System.ComponentModel.ISupportInitialize)(this.collageViewPictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox collageViewPictureBox;
		private System.Windows.Forms.Button saveAsButton;
	}
}