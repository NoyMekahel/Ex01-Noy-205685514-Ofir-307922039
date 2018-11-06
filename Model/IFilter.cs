using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
	public interface IFilter
	{
		ICollection<User> filter(ICollection<User> i_Friends);
	}
}
