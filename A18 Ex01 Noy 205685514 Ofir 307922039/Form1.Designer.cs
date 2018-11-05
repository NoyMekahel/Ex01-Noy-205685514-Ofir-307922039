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
			this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ImageSmall = new System.Windows.Forms.DataGridViewImageColumn();
			this.aboutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.m_BindingSourceFriendsGrid = new System.Windows.Forms.BindingSource(this.components);
			this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.friendListBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.m_FriensListLabel = new System.Windows.Forms.Label();
			this.m_UserInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.m_UserInfoListBox = new System.Windows.Forms.ListBox();
			this.m_TabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.backButton = new System.Windows.Forms.Button();
			this.fromLocationLabel = new System.Windows.Forms.Label();
			this.eventsComboBox = new System.Windows.Forms.ComboBox();
			this.workPlaceLabel = new System.Windows.Forms.Label();
			this.academicInstitutionLabel = new System.Windows.Forms.Label();
			this.locationsListBox = new System.Windows.Forms.ListBox();
			this.eventButton = new System.Windows.Forms.Button();
			this.workButton = new System.Windows.Forms.Button();
			this.academicInstitutionButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.m_UserProfilePictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.m_FriendsDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.m_BindingSourceFriendsGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.friendListBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.m_UserInfoBindingSource)).BeginInit();
			this.m_TabControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_LoginButton
			// 
			this.m_LoginButton.Location = new System.Drawing.Point(31, 18);
			this.m_LoginButton.Name = "m_LoginButton";
			this.m_LoginButton.Size = new System.Drawing.Size(78, 23);
			this.m_LoginButton.TabIndex = 0;
			this.m_LoginButton.Text = "Login";
			this.m_LoginButton.UseVisualStyleBackColor = true;
			this.m_LoginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// m_UserProfilePictureBox
			// 
			this.m_UserProfilePictureBox.Location = new System.Drawing.Point(28, 51);
			this.m_UserProfilePictureBox.Name = "m_UserProfilePictureBox";
			this.m_UserProfilePictureBox.Size = new System.Drawing.Size(81, 88);
			this.m_UserProfilePictureBox.TabIndex = 1;
			this.m_UserProfilePictureBox.TabStop = false;
			// 
			// m_FindARideButton
			// 
			this.m_FindARideButton.Location = new System.Drawing.Point(490, 185);
			this.m_FindARideButton.Name = "m_FindARideButton";
			this.m_FindARideButton.Size = new System.Drawing.Size(75, 23);
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
			this.m_FriendsDataGridView.Location = new System.Drawing.Point(7, 324);
			this.m_FriendsDataGridView.Margin = new System.Windows.Forms.Padding(2);
			this.m_FriendsDataGridView.Name = "m_FriendsDataGridView";
			this.m_FriendsDataGridView.ReadOnly = true;
			this.m_FriendsDataGridView.RowTemplate.Height = 28;
			this.m_FriendsDataGridView.Size = new System.Drawing.Size(573, 206);
			this.m_FriendsDataGridView.TabIndex = 3;
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
			// m_FriensListLabel
			// 
			this.m_FriensListLabel.AutoSize = true;
			this.m_FriensListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.m_FriensListLabel.Location = new System.Drawing.Point(24, 298);
			this.m_FriensListLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.m_FriensListLabel.Name = "m_FriensListLabel";
			this.m_FriensListLabel.Size = new System.Drawing.Size(116, 24);
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
			this.m_UserInfoListBox.Location = new System.Drawing.Point(268, 18);
			this.m_UserInfoListBox.Margin = new System.Windows.Forms.Padding(2);
			this.m_UserInfoListBox.Name = "m_UserInfoListBox";
			this.m_UserInfoListBox.Size = new System.Drawing.Size(297, 121);
			this.m_UserInfoListBox.TabIndex = 6;
			// 
			// m_TabControl
			// 
			this.m_TabControl.Controls.Add(this.tabPage1);
			this.m_TabControl.Controls.Add(this.tabPage2);
			this.m_TabControl.Location = new System.Drawing.Point(1, 2);
			this.m_TabControl.Name = "m_TabControl";
			this.m_TabControl.SelectedIndex = 0;
			this.m_TabControl.Size = new System.Drawing.Size(590, 561);
			this.m_TabControl.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.m_LoginButton);
			this.tabPage1.Controls.Add(this.m_FriensListLabel);
			this.tabPage1.Controls.Add(this.m_UserInfoListBox);
			this.tabPage1.Controls.Add(this.m_FriendsDataGridView);
			this.tabPage1.Controls.Add(this.m_UserProfilePictureBox);
			this.tabPage1.Controls.Add(this.m_FindARideButton);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(582, 535);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.backButton);
			this.tabPage2.Controls.Add(this.fromLocationLabel);
			this.tabPage2.Controls.Add(this.eventsComboBox);
			this.tabPage2.Controls.Add(this.workPlaceLabel);
			this.tabPage2.Controls.Add(this.academicInstitutionLabel);
			this.tabPage2.Controls.Add(this.locationsListBox);
			this.tabPage2.Controls.Add(this.eventButton);
			this.tabPage2.Controls.Add(this.workButton);
			this.tabPage2.Controls.Add(this.academicInstitutionButton);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(582, 535);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// backButton
			// 
			this.backButton.Location = new System.Drawing.Point(35, 500);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(75, 23);
			this.backButton.TabIndex = 21;
			this.backButton.Text = "<- Back";
			this.backButton.UseVisualStyleBackColor = true;
			// 
			// fromLocationLabel
			// 
			this.fromLocationLabel.AutoSize = true;
			this.fromLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.fromLocationLabel.Location = new System.Drawing.Point(21, 34);
			this.fromLocationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.fromLocationLabel.Name = "fromLocationLabel";
			this.fromLocationLabel.Size = new System.Drawing.Size(45, 20);
			this.fromLocationLabel.TabIndex = 20;
			this.fromLocationLabel.Text = "from:";
			// 
			// eventsComboBox
			// 
			this.eventsComboBox.Enabled = false;
			this.eventsComboBox.FormattingEnabled = true;
			this.eventsComboBox.Location = new System.Drawing.Point(35, 392);
			this.eventsComboBox.Name = "eventsComboBox";
			this.eventsComboBox.Size = new System.Drawing.Size(181, 21);
			this.eventsComboBox.TabIndex = 19;
			this.eventsComboBox.SelectedIndexChanged += new System.EventHandler(this.m_EventsComboBox_SelectedIndexChanged);
			// 
			// workPlaceLabel
			// 
			this.workPlaceLabel.AutoSize = true;
			this.workPlaceLabel.Location = new System.Drawing.Point(230, 339);
			this.workPlaceLabel.Name = "workPlaceLabel";
			this.workPlaceLabel.Size = new System.Drawing.Size(16, 13);
			this.workPlaceLabel.TabIndex = 18;
			this.workPlaceLabel.Text = "...";
			// 
			// academicInstitutionLabel
			// 
			this.academicInstitutionLabel.AutoSize = true;
			this.academicInstitutionLabel.Location = new System.Drawing.Point(230, 310);
			this.academicInstitutionLabel.Name = "academicInstitutionLabel";
			this.academicInstitutionLabel.Size = new System.Drawing.Size(16, 13);
			this.academicInstitutionLabel.TabIndex = 17;
			this.academicInstitutionLabel.Text = "...";
			// 
			// locationsListBox
			// 
			this.locationsListBox.FormattingEnabled = true;
			this.locationsListBox.Location = new System.Drawing.Point(35, 58);
			this.locationsListBox.Name = "locationsListBox";
			this.locationsListBox.Size = new System.Drawing.Size(181, 225);
			this.locationsListBox.TabIndex = 16;
			this.locationsListBox.SelectedIndexChanged += new System.EventHandler(this.m_LocationsListBox_SelectedIndexChanged);
			// 
			// eventButton
			// 
			this.eventButton.Enabled = false;
			this.eventButton.Location = new System.Drawing.Point(35, 363);
			this.eventButton.Name = "eventButton";
			this.eventButton.Size = new System.Drawing.Size(167, 23);
			this.eventButton.TabIndex = 15;
			this.eventButton.Text = "Ride To An Event";
			this.eventButton.UseVisualStyleBackColor = true;
			this.eventButton.Click += new System.EventHandler(this.m_EventButton_Click);
			// 
			// workButton
			// 
			this.workButton.Enabled = false;
			this.workButton.Location = new System.Drawing.Point(35, 334);
			this.workButton.Name = "workButton";
			this.workButton.Size = new System.Drawing.Size(167, 23);
			this.workButton.TabIndex = 14;
			this.workButton.Text = "Ride To Work";
			this.workButton.UseVisualStyleBackColor = true;
			// 
			// academicInstitutionButton
			// 
			this.academicInstitutionButton.Enabled = false;
			this.academicInstitutionButton.Location = new System.Drawing.Point(35, 305);
			this.academicInstitutionButton.Name = "academicInstitutionButton";
			this.academicInstitutionButton.Size = new System.Drawing.Size(167, 23);
			this.academicInstitutionButton.TabIndex = 13;
			this.academicInstitutionButton.Text = "Ride To Academic Institution";
			this.academicInstitutionButton.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(589, 561);
			this.Controls.Add(this.m_TabControl);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.m_UserProfilePictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.m_FriendsDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.m_BindingSourceFriendsGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.friendListBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.m_UserInfoBindingSource)).EndInit();
			this.m_TabControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button m_LoginButton;
		private System.Windows.Forms.PictureBox m_UserProfilePictureBox;
		private System.Windows.Forms.Button m_FindARideButton;
		private System.Windows.Forms.DataGridView m_FriendsDataGridView;
		private System.Windows.Forms.BindingSource friendListBindingSource;
		private System.Windows.Forms.BindingSource m_BindingSourceFriendsGrid;
		private System.Windows.Forms.BindingSource userBindingSource;
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
		private System.Windows.Forms.TabControl m_TabControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label fromLocationLabel;
		private System.Windows.Forms.ComboBox eventsComboBox;
		private System.Windows.Forms.Label workPlaceLabel;
		private System.Windows.Forms.Label academicInstitutionLabel;
		private System.Windows.Forms.ListBox locationsListBox;
		private System.Windows.Forms.Button eventButton;
		private System.Windows.Forms.Button workButton;
		private System.Windows.Forms.Button academicInstitutionButton;
		private System.Windows.Forms.Button backButton;
	}
}

