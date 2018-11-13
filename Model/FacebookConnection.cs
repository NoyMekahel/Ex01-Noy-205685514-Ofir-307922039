using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
	/*2246590548924227*/
	public class FacebookConnection
	{
		public static DataManager Login()
		{
			LoginResult result = FacebookService.Login(
				"264186474290093", 
				"user_birthday",
				"user_events",
				"user_posts",
				"user_location",
				"user_friends",
                "user_photos"
						/*
						                 "user_likes"
										"user_education_history",
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
											"publish_actions",
											"rsvp_event" */

						);
			// These are NOT the complete list of permissions. Other permissions for example:
			// "user_birthday", "user_education_history", "user_hometown", "user_likes","user_location","user_relationships","user_relationship_details","user_religion_politics", "user_videos", "user_website", "user_work_history", "email","read_insights","rsvp_event","manage_pages"
			// The documentation regarding facebook login and permissions can be found here: 
			// https://developers.facebook.com/docs/facebook-login/permissions#reference


			if (!string.IsNullOrEmpty(result.AccessToken))
			{
				 return (new DataManager(result.LoggedInUser));
			}

			else
			{
				throw new Exception(result.ErrorMessage);
			}
		}

		public static void Logout()
		{
			FacebookService.Logout(null);
		}
	}
}
