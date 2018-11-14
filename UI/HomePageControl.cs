using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using FacebookWrapper.ObjectModel;

namespace UI
{
	public partial class HomePageControl : UserControl, ILogoutable
	{
		public HomePageControl()
		{
			InitializeComponent();
		}

		internal void FindARideButton_AddClickedListener(EventHandler i_EventHandler)
		{
			this.findARideButton.Click += i_EventHandler;
		}

		internal void fetchUserInfo()
		{
			try
			{
                userDetailsControl.ShowUserInfo();
                showUserFriends();
			}
			catch (Exception)
			{
				FacebookApp.showFacebookError();
			}
		}

		private void showUserFriends()
        {
			try
			{
				FacebookObjectCollection<User> allFriends = DataManagerWrapper.DataManager.GetFriends();
				bindingSourceFriendsGrid.DataSource = allFriends;
				int counter = 0;
				foreach (User currentUser in allFriends)
				{
					DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
					cell.Value = currentUser.Location.Name;
					friendsDataGridView.Rows[counter].Cells[locationColumn.Index] = cell;
					counter++;
				}
			}
			catch (Exception)
			{
				FacebookApp.showFacebookError();
			}
		}

        public void AddLogoutButton(Button i_LogoutButton)
		{
			Controls.Add(i_LogoutButton);
		}

		private void likedPagesButton_Click(object sender, EventArgs e)
		{
			showUserLikedPages();
		}

		private void showUserLikedPages()
		{
			try
			{
				FacebookObjectCollection<Page> allLikedPages = DataManagerWrapper.DataManager.GetUserLikedPages();
				ImageList allPagesImage = getAllPagesImage(allLikedPages);
				likedPagesListView.SmallImageList = allPagesImage;

				foreach (Page currentPage in allLikedPages)
				{
					ListViewItem item = new ListViewItem();
					item.ImageIndex = 0;
					item.SubItems.Add(currentPage.Name);
					item.SubItems.Add(currentPage.LikesCount.ToString());
					likedPagesListView.Items.Add(item);
				}

				likedPagesButton.Enabled = false;
				likedPagesListView.Visible = true;
			}
			catch (Exception)
			{
				FacebookApp.showFacebookError("FaceBook error! Couldn't fetch liked pages data");
			}
		}

		private ImageList getAllPagesImage(FacebookObjectCollection<Page> i_AllLikedPages)
		{
			ImageList allPagesImage = new ImageList();

			foreach (Page currentPage in i_AllLikedPages)
			{
				allPagesImage.Images.Add(currentPage.ImageSmall);
			}

			return allPagesImage;
		}

		private void postsButton_Click(object sender, EventArgs e)
		{
			showUserPosts();
		}

		private void showUserPosts()
		{
			try
			{
				FacebookObjectCollection<Post> allPosts = DataManagerWrapper.DataManager.GetUserPosts();

				foreach (Post currentPost in allPosts)
				{
					if (currentPost.Message != null)
					{
						ListViewItem item = new ListViewItem();
						item.Text = currentPost.CreatedTime.ToString();
						item.SubItems.Add(currentPost.Message);
						postsListView.Items.Add(item);
					}
				}

				postsListView.Columns[messagesColumn.Index].Width = -1;
				postsButton.Enabled = false;
				postsListView.Visible = true;
			}
			catch (Exception)
			{
				FacebookApp.showFacebookError("FaceBook error! Couldn't fetch posts data");
			}
		}

		private void button_MouseEnter(object sender, EventArgs e)
		{
			Button button = sender as Button;
			button.Cursor = Cursors.Hand;
		}

		private void button_MouseLeave(object sender, EventArgs e)
		{
			Button button = sender as Button;
			button.Cursor = Cursors.Default;
		}

		internal void CreateVideoButton_AddClickedListener(EventHandler i_EventHandler)
		{
			this.createVideoButton.Click += i_EventHandler;
		}
	}
}
