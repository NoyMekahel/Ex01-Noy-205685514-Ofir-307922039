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
                showUserAlbums();
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

        private void addSingleAlbum(Album currentAlbum)
        {
            
            AlbumPictureBox albumToAdd = new AlbumPictureBox();
            albumToAdd.Album = currentAlbum;
            albumToAdd.Image = currentAlbum.ImageSmall;
            albumToAdd.SizeMode = PictureBoxSizeMode.CenterImage;
            albumToAdd.Size = new Size(140, 90);
            userAlbumsFlowLayoutPanel.Controls.Add(albumToAdd);
            albumToAdd.MouseHover += albumPictureBox_MouseHover;
            albumToAdd.MouseLeave += albumPictureBox_MouseLeave;
            albumToAdd.Click += albumPictureBox_Click;
        }

        private void albumPictureBox_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
	}
}
