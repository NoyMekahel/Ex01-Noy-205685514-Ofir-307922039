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
		private static HomePanel m_OwnerPanel;

		internal static void setDataManager(HomePanel i_HomePanel, DataManager i_DataManager)
		{
			if(DataManager == null)
			{
				m_OwnerPanel = i_HomePanel;
			}

			if(m_OwnerPanel == i_HomePanel)
			{
				DataManager = i_DataManager;
			}
		}
	}
}
