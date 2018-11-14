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
						);
			// These are NOT the complete list of permissions. Other permissions for example:
			// "user_birthday", "user_education_history", "user_hometown", "user_likes","user_location","user_relationships","user_relationship_details","user_religion_politics", "user_videos", "user_website", "user_work_history", "email","read_insights","rsvp_event","manage_pages"
			// The documentation regarding facebook login and permissions can be found here: 
			// https://developers.facebook.com/docs/facebook-login/permissions#reference


			if (!string.IsNullOrEmpty(result.AccessToken))
			{
				
				 return (new DataManager(result.LoggedInUser, result.AccessToken));
			}

			else
			{
				throw new Exception(result.ErrorMessage);
			}
		}

		public static DataManager Connect(string i_LastAccessToken)
		{
			LoginResult result = FacebookService.Connect(i_LastAccessToken);

			return (new DataManager(result.LoggedInUser, result.AccessToken));
		}

		public static void Logout()
		{
			FacebookService.Logout(null);
		}
	}
}
