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
			this.friendListBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.m_BindingSourceFriendsGrid = new System.Windows.Forms.BindingSource(this.components);
			this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.aboutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pictureSmallURLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.m_UserProfilePictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.m_FriendsDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.friendListBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.m_BindingSourceFriendsGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// m_LoginButton
			// 
			this.m_LoginButton.Location = new System.Drawing.Point(18, 18);
			this.m_LoginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.m_LoginButton.Name = "m_LoginButton";
			this.m_LoginButton.Size = new System.Drawing.Size(112, 35);
			this.m_LoginButton.TabIndex = 0;
			this.m_LoginButton.Text = "Login";
			this.m_LoginButton.UseVisualStyleBackColor = true;
			this.m_LoginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// m_UserProfilePictureBox
			// 
			this.m_UserProfilePictureBox.Location = new System.Drawing.Point(446, 18);
			this.m_UserProfilePictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.m_UserProfilePictureBox.Name = "m_UserProfilePictureBox";
			this.m_UserProfilePictureBox.Size = new System.Drawing.Size(122, 135);
			this.m_UserProfilePictureBox.TabIndex = 1;
			this.m_UserProfilePictureBox.TabStop = false;
			// 
			// m_FindARideButton
			// 
			this.m_FindARideButton.Location = new System.Drawing.Point(18, 205);
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
			this.m_FriendsDataGridView.AutoGenerateColumns = false;
			this.m_FriendsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.m_FriendsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.aboutDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.pictureSmallURLDataGridViewTextBoxColumn});
			this.m_FriendsDataGridView.DataSource = this.m_BindingSourceFriendsGrid;
			this.m_FriendsDataGridView.Location = new System.Drawing.Point(12, 260);
			this.m_FriendsDataGridView.Name = "m_FriendsDataGridView";
			this.m_FriendsDataGridView.RowTemplate.Height = 28;
			this.m_FriendsDataGridView.Size = new System.Drawing.Size(579, 317);
			this.m_FriendsDataGridView.TabIndex = 3;
			// 
			// friendListBindingSource
			// 
			this.friendListBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.FriendList);
			// 
			// userBindingSource
			// 
			this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
			// 
			// m_BindingSourceFriendsGrid
			// 
			this.m_BindingSourceFriendsGrid.DataSource = this.userBindingSource;
			// 
			// userNameDataGridViewTextBoxColumn
			// 
			this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
			this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
			this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
			this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// aboutDataGridViewTextBoxColumn
			// 
			this.aboutDataGridViewTextBoxColumn.DataPropertyName = "About";
			this.aboutDataGridViewTextBoxColumn.HeaderText = "About";
			this.aboutDataGridViewTextBoxColumn.Name = "aboutDataGridViewTextBoxColumn";
			// 
			// birthdayDataGridViewTextBoxColumn
			// 
			this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
			this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
			this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
			this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			this.emailDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// locationDataGridViewTextBoxColumn
			// 
			this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
			this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
			this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
			this.locationDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// pictureSmallURLDataGridViewTextBoxColumn
			// 
			this.pictureSmallURLDataGridViewTextBoxColumn.DataPropertyName = "PictureSmallURL";
			this.pictureSmallURLDataGridViewTextBoxColumn.HeaderText = "PictureSmallURL";
			this.pictureSmallURLDataGridViewTextBoxColumn.Name = "pictureSmallURLDataGridViewTextBoxColumn";
			this.pictureSmallURLDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(603, 589);
			this.Controls.Add(this.m_FriendsDataGridView);
			this.Controls.Add(this.m_FindARideButton);
			this.Controls.Add(this.m_UserProfilePictureBox);
			this.Controls.Add(this.m_LoginButton);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.m_UserProfilePictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.m_FriendsDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.friendListBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.m_BindingSourceFriendsGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button m_LoginButton;
		private System.Windows.Forms.PictureBox m_UserProfilePictureBox;
		private System.Windows.Forms.Button m_FindARideButton;
		private System.Windows.Forms.DataGridView m_FriendsDataGridView;
		private System.Windows.Forms.BindingSource friendListBindingSource;
		private System.Windows.Forms.BindingSource userBindingSource;
		private System.Windows.Forms.BindingSource m_BindingSourceFriendsGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn aboutDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pictureSmallURLDataGridViewTextBoxColumn;
	}
}

