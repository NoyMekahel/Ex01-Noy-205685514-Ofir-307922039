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
	public partial class ControlCollagePage : UserControl, ILogoutable, IBackable
	{
		private const int k_UserChoiceOffset = 3;
		private FacebookObjectCollection<Photo> m_FilteredPhotosCollection;
		private FacebookObjectCollection<Image> m_SelectedImagesCollection = new FacebookObjectCollection<Image>();
		private eFrameCollage m_FrameUserChoice;
		private ICollection<CollageBase> m_AllCollagesCollection;

		public ControlCollagePage()
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
				checkedListBoxFilter.Visible = true;
			}
		}

		private void albumsPhotosRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			if (albumsPhotosRadioButton.Checked == true)
			{
				createAlbumsCheckListBox();
				checkedListBoxFilter.Visible = true;
			}
		}

		private void allPhotosRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			if (allPhotosRadioButton.Checked == true)
			{
				checkedListBoxFilter.Visible = false;
			}
		}

		private void createFriendsCheckListBox()
		{
			try
			{
				checkedListBoxFilter.Items.Clear();
				ICollection<string>  friendsNamesCollection = DataManagerWrapper.DataManager.GetFriendsNames();

				foreach (string name in friendsNamesCollection)
				{
					checkedListBoxFilter.Items.Add(name);
				}
			}
			catch (Exception)
			{
				FormFacebookApp.showFacebookError("Couldn't fetch your friends names data.");
			}
		}

		private void createAlbumsCheckListBox()
		{
			try
			{
				checkedListBoxFilter.Items.Clear();
				ICollection<string>  albumsNamesCollection = DataManagerWrapper.DataManager.GetAlbumsNames();

				foreach (string name in albumsNamesCollection)
				{
					checkedListBoxFilter.Items.Add(name);
				}
			}
			catch (Exception)
			{
				FormFacebookApp.showFacebookError("Couldn't fetch your albums names data.");
			}
		}

		private void setSelectedAlbumsPhotosOnListBox()
		{
			try
			{
				ICollection<string> selectedAlbums = checkedListBoxFilter.CheckedItems.Cast<string>().ToList();
				m_FilteredPhotosCollection = DataManagerWrapper.DataManager.GetAlbumsPhotos(selectedAlbums);
				populatePhotosCheckedListBox();
			}

			catch(Exception)
			{
				FormFacebookApp.showFacebookError("Couldn't fetch albums photos data.");
			}
		}

		private void populatePhotosCheckedListBox()
		{
			int photoCounter = 1;

			foreach (Photo photo in m_FilteredPhotosCollection)
			{
				checkedListBoxPhotos.Items.Add(string.Format("Picture {0}", photoCounter));
				photoCounter++;
			}
		}

		private void setSharedPhotosOnListBox()
		{
			try
			{
				ICollection<string> selectedFriends = checkedListBoxFilter.CheckedItems.Cast<string>().ToList();
				m_FilteredPhotosCollection = DataManagerWrapper.DataManager.GetSharedFriendsPhotos(selectedFriends);
				populatePhotosCheckedListBox();

			}
			catch (Exception)
			{
				FormFacebookApp.showFacebookError("Couldn't fetch friends shared photos data.");
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
						checkedListBoxPhotos.Items.Add(string.Format("{0} - Picture {1}", album.Name, photoCounter));
						m_FilteredPhotosCollection.Add(photo);
						photoCounter++;
					}
					nodeCouner++;
				}
			}
			catch (Exception)
			{
				FormFacebookApp.showFacebookError("Couldn't fetch albums data.");
			}

		}

		private void selectPhotosButton_Click(object sender, EventArgs e)
		{
			checkedListBoxPhotos.Items.Clear();
			if (allPhotosRadioButton.Checked == true)
			{
				setAllPhotosOnListBox();
			}
			else if (sharedPhotosRadioButton.Checked == true)
			{
				if (checkedListBoxFilter.CheckedItems.Count == 0)
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
				if (checkedListBoxFilter.CheckedItems.Count == 0)
				{
					MessageBox.Show("Error! You didn't selected any album.");
				}
				else
				{
					setSelectedAlbumsPhotosOnListBox();
				}
			}

			checkedListBoxPhotos.Visible = true;
			pictureBoxImage.Visible = true;
		}

		private void photosCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (checkedListBoxPhotos.SelectedItem != null)
			{
				pictureBoxImage.LoadAsync(m_FilteredPhotosCollection[checkedListBoxPhotos.SelectedIndex].PictureNormalURL);
				pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;

				if (checkedListBoxPhotos.CheckedItems.Count > 0)
				{
					buttonSeeCollage.Enabled = true;
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
			if(checkedListBoxPhotos.GetItemChecked(checkedListBoxPhotos.SelectedIndex))
			{
				m_SelectedImagesCollection.Remove(
					m_FilteredPhotosCollection[checkedListBoxPhotos.SelectedIndex].ImageNormal);
			}
			else
			{
				m_SelectedImagesCollection.Add(
					m_FilteredPhotosCollection[checkedListBoxPhotos.SelectedIndex].ImageNormal);
			}
		}

		private void collageFrameButton_Click(object sender, EventArgs e)
		{
			m_AllCollagesCollection = CollagesFactory.CreateAllCollages();
			FormCollageFrameOptions collageForm = new FormCollageFrameOptions(m_AllCollagesCollection);
			collageForm.FormClosing += CollageForm_FormClosing;
			collageForm.ShowDialog();
		}

		private void CollageForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			m_FrameUserChoice = (sender as FormCollageFrameOptions).GetUserChoice();
			groupBoxPhotosChooser.Enabled = true;
			buttonSelectPhotos.Enabled = true;
		}

		private void seeCollageButton_Click(object sender, EventArgs e)
		{
			if (checkIfUserSelectedTheCorrectImagesQuantity())
			{
				try
				{
					m_AllCollagesCollection.ElementAt((int)m_FrameUserChoice).CreateCollage(m_SelectedImagesCollection);
					FormCollageView collageViewForm = new FormCollageView(m_AllCollagesCollection.ElementAt((int)m_FrameUserChoice));
					collageViewForm.ShowDialog();
				}
				catch (Exception ex)
				{
					FormFacebookApp.showFacebookError(ex.Message);
				}
			}
			else
			{
				FormFacebookApp.showFacebookError("Error! There is a mismatch between your frame choice to the number of images you selected.");
			}
		}
	}
}
