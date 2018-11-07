using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;

namespace UI
{
	public partial class FacebookApp : Form
	{

		private HomePageControl homePageControl;
		private RidePageControl ridePageControl;

		public FacebookApp()
		{
			InitializeComponent();
		}

		private void showHomePage()
		{
			mainPanel.Controls.Clear();
			homePageControl = new HomePageControl();
			homePageControl.AddLogoutButton(logoutButton);
			this.mainPanel.Controls.Add(this.homePageControl);
			this.homePageControl.findARideButton_AddClickedListener(new EventHandler(findARideButton_Click));
		}

		private void logoutButton_Click(object sender, EventArgs e)
		{
			FacebookConnection.Logout();
			mainPanel.Controls.Clear();
			mainPanel.Controls.Add(loginButton);
		}

		private void findARideButton_Click(object sender, EventArgs e)
		{
			ridePageControl = new RidePageControl();
			ridePageControl.AddLogoutButton(logoutButton);
			ridePageControl.backButton_AddListener(new EventHandler(backButton_Click));
			mainPanel.Controls.Clear();
			mainPanel.Controls.Add(ridePageControl);
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			homePageControl.AddLogoutButton(logoutButton);
			mainPanel.Controls.Clear();
			mainPanel.Controls.Add(homePageControl);
		}


		public static void showFacebookError()
		{
			showFacebookError("An error has occured. Couldn't retrieve the requested information from facebook");
		}

		internal static void showFacebookError(string i_ErrorMessage)
		{
			MessageBox.Show(i_ErrorMessage);
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			try
			{
				DataManager dataManager = FacebookConnection.Login();
				DataManagerWrapper.setDataManager(this, dataManager);
				showHomePage();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
