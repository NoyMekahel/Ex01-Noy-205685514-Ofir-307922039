using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace A18_Ex01_Noy_205685514_Ofir_307922039
{
	public partial class Form1 : Form
	{
		private User m_LoggedInUser;

		public Form1()
		{
			InitializeComponent();
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			loginAndInit();
		}

		private void loginAndInit()
		{

			LoginResult result = FacebookService.Login("264186474290093",
				"user_birthday", "user_events", "user_posts", "user_location", "user_friends"/*,"public_profile", "user_education_history", "user_work_history", "user_about_me"*/
				/*		"user_education_history",
						"user_birthday",
						"user_actions.video",
						"user_actions.news",
						"user_actions.music",
						"user_actions.fitness",
						"user_actions.books",
						"user_about_me",
						"user_friends",
						"publish_actions",
						"user_events",
						"user_games_activity",
						"user_hometown",
						"user_likes",
						"user_location",
						"user_managed_groups",
						"user_photos",
						"user_posts",
						"user_relationships",
						"user_relationship_details",
						"user_religion_politics",
						"user_tagged_places",
						"user_videos",
						"user_website",
						"user_work_history",
						"read_custom_friendlists",
						"read_page_mailboxes",
						"manage_pages",
						"publish_pages",
						"publish_actions",
						"rsvp_event" */
				);
			// These are NOT the complete list of permissions. Other permissions for example:
			// "user_birthday", "user_education_history", "user_hometown", "user_likes","user_location","user_relationships","user_relationship_details","user_religion_politics", "user_videos", "user_website", "user_work_history", "email","read_insights","rsvp_event","manage_pages"
			// The documentation regarding facebook login and permissions can be found here: 
			// https://developers.facebook.com/docs/facebook-login/permissions#reference


			if (!string.IsNullOrEmpty(result.AccessToken))
			{
				m_LoggedInUser = result.LoggedInUser;
				fetchUserInfo();
			}
			else
			{
				MessageBox.Show(result.ErrorMessage);
			}
		}

		private void fetchUserInfo()
		{
			m_UserProfilePictureBox.Load(m_LoggedInUser.PictureNormalURL);
			m_FindARideButton.Visible = true;
			try
			{
				m_BindingSourceFriendsGrid.DataSource = m_LoggedInUser.Friends;
			}
			catch(Exception)
			{
			}
			//m_FriendsDataGridView.Invoke()
		}

		private void m_FindARideButton_Click(object sender, EventArgs e)
		{
			FindARideForm findARideForm = new FindARideForm();
			findARideForm.CreateLocationsList(m_LoggedInUser);
			findARideForm.ShowDialog();
		}
	}
}
