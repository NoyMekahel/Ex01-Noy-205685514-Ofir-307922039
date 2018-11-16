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
	public partial class ControlUserDetails : UserControl
	{
		public ControlUserDetails()
		{
			InitializeComponent();
		}

		internal void ShowUserInfo()
		{
			try
			{
				pictureBoxUserProfile.LoadAsync(DataManagerWrapper.DataManager.GetPictureNormalURL());
				labelFirstNameData.Text = DataManagerWrapper.DataManager.GetFirstName();
				labelLastNameData.Text = DataManagerWrapper.DataManager.GetLastName();
				labelEmailData.Text = DataManagerWrapper.DataManager.GetEmail();
				labelBirthdayData.Text = DataManagerWrapper.DataManager.GetBirthday();
				string daysTillBirthday = DataManagerWrapper.DataManager.GetDaysTillBirthday().ToString();

				labelDaysTillBirthdayData.Text = daysTillBirthday.Equals("0") ? "Happy Birthday!" : daysTillBirthday;
			}
			catch(Exception)
			{
				FormFacebookApp.showFacebookError();
			}
		}
	}
}
