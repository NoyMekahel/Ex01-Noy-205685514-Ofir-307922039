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

namespace UI
{
	public partial class FilterControl : UserControl
	{
		public FilterControl()
		{
			InitializeComponent();
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

		internal void FillFriendsResultOnDataTable(ICollection<User> i_AllFriendsFromStartPoint)
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
	}
}
