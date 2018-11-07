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
	public partial class HomePageControl : UserControl, ILogoutable
	{
		public HomePageControl()
		{
			InitializeComponent();
		}

		public void findARideButton_AddClickedListener(EventHandler i_EventHandler)
		{
			this.findARideButton.Click += i_EventHandler;
		}

		internal void fetchUserInfo()
		{
			findARideButton.Visible = true;
			try
			{
				FacebookObjectCollection<User> allFriends = DataManagerWrapper.DataManager.GetFriends();
				bindingSourceFriendsGrid.DataSource = allFriends;
				int counter = 0;
				foreach (User currentUser in allFriends)
				{
					DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
					cell.Value = currentUser.Location.Name;
					friendsDataGridView.Rows[counter].Cells[locationColumn.Index] = cell;
					counter++;
				}

				userDetailsControl.ShowUserInfo();
				userDetailsControl.Visible = true;
			}
			catch (Exception)
			{
				FacebookApp.showFacebookError();
			}
		}

		public void AddLogoutButton(Button i_LogoutButton)
		{
			Controls.Add(i_LogoutButton);
		}
	}
}
