using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace UI
{
	public partial class controlAlbum : UserControl
	{
		public controlAlbum()
		{
			InitializeComponent();
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
			catch (Exception)
			{
				FormFacebookApp.showFacebookError();
			}
		}

		private void albumPictureBox_Click(object sender, EventArgs e)
		{
			AlbumPictureBox albumPictureBox = sender as AlbumPictureBox;
			albumsNameLabel.Text = albumPictureBox.Album.Name;
			Controls.Remove(flowLayoutPanelUserAlbums);
			Controls.Add(userAlbumsPhotosFlowLayoutPanel);
			foreach (Photo currentPhoto in albumPictureBox.Album.Photos)
			{
				addSinglePhoto(currentPhoto);
			}
			buttonAlbums.Enabled = true;
			buttonAlbums.Text = "Back to albums";
		}

		private void addSingleAlbum(Album i_Album)
		{
			AlbumPictureBox albumToAdd = new AlbumPictureBox();
			albumToAdd.Album = i_Album;
			//albumToAdd.Image = i_Album.ImageSmall;
			albumToAdd.LoadAsync(i_Album.PictureSmallURL);
			albumToAdd.Size = new Size(140, 90);
			albumToAdd.SizeMode = PictureBoxSizeMode.StretchImage;
			flowLayoutPanelUserAlbums.Controls.Add(albumToAdd);
			albumToAdd.MouseHover += albumPictureBox_MouseHover;
			albumToAdd.MouseLeave += albumPictureBox_MouseLeave;
			albumToAdd.Click += albumPictureBox_Click;
		}

		private void addSinglePhoto(Photo i_Photo)
		{
			PhotoPictureBox photoToAdd = new PhotoPictureBox();
			photoToAdd.Photo = i_Photo;
			// photoToAdd.Image = i_Photo.ImageNormal;
			photoToAdd.LoadAsync(i_Photo.PictureNormalURL);
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
			FormPhotoInfo photoInfo = new FormPhotoInfo(photo);
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

		private void albumsButton_Click(object sender, EventArgs e)
		{
			buttonAlbums.Enabled = false;
			buttonAlbums.Text = "Albums";
			flowLayoutPanelUserAlbums.Controls.Clear();
			flowLayoutPanelUserAlbums.Visible = true;
			albumsNameLabel.Text = string.Empty;
			userAlbumsPhotosFlowLayoutPanel.Controls.Clear();
			showUserAlbums();
			Controls.Remove(userAlbumsPhotosFlowLayoutPanel);
			Controls.Add(flowLayoutPanelUserAlbums);
		}

		private void albumsButton_MouseEnter(object sender, EventArgs e)
		{
			buttonAlbums.Cursor = Cursors.Hand;
		}

		private void albumsButton_MouseLeave(object sender, EventArgs e)
		{
			buttonAlbums.Cursor = Cursors.Default;
		}
	}
}
