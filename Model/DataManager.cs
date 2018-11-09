using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using System.Text.RegularExpressions;

namespace Model
{
	public class DataManager
	{
		private User m_LoggedInUser;

		public Ride Ride { get; }

		public DataManager(User i_LoggedInUser)
		{
			m_LoggedInUser = i_LoggedInUser;
		}

		public string GetPictureNormalURL()
		{
			return m_LoggedInUser.PictureNormalURL;
		}

		public FacebookObjectCollection<User> GetFriends()
		{
			return m_LoggedInUser.Friends;
		}

		public Education[] GetEducations()
		{
			return m_LoggedInUser.Educations;
		}

		public FacebookObjectCollection<Page> GetUserLikedPages()
		{
			return m_LoggedInUser.LikedPages;
		}

		public FacebookObjectCollection<Post> GetUserPosts()
		{
			return m_LoggedInUser.Posts;
		}

		public FacebookObjectCollection<Album> GetAlbums()
        {
            return m_LoggedInUser.Albums;
        }

        public FacebookObjectCollection<Event> GetEvents()
		{
			return m_LoggedInUser.Events;
		}

		public WorkExperience[] GetWorkExperiences()
		{
			return m_LoggedInUser.WorkExperiences;
		}

		public ICollection<string> GetSortedFriendsLocation()
		{
			ISet<string> locationsSet = new SortedSet<string>();

			foreach (User currentFriend in m_LoggedInUser.Friends)
			{
				if (currentFriend.Location != null)
				{
					locationsSet.Add(currentFriend.Location.Name);
				}
			}

			return locationsSet;
		}

		public ICollection<string> GetEventsNames()
		{
			List<string> allEventsNames = new List<string>(m_LoggedInUser.Events.Count);
			
			foreach (Event currEvent in m_LoggedInUser.Events)
			{
				allEventsNames.Add(currEvent.Name);
			}

			return allEventsNames;
		}

		public ICollection<string> GetWorkPlacesNames()
		{
			List<string> allWorkPlacesNames = new List<string>(m_LoggedInUser.WorkExperiences.Length);

			foreach (WorkExperience currWorkPlace in m_LoggedInUser.WorkExperiences)
			{
				allWorkPlacesNames.Add(currWorkPlace.Name);
			}

			return allWorkPlacesNames;
		}

		public ICollection<string> GetAcademicInstitutionsNames()
		{
			List<string> allAcademicInstitutionsNames = new List<string>(m_LoggedInUser.Educations.Length);

			foreach (Education currAcademicInstitution in m_LoggedInUser.Educations)
			{
				allAcademicInstitutionsNames.Add(currAcademicInstitution.School.Name);
			}

			return allAcademicInstitutionsNames;
		}

		public string GetFirstName()
		{
			return m_LoggedInUser.FirstName;
		}

		public string GetLastName()
		{
			return m_LoggedInUser.LastName;
		}

		public string GetEmail()
		{
			return m_LoggedInUser.Email;
		}

		public string GetBirthday()
		{
			return m_LoggedInUser.Birthday;
		}

		public int GetDaysTillBirthday()
		{
			return calculateDaysTillBirthday();
		}

		private int calculateDaysTillBirthday()
		{
			DateTime birthdate = parseStringToDateTime(m_LoggedInUser.Birthday);
			DateTime todayDate = DateTime.Today;
			DateTime birthday = new DateTime(todayDate.Year, birthdate.Month, birthdate.Day);

			if (birthday < todayDate)
			{
				birthday = birthday.AddYears(1);
			}

			return (birthday - todayDate).Days;

		}

		private DateTime parseStringToDateTime(string i_Date)
		{
			int day = 0, month = 0, year = 0;
			if (Regex.IsMatch(i_Date, "^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\\d\\d$"))
			{
				month =int.Parse(i_Date.Substring(0, 2));
				day = int.Parse(i_Date.Substring(3, 2));
				year = int.Parse(i_Date.Substring(6, 4));
			}
			else if (Regex.IsMatch(i_Date, "^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])$"))
			{
				month = int.Parse(i_Date.Substring(0, 2));
				day = int.Parse(i_Date.Substring(3, 2));
				year = DateTime.Today.Year;
			}
			else
			{
				throw new FormatException("Illegal date format! ");
			}

			return new DateTime(year, month, day);
		}

		public void InitializeRide(string i_RideFromLocationName)
		{
			List<User> friendsFromStartPoint = new List<User>();
			foreach(User user in m_LoggedInUser.Friends)
			{
				if(user.Location.Name.Equals(i_RideFromLocationName))
				{
					friendsFromStartPoint.Add(user);
				}
			}

			Ride.FriendsFromStartPoint = friendsFromStartPoint;
		}
	}
}
