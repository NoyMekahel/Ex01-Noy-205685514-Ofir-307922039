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

        private void addSingleAlbum(Album i_Album)
        {
            
            AlbumPictureBox albumToAdd = new AlbumPictureBox();
            albumToAdd.Album = i_Album;
            albumToAdd.Image = i_Album.ImageSmall;
            albumToAdd.Size = new Size(140, 90);
            albumToAdd.SizeMode = PictureBoxSizeMode.CenterImage;
            userAlbumsFlowLayoutPanel.Controls.Add(albumToAdd);
            albumToAdd.MouseHover += albumPictureBox_MouseHover;
            albumToAdd.MouseLeave += albumPictureBox_MouseLeave;
            albumToAdd.Click += albumPictureBox_Click;
        }

        private void albumPictureBox_Click(object sender, EventArgs e)
        {
            albumsButton.Enabled = true;
            AlbumPictureBox albumPictureBox = sender as AlbumPictureBox;
            albumsNameLabel.Text = albumPictureBox.Album.Name;
            Controls.Remove(userAlbumsFlowLayoutPanel);
            Controls.Add(userAlbumsPhotosFlowLayoutPanel);
            foreach (Photo currentPhoto in albumPictureBox.Album.Photos)
            {
                addSinglePhoto(currentPhoto);
            }

        }

        private void addSinglePhoto(Photo i_Photo)
        {
            PictureBox photoToAdd = new PictureBox();
            photoToAdd.Image = i_Photo.ImageNormal;
            photoToAdd.Size = new Size(95, 80);
            photoToAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            userAlbumsPhotosFlowLayoutPanel.Controls.Add(photoToAdd);
        }

        private void albumPictureBox_MouseLeave(object sender, EventArgs e)
        {
            AlbumPictureBox albumPictureBox = sender as AlbumPictureBox;
            albumPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            albumPictureBox.Cursor = Cursors.Default;
            //  Graphics.Clear(Color.White);
            albumPictureBox.Invalidate();

            using (Graphics G = Graphics.FromImage(albumPictureBox.Image))
            {
            }
        }

        private void albumPictureBox_MouseHover(object sender, EventArgs e)
        {
            AlbumPictureBox albumPictureBox = sender as AlbumPictureBox;
            albumPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            albumPictureBox.Cursor = Cursors.Hand;
            using (Graphics G = Graphics.FromImage(albumPictureBox.Image))
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

        public void AddLogoutButton(Button i_LogoutButton)
		{
			Controls.Add(i_LogoutButton);
		}

        private void albumsButton_Click(object sender, EventArgs e)
        {
            albumsButton.Enabled = false;
            albumsNameLabel.Text = string.Empty;
            userAlbumsPhotosFlowLayoutPanel.Controls.Clear();
            showUserAlbums();
            Controls.Remove(userAlbumsPhotosFlowLayoutPanel);
            Controls.Add(userAlbumsFlowLayoutPanel);

        }
    }
}
