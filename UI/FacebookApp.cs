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
		private VideoCreatorPageControl videoCreatorPageControl;

		public FacebookApp()
		{
			InitializeComponent();
		}

		private void showHomePage()
		{
			BackgroundImage = global::UI.Properties.Resources.facebook_widescreen_navy_background_image;
			mainPanel.Controls.Clear();
			homePageControl = new HomePageControl();
			mainPanel.Controls.Add(this.homePageControl);
			homePageControl.AddLogoutButton(logoutButton);
			homePageControl.FindARideButton_AddClickedListener(new EventHandler(findARideButton_Click));
			homePageControl.CreateVideoButton_AddClickedListener(new EventHandler(createVideoButton_Click));
			homePageControl.fetchUserInfo();
		}

		private void createVideoButton_Click(object sender, EventArgs e)
		{
			videoCreatorPageControl = new VideoCreatorPageControl();
			videoCreatorPageControl.AddLogoutButton(logoutButton);
			videoCreatorPageControl.AddBackButton(backButton);
			mainPanel.Controls.Clear();
			mainPanel.Controls.Add(videoCreatorPageControl);
		}

		private void logoutButton_Click(object sender, EventArgs e)
		{
			this.BackgroundImage = global::UI.Properties.Resources.faccebook_background;
			FacebookConnection.Logout();
			mainPanel.Controls.Clear();
			mainPanel.Controls.Add(loginButton);
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

		private void findARideButton_Click(object sender, EventArgs e)
		{
			ridePageControl = new RidePageControl();
			ridePageControl.AddLogoutButton(logoutButton);
			ridePageControl.AddBackButton(backButton);
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
