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
	public partial class ControlHomePage : UserControl, ILogoutable
	{
		public ControlHomePage()
		{
			InitializeComponent();
		}

		internal void FindARideButton_AddClickedListener(EventHandler i_EventHandler)
		{
			this.buttonFindARide.Click += i_EventHandler;
		}

		internal void fetchUserInfo()
		{
			try
			{
                controlUserDetails.ShowUserInfo();
                showUserFriends();
			}
			catch (Exception)
			{
				FormFacebookApp.showFacebookError();
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
					dataGridViewFriends.Rows[counter].Cells[locationColumn.Index] = cell;
					counter++;
				}
			}
			catch (Exception)
			{
				FormFacebookApp.showFacebookError();
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
				listViewLikedPages.SmallImageList = allPagesImage;

				foreach (Page currentPage in allLikedPages)
				{
					ListViewItem item = new ListViewItem();
					item.ImageIndex = 0;
					item.SubItems.Add(currentPage.Name);
					item.SubItems.Add(currentPage.LikesCount.ToString());
					listViewLikedPages.Items.Add(item);
				}

				buttonLikedPages.Enabled = false;
				listViewLikedPages.Visible = true;
			}
			catch (Exception)
			{
				FormFacebookApp.showFacebookError("FaceBook error! Couldn't fetch liked pages data");
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
						listViewPosts.Items.Add(item);
					}
				}
				listViewPosts.Columns[messagesColumn.Index].Width = -1;
				buttonPosts.Enabled = false;
				listViewPosts.Visible = true;
			}
			catch (Exception)
			{
				FormFacebookApp.showFacebookError("FaceBook error! Couldn't fetch posts data");
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

		internal void CreateCollageButton_AddClickedListener(EventHandler i_EventHandler)
		{
			this.buttonCreateCollage.Click += i_EventHandler;
		}
	}
}
