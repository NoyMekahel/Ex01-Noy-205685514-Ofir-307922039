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
	public partial class VideoCreatorPageControl : UserControl, ILogoutable, IBackable
	{
		FacebookObjectCollection<Photo> m_FilteredPhotosCollection;

		public VideoCreatorPageControl()
		{
			InitializeComponent();
		}

		public void AddBackButton(Button i_BackButton)
		{
			Controls.Add(i_BackButton);
		}

		private void sharedPhotosRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			if(sharedPhotosRadioButton.Checked == true)
			{
				createFriendsCheckListBox();
				filterCheckedListBox.Visible = true;
			}
		}

		private void albumsPhotosRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			if (albumsPhotosRadioButton.Checked == true)
			{
				createAlbumsCheckListBox();
				filterCheckedListBox.Visible = true;
			}
		}

		private void allPhotosRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			if (allPhotosRadioButton.Checked == true)
			{
				filterCheckedListBox.Visible = false;
			}
		}

		private void createFriendsCheckListBox()
		{
			try
			{
				filterCheckedListBox.Items.Clear();
				ICollection<string>  friendsNamesCollection = DataManagerWrapper.DataManager.GetFriendsNames();

				foreach (string name in friendsNamesCollection)
				{
					filterCheckedListBox.Items.Add(name);
				}
			}
			catch (Exception)
			{
				FacebookApp.showFacebookError("Couldn't fetch your friends names data.");
			}
		}

		private void createAlbumsCheckListBox()
		{
			try
			{
				filterCheckedListBox.Items.Clear();
				ICollection<string>  albumsNamesCollection = DataManagerWrapper.DataManager.GetAlbumsNames();

				foreach (string name in albumsNamesCollection)
				{
					filterCheckedListBox.Items.Add(name);
				}
			}
			catch (Exception)
			{
				FacebookApp.showFacebookError("Couldn't fetch your albums names data.");
			}
		}

		private void createVideoButton_Click(object sender, EventArgs e)
		{
		}

		private void setSelectedAlbumsPhotosOnListBox()
		{
			try
			{
				ICollection<string> selectedAlbums = filterCheckedListBox.CheckedItems.Cast<string>().ToList();
				m_FilteredPhotosCollection = DataManagerWrapper.DataManager.GetAlbumsPhotos(selectedAlbums);
				populatePhotosCheckedListBox();
			}

			catch(Exception)
			{
				FacebookApp.showFacebookError("Couldn't fetch albums photos data.");
			}
		}

		private void populatePhotosCheckedListBox()
		{
			int photoCounter = 1;

			foreach (Photo photo in m_FilteredPhotosCollection)
			{
				photosCheckedListBox.Items.Add(string.Format("Picture {0}", photoCounter));
				photoCounter++;
			}
		}

		private void setSharedPhotosOnListBox()
		{
			try
			{
				ICollection<string> selectedFriends = filterCheckedListBox.CheckedItems.Cast<string>().ToList();
				m_FilteredPhotosCollection = DataManagerWrapper.DataManager.GetSharedFriendsPhotos(selectedFriends);
				populatePhotosCheckedListBox();

			}
			catch (Exception)
			{
				FacebookApp.showFacebookError("Couldn't fetch friends shared photos data.");
			}
		}

		private void setAllPhotosOnListBox()
		{
			try
			{
				FacebookObjectCollection<Album> allAlbums = DataManagerWrapper.DataManager.GetAlbums();
				int photoCounter = 1;

				m_FilteredPhotosCollection = new FacebookObjectCollection<Photo>();
				foreach (Album album in allAlbums)
				{
					foreach (Photo photo in album.Photos)
					{
						photosCheckedListBox.Items.Add(string.Format("Picture {0}", photoCounter));
						m_FilteredPhotosCollection.Add(photo);
					}
				}
			}
			catch (Exception)
			{
				FacebookApp.showFacebookError("Couldn't fetch albums data.");
			}

		}

		private void selectPhotosButton_Click(object sender, EventArgs e)
		{
			photosCheckedListBox.Items.Clear();

			if (allPhotosRadioButton.Checked == true)
			{
				setAllPhotosOnListBox();
			}
			else if (sharedPhotosRadioButton.Checked == true)
			{
				if (filterCheckedListBox.SelectedItems.Count == 0)
				{
					MessageBox.Show("Error! You didn't selected any friends.");
				}
				else
				{
					setSharedPhotosOnListBox();
				}
			}
			else
			{
				if (filterCheckedListBox.SelectedItems.Count == 0)
				{
					MessageBox.Show("Error! You didn't selected any album.");
				}
				else
				{
					setSelectedAlbumsPhotosOnListBox();
				}
			}

			photosCheckedListBox.Visible = true;
			imagePictureBox.Visible = true;
		}

		private void photosCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (photosCheckedListBox.SelectedItem != null)
			{
				imagePictureBox.LoadAsync(m_FilteredPhotosCollection[photosCheckedListBox.SelectedIndex].PictureNormalURL);
				imagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

				if (photosCheckedListBox.Items.Count != 0)
				{
					createVideoButton.Enabled = true;
				}
			}
		}

		public void AddLogoutButton(Button i_LogoutButton)
		{
			Controls.Add(i_LogoutButton);
		}


		private void checkedListBox_Click(object sender, EventArgs e)
		{
			changeItemCheckedStatus(sender as CheckedListBox);
		}

		private void checkedListBox_MouseClick(object sender, MouseEventArgs e)
		{
			changeItemCheckedStatus(sender as CheckedListBox);
		}

		private void changeItemCheckedStatus(CheckedListBox i_CheckedListBox)
		{
			if (i_CheckedListBox.SelectedItem != null)
			{
				i_CheckedListBox.SetItemCheckState(i_CheckedListBox.SelectedIndex,
				i_CheckedListBox.GetItemCheckState(i_CheckedListBox.SelectedIndex) == CheckState.Checked ?
				CheckState.Unchecked : CheckState.Checked);
			}
		}

		private void addSongButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "(*.mp3)|*.mp3";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				SongNameLabel.Text = openFileDialog.FileName;
				SongNameLabel.Visible = true;
				SongNameLabel.AutoSize = true;
			}
		}
	}
}
