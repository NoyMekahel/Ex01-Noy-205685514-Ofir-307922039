namespace UI
{
	partial class HomePageControl
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
			this.friensListLabel = new System.Windows.Forms.Label();
			this.friendsDataGridView = new System.Windows.Forms.DataGridView();
			this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ImageSmall = new System.Windows.Forms.DataGridViewImageColumn();
			this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.locationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.aboutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSourceFriendsGrid = new System.Windows.Forms.BindingSource(this.components);
			this.findARideButton = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
			this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
			this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
			this.userDetailsControl = new UI.UserDetailsControl();
			((System.ComponentModel.ISupportInitialize)(this.friendsDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriendsGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// friensListLabel
			// 
			this.friensListLabel.AutoSize = true;
			this.friensListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.friensListLabel.Location = new System.Drawing.Point(11, 428);
			this.friensListLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.friensListLabel.Name = "friensListLabel";
			this.friensListLabel.Size = new System.Drawing.Size(116, 24);
			this.friensListLabel.TabIndex = 11;
			this.friensListLabel.Text = "Your friends:";
			// 
			// friendsDataGridView
			// 
			this.friendsDataGridView.AllowUserToAddRows = false;
			this.friendsDataGridView.AllowUserToDeleteRows = false;
			this.friendsDataGridView.AllowUserToResizeRows = false;
			this.friendsDataGridView.AutoGenerateColumns = false;
			this.friendsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.friendsDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.friendsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.friendsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.friendsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.ImageSmall,
            this.birthdayDataGridViewTextBoxColumn,
            this.aboutDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.locationColumn});
			this.friendsDataGridView.DataSource = this.bindingSourceFriendsGrid;
			this.friendsDataGridView.Location = new System.Drawing.Point(2, 464);
			this.friendsDataGridView.Margin = new System.Windows.Forms.Padding(2);
			this.friendsDataGridView.Name = "friendsDataGridView";
			this.friendsDataGridView.ReadOnly = true;
			this.friendsDataGridView.RowTemplate.Height = 28;
			this.friendsDataGridView.Size = new System.Drawing.Size(596, 164);
			this.friendsDataGridView.TabIndex = 10;
			// 
			// FirstName
			// 
			this.FirstName.DataPropertyName = "FirstName";
			this.FirstName.HeaderText = "FirstName";
			this.FirstName.Name = "FirstName";
			this.FirstName.ReadOnly = true;
			// 
			// LastName
			// 
			this.LastName.DataPropertyName = "LastName";
			this.LastName.HeaderText = "LastName";
			this.LastName.Name = "LastName";
			this.LastName.ReadOnly = true;
			// 
			// ImageSmall
			// 
			this.ImageSmall.DataPropertyName = "ImageSmall";
			this.ImageSmall.HeaderText = "Image";
			this.ImageSmall.Name = "ImageSmall";
			this.ImageSmall.ReadOnly = true;
			// 
			// birthdayDataGridViewTextBoxColumn
			// 
			this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
			this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
			this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
			this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// locationColumn
			// 
			this.locationColumn.HeaderText = "Location";
			this.locationColumn.Name = "locationColumn";
			this.locationColumn.ReadOnly = true;
			// 
			// aboutDataGridViewTextBoxColumn
			// 
			this.aboutDataGridViewTextBoxColumn.DataPropertyName = "About";
			this.aboutDataGridViewTextBoxColumn.HeaderText = "About";
			this.aboutDataGridViewTextBoxColumn.Name = "aboutDataGridViewTextBoxColumn";
			this.aboutDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			this.emailDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// bindingSourceFriendsGrid
			// 
			this.bindingSourceFriendsGrid.DataSource = typeof(FacebookWrapper.ObjectModel.User);
			// 
			// findARideButton
			// 
			this.findARideButton.Location = new System.Drawing.Point(43, 298);
			this.findARideButton.Name = "findARideButton";
			this.findARideButton.Size = new System.Drawing.Size(75, 23);
			this.findARideButton.TabIndex = 9;
			this.findARideButton.Text = "Find A Ride";
			this.findARideButton.UseVisualStyleBackColor = true;
			this.findARideButton.Visible = false;
			// 
			// userDetailsControl
			// 
			this.userDetailsControl.BackColor = System.Drawing.Color.Transparent;
			this.userDetailsControl.Location = new System.Drawing.Point(26, 29);
			this.userDetailsControl.Name = "userDetailsControl";
			this.userDetailsControl.Size = new System.Drawing.Size(231, 240);
			this.userDetailsControl.TabIndex = 12;
			this.userDetailsControl.Visible = false;
			// 
			// HomePageControl
			// 
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.userDetailsControl);
			this.Controls.Add(this.friensListLabel);
			this.Controls.Add(this.friendsDataGridView);
			this.Controls.Add(this.findARideButton);
			this.Name = "HomePageControl";
			this.Size = new System.Drawing.Size(608, 637);
			((System.ComponentModel.ISupportInitialize)(this.friendsDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriendsGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}


		private System.Windows.Forms.Label friensListLabel;
		private System.Windows.Forms.DataGridView friendsDataGridView;
		private System.Windows.Forms.Button findARideButton;
		private System.Windows.Forms.BindingSource bindingSourceFriendsGrid;
		#endregion

		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.ComponentModel.BackgroundWorker backgroundWorker2;
		private System.ComponentModel.BackgroundWorker backgroundWorker3;
		private System.ComponentModel.BackgroundWorker backgroundWorker4;
		private UserDetailsControl userDetailsControl;
		private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
		private System.Windows.Forms.DataGridViewImageColumn ImageSmall;
		private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn locationColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn aboutDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
	}
}
