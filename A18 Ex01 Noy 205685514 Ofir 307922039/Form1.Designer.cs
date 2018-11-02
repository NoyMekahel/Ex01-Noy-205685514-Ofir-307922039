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
			this.m_FromLocationLabel = new System.Windows.Forms.Label();
			this.m_EventsComboBox = new System.Windows.Forms.ComboBox();
			this.m_WorkPlaceLabel = new System.Windows.Forms.Label();
			this.m_AcademicInstitutionLabel = new System.Windows.Forms.Label();
			this.m_LocationsListBox = new System.Windows.Forms.ListBox();
			this.m_EventButton = new System.Windows.Forms.Button();
			this.m_WorkButton = new System.Windows.Forms.Button();
			this.m_AcademicInstitutionButton = new System.Windows.Forms.Button();
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
			this.m_LoginButton.Location = new System.Drawing.Point(46, 28);
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
			this.m_UserProfilePictureBox.Location = new System.Drawing.Point(42, 78);
			this.m_UserProfilePictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.m_UserProfilePictureBox.Name = "m_UserProfilePictureBox";
			this.m_UserProfilePictureBox.Size = new System.Drawing.Size(122, 135);
			this.m_UserProfilePictureBox.TabIndex = 1;
			this.m_UserProfilePictureBox.TabStop = false;
			// 
			// m_FindARideButton
			// 
			this.m_FindARideButton.Location = new System.Drawing.Point(735, 285);
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
			this.m_FriendsDataGridView.Location = new System.Drawing.Point(10, 498);
			this.m_FriendsDataGridView.Name = "m_FriendsDataGridView";
			this.m_FriendsDataGridView.ReadOnly = true;
			this.m_FriendsDataGridView.RowTemplate.Height = 28;
			this.m_FriendsDataGridView.Size = new System.Drawing.Size(860, 317);
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
			this.m_FriensListLabel.Location = new System.Drawing.Point(36, 458);
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
			this.m_UserInfoListBox.Location = new System.Drawing.Point(402, 28);
			this.m_UserInfoListBox.Name = "m_UserInfoListBox";
			this.m_UserInfoListBox.Size = new System.Drawing.Size(444, 184);
			this.m_UserInfoListBox.TabIndex = 6;
			// 
			// m_TabControl
			// 
			this.m_TabControl.Controls.Add(this.tabPage1);
			this.m_TabControl.Controls.Add(this.tabPage2);
			this.m_TabControl.Location = new System.Drawing.Point(2, 3);
			this.m_TabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.m_TabControl.Name = "m_TabControl";
			this.m_TabControl.SelectedIndex = 0;
			this.m_TabControl.Size = new System.Drawing.Size(885, 863);
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
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage1.Size = new System.Drawing.Size(877, 830);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.m_FromLocationLabel);
			this.tabPage2.Controls.Add(this.m_EventsComboBox);
			this.tabPage2.Controls.Add(this.m_WorkPlaceLabel);
			this.tabPage2.Controls.Add(this.m_AcademicInstitutionLabel);
			this.tabPage2.Controls.Add(this.m_LocationsListBox);
			this.tabPage2.Controls.Add(this.m_EventButton);
			this.tabPage2.Controls.Add(this.m_WorkButton);
			this.tabPage2.Controls.Add(this.m_AcademicInstitutionButton);
			this.tabPage2.Location = new System.Drawing.Point(4, 29);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage2.Size = new System.Drawing.Size(877, 830);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// m_FromLocationLabel
			// 
			this.m_FromLocationLabel.AutoSize = true;
			this.m_FromLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.m_FromLocationLabel.Location = new System.Drawing.Point(32, 52);
			this.m_FromLocationLabel.Name = "m_FromLocationLabel";
			this.m_FromLocationLabel.Size = new System.Drawing.Size(67, 29);
			this.m_FromLocationLabel.TabIndex = 20;
			this.m_FromLocationLabel.Text = "from:";
			// 
			// m_EventsComboBox
			// 
			this.m_EventsComboBox.Enabled = false;
			this.m_EventsComboBox.FormattingEnabled = true;
			this.m_EventsComboBox.Location = new System.Drawing.Point(52, 603);
			this.m_EventsComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.m_EventsComboBox.Name = "m_EventsComboBox";
			this.m_EventsComboBox.Size = new System.Drawing.Size(270, 28);
			this.m_EventsComboBox.TabIndex = 19;
			this.m_EventsComboBox.SelectedIndexChanged += new System.EventHandler(this.m_EventsComboBox_SelectedIndexChanged);
			// 
			// m_WorkPlaceLabel
			// 
			this.m_WorkPlaceLabel.AutoSize = true;
			this.m_WorkPlaceLabel.Location = new System.Drawing.Point(345, 522);
			this.m_WorkPlaceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.m_WorkPlaceLabel.Name = "m_WorkPlaceLabel";
			this.m_WorkPlaceLabel.Size = new System.Drawing.Size(21, 20);
			this.m_WorkPlaceLabel.TabIndex = 18;
			this.m_WorkPlaceLabel.Text = "...";
			// 
			// m_AcademicInstitutionLabel
			// 
			this.m_AcademicInstitutionLabel.AutoSize = true;
			this.m_AcademicInstitutionLabel.Location = new System.Drawing.Point(345, 477);
			this.m_AcademicInstitutionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.m_AcademicInstitutionLabel.Name = "m_AcademicInstitutionLabel";
			this.m_AcademicInstitutionLabel.Size = new System.Drawing.Size(21, 20);
			this.m_AcademicInstitutionLabel.TabIndex = 17;
			this.m_AcademicInstitutionLabel.Text = "...";
			// 
			// m_LocationsListBox
			// 
			this.m_LocationsListBox.FormattingEnabled = true;
			this.m_LocationsListBox.ItemHeight = 20;
			this.m_LocationsListBox.Location = new System.Drawing.Point(52, 89);
			this.m_LocationsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.m_LocationsListBox.Name = "m_LocationsListBox";
			this.m_LocationsListBox.Size = new System.Drawing.Size(270, 344);
			this.m_LocationsListBox.TabIndex = 16;
			this.m_LocationsListBox.SelectedIndexChanged += new System.EventHandler(this.m_LocationsListBox_SelectedIndexChanged);
			// 
			// m_EventButton
			// 
			this.m_EventButton.Enabled = false;
			this.m_EventButton.Location = new System.Drawing.Point(52, 558);
			this.m_EventButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.m_EventButton.Name = "m_EventButton";
			this.m_EventButton.Size = new System.Drawing.Size(250, 35);
			this.m_EventButton.TabIndex = 15;
			this.m_EventButton.Text = "Ride To An Event";
			this.m_EventButton.UseVisualStyleBackColor = true;
			this.m_EventButton.Click += new System.EventHandler(this.m_EventButton_Click);
			// 
			// m_WorkButton
			// 
			this.m_WorkButton.Enabled = false;
			this.m_WorkButton.Location = new System.Drawing.Point(52, 514);
			this.m_WorkButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.m_WorkButton.Name = "m_WorkButton";
			this.m_WorkButton.Size = new System.Drawing.Size(250, 35);
			this.m_WorkButton.TabIndex = 14;
			this.m_WorkButton.Text = "Ride To Work";
			this.m_WorkButton.UseVisualStyleBackColor = true;
			// 
			// m_AcademicInstitutionButton
			// 
			this.m_AcademicInstitutionButton.Enabled = false;
			this.m_AcademicInstitutionButton.Location = new System.Drawing.Point(52, 469);
			this.m_AcademicInstitutionButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.m_AcademicInstitutionButton.Name = "m_AcademicInstitutionButton";
			this.m_AcademicInstitutionButton.Size = new System.Drawing.Size(250, 35);
			this.m_AcademicInstitutionButton.TabIndex = 13;
			this.m_AcademicInstitutionButton.Text = "Ride To Academic Institution";
			this.m_AcademicInstitutionButton.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 863);
			this.Controls.Add(this.m_TabControl);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
		private System.Windows.Forms.TabControl m_TabControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label m_FromLocationLabel;
		private System.Windows.Forms.ComboBox m_EventsComboBox;
		private System.Windows.Forms.Label m_WorkPlaceLabel;
		private System.Windows.Forms.Label m_AcademicInstitutionLabel;
		private System.Windows.Forms.ListBox m_LocationsListBox;
		private System.Windows.Forms.Button m_EventButton;
		private System.Windows.Forms.Button m_WorkButton;
		private System.Windows.Forms.Button m_AcademicInstitutionButton;
	}
}

