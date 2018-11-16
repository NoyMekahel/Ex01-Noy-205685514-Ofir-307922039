using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace Model
{
	public interface IFilter
	{
		ICollection<User> filter(ICollection<User> i_Friends);
	}
}
