using System;
using FacebookWrapper;

namespace Model
{
	/*264186474290093- US*/

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
                "user_photos");

			if (!string.IsNullOrEmpty(result.AccessToken))
			{		
				 return new DataManager(result.LoggedInUser, result.AccessToken);
			}
			else
			{
				throw new Exception(result.ErrorMessage);
			}
		}

		public static DataManager Connect(string i_LastAccessToken)
		{
			LoginResult result = FacebookService.Connect(i_LastAccessToken);
			return new DataManager(result.LoggedInUser, result.AccessToken);
		}

		public static void Logout()
		{
			FacebookService.Logout(null);
		}
	}
}
