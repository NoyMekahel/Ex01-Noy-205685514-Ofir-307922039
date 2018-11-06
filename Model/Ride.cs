using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
	public class Ride
	{
		public ICollection<User> FriendsFromStartPoint { get; set; }

		public ICollection<User> getFriendsFromWork(string i_WorkName)
		{
			List<User> friendsFromWork = new List<User>();

			foreach(User user in FriendsFromStartPoint)
			{
				for(int workIndex=0; workIndex< user.WorkExperiences.Length; ++workIndex)
				{
					if(user.WorkExperiences[workIndex].Name.Equals(i_WorkName))
					{
						friendsFromWork.Add(user);
					}
				}
			}

			return friendsFromWork;
		}

		public ICollection<User> getFriendsFromAcademicInstitution(string i_AcademicInstitutionName)
		{
			List<User> friendsFromAcademicInstitution = new List<User>();

			foreach (User user in FriendsFromStartPoint)
			{
				for (int academicInstitutionIndex = 0; academicInstitutionIndex < user.Educations.Length; ++academicInstitutionIndex)
				{
					if (user.Educations[academicInstitutionIndex].School.Name.Equals(i_AcademicInstitutionName))
					{
						friendsFromAcademicInstitution.Add(user);
					}
				}
			}

			return friendsFromAcademicInstitution;
		}

		public ICollection<User> getFriendsFromChosenEvent(string i_EventName)
		{
			List<User> friendsFromChosenEvent = new List<User>();

			foreach (User user in FriendsFromStartPoint)
			{
				for (int eventIndex = 0; eventIndex < user.Events.Count; ++eventIndex)
				{
					if (user.Events[eventIndex].Name.Equals(i_EventName))
					{
						friendsFromChosenEvent.Add(user);
					}
				}
			}

			return friendsFromChosenEvent;
		}
	}
}
