using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace UI
{
	// Creating this class to able all the panels to use the most updated datamanager without holding an instance of it,
	// and the creator of this datamanager can only be the homePanel in which the login was preformed

	class DataManagerWrapper
	{
		public static DataManager DataManager { get; private set; }
		private static FacebookApp m_OwnerApp;

		internal static void setDataManager(FacebookApp i_FacebookApp, DataManager i_DataManager)
		{
			if(DataManager == null)
			{
				m_OwnerApp = i_FacebookApp;
			}

			if(m_OwnerApp == i_FacebookApp)
			{
				DataManager = i_DataManager;
			}
		}
	}
}
