namespace UI
{
	partial class FormCollageView
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
			this.buttonSaveAs = new System.Windows.Forms.Button();
			this.pictureBoxCollageView = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCollageView)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonSaveAs
			// 
			this.buttonSaveAs.BackColor = System.Drawing.Color.Transparent;
			this.buttonSaveAs.BackgroundImage = global::UI.Properties.Resources.orange_button;
			this.buttonSaveAs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonSaveAs.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonSaveAs.FlatAppearance.BorderSize = 0;
			this.buttonSaveAs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonSaveAs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonSaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSaveAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.buttonSaveAs.Location = new System.Drawing.Point(758, 957);
			this.buttonSaveAs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonSaveAs.Name = "buttonSaveAs";
			this.buttonSaveAs.Size = new System.Drawing.Size(162, 35);
			this.buttonSaveAs.TabIndex = 60;
			this.buttonSaveAs.Text = "Save As";
			this.buttonSaveAs.UseVisualStyleBackColor = false;
			this.buttonSaveAs.Click += new System.EventHandler(this.saveAsButton_Click);
			// 
			// pictureBoxCollageView
			// 
			this.pictureBoxCollageView.Location = new System.Drawing.Point(20, 20);
			this.pictureBoxCollageView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBoxCollageView.Name = "pictureBoxCollageView";
			this.pictureBoxCollageView.Size = new System.Drawing.Size(900, 923);
			this.pictureBoxCollageView.TabIndex = 0;
			this.pictureBoxCollageView.TabStop = false;
			// 
			// FormCollageView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(940, 1011);
			this.Controls.Add(this.buttonSaveAs);
			this.Controls.Add(this.pictureBoxCollageView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FormCollageView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "CollageViewForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCollageView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxCollageView;
		private System.Windows.Forms.Button buttonSaveAs;
	}
}