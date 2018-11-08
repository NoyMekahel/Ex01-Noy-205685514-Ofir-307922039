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
	public partial class RidePageControl : UserControl, ILogoutable
	{
		private string m_RideFromLocationName;


		public RidePageControl()
		{
			InitializeComponent();
			createLocationsList();
		}


		private void createLocationsList()
		{
			ICollection<string> locationsCollection = DataManagerWrapper.DataManager.GetSortedFriendsLocation();


			foreach (string currentLocation in locationsCollection)
			{
				locationsListBox.Items.Add(currentLocation);
			}
		}

		private void eventButton_Click(object sender, EventArgs e)
		{
			eventsComboBox.Enabled = true;
			ICollection<string> allEventsNames = DataManagerWrapper.DataManager.GetEventsNames();

			foreach (string currEventName in allEventsNames)
			{
				eventsComboBox.Items.Add(currEventName);
			}
		}

		private void eventsComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			visibleTableAndFilter();

			try
			{
				ICollection<User> allFriendsFromStartPoint = DataManagerWrapper.DataManager.Ride.getFriendsFromChosenEvent((sender as ComboBox).SelectedItem.ToString());
				fillFriendsResultDataTable(allFriendsFromStartPoint);
			}
			catch (Exception)
			{
				FacebookApp.showFacebookError();
			}
		}

		private void workButton_Click(object sender, EventArgs e)
		{
			workComboBox.Enabled = true;
			ICollection<string> allWorkPlacesNames = DataManagerWrapper.DataManager.GetWorkPlacesNames();

			foreach (string currWorkPlaceName in allWorkPlacesNames)
			{
				workComboBox.Items.Add(currWorkPlaceName);
			}
		}

		private void workComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			visibleTableAndFilter();

			try
			{
				ICollection<User> allFriendsFromStartPoint = DataManagerWrapper.DataManager.Ride.getFriendsFromWork((sender as ComboBox).SelectedItem.ToString());
				fillFriendsResultDataTable(allFriendsFromStartPoint);
			}
			catch (Exception)
			{
				FacebookApp.showFacebookError();
			}
		}

		private void academicInstitutionButton_Click(object sender, EventArgs e)
		{
			academicComboBox.Enabled = true;
			ICollection<string> allAcademicInstitutionsNames = DataManagerWrapper.DataManager.GetAcademicInstitutionsNames();

			foreach (string currAcademicInstitution in allAcademicInstitutionsNames)
			{
				academicComboBox.Items.Add(currAcademicInstitution);
			}
		}

		private void academicComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			visibleTableAndFilter();

			try
			{
				ICollection<User> allFriendsFromStartPoint = DataManagerWrapper.DataManager.Ride.getFriendsFromAcademicInstitution((sender as ComboBox).SelectedItem.ToString());
				fillFriendsResultDataTable(allFriendsFromStartPoint);
			}
			catch (Exception)
			{
				FacebookApp.showFacebookError();
			}
		}

		private void genderCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (genderCheckBox.Checked)
			{
				GenderGroupBox.Visible = true;
				FilterButton.Enabled = true;
			}
			else
			{
				GenderGroupBox.Visible = false;
				if (ageCheckBox.Checked == false)
				{
					FilterButton.Enabled = false;
				}
			}
		}

		private void ageCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (ageCheckBox.Checked)
			{
				ageGroupBox.Visible = true;
				FilterButton.Enabled = true;
			}
			else
			{
				ageGroupBox.Visible = false;
				if (genderCheckBox.Checked == false)
				{
					FilterButton.Enabled = false;
				}
			}
		}

		private void FilterButton_Click(object sender, EventArgs e)
		{
			if (genderCheckBox.Checked)
			{
				RadioButton genderPreferenceRadioButton = GenderGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
				DataManagerWrapper.DataManager.Ride.AddFilter(new GenderFilter(genderPreferenceRadioButton.Text));
			}

			if (ageCheckBox.Checked)
			{
				RadioButton agePreferenceRadioButton = ageGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
				DataManagerWrapper.DataManager.Ride.AddFilter(new AgeFilter(agePreferenceRadioButton.Text));
			}

			ICollection<User> friendsAfterFilter = DataManagerWrapper.DataManager.Ride.Filter();
			bindingSourceRideFriendsGrid.DataSource = friendsAfterFilter;
		}

		public void backButton_AddListener(EventHandler i_EventHandler)
		{
			this.backButton.Click += i_EventHandler;
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
				}
				catch (Exception ex)
				{
					FacebookApp.showFacebookError(ex.Message);
				}
			}
		}

		private void fillFriendsResultDataTable(ICollection<User> i_AllFriendsFromStartPoint)
		{
			bindingSourceRideFriendsGrid.DataSource = i_AllFriendsFromStartPoint;
			int counter = 0;
			foreach (User currentUser in i_AllFriendsFromStartPoint)
			{
				DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
				cell.Value = AgeFilter.GetAgeFromUserBirthday(currentUser.Birthday);
				friendsResultDataGrid.Rows[counter++].Cells[AgeColunm.Index] = cell;
			}
		}

		private void handlePageAfterStartPointSelected()
		{
			bool isFacebookError = false;
			string errorMessage = "Couldn't fetch the following data: " + Environment.NewLine;

			if (DataManagerWrapper.DataManager.GetEducations() != null)
			{
				academicInstitutionButton.Enabled = true;
			}
			else
			{
				isFacebookError = true;
				errorMessage += "Educations" + Environment.NewLine;
			}

			if (DataManagerWrapper.DataManager.GetEvents().Count > 0)
			{
				eventButton.Enabled = true;
			}
			else
			{
				eventsComboBox.Text = "No Upcoming Events!";
			}

			if (DataManagerWrapper.DataManager.GetWorkExperiences() != null)
			{
				workButton.Enabled = true;
			}
			else
			{
				errorMessage += "Work" + Environment.NewLine;
				isFacebookError = true;
			}

			if (isFacebookError)
			{
				FacebookApp.showFacebookError(errorMessage);
			}
		}

		private void visibleTableAndFilter()
		{
			friendsResultDataGrid.Visible = true;
			filterGroupBox.Visible = true;
		}

		public void AddLogoutButton(Button i_LogoutButton)
		{
			Controls.Add(i_LogoutButton);
		}
    }
}
