using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace Model
{
	public class GenderFilter : IFilter
	{

		private User.eGender m_GenderType;

		public GenderFilter(string i_GenderType)
		{
			m_GenderType = i_GenderType.ToLower().Equals("male") ? User.eGender.male : User.eGender.female;
		}

		public ICollection<User> filter(ICollection<User> i_Friends)
		{
			HashSet<User> friendsFromStartPointToEndPoint = new HashSet<User>();

			foreach (User user in i_Friends)
			{
				if (user.Gender.Value == m_GenderType)
				{
					friendsFromStartPointToEndPoint.Add(user);
				}
			}

			return friendsFromStartPointToEndPoint;
		}
	}
}
