using FacebookWrapper.ObjectModel;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
	public class HomePanel : Panel
	{
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.Label friensListLabel;
		private System.Windows.Forms.DataGridView friendsDataGridView;
		private System.Windows.Forms.PictureBox userProfilePictureBox;
		private System.Windows.Forms.Button findARideButton;

		private System.Windows.Forms.BindingSource bindingSourceFriendsGrid;
		private System.Windows.Forms.Label firstNameDataLabel;
		private System.Windows.Forms.Label lastNameDataLabel;
		private System.Windows.Forms.Label emailDataLabel;
		private System.Windows.Forms.Label firstNameLabel;
		private System.Windows.Forms.Label lastNameLabel;
		private System.Windows.Forms.Label emailLabel;
		private System.Windows.Forms.Label birthdayLabel;
		private System.Windows.Forms.Label daysTillBirthdayLabel;
		private System.Windows.Forms.Label birthdayDataLabel;
		private System.Windows.Forms.Label daysTillBirthdayDataLabel;
		private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
		private System.Windows.Forms.DataGridViewImageColumn ImageSmall;
		private System.Windows.Forms.DataGridViewTextBoxColumn locationColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn aboutDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private System.ComponentModel.IContainer components = null;

		public HomePanel()
		{
			InitializeComponent();
		}


		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.loginButton = new System.Windows.Forms.Button();
			this.friensListLabel = new System.Windows.Forms.Label();
			this.friendsDataGridView = new System.Windows.Forms.DataGridView();
			this.locationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userProfilePictureBox = new System.Windows.Forms.PictureBox();
			this.findARideButton = new System.Windows.Forms.Button();
			this.firstNameDataLabel = new System.Windows.Forms.Label();
			this.lastNameDataLabel = new System.Windows.Forms.Label();
			this.emailDataLabel = new System.Windows.Forms.Label();
			this.firstNameLabel = new System.Windows.Forms.Label();
			this.lastNameLabel = new System.Windows.Forms.Label();
			this.emailLabel = new System.Windows.Forms.Label();
			this.birthdayLabel = new System.Windows.Forms.Label();
			this.daysTillBirthdayLabel = new System.Windows.Forms.Label();
			this.birthdayDataLabel = new System.Windows.Forms.Label();
			this.daysTillBirthdayDataLabel = new System.Windows.Forms.Label();
			this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ImageSmall = new System.Windows.Forms.DataGridViewImageColumn();
			this.aboutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSourceFriendsGrid = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.friendsDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userProfilePictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriendsGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(35, 37);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(78, 23);
			this.loginButton.TabIndex = 7;
			this.loginButton.Text = "Login";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// friensListLabel
			// 
			this.friensListLabel.AutoSize = true;
			this.friensListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.friensListLabel.Location = new System.Drawing.Point(11, 376);
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
			this.friendsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.friendsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.friendsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.FirstName,
			this.LastName,
			this.ImageSmall,
			this.locationColumn,
			this.aboutDataGridViewTextBoxColumn,
			this.birthdayDataGridViewTextBoxColumn,
			this.emailDataGridViewTextBoxColumn});
			this.friendsDataGridView.DataSource = this.bindingSourceFriendsGrid;
			this.friendsDataGridView.Location = new System.Drawing.Point(2, 413);
			this.friendsDataGridView.Margin = new System.Windows.Forms.Padding(2);
			this.friendsDataGridView.Name = "friendsDataGridView";
			this.friendsDataGridView.ReadOnly = true;
			this.friendsDataGridView.RowTemplate.Height = 28;
			this.friendsDataGridView.Size = new System.Drawing.Size(596, 215);
			this.friendsDataGridView.TabIndex = 10;
			// 
			// locationColumn
			// 
			this.locationColumn.HeaderText = "Location";
			this.locationColumn.Name = "locationColumn";
			this.locationColumn.ReadOnly = true;
			// 
			// userProfilePictureBox
			// 
			this.userProfilePictureBox.Location = new System.Drawing.Point(393, 37);
			this.userProfilePictureBox.Name = "userProfilePictureBox";
			this.userProfilePictureBox.Size = new System.Drawing.Size(81, 88);
			this.userProfilePictureBox.TabIndex = 8;
			this.userProfilePictureBox.TabStop = false;
			// 
			// findARideButton
			// 
			this.findARideButton.Location = new System.Drawing.Point(38, 207);
			this.findARideButton.Name = "findARideButton";
			this.findARideButton.Size = new System.Drawing.Size(75, 23);
			this.findARideButton.TabIndex = 9;
			this.findARideButton.Text = "Find A Ride";
			this.findARideButton.UseVisualStyleBackColor = true;
			this.findARideButton.Visible = false;
			// 
			// firstNameDataLabel
			// 
			this.firstNameDataLabel.AutoSize = true;
			this.firstNameDataLabel.Location = new System.Drawing.Point(516, 153);
			this.firstNameDataLabel.Name = "firstNameDataLabel";
			this.firstNameDataLabel.Size = new System.Drawing.Size(35, 13);
			this.firstNameDataLabel.TabIndex = 12;
			this.firstNameDataLabel.Text = "label1";
			this.firstNameDataLabel.Visible = false;
			// 
			// lastNameDataLabel
			// 
			this.lastNameDataLabel.AutoSize = true;
			this.lastNameDataLabel.Location = new System.Drawing.Point(516, 176);
			this.lastNameDataLabel.Name = "lastNameDataLabel";
			this.lastNameDataLabel.Size = new System.Drawing.Size(35, 13);
			this.lastNameDataLabel.TabIndex = 13;
			this.lastNameDataLabel.Text = "label2";
			this.lastNameDataLabel.Visible = false;
			// 
			// emailDataLabel
			// 
			this.emailDataLabel.AutoSize = true;
			this.emailDataLabel.Location = new System.Drawing.Point(516, 198);
			this.emailDataLabel.Name = "emailDataLabel";
			this.emailDataLabel.Size = new System.Drawing.Size(35, 13);
			this.emailDataLabel.TabIndex = 14;
			this.emailDataLabel.Text = "label3";
			this.emailDataLabel.Visible = false;
			// 
			// firstNameLabel
			// 
			this.firstNameLabel.AutoSize = true;
			this.firstNameLabel.Location = new System.Drawing.Point(390, 153);
			this.firstNameLabel.Name = "firstNameLabel";
			this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
			this.firstNameLabel.TabIndex = 15;
			this.firstNameLabel.Text = "First Name:";
			this.firstNameLabel.Visible = false;
			// 
			// lastNameLabel
			// 
			this.lastNameLabel.AutoSize = true;
			this.lastNameLabel.Location = new System.Drawing.Point(390, 176);
			this.lastNameLabel.Name = "lastNameLabel";
			this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
			this.lastNameLabel.TabIndex = 16;
			this.lastNameLabel.Text = "Last Name:";
			this.lastNameLabel.Visible = false;
			// 
			// emailLabel
			// 
			this.emailLabel.AutoSize = true;
			this.emailLabel.Location = new System.Drawing.Point(390, 198);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(35, 13);
			this.emailLabel.TabIndex = 17;
			this.emailLabel.Text = "Email:";
			this.emailLabel.Visible = false;
			// 
			// birthdayLabel
			// 
			this.birthdayLabel.AutoSize = true;
			this.birthdayLabel.Location = new System.Drawing.Point(390, 219);
			this.birthdayLabel.Name = "birthdayLabel";
			this.birthdayLabel.Size = new System.Drawing.Size(48, 13);
			this.birthdayLabel.TabIndex = 18;
			this.birthdayLabel.Text = "Birthday:";
			this.birthdayLabel.Visible = false;
			// 
			// daysTillBirthdayLabel
			// 
			this.daysTillBirthdayLabel.AutoSize = true;
			this.daysTillBirthdayLabel.Location = new System.Drawing.Point(390, 241);
			this.daysTillBirthdayLabel.Name = "daysTillBirthdayLabel";
			this.daysTillBirthdayLabel.Size = new System.Drawing.Size(91, 13);
			this.daysTillBirthdayLabel.TabIndex = 19;
			this.daysTillBirthdayLabel.Text = "Days Till Birthday:";
			this.daysTillBirthdayLabel.Visible = false;
			// 
			// birthdayDataLabel
			// 
			this.birthdayDataLabel.AutoSize = true;
			this.birthdayDataLabel.Location = new System.Drawing.Point(516, 219);
			this.birthdayDataLabel.Name = "birthdayDataLabel";
			this.birthdayDataLabel.Size = new System.Drawing.Size(35, 13);
			this.birthdayDataLabel.TabIndex = 20;
			this.birthdayDataLabel.Text = "label9";
			this.birthdayDataLabel.Visible = false;
			// 
			// daysTillBirthdayDataLabel
			// 
			this.daysTillBirthdayDataLabel.AutoSize = true;
			this.daysTillBirthdayDataLabel.Location = new System.Drawing.Point(516, 241);
			this.daysTillBirthdayDataLabel.Name = "daysTillBirthdayDataLabel";
			this.daysTillBirthdayDataLabel.Size = new System.Drawing.Size(41, 13);
			this.daysTillBirthdayDataLabel.TabIndex = 21;
			this.daysTillBirthdayDataLabel.Text = "label10";
			this.daysTillBirthdayDataLabel.Visible = false;
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
			// HomeUI
			// 
			this.ClientSize = new System.Drawing.Size(608, 637);
			this.Controls.Add(this.daysTillBirthdayDataLabel);
			this.Controls.Add(this.birthdayDataLabel);
			this.Controls.Add(this.daysTillBirthdayLabel);
			this.Controls.Add(this.birthdayLabel);
			this.Controls.Add(this.emailLabel);
			this.Controls.Add(this.lastNameLabel);
			this.Controls.Add(this.firstNameLabel);
			this.Controls.Add(this.emailDataLabel);
			this.Controls.Add(this.lastNameDataLabel);
			this.Controls.Add(this.firstNameDataLabel);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.friensListLabel);
			this.Controls.Add(this.friendsDataGridView);
			this.Controls.Add(this.userProfilePictureBox);
			this.Controls.Add(this.findARideButton);
			this.Name = "HomeUI";
			this.Text = "HomeUI";
			((System.ComponentModel.ISupportInitialize)(this.friendsDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userProfilePictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriendsGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			try
			{
				FacebookLogin login = new FacebookLogin();
				DataManagerWrapper.setDataManager(this, login.DataManager);

				fetchUserInfo();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		internal void fetchUserInfo()
		{
			userProfilePictureBox.Load(DataManagerWrapper.DataManager.GetPictureNormalURL());
			findARideButton.Visible = true;
			try
			{
				FacebookObjectCollection<User> allFriends = DataManagerWrapper.DataManager.GetFriends();
				bindingSourceFriendsGrid.DataSource = allFriends;
				int counter = 0;
				foreach(User currentUser in allFriends)
				{
					DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
					cell.Value = currentUser.Location.Name;
					friendsDataGridView.Rows[counter++].Cells[locationColumn.Index] = cell;
				}
			
				showUserInfo();
			}
			catch (Exception)
			{
				FacebookApp.showFacebookError();
			}
		}

		private void showUserInfo()
		{
			visibleAllUserInfoLabels(true);
			firstNameDataLabel.Text = DataManagerWrapper.DataManager.GetFirstName();
			lastNameDataLabel.Text = DataManagerWrapper.DataManager.GetLastName();
			emailDataLabel.Text = DataManagerWrapper.DataManager.GetEmail();
			birthdayDataLabel.Text = DataManagerWrapper.DataManager.GetBirthday();
			string daysTillBirthday = DataManagerWrapper.DataManager.GetDaysTillBirthday().ToString();

			daysTillBirthdayDataLabel.Text = daysTillBirthday.Equals("0") ? "Happy Birthday!" : daysTillBirthday;
		}

		private void visibleAllUserInfoLabels(bool i_IsVisible)
		{
			firstNameLabel.Visible = i_IsVisible;
			lastNameLabel.Visible = i_IsVisible;
			emailLabel.Visible = i_IsVisible;
			birthdayLabel.Visible = i_IsVisible;
			daysTillBirthdayLabel.Visible = i_IsVisible;
			firstNameDataLabel.Visible = i_IsVisible;
			lastNameDataLabel.Visible = i_IsVisible;
			emailDataLabel.Visible = i_IsVisible;
			birthdayDataLabel.Visible = i_IsVisible;
			daysTillBirthdayDataLabel.Visible = i_IsVisible;

		}

		public void findARideButton_AddListener(EventHandler i_EventHandler)
		{
			this.findARideButton.Click += i_EventHandler;
		}

	}
}
