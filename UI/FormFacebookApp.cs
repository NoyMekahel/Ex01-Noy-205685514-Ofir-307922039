using System;
using System.ComponentModel;
using System.Windows.Forms;
using Model;

namespace UI
{
	public partial class FormFacebookApp : Form
	{
		private ControlHomePage controlHomePage;
		private ControlRidePage controlRidePage;
		private ControlCollagePage controlCollagePage;
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
					DataManagerWrapper.SetDataManager(this, dataManager);
					initializeUserPreferences();
					showHomePage();
				}
			}
			catch(Exception)
			{
			}

			base.OnShown(e);
		}

		private void initializeUserPreferences()
		{
			this.Location = m_AppSettings.Location;
			checkBoxRememberUser.Checked = m_AppSettings.RememberUser;
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			try
			{
				DataManager dataManager = FacebookConnection.Login();
				DataManagerWrapper.SetDataManager(this, dataManager);
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
			{
			}

			base.OnClosing(e);
		}

		private void showHomePage()
		{
			BackgroundImage = global::UI.Properties.Resources.facebook_widescreen_navy_background_image;
			panelMain.Controls.Clear();
			controlHomePage = new ControlHomePage();
			panelMain.Controls.Add(this.controlHomePage);
			controlHomePage.AddLogoutButton(logoutButton);
			controlHomePage.ButtonFindARide_AddClickedListener(new EventHandler(buttonFindARide_Click));
			controlHomePage.ButtonCreateCollage_AddClickedListener(new EventHandler(buttonCreateCollage_Click));
			controlHomePage.FetchUserInfo();
		}

		private void buttonCreateCollage_Click(object sender, EventArgs e)
		{
			controlCollagePage = new ControlCollagePage();
			controlCollagePage.AddLogoutButton(logoutButton);
			controlCollagePage.AddBackButton(backButton);
			panelMain.Controls.Clear();
			panelMain.Controls.Add(controlCollagePage);
		}

		private void buttonLogout_Click(object sender, EventArgs e)
		{
			this.BackgroundImage = global::UI.Properties.Resources.faccebook_background;
			FacebookConnection.Logout();
			panelMain.Controls.Clear();
			panelMain.Controls.Add(buttonlLogin);
			checkBoxRememberUser.Checked = false;
			panelMain.Controls.Add(checkBoxRememberUser);
		}

		private void buttonFindARide_Click(object sender, EventArgs e)
		{
			controlRidePage = new ControlRidePage();
			controlRidePage.AddLogoutButton(logoutButton);
			controlRidePage.AddBackButton(backButton);
			panelMain.Controls.Clear();
			panelMain.Controls.Add(controlRidePage);
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			controlHomePage.AddLogoutButton(logoutButton);
			panelMain.Controls.Clear();
			panelMain.Controls.Add(controlHomePage);
		}

		internal static void ShowFacebookError()
		{
			ShowFacebookError("An error has occured. Couldn't retrieve the requested information from facebook");
		}

		internal static void ShowFacebookError(string i_ErrorMessage)
		{
			MessageBox.Show(i_ErrorMessage);
		}
	}
}
