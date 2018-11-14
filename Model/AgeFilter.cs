using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Model
{
	public class AgeFilter : IFilter
	{
		private int m_MinAge;
		private int m_MaxAge;

		public AgeFilter(string i_Range)
		{
			m_MinAge = int.Parse(i_Range.Substring(0, 2));			
			m_MaxAge = i_Range.Contains("-") ? int.Parse(i_Range.Substring(3, 2)) : 200;
		}

		public static int? GetAgeFromUserBirthday(string i_Birthday)
		{
			int? age = null;
			int birthYear;
			if (isDateContainsYear(i_Birthday))
			{
				birthYear = int.Parse(i_Birthday.Substring(6, 4));
				age = DateTime.Today.Year - birthYear;
			}

			return age;
		}

		private static bool isDateContainsYear(string i_Birthday)
		{
			return i_Birthday.Length == 10;
		}

		public ICollection<User> filter(ICollection<User> i_Friends)
		{
			HashSet<User> friendsFromStartPointToEndPoint = new HashSet<User>();

			foreach(User user in i_Friends)
			{
				int? age = GetAgeFromUserBirthday(user.Birthday);
				if(age >= m_MinAge && age <= m_MaxAge)
				{
					friendsFromStartPointToEndPoint.Add(user);
				}
			}

			return friendsFromStartPointToEndPoint;
		}
	}
}
