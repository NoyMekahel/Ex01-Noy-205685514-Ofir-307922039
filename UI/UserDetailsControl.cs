using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
	public partial class UserDetailsControl : UserControl
	{
		public UserDetailsControl()
		{
			InitializeComponent();
		}

		internal void ShowUserInfo()
		{
			userProfilePictureBox.LoadAsync(DataManagerWrapper.DataManager.GetPictureNormalURL());
			firstNameDataLabel.Text = DataManagerWrapper.DataManager.GetFirstName();
			lastNameDataLabel.Text = DataManagerWrapper.DataManager.GetLastName();
			emailDataLabel.Text = DataManagerWrapper.DataManager.GetEmail();
			birthdayDataLabel.Text = DataManagerWrapper.DataManager.GetBirthday();
			string daysTillBirthday = DataManagerWrapper.DataManager.GetDaysTillBirthday().ToString();

			daysTillBirthdayDataLabel.Text = daysTillBirthday.Equals("0") ? "Happy Birthday!" : daysTillBirthday;
		}
	}
}
