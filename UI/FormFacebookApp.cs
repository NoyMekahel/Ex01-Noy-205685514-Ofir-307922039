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
	public partial class FormFacebookApp : Form
	{

		private ControlHomePage homePageControl;
		private ControlRidePage ridePageControl;
		private ControlCollagePage videoCreatorPageControl;
		private AppSettings m_AppSettings;
		public FormFacebookApp()
		{
			InitializeComponent();
		}

		protected override void OnShown(EventArgs e)
		{
			try
			{
				m_AppSettings = AppSettings.LoadFromFile();
				if (m_AppSettings.RememberUser && !string.IsNullOrEmpty(m_AppSettings.LastAccessToken))
				{
					DataManager dataManager = FacebookConnection.Connect(m_AppSettings.LastAccessToken);
					DataManagerWrapper.setDataManager(this, dataManager);
					initializeUserPreferences();
					showHomePage();
				}
			}
			catch(Exception)
			{ }
			base.OnShown(e);
		}

		private void initializeUserPreferences()
		{
			this.Location = m_AppSettings.Location;
			checkBoxRememberUser.Checked = m_AppSettings.RememberUser;
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

		protected override void OnClosing(CancelEventArgs e)
		{
			m_AppSettings.Location = this.Location;
			m_AppSettings.RememberUser = checkBoxRememberUser.Checked ? true : false;
			if(m_AppSettings.RememberUser)
			{
				m_AppSettings.LastAccessToken = DataManagerWrapper.DataManager.UserAccessToken;
			}
			else
			{
				m_AppSettings.LastAccessToken = null;
			}
			try
			{
				m_AppSettings.SaveToFile();
			}
			catch(Exception)
			{}
			base.OnClosing(e);
		}

		private void showHomePage()
		{
			BackgroundImage = global::UI.Properties.Resources.facebook_widescreen_navy_background_image;
			panelMain.Controls.Clear();
			homePageControl = new ControlHomePage();
			panelMain.Controls.Add(this.homePageControl);
			homePageControl.AddLogoutButton(logoutButton);
			homePageControl.FindARideButton_AddClickedListener(new EventHandler(findARideButton_Click));
			homePageControl.CreateCollageButton_AddClickedListener(new EventHandler(createCollageButton_Click));
			homePageControl.fetchUserInfo();
		}

		private void createCollageButton_Click(object sender, EventArgs e)
		{
			videoCreatorPageControl = new ControlCollagePage();
			videoCreatorPageControl.AddLogoutButton(logoutButton);
			videoCreatorPageControl.AddBackButton(backButton);
			panelMain.Controls.Clear();
			panelMain.Controls.Add(videoCreatorPageControl);
		}

		private void logoutButton_Click(object sender, EventArgs e)
		{
			this.BackgroundImage = global::UI.Properties.Resources.faccebook_background;
			FacebookConnection.Logout();
			panelMain.Controls.Clear();
			panelMain.Controls.Add(buttonlLogin);
			checkBoxRememberUser.Checked = false;
			panelMain.Controls.Add(checkBoxRememberUser);
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
			ridePageControl = new ControlRidePage();
			ridePageControl.AddLogoutButton(logoutButton);
			ridePageControl.AddBackButton(backButton);
			panelMain.Controls.Clear();
			panelMain.Controls.Add(ridePageControl);
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			homePageControl.AddLogoutButton(logoutButton);
			panelMain.Controls.Clear();
			panelMain.Controls.Add(homePageControl);
		}

		public static void showFacebookError()
		{
			showFacebookError("An error has occured. Couldn't retrieve the requested information from facebook");
		}

		internal static void showFacebookError(string i_ErrorMessage)
		{
			MessageBox.Show(i_ErrorMessage);
		}
	}
}
