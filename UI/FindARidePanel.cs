using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
	public class FindARidePanel : Panel
	{
		private System.Windows.Forms.Label fromLocationLabel;
		private System.Windows.Forms.ComboBox eventsComboBox;
		private System.Windows.Forms.Label workPlaceLabel;
		private System.Windows.Forms.Label academicInstitutionLabel;
		private System.Windows.Forms.ListBox locationsListBox;
		private System.Windows.Forms.Button eventButton;
		private System.Windows.Forms.Button workButton;
		private System.Windows.Forms.Button academicInstitutionButton;
		private System.Windows.Forms.Button backButton;
		private string m_RideFromLocationName;


		public FindARidePanel()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			this.backButton = new System.Windows.Forms.Button();
			this.fromLocationLabel = new System.Windows.Forms.Label();
			this.eventsComboBox = new System.Windows.Forms.ComboBox();
			this.workPlaceLabel = new System.Windows.Forms.Label();
			this.academicInstitutionLabel = new System.Windows.Forms.Label();
			this.academicInstitutionButton = new System.Windows.Forms.Button();
			this.locationsListBox = new System.Windows.Forms.ListBox();
			this.eventButton = new System.Windows.Forms.Button();
			this.workButton = new System.Windows.Forms.Button();
			SuspendLayout();

			// 
			// homePanel
			// 
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.fromLocationLabel);
			this.Controls.Add(this.eventsComboBox);
			this.Controls.Add(this.workPlaceLabel);
			this.Controls.Add(this.academicInstitutionLabel);
			this.Controls.Add(this.locationsListBox);
			this.Controls.Add(this.eventButton);
			this.Controls.Add(this.workButton);
			this.Controls.Add(this.academicInstitutionButton);
			Dock = System.Windows.Forms.DockStyle.Fill;
			Location = new System.Drawing.Point(0, 0);
			Name = "homePanel";
			Size = new System.Drawing.Size(600, 630);
			TabIndex = 0;
			// 
			// backButton
			// 
			this.backButton.Location = new System.Drawing.Point(35, 500);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(75, 23);
			this.backButton.TabIndex = 21;
			this.backButton.Text = "<- Back";
			this.backButton.UseVisualStyleBackColor = true;
			// 
			// fromLocationLabel
			// 
			this.fromLocationLabel.AutoSize = true;
			this.fromLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.fromLocationLabel.Location = new System.Drawing.Point(21, 34);
			this.fromLocationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.fromLocationLabel.Name = "fromLocationLabel";
			this.fromLocationLabel.Size = new System.Drawing.Size(45, 20);
			this.fromLocationLabel.TabIndex = 20;
			this.fromLocationLabel.Text = "Choose Starting Point:";
			// 
			// eventsComboBox
			// 
			this.eventsComboBox.Enabled = false;
			this.eventsComboBox.FormattingEnabled = true;
			this.eventsComboBox.Location = new System.Drawing.Point(35, 392);
			this.eventsComboBox.Name = "eventsComboBox";
			this.eventsComboBox.Size = new System.Drawing.Size(181, 21);
			this.eventsComboBox.TabIndex = 19;
			this.eventsComboBox.SelectedIndexChanged += new EventHandler(eventsComboBox_SelectedIndexChanged);

			// 
			// workPlaceLabel
			// 
			this.workPlaceLabel.AutoSize = true;
			this.workPlaceLabel.Location = new System.Drawing.Point(230, 339);
			this.workPlaceLabel.Name = "workPlaceLabel";
			this.workPlaceLabel.Size = new System.Drawing.Size(16, 13);
			this.workPlaceLabel.TabIndex = 18;
			this.workPlaceLabel.Text = "...";
			// 
			// academicInstitutionLabel
			// 
			this.academicInstitutionLabel.AutoSize = true;
			this.academicInstitutionLabel.Location = new System.Drawing.Point(230, 310);
			this.academicInstitutionLabel.Name = "academicInstitutionLabel";
			this.academicInstitutionLabel.Size = new System.Drawing.Size(16, 13);
			this.academicInstitutionLabel.TabIndex = 17;
			this.academicInstitutionLabel.Text = "...";
			// 
			// locationsListBox
			// 
			this.locationsListBox.FormattingEnabled = true;
			this.locationsListBox.Location = new System.Drawing.Point(35, 58);
			this.locationsListBox.Name = "locationsListBox";
			this.locationsListBox.Size = new System.Drawing.Size(181, 225);
			this.locationsListBox.TabIndex = 16;
			this.locationsListBox.SelectedIndexChanged += new EventHandler(locationsListBox_SelectedIndexChanged);

			// 
			// eventButton
			// 
			this.eventButton.Enabled = false;
			this.eventButton.Location = new System.Drawing.Point(35, 363);
			this.eventButton.Name = "eventButton";
			this.eventButton.Size = new System.Drawing.Size(167, 23);
			this.eventButton.TabIndex = 15;
			this.eventButton.Text = "Ride To An Event";
			this.eventButton.UseVisualStyleBackColor = true;
			this.eventButton.Click += new EventHandler(eventButton_click);
			// 
			// workButton
			// 
			this.workButton.Enabled = false;
			this.workButton.Location = new System.Drawing.Point(35, 334);
			this.workButton.Name = "workButton";
			this.workButton.Size = new System.Drawing.Size(167, 23);
			this.workButton.TabIndex = 14;
			this.workButton.Text = "Ride To Work";
			this.workButton.UseVisualStyleBackColor = true;
			// 
			// academicInstitutionButton
			// 
			this.academicInstitutionButton.Enabled = false;
			this.academicInstitutionButton.Location = new System.Drawing.Point(35, 305);
			this.academicInstitutionButton.Name = "academicInstitutionButton";
			this.academicInstitutionButton.Size = new System.Drawing.Size(167, 23);
			this.academicInstitutionButton.TabIndex = 13;
			this.academicInstitutionButton.Text = "Ride To Academic Institution";
			this.academicInstitutionButton.UseVisualStyleBackColor = true;


		}

		public void eventsComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		public void eventButton_click(object sender, EventArgs e)
		{
			eventsComboBox.Enabled = true;
			List<string> allEventsNames =  DataManagerWrapper.DataManager.GetEventsNames();

			foreach (string currEventName in allEventsNames)
			{
				eventsComboBox.Items.Add(currEventName);
			}
		}

		public void backButton_AddListener(EventHandler i_EventHandler)
		{
			this.backButton.Click += i_EventHandler;
		}

		private void locationsListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			m_RideFromLocationName = sender as string;

			bool isFacebookError = false;
			string errorMessage = "Couldn't fetch the following data: " + Environment.NewLine;
			try
			{
				if (DataManagerWrapper.DataManager.GetEducations() != null)
				{
					academicInstitutionButton.Enabled = true;
				}
				else
				{
					isFacebookError = true;
					errorMessage+= "Educations" + Environment.NewLine;
				}

				if (DataManagerWrapper.DataManager.GetEvents().Count > 0)
				{
					eventButton.Enabled = true;
				}
				else
				{
					eventsComboBox.Text = "No Upcoming Events!";
				}

				if (DataManagerWrapper.DataManager.GetWorkExperiences() != null)
				{
					workButton.Enabled = true;
				}
				else
				{
					errorMessage += "Work" + Environment.NewLine;
					isFacebookError = true;
				}

				if (isFacebookError)
				{
					FacebookApp.showFacebookError(errorMessage);
				}
			}
			catch (Exception ex)
			{
				FacebookApp.showFacebookError(ex.Message);
			}
		}

		public void CreateLocationsList()
		{
			ISet<string> locationsSet = DataManagerWrapper.DataManager.GetSortedFriendsLocation();


			foreach (string currentLocation in locationsSet)
			{
				locationsListBox.Items.Add(currentLocation);
			}

			if (DataManagerWrapper.DataManager.GetWorkExperiences() != null)
			{
				workPlaceLabel.Text = DataManagerWrapper.DataManager.GetWorkExperiences()[0].Location.Name;
			}

			if (DataManagerWrapper.DataManager.GetEducations() != null)
			{
				academicInstitutionLabel.Text = DataManagerWrapper.DataManager.GetEducations()[0].School.Name;
			}
		}
	}
}
