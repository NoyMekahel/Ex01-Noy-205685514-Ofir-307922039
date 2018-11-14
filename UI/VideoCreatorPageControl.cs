using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace UI
{
	public partial class VideoCreatorPageControl : UserControl, ILogoutable, IBackable
	{
		private FacebookObjectCollection<Photo> m_FilteredPhotosCollection;
		private FacebookObjectCollection<Image> m_SelectedImagesCollection = new FacebookObjectCollection<Image>();
		private string m_VideoURL;

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
				ICollection<string> friendsNamesCollection = DataManagerWrapper.DataManager.GetFriendsNames();

				filterCheckedListBox.Items.Clear();
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
				ICollection<string> albumsNamesCollection = DataManagerWrapper.DataManager.GetAlbumsNames();

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

				m_FilteredPhotosCollection = new FacebookObjectCollection<Photo>();

				foreach (Album album in allAlbums)
				{
					int photoCounter = 1;
					foreach (Photo photo in album.Photos)
					{
						photosCheckedListBox.Items.Add(string.Format("{0} - Picture {1}", album.Name, photoCounter));
						m_FilteredPhotosCollection.Add(photo);
						photoCounter++;
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
				if (filterCheckedListBox.CheckedItems.Count == 0)
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
				if (filterCheckedListBox.CheckedItems.Count == 0)
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

				if (photosCheckedListBox.CheckedItems.Count > 0)
				{
					saveAsButton.Enabled = true;
				}
			}
		}

		public void AddLogoutButton(Button i_LogoutButton)
		{
			Controls.Add(i_LogoutButton);
		}

		private void button_MouseLeave(object sender, EventArgs e)
		{
			Button button = sender as Button;
			button.Cursor = Cursors.Default;
		}

		private void button_MouseEnter(object sender, EventArgs e)
		{
			Button button = sender as Button;
			button.Cursor = Cursors.Hand;
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
				CheckState checkState = i_CheckedListBox.GetItemCheckState(i_CheckedListBox.SelectedIndex) == CheckState.Checked ?
				CheckState.Unchecked : CheckState.Checked;
				i_CheckedListBox.SetItemCheckState(i_CheckedListBox.SelectedIndex, checkState);
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

		private void watchVideoButton_Click(object sender, EventArgs e)
		{
			VideoResultForm videoResultForm = new VideoResultForm(m_VideoURL);
			videoResultForm.ShowDialog();
		}

		private void saveAsButton_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "(*.mp4)|*.mp4";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					createVideoLabel.Text = "creating video...";
					saveAsButton.Enabled = false;
					addSongButton.Enabled = false;
					if (!SongNameLabel.Text.Equals(string.Empty))
					{
						Model.VideoCreator.createVideo(m_SelectedImagesCollection, saveFileDialog.FileName, SongNameLabel.Text);
					}
					else
					{
						Model.VideoCreator.createVideo(m_SelectedImagesCollection, saveFileDialog.FileName);
					}

					saveAsButton.Enabled = true;
					addSongButton.Enabled = true;
					createVideoLabel.Text = "Video created!";
					m_VideoURL = saveFileDialog.FileName;
					watchVideoButton.Visible = true;
				}
				catch(Exception ex)
				{
					FacebookApp.showFacebookError(ex.Message);
				}
			}
		}

		private void photosCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if(photosCheckedListBox.GetItemChecked(photosCheckedListBox.SelectedIndex))
			{
				m_SelectedImagesCollection.Remove(
					m_FilteredPhotosCollection[photosCheckedListBox.SelectedIndex].ImageNormal);
			}
			else
			{
				m_SelectedImagesCollection.Add(
					m_FilteredPhotosCollection[photosCheckedListBox.SelectedIndex].ImageNormal);
			}
		}
	}
}
