using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Model;

namespace UI
{
	public partial class ControlRidePage : UserControl, ILogoutable, IBackable
	{
		private string m_RideFromLocationName;


		public ControlRidePage()
		{
			InitializeComponent();
			createLocationsList();
		}


		private void createLocationsList()
		{
			try
			{
				ICollection<string> locationsCollection = DataManagerWrapper.DataManager.GetSortedFriendsLocation();

				foreach (string currentLocation in locationsCollection)
				{
					listBoxLocations.Items.Add(currentLocation);
				}
			}
			catch(Exception)
			{
				FormFacebookApp.showFacebookError("Couldn't fetch your friends location data.");
			}
		}

		private void locationsListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if ((sender as ListBox).SelectedItem != null)
			{
				m_RideFromLocationName = (sender as ListBox).SelectedItem.ToString();

				try
				{
					handlePageAfterStartPointSelected();
					DataManagerWrapper.DataManager.InitializeRide(m_RideFromLocationName);
					FormMap map = new FormMap();
					map.ShowLocationOnMap(m_RideFromLocationName);
					map.ShowDialog();
				}
				catch (Exception ex)
				{
					FormFacebookApp.showFacebookError(ex.Message);
				}
			}
		}

		private void eventButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (DataManagerWrapper.DataManager.GetEvents().Count > 0)
				{
					ICollection<string> allEventsNames = DataManagerWrapper.DataManager.GetEventsNames();

					foreach (string currEventName in allEventsNames)
					{
						comboBoxEvents.Items.Add(currEventName);
					}
					comboBoxEvents.Enabled = true;
				}
				else
				{
					FormFacebookApp.showFacebookError("There are no events you go to.");
				}

			}
			catch (Exception)
			{
				FormFacebookApp.showFacebookError("Couldn't fetch your events data.");
			}
		}

		private void eventsComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				ICollection<User> allFriendsFromStartPoint = DataManagerWrapper.DataManager.Ride.getFriendsFromChosenEvent((sender as ComboBox).SelectedItem.ToString());
				controlFilter.FillFriendsResultOnDataTable(allFriendsFromStartPoint);
				controlFilter.Visible = true;
			}
			catch (Exception)
			{
				FormFacebookApp.showFacebookError();
			}
		}

		private void workButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (DataManagerWrapper.DataManager.GetWorkExperiences() != null)
				{
					ICollection<string> allWorkPlacesNames = DataManagerWrapper.DataManager.GetWorkPlacesNames();

					foreach (string currWorkPlaceName in allWorkPlacesNames)
					{
						comboBoxWork.Items.Add(currWorkPlaceName);
					}
					comboBoxWork.Enabled = true;
				}
				else
				{
					FormFacebookApp.showFacebookError("There are no places where you work.");
				}
			}

			catch (Exception)
			{
				FormFacebookApp.showFacebookError("Couldn't fetch your work experiences data.");
			}
		}

		private void workComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				ICollection<User> allFriendsFromStartPoint = DataManagerWrapper.DataManager.Ride.getFriendsFromWork((sender as ComboBox).SelectedItem.ToString());
				controlFilter.FillFriendsResultOnDataTable(allFriendsFromStartPoint);
				controlFilter.Visible = true;
			}
			catch (Exception)
			{
				FormFacebookApp.showFacebookError();
			}
		}

		private void academicInstitutionButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (DataManagerWrapper.DataManager.GetEducations() != null)
				{
					ICollection<string> allAcademicInstitutionsNames = DataManagerWrapper.DataManager.GetAcademicInstitutionsNames();

					foreach (string currAcademicInstitution in allAcademicInstitutionsNames)
					{
						comboBoxAcademic.Items.Add(currAcademicInstitution);
					}
					comboBoxAcademic.Enabled = true;
				}
				else
				{
					FormFacebookApp.showFacebookError("There are no academic institutions where you study.");
				}
			}

			catch(Exception)
			{
				FormFacebookApp.showFacebookError("Couldn't fetch your academic institutions data.");
			}
		}

		private void academicComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				ICollection<User> allFriendsFromStartPoint = DataManagerWrapper.DataManager.Ride.getFriendsFromAcademicInstitution((sender as ComboBox).SelectedItem.ToString());
				controlFilter.FillFriendsResultOnDataTable(allFriendsFromStartPoint);
				controlFilter.Visible = true;
			}
			catch (Exception)
			{
				FormFacebookApp.showFacebookError();
			}
		}

		private void handlePageAfterStartPointSelected()
		{
			buttonAcademicInstitution.Enabled = true;
			buttonEvent.Enabled = true;
			buttonWork.Enabled = true;
		}

		public void AddLogoutButton(Button i_LogoutButton)
		{
			Controls.Add(i_LogoutButton);
		}

		public void AddBackButton(Button i_BackButton)
		{
			Controls.Add(i_BackButton);
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
	}
}
