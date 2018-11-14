using System.Drawing;

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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.friensListLabel = new System.Windows.Forms.Label();
			this.friendsDataGridView = new System.Windows.Forms.DataGridView();
			this.locationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
			this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
			this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
			this.findARideButton = new System.Windows.Forms.Button();
			this.likedPagesButton = new System.Windows.Forms.Button();
			this.postsButton = new System.Windows.Forms.Button();
			this.createVideoButton = new System.Windows.Forms.Button();
			this.postsListView = new System.Windows.Forms.ListView();
			this.postDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.messagesColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.likedPagesListView = new System.Windows.Forms.ListView();
			this.ImageColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.pageNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.likesCountColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ImageSmall = new System.Windows.Forms.DataGridViewImageColumn();
			this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.aboutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSourceFriendsGrid = new System.Windows.Forms.BindingSource(this.components);
			this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.albumControl1 = new UI.AlbumControl();
			this.userDetailsControl = new UI.UserDetailsControl();
			((System.ComponentModel.ISupportInitialize)(this.friendsDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriendsGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// friensListLabel
			// 
			this.friensListLabel.AutoSize = true;
			this.friensListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.friensListLabel.Location = new System.Drawing.Point(11, 428);
			this.friensListLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.friensListLabel.Name = "friensListLabel";
			this.friensListLabel.Size = new System.Drawing.Size(176, 32);
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
			this.friendsDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
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
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.friendsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.friendsDataGridView.RowTemplate.Height = 28;
			this.friendsDataGridView.Size = new System.Drawing.Size(626, 164);
			this.friendsDataGridView.TabIndex = 10;
			// 
			// locationColumn
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.locationColumn.DefaultCellStyle = dataGridViewCellStyle7;
			this.locationColumn.HeaderText = "Location";
			this.locationColumn.Name = "locationColumn";
			this.locationColumn.ReadOnly = true;
			// 
			// findARideButton
			// 
			this.findARideButton.BackColor = System.Drawing.Color.Transparent;
			this.findARideButton.BackgroundImage = global::UI.Properties.Resources.orange_button;
			this.findARideButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.findARideButton.FlatAppearance.BorderSize = 0;
			this.findARideButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.findARideButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.findARideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.findARideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.findARideButton.Location = new System.Drawing.Point(393, 15);
			this.findARideButton.Name = "findARideButton";
			this.findARideButton.Size = new System.Drawing.Size(96, 23);
			this.findARideButton.TabIndex = 62;
			this.findARideButton.Text = "Find A Ride";
			this.findARideButton.UseVisualStyleBackColor = false;
			this.findARideButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.findARideButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			// 
			// likedPagesButton
			// 
			this.likedPagesButton.BackColor = System.Drawing.Color.Transparent;
			this.likedPagesButton.BackgroundImage = global::UI.Properties.Resources.orange_button;
			this.likedPagesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.likedPagesButton.FlatAppearance.BorderSize = 0;
			this.likedPagesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.likedPagesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.likedPagesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.likedPagesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.likedPagesButton.Location = new System.Drawing.Point(3, 299);
			this.likedPagesButton.Name = "likedPagesButton";
			this.likedPagesButton.Size = new System.Drawing.Size(96, 23);
			this.likedPagesButton.TabIndex = 61;
			this.likedPagesButton.Text = "Liked Pages";
			this.likedPagesButton.UseVisualStyleBackColor = false;
			this.likedPagesButton.Click += new System.EventHandler(this.likedPagesButton_Click);
			this.likedPagesButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.likedPagesButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			// 
			// postsButton
			// 
			this.postsButton.BackColor = System.Drawing.Color.Transparent;
			this.postsButton.BackgroundImage = global::UI.Properties.Resources.orange_button;
			this.postsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.postsButton.FlatAppearance.BorderSize = 0;
			this.postsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.postsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.postsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.postsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.postsButton.Location = new System.Drawing.Point(264, 299);
			this.postsButton.Name = "postsButton";
			this.postsButton.Size = new System.Drawing.Size(96, 23);
			this.postsButton.TabIndex = 60;
			this.postsButton.Text = "Posts";
			this.postsButton.UseVisualStyleBackColor = false;
			this.postsButton.Click += new System.EventHandler(this.postsButton_Click);
			this.postsButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.postsButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			// 
			// createVideoButton
			// 
			this.createVideoButton.BackColor = System.Drawing.Color.Transparent;
			this.createVideoButton.BackgroundImage = global::UI.Properties.Resources.orange_button;
			this.createVideoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.createVideoButton.FlatAppearance.BorderSize = 0;
			this.createVideoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.createVideoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.createVideoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createVideoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.createVideoButton.Location = new System.Drawing.Point(291, 15);
			this.createVideoButton.Name = "createVideoButton";
			this.createVideoButton.Size = new System.Drawing.Size(96, 23);
			this.createVideoButton.TabIndex = 59;
			this.createVideoButton.Text = "Create Video";
			this.createVideoButton.UseVisualStyleBackColor = false;
			this.createVideoButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.createVideoButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			// 
			// postsListView
			// 
			this.postsListView.BackgroundImage = global::UI.Properties.Resources.facebook_widescreen_navy_background_image;
			this.postsListView.BackgroundImageTiled = true;
			this.postsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.postDateColumn,
            this.messagesColumn});
			this.postsListView.Location = new System.Drawing.Point(264, 328);
			this.postsListView.Name = "postsListView";
			this.postsListView.Size = new System.Drawing.Size(366, 131);
			this.postsListView.TabIndex = 19;
			this.postsListView.UseCompatibleStateImageBehavior = false;
			this.postsListView.View = System.Windows.Forms.View.Details;
			this.postsListView.Visible = false;
			// 
			// postDateColumn
			// 
			this.postDateColumn.Text = "Date";
			this.postDateColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.postDateColumn.Width = 106;
			// 
			// messagesColumn
			// 
			this.messagesColumn.Text = "Message";
			this.messagesColumn.Width = 211;
			// 
			// likedPagesListView
			// 
			this.likedPagesListView.BackgroundImage = global::UI.Properties.Resources.facebook_widescreen_navy_background_image;
			this.likedPagesListView.BackgroundImageTiled = true;
			this.likedPagesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ImageColumnHeader,
            this.pageNameColumnHeader,
            this.likesCountColumnHeader});
			this.likedPagesListView.Location = new System.Drawing.Point(3, 328);
			this.likedPagesListView.Name = "likedPagesListView";
			this.likedPagesListView.Size = new System.Drawing.Size(254, 97);
			this.likedPagesListView.TabIndex = 18;
			this.likedPagesListView.UseCompatibleStateImageBehavior = false;
			this.likedPagesListView.View = System.Windows.Forms.View.Details;
			this.likedPagesListView.Visible = false;
			// 
			// ImageColumnHeader
			// 
			this.ImageColumnHeader.Text = "Page Image";
			this.ImageColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ImageColumnHeader.Width = 77;
			// 
			// pageNameColumnHeader
			// 
			this.pageNameColumnHeader.Text = "Page Name";
			this.pageNameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.pageNameColumnHeader.Width = 78;
			// 
			// likesCountColumnHeader
			// 
			this.likesCountColumnHeader.Text = "Likes";
			this.likesCountColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FirstName
			// 
			this.FirstName.DataPropertyName = "FirstName";
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.FirstName.DefaultCellStyle = dataGridViewCellStyle1;
			this.FirstName.HeaderText = "FirstName";
			this.FirstName.Name = "FirstName";
			this.FirstName.ReadOnly = true;
			// 
			// LastName
			// 
			this.LastName.DataPropertyName = "LastName";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.LastName.DefaultCellStyle = dataGridViewCellStyle2;
			this.LastName.HeaderText = "LastName";
			this.LastName.Name = "LastName";
			this.LastName.ReadOnly = true;
			// 
			// ImageSmall
			// 
			this.ImageSmall.DataPropertyName = "ImageSmall";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.NullValue = null;
			this.ImageSmall.DefaultCellStyle = dataGridViewCellStyle3;
			this.ImageSmall.HeaderText = "Image";
			this.ImageSmall.Name = "ImageSmall";
			this.ImageSmall.ReadOnly = true;
			// 
			// birthdayDataGridViewTextBoxColumn
			// 
			this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.birthdayDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
			this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
			this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
			this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// aboutDataGridViewTextBoxColumn
			// 
			this.aboutDataGridViewTextBoxColumn.DataPropertyName = "About";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.aboutDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
			this.aboutDataGridViewTextBoxColumn.HeaderText = "About";
			this.aboutDataGridViewTextBoxColumn.Name = "aboutDataGridViewTextBoxColumn";
			this.aboutDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.emailDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
			this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			this.emailDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// bindingSourceFriendsGrid
			// 
			this.bindingSourceFriendsGrid.DataSource = typeof(FacebookWrapper.ObjectModel.User);
			// 
			// albumControl1
			// 
			this.albumControl1.Location = new System.Drawing.Point(264, 60);
			this.albumControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.albumControl1.Name = "albumControl1";
			this.albumControl1.Size = new System.Drawing.Size(331, 233);
			this.albumControl1.TabIndex = 21;
			// 
			// userDetailsControl
			// 
			this.userDetailsControl.BackColor = System.Drawing.Color.Transparent;
			this.userDetailsControl.Location = new System.Drawing.Point(4, 22);
			this.userDetailsControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.userDetailsControl.Name = "userDetailsControl";
			this.userDetailsControl.Size = new System.Drawing.Size(253, 269);
			this.userDetailsControl.TabIndex = 12;
			// 
			// HomePageControl
			// 
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.findARideButton);
			this.Controls.Add(this.likedPagesButton);
			this.Controls.Add(this.postsButton);
			this.Controls.Add(this.createVideoButton);
			this.Controls.Add(this.albumControl1);
			this.Controls.Add(this.postsListView);
			this.Controls.Add(this.likedPagesListView);
			this.Controls.Add(this.userDetailsControl);
			this.Controls.Add(this.friensListLabel);
			this.Controls.Add(this.friendsDataGridView);
			this.Name = "HomePageControl";
			this.Size = new System.Drawing.Size(630, 637);
			((System.ComponentModel.ISupportInitialize)(this.friendsDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriendsGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}


		private System.Windows.Forms.Label friensListLabel;
		private System.Windows.Forms.DataGridView friendsDataGridView;
		private System.Windows.Forms.BindingSource bindingSourceFriendsGrid;
		#endregion

		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.ComponentModel.BackgroundWorker backgroundWorker2;
		private System.ComponentModel.BackgroundWorker backgroundWorker3;
		private System.ComponentModel.BackgroundWorker backgroundWorker4;
		private UserDetailsControl userDetailsControl;
		private System.Windows.Forms.ColumnHeader pageNameColumnHeader;
		private System.Windows.Forms.ColumnHeader likesCountColumnHeader;
		private System.Windows.Forms.ColumnHeader ImageColumnHeader;
		private System.Windows.Forms.ListView likedPagesListView;
		private System.Windows.Forms.ListView postsListView;
		private System.Windows.Forms.ColumnHeader postDateColumn;
		private System.Windows.Forms.BindingSource postsBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
		private System.Windows.Forms.DataGridViewImageColumn ImageSmall;
		private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn locationColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn aboutDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private System.Windows.Forms.ColumnHeader messagesColumn;
		private AlbumControl albumControl1;
		private System.Windows.Forms.Button createVideoButton;
		private System.Windows.Forms.Button postsButton;
		private System.Windows.Forms.Button likedPagesButton;
		private System.Windows.Forms.Button findARideButton;
	}
}
