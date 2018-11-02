using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Noy_205685514_Ofir_307922039
{
	public partial class FindARideForm : Form
	{
		private string m_FromLocation;

		public FindARideForm()
		{
			InitializeComponent();
		}

		private void AcademicInstitutionButton_Click(object sender, EventArgs e)
		{

		}

		private void m_WorkButton_Click(object sender, EventArgs e)
		{

		}

		private void m_EventButton_Click(object sender, EventArgs e)
		{
			m_EventsComboBox.Enabled = true;
		}

		internal void CreateLocationsList(User i_LoggedInUser)
		{
			//m_LocationsListBox
			//HashSet<String> locationsSet = new HashSet<String>();
			ISet<string> locationsSet = new SortedSet<string>();
			foreach (User currentFriend in i_LoggedInUser.Friends)
			{
				if (currentFriend.Location != null)
				{
					locationsSet.Add(currentFriend.Location.Name);
				}
			}
			foreach (string currentLocation in locationsSet)
			{
				m_LocationsListBox.Items.Add(currentLocation);
			}

			if (i_LoggedInUser.WorkExperiences != null)
			{
				m_WorkPlaceLabel.Text = i_LoggedInUser.WorkExperiences[0].Location.Name;
			}
			else
			{
				m_WorkButton.Enabled = false;
			}
			m_AcademicInstitutionLabel.Text = i_LoggedInUser.Educations[0].School.Name;
		}

		private void m_LocationsListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			m_AcademicInstitutionButton.Enabled = true;
			m_EventButton.Enabled = true;
			m_WorkButton.Enabled = true;			
		}
	}
}
