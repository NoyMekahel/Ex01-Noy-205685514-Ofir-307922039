using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using System.IO;
using static Model.CollageData;
using Model;

namespace UI
{
	public partial class CollagePageControl : UserControl, ILogoutable, IBackable
	{
		private const int k_UserChoiceOffset = 3;
		private FacebookObjectCollection<Photo> m_FilteredPhotosCollection;
		private FacebookObjectCollection<Image> m_SelectedImagesCollection = new FacebookObjectCollection<Image>();
		private eFrameCollage m_FrameUserChoice;
		private ICollection<CollageBase> m_AllCollagesCollection;

		public CollagePageControl()
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
				int nodeCouner = 0;
				foreach (Album album in allAlbums)
				{
					int photoCounter = 1;
					foreach (Photo photo in album.Photos)
					{
						photosCheckedListBox.Items.Add(string.Format("{0} - Picture {1}", album.Name, photoCounter));
						m_FilteredPhotosCollection.Add(photo);
						photoCounter++;
					}
					nodeCouner++;
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
					seeCollageButton.Enabled = true;
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
				i_CheckedListBox.SetItemCheckState(i_CheckedListBox.SelectedIndex,
				i_CheckedListBox.GetItemCheckState(i_CheckedListBox.SelectedIndex) == CheckState.Checked ?
				CheckState.Unchecked : CheckState.Checked);
			}
		}

		private bool checkIfUserSelectedTheCorrectImagesQuantity()
		{
			return m_SelectedImagesCollection.Count == (int)(m_FrameUserChoice + k_UserChoiceOffset);
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

		private void collageFrameButton_Click(object sender, EventArgs e)
		{
			m_AllCollagesCollection = CollagesFactory.CreateAllCollages();
			CollageFrameOptionsForm collageForm = new CollageFrameOptionsForm(m_AllCollagesCollection);
			collageForm.FormClosing += CollageForm_FormClosing;
			collageForm.ShowDialog();
		}

		private void CollageForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			m_FrameUserChoice = (sender as CollageFrameOptionsForm).GetUserChoice();
			selectPhotosButton.Enabled = true;
		}

		private void seeCollageButton_Click(object sender, EventArgs e)
		{
			if (checkIfUserSelectedTheCorrectImagesQuantity())
			{
				try
				{
					m_AllCollagesCollection.ElementAt((int)m_FrameUserChoice).CreateCollage(m_SelectedImagesCollection);
					CollageViewForm collageViewForm = new CollageViewForm(m_AllCollagesCollection.ElementAt((int)m_FrameUserChoice));
					collageViewForm.ShowDialog();
				}
				catch (Exception ex)
				{
					FacebookApp.showFacebookError(ex.Message);
				}
			}
			else
			{
				FacebookApp.showFacebookError("Error! There is a mismatch between your frame choice to the number of images you selected.");
			}
		}
	}
}
