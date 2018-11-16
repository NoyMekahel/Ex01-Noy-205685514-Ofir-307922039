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
	public partial class ControlFilter : UserControl
	{
		public ControlFilter()
		{
			InitializeComponent();
		}

		private void genderCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxGender.Checked)
			{
				groupBoxGender.Visible = true;
				buttonFilter.Enabled = true;
			}
			else
			{
				groupBoxGender.Visible = false;
				if (checkBoxAge.Checked == false)
				{
					buttonFilter.Enabled = false;
				}
			}
		}

		private void ageCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxAge.Checked)
			{
				groupBoxAge.Visible = true;
				buttonFilter.Enabled = true;
			}
			else
			{
				groupBoxAge.Visible = false;
				if (checkBoxGender.Checked == false)
				{
					buttonFilter.Enabled = false;
				}
			}
		}

		private void filterButton_Click(object sender, EventArgs e)
		{
			if (checkBoxGender.Checked)
			{
				RadioButton genderPreferenceRadioButton = groupBoxGender.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
				DataManagerWrapper.DataManager.Ride.AddFilter(new GenderFilter(genderPreferenceRadioButton.Text));
			}

			if (checkBoxAge.Checked)
			{
				RadioButton agePreferenceRadioButton = groupBoxAge.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
				DataManagerWrapper.DataManager.Ride.AddFilter(new AgeFilter(agePreferenceRadioButton.Text));
			}

			ICollection<User> friendsAfterFilter = DataManagerWrapper.DataManager.Ride.Filter();
			FillFriendsResultOnDataTable(friendsAfterFilter);
		}

		internal void FillFriendsResultOnDataTable(ICollection<User> i_AllFriendsFromStartPoint)
		{
			dataGridFriendsResult.Controls.Clear();
			bindingSourceRideFriendsGrid.DataSource = i_AllFriendsFromStartPoint;
			int counter = 0;
			foreach (User currentUser in i_AllFriendsFromStartPoint)
			{
				DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
				cell.Value = AgeFilter.GetAgeFromUserBirthday(currentUser.Birthday);
				dataGridFriendsResult.Rows[counter].Cells[AgeColumn.Index] = cell;
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
