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
				filterButton.Enabled = true;
			}
			else
			{
				GenderGroupBox.Visible = false;
				if (ageCheckBox.Checked == false)
				{
					filterButton.Enabled = false;
				}
			}
		}

		private void ageCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (ageCheckBox.Checked)
			{
				ageGroupBox.Visible = true;
				filterButton.Enabled = true;
			}
			else
			{
				ageGroupBox.Visible = false;
				if (genderCheckBox.Checked == false)
				{
					filterButton.Enabled = false;
				}
			}
		}

		private void filterButton_Click(object sender, EventArgs e)
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

			try
			{
				ICollection<User> friendsAfterFilter = DataManagerWrapper.DataManager.Ride.Filter();
				FillFriendsResultOnDataTable(friendsAfterFilter);
			}
			catch(Exception)
			{
				FacebookApp.showFacebookError();
			}
		}

		internal void FillFriendsResultOnDataTable(ICollection<User> i_AllFriendsFromStartPoint)
		{
			friendsResultDataGrid.Controls.Clear();
			bindingSourceRideFriendsGrid.DataSource = i_AllFriendsFromStartPoint;
			int counter = 0;
			foreach (User currentUser in i_AllFriendsFromStartPoint)
			{
				DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
				cell.Value = AgeFilter.GetAgeFromUserBirthday(currentUser.Birthday);
				friendsResultDataGrid.Rows[counter].Cells[AgeColumn.Index] = cell;
				counter++;
			}
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
