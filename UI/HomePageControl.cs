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
using System.Drawing.Drawing2D;

namespace UI
{
	public partial class HomePageControl : UserControl, ILogoutable
	{
		public HomePageControl()
		{
			InitializeComponent();
		}

		public void findARideButton_AddClickedListener(EventHandler i_EventHandler)
		{
			this.findARideButton.Click += i_EventHandler;
		}

		internal void fetchUserInfo()
		{
			findARideButton.Visible = true;
			try
			{
                showUserFriends();
                userDetailsControl.ShowUserInfo();
				userDetailsControl.Visible = true;
			}
			catch (Exception)
			{
				FacebookApp.showFacebookError();
			}
		}

        private void showUserAlbums()
        {
            try
            {
                FacebookObjectCollection<Album> allAlbums = DataManagerWrapper.DataManager.GetAlbums();

                foreach (Album currentAlbum in allAlbums)
                {
                    addSingleAlbum(currentAlbum);
                }
            }
            catch(Exception)
            {
                FacebookApp.showFacebookError();
            }
        }

        private void albumPictureBox_Click(object sender, EventArgs e)
        {
            albumsButton.Enabled = true;
			albumsButton.Text = "Back to albums";
			AlbumPictureBox albumPictureBox = sender as AlbumPictureBox;
            albumsNameLabel.Text = albumPictureBox.Album.Name;
            Controls.Remove(userAlbumsFlowLayoutPanel);
            Controls.Add(userAlbumsPhotosFlowLayoutPanel);
            foreach (Photo currentPhoto in albumPictureBox.Album.Photos)
            {
                addSinglePhoto(currentPhoto);
            }
        }

		private void addSingleAlbum(Album i_Album)
		{
			AlbumPictureBox albumToAdd = new AlbumPictureBox();
			albumToAdd.Album = i_Album;
			albumToAdd.Image = i_Album.ImageSmall;
			albumToAdd.Size = new Size(140, 90);
			albumToAdd.SizeMode = PictureBoxSizeMode.StretchImage;
			userAlbumsFlowLayoutPanel.Controls.Add(albumToAdd);
			albumToAdd.MouseHover += albumPictureBox_MouseHover;
			albumToAdd.MouseLeave += albumPictureBox_MouseLeave;
			albumToAdd.Click += albumPictureBox_Click;
		}

		private void addSinglePhoto(Photo i_Photo)
        {
            PhotoPictureBox photoToAdd = new PhotoPictureBox();
			photoToAdd.Photo = i_Photo;
            photoToAdd.Image = i_Photo.ImageNormal;
            photoToAdd.Size = new Size(95, 80);
            photoToAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            userAlbumsPhotosFlowLayoutPanel.Controls.Add(photoToAdd);
			photoToAdd.Click += photoPictureBox_Click;
			photoToAdd.MouseHover += photoPictureBox_MouseHover;
			photoToAdd.MouseLeave += photoPictureBox_MouseLeave;
		}

		private void photoPictureBox_MouseLeave(object sender, EventArgs e)
		{
			PhotoPictureBox photoPictureBox = sender as PhotoPictureBox;
			photoPictureBox.Cursor = Cursors.Default;
			photoPictureBox.BorderStyle = BorderStyle.None;
		}

		private void photoPictureBox_MouseHover(object sender, EventArgs e)
		{
			PhotoPictureBox photoPictureBox = sender as PhotoPictureBox;
			photoPictureBox.Cursor = Cursors.Hand;
			photoPictureBox.BorderStyle = BorderStyle.Fixed3D;
		}

		private void photoPictureBox_Click(object sender, EventArgs e)
		{
			PhotoPictureBox photo = sender as PhotoPictureBox;
			PhotoInfo photoInfo = new PhotoInfo(photo);
			photoInfo.ShowDialog();
		}

		private void albumPictureBox_MouseLeave(object sender, EventArgs e)
        {
            AlbumPictureBox albumPictureBox = sender as AlbumPictureBox;
			albumPictureBox.BorderStyle = BorderStyle.None;
			albumPictureBox.Cursor = Cursors.Default;
            albumPictureBox.Invalidate();
        }
		
		private void albumPictureBox_MouseHover(object sender, EventArgs e)
		{
			AlbumPictureBox albumPictureBox = sender as AlbumPictureBox;
			albumPictureBox.BorderStyle = BorderStyle.Fixed3D;
			albumPictureBox.Cursor = Cursors.Hand;
			using (Graphics G = Graphics.FromHwnd(albumPictureBox.Handle))
			{
				PointF locationToDraw = new PointF();
				SizeF textSize = G.MeasureString(albumPictureBox.Album.Name, Font);

				locationToDraw.X = (albumPictureBox.Width / 2) - (textSize.Width / 2);
				locationToDraw.Y = (albumPictureBox.Height / 2) - (textSize.Height / 2);
				G.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
				G.DrawString(albumPictureBox.Album.Name, new Font(Font, FontStyle.Bold), Brushes.White, locationToDraw);
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

        private void albumsButton_Click(object sender, EventArgs e)
        {
            albumsButton.Enabled = false;
			albumsButton.Text = "Albums";
			userAlbumsFlowLayoutPanel.Controls.Clear();
			userAlbumsFlowLayoutPanel.Visible = true;
            albumsNameLabel.Text = string.Empty;
            userAlbumsPhotosFlowLayoutPanel.Controls.Clear();
            showUserAlbums();
            Controls.Remove(userAlbumsPhotosFlowLayoutPanel);
            Controls.Add(userAlbumsFlowLayoutPanel);
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
					ListViewItem item = new ListViewItem();
					item.SubItems.Add(currentPost.CreatedTime.ToString());
					item.SubItems.Add(currentPost.Description.ToString());
					likedPagesListView.Items.Add(item);
				}

				postsButton.Enabled = false;
				postsListView.Visible = true;
			}
			catch (Exception)
			{
				FacebookApp.showFacebookError("FaceBook error! Couldn't fetch posts data");
			}

		}
	}
}
