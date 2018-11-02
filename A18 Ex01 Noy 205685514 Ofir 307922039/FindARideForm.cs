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

		}

		internal void CreateLocationsList(User i_LoggedInUser)
		{
			//m_LocationsListBox
			//HashSet<String> locationsSet = new HashSet<String>();
			ISet<string> locationsSet = new SortedSet<string>();
			foreach (User currentFriend in i_LoggedInUser.Friends)
			{
				locationsSet.Add(currentFriend.Location.Name);
			}
			foreach (string currentLocation in locationsSet)
			{
				m_LocationsListBox.Items.Add(currentLocation);
			}
		}
	}
}
