namespace A18_Ex01_Noy_205685514_Ofir_307922039
{
	partial class Form1
	{
		private System.ComponentModel.IContainer components = null;

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
			this.components = new System.ComponentModel.Container();
			this.m_LoginButton = new System.Windows.Forms.Button();
			this.m_UserProfilePictureBox = new System.Windows.Forms.PictureBox();
			this.m_FindARideButton = new System.Windows.Forms.Button();
			this.m_FriendsDataGridView = new System.Windows.Forms.DataGridView();
			this.m_BindingSourceFriendsGrid = new System.Windows.Forms.BindingSource(this.components);
			this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.friendListBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ImageSmall = new System.Windows.Forms.DataGridViewImageColumn();
			this.aboutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.m_FriensListLabel = new System.Windows.Forms.Label();
			this.m_UserInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.m_UserInfoListBox = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.m_UserProfilePictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.m_FriendsDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.m_BindingSourceFriendsGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.friendListBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.m_UserInfoBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// m_LoginButton
			// 
			this.m_LoginButton.Location = new System.Drawing.Point(18, 18);
			this.m_LoginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.m_LoginButton.Name = "m_LoginButton";
			this.m_LoginButton.Size = new System.Drawing.Size(117, 35);
			this.m_LoginButton.TabIndex = 0;
			this.m_LoginButton.Text = "Login";
			this.m_LoginButton.UseVisualStyleBackColor = true;
			this.m_LoginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// m_UserProfilePictureBox
			// 
			this.m_UserProfilePictureBox.Location = new System.Drawing.Point(13, 75);
			this.m_UserProfilePictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.m_UserProfilePictureBox.Name = "m_UserProfilePictureBox";
			this.m_UserProfilePictureBox.Size = new System.Drawing.Size(122, 135);
			this.m_UserProfilePictureBox.TabIndex = 1;
			this.m_UserProfilePictureBox.TabStop = false;
			// 
			// m_FindARideButton
			// 
			this.m_FindARideButton.Location = new System.Drawing.Point(701, 392);
			this.m_FindARideButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.m_FindARideButton.Name = "m_FindARideButton";
			this.m_FindARideButton.Size = new System.Drawing.Size(112, 35);
			this.m_FindARideButton.TabIndex = 2;
			this.m_FindARideButton.Text = "Find A Ride";
			this.m_FindARideButton.UseVisualStyleBackColor = true;
			this.m_FindARideButton.Visible = false;
			this.m_FindARideButton.Click += new System.EventHandler(this.m_FindARideButton_Click);
			// 
			// m_FriendsDataGridView
			// 
			this.m_FriendsDataGridView.AllowUserToAddRows = false;
			this.m_FriendsDataGridView.AllowUserToDeleteRows = false;
			this.m_FriendsDataGridView.AllowUserToResizeRows = false;
			this.m_FriendsDataGridView.AutoGenerateColumns = false;
			this.m_FriendsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.m_FriendsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.m_FriendsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.m_FriendsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.ImageSmall,
            this.aboutDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
			this.m_FriendsDataGridView.DataSource = this.m_BindingSourceFriendsGrid;
			this.m_FriendsDataGridView.Location = new System.Drawing.Point(12, 539);
			this.m_FriendsDataGridView.Name = "m_FriendsDataGridView";
			this.m_FriendsDataGridView.ReadOnly = true;
			this.m_FriendsDataGridView.RowTemplate.Height = 28;
			this.m_FriendsDataGridView.Size = new System.Drawing.Size(860, 317);
			this.m_FriendsDataGridView.TabIndex = 3;
			// 
			// m_BindingSourceFriendsGrid
			// 
			this.m_BindingSourceFriendsGrid.DataSource = this.userBindingSource;
			// 
			// userBindingSource
			// 
			this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
			// 
			// friendListBindingSource
			// 
			this.friendListBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.FriendList);
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
			this.ImageSmall.HeaderText = "ImageSmall";
			this.ImageSmall.Name = "ImageSmall";
			this.ImageSmall.ReadOnly = true;
			// 
			// aboutDataGridViewTextBoxColumn
			// 
			this.aboutDataGridViewTextBoxColumn.DataPropertyName = "About";
			this.aboutDataGridViewTextBoxColumn.HeaderText = "About";
			this.aboutDataGridViewTextBoxColumn.Name = "aboutDataGridViewTextBoxColumn";
			this.aboutDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// birthdayDataGridViewTextBoxColumn
			// 
			this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
			this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
			this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
			this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// locationDataGridViewTextBoxColumn
			// 
			this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
			this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
			this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
			this.locationDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			this.emailDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// m_FriensListLabel
			// 
			this.m_FriensListLabel.AutoSize = true;
			this.m_FriensListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.m_FriensListLabel.Location = new System.Drawing.Point(12, 495);
			this.m_FriensListLabel.Name = "m_FriensListLabel";
			this.m_FriensListLabel.Size = new System.Drawing.Size(176, 32);
			this.m_FriensListLabel.TabIndex = 4;
			this.m_FriensListLabel.Text = "Your friends:";
			// 
			// m_UserInfoBindingSource
			// 
			this.m_UserInfoBindingSource.DataSource = this.userBindingSource;
			// 
			// m_UserInfoListBox
			// 
			this.m_UserInfoListBox.DataSource = this.m_UserInfoBindingSource;
			this.m_UserInfoListBox.FormattingEnabled = true;
			this.m_UserInfoListBox.ItemHeight = 20;
			this.m_UserInfoListBox.Location = new System.Drawing.Point(291, 18);
			this.m_UserInfoListBox.Name = "m_UserInfoListBox";
			this.m_UserInfoListBox.Size = new System.Drawing.Size(464, 264);
			this.m_UserInfoListBox.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 868);
			this.Controls.Add(this.m_UserInfoListBox);
			this.Controls.Add(this.m_FriensListLabel);
			this.Controls.Add(this.m_FriendsDataGridView);
			this.Controls.Add(this.m_FindARideButton);
			this.Controls.Add(this.m_UserProfilePictureBox);
			this.Controls.Add(this.m_LoginButton);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.m_UserProfilePictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.m_FriendsDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.m_BindingSourceFriendsGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.friendListBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.m_UserInfoBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button m_LoginButton;
		private System.Windows.Forms.PictureBox m_UserProfilePictureBox;
		private System.Windows.Forms.Button m_FindARideButton;
		private System.Windows.Forms.DataGridView m_FriendsDataGridView;
		private System.Windows.Forms.BindingSource friendListBindingSource;
		private System.Windows.Forms.BindingSource userBindingSource;
		private System.Windows.Forms.BindingSource m_BindingSourceFriendsGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
		private System.Windows.Forms.DataGridViewImageColumn ImageSmall;
		private System.Windows.Forms.DataGridViewTextBoxColumn aboutDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label m_FriensListLabel;
		private System.Windows.Forms.BindingSource m_UserInfoBindingSource;
		private System.Windows.Forms.ListBox m_UserInfoListBox;
	}
}

