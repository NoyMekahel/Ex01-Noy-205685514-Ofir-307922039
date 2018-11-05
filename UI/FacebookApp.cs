﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;

namespace UI
{
	public partial class FacebookApp : Form
	{
		public FacebookApp()
		{
			InitializeComponent();
			showHomePage();
		}

		private void showHomePage()
		{
			homePanel = new HomePanel();
			this.mainPanel.Controls.Add(this.homePanel);
			this.homePanel.ResumeLayout(false);
			this.homePanel.PerformLayout();
			this.homePanel.findARideButton_AddListener(new EventHandler(findARideButton_Click));
		}

		private void findARideButton_Click(object sender, EventArgs e)
		{
			if (findARidePanel == null)
			{
				findARidePanel = new FindARidePanel();
				this.findARidePanel.backButton_AddListener(new EventHandler(backButton_Click));
				findARidePanel.CreateLocationsList();
			}
			mainPanel.Controls.Clear();
			mainPanel.Controls.Add(findARidePanel);
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			mainPanel.Controls.Clear();
			mainPanel.Controls.Add(homePanel);
		}



		public static void showFacebookError()
		{
			MessageBox.Show("An error has occured. Couldn't retrieve the requested information from facebook");
		}

		private HomePanel homePanel;
		private FindARidePanel findARidePanel;
	}
}