using FacebookWrapper.ObjectModel;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
	/*
	public class FindARidePanel : Panel
	{
		private System.ComponentModel.IContainer components = null;
		private Button backButton;
		private Label fromLocationLabel;
		private ComboBox eventsComboBox;
		private ListBox locationsListBox;
		private Button eventButton;
		private Button workButton;
		private Button academicInstitutionButton;
		private ComboBox academicComboBox;
		private ComboBox workComboBox;
		private DataGridView friendsResultDataGrid;
		private BindingSource bindingSourceRideFriendsGrid;
		private DataGridViewImageColumn imageSmallDataGridViewImageColumn;
		private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn AgeColunm;
		private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn relationshipStatusDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn religionDataGridViewTextBoxColumn;
		private GroupBox filterGroupBox;
		private Button FilterButton;
		private CheckBox ageCheckBox;
		private GroupBox ageGroupBox;
		private RadioButton age1RadioButton;
		private RadioButton age2RadioButton;
		private RadioButton age3RadioButton;
		private RadioButton age4RadioButton;
		private CheckBox genderCheckBox;
		private GroupBox GenderGroupBox;
		private RadioButton famaleRadioButton;
		private RadioButton maleRadioButton;
		private string m_RideFromLocationName;


		public FindARidePanel()
		{
			InitializeComponent();
			createLocationsList();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void createLocationsList()
		{
			ICollection<string> locationsCollection = DataManagerWrapper.DataManager.GetSortedFriendsLocation();


			foreach (string currentLocation in locationsCollection)
			{
				locationsListBox.Items.Add(currentLocation);
			}

			if (DataManagerWrapper.DataManager.GetWorkExperiences() != null)
			{
			}

			if (DataManagerWrapper.DataManager.GetEducations() != null)
			{
			}
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.backButton = new System.Windows.Forms.Button();
			this.fromLocationLabel = new System.Windows.Forms.Label();
			this.eventsComboBox = new System.Windows.Forms.ComboBox();
			this.locationsListBox = new System.Windows.Forms.ListBox();
			this.eventButton = new System.Windows.Forms.Button();
			this.workButton = new System.Windows.Forms.Button();
			this.academicInstitutionButton = new System.Windows.Forms.Button();
			this.academicComboBox = new System.Windows.Forms.ComboBox();
			this.workComboBox = new System.Windows.Forms.ComboBox();
			this.friendsResultDataGrid = new System.Windows.Forms.DataGridView();
			this.bindingSourceRideFriendsGrid = new System.Windows.Forms.BindingSource(this.components);
			this.filterGroupBox = new System.Windows.Forms.GroupBox();
			this.FilterButton = new System.Windows.Forms.Button();
			this.ageCheckBox = new System.Windows.Forms.CheckBox();
			this.ageGroupBox = new System.Windows.Forms.GroupBox();
			this.age1RadioButton = new System.Windows.Forms.RadioButton();
			this.age2RadioButton = new System.Windows.Forms.RadioButton();
			this.age3RadioButton = new System.Windows.Forms.RadioButton();
			this.age4RadioButton = new System.Windows.Forms.RadioButton();
			this.genderCheckBox = new System.Windows.Forms.CheckBox();
			this.GenderGroupBox = new System.Windows.Forms.GroupBox();
			this.famaleRadioButton = new System.Windows.Forms.RadioButton();
			this.maleRadioButton = new System.Windows.Forms.RadioButton();
			this.imageSmallDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AgeColunm = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.relationshipStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.religionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.friendsResultDataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceRideFriendsGrid)).BeginInit();
			this.filterGroupBox.SuspendLayout();
			this.ageGroupBox.SuspendLayout();
			this.GenderGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// backButton
			// 
			this.backButton.Location = new System.Drawing.Point(13, 745);
			this.backButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(112, 35);
			this.backButton.TabIndex = 30;
			this.backButton.Text = "<- Back";
			this.backButton.UseVisualStyleBackColor = true;
			// 
			// fromLocationLabel
			// 
			this.fromLocationLabel.AutoSize = true;
			this.fromLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.fromLocationLabel.Location = new System.Drawing.Point(14, 9);
			this.fromLocationLabel.Name = "fromLocationLabel";
			this.fromLocationLabel.Size = new System.Drawing.Size(252, 29);
			this.fromLocationLabel.TabIndex = 29;
			this.fromLocationLabel.Text = "Choose Starting Point:";
			// 
			// eventsComboBox
			// 
			this.eventsComboBox.Enabled = false;
			this.eventsComboBox.FormattingEnabled = true;
			this.eventsComboBox.Location = new System.Drawing.Point(493, 634);
			this.eventsComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.eventsComboBox.Name = "eventsComboBox";
			this.eventsComboBox.Size = new System.Drawing.Size(223, 28);
			this.eventsComboBox.TabIndex = 28;
			this.eventsComboBox.SelectedIndexChanged += new System.EventHandler(this.eventsComboBox_SelectedIndexChanged);
			// 
			// locationsListBox
			// 
			this.locationsListBox.FormattingEnabled = true;
			this.locationsListBox.ItemHeight = 20;
			this.locationsListBox.Location = new System.Drawing.Point(13, 43);
			this.locationsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.locationsListBox.Name = "locationsListBox";
			this.locationsListBox.Size = new System.Drawing.Size(253, 524);
			this.locationsListBox.TabIndex = 25;
			this.locationsListBox.SelectedIndexChanged += new System.EventHandler(this.locationsListBox_SelectedIndexChanged);
			// 
			// eventButton
			// 
			this.eventButton.Enabled = false;
			this.eventButton.Location = new System.Drawing.Point(493, 589);
			this.eventButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.eventButton.Name = "eventButton";
			this.eventButton.Size = new System.Drawing.Size(223, 35);
			this.eventButton.TabIndex = 24;
			this.eventButton.Text = "Ride To An Event";
			this.eventButton.UseVisualStyleBackColor = true;
			this.eventButton.Click += new System.EventHandler(this.eventButton_Click);
			// 
			// workButton
			// 
			this.workButton.Enabled = false;
			this.workButton.Location = new System.Drawing.Point(253, 589);
			this.workButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.workButton.Name = "workButton";
			this.workButton.Size = new System.Drawing.Size(223, 35);
			this.workButton.TabIndex = 23;
			this.workButton.Text = "Ride To Work";
			this.workButton.UseVisualStyleBackColor = true;
			this.workButton.Click += new System.EventHandler(this.workButton_Click);
			// 
			// academicInstitutionButton
			// 
			this.academicInstitutionButton.Enabled = false;
			this.academicInstitutionButton.Location = new System.Drawing.Point(13, 589);
			this.academicInstitutionButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.academicInstitutionButton.Name = "academicInstitutionButton";
			this.academicInstitutionButton.Size = new System.Drawing.Size(223, 35);
			this.academicInstitutionButton.TabIndex = 22;
			this.academicInstitutionButton.Text = "Ride To Academic Institution";
			this.academicInstitutionButton.UseVisualStyleBackColor = true;
			this.academicInstitutionButton.Click += new System.EventHandler(this.academicInstitutionButton_Click);
			// 
			// academicComboBox
			// 
			this.academicComboBox.Enabled = false;
			this.academicComboBox.FormattingEnabled = true;
			this.academicComboBox.Location = new System.Drawing.Point(13, 634);
			this.academicComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.academicComboBox.Name = "academicComboBox";
			this.academicComboBox.Size = new System.Drawing.Size(223, 28);
			this.academicComboBox.TabIndex = 31;
			this.academicComboBox.SelectedIndexChanged += new System.EventHandler(this.academicComboBox_SelectedIndexChanged);
			// 
			// workComboBox
			// 
			this.workComboBox.Enabled = false;
			this.workComboBox.FormattingEnabled = true;
			this.workComboBox.Location = new System.Drawing.Point(253, 634);
			this.workComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.workComboBox.Name = "workComboBox";
			this.workComboBox.Size = new System.Drawing.Size(223, 28);
			this.workComboBox.TabIndex = 32;
			this.workComboBox.SelectedIndexChanged += new System.EventHandler(this.workComboBox_SelectedIndexChanged);
			// 
			// friendsResultDataGrid
			// 
			this.friendsResultDataGrid.AllowUserToAddRows = false;
			this.friendsResultDataGrid.AllowUserToDeleteRows = false;
			this.friendsResultDataGrid.AllowUserToOrderColumns = true;
			this.friendsResultDataGrid.AllowUserToResizeRows = false;
			this.friendsResultDataGrid.AutoGenerateColumns = false;
			this.friendsResultDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.friendsResultDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.imageSmallDataGridViewImageColumn,
			this.nameDataGridViewTextBoxColumn,
			this.genderDataGridViewTextBoxColumn,
			this.AgeColunm,
			this.relationshipStatusDataGridViewTextBoxColumn,
			this.religionDataGridViewTextBoxColumn});
			this.friendsResultDataGrid.DataSource = this.bindingSourceRideFriendsGrid;
			this.friendsResultDataGrid.Location = new System.Drawing.Point(279, 43);
			this.friendsResultDataGrid.Name = "friendsResultDataGrid";
			this.friendsResultDataGrid.RowTemplate.Height = 28;
			this.friendsResultDataGrid.Size = new System.Drawing.Size(437, 377);
			this.friendsResultDataGrid.TabIndex = 33;
			this.friendsResultDataGrid.Visible = false;
			// 
			// bindingSourceRideFriendsGrid
			// 
			this.bindingSourceRideFriendsGrid.DataSource = typeof(FacebookWrapper.ObjectModel.User);
			// 
			// filterGroupBox
			// 
			this.filterGroupBox.Controls.Add(this.FilterButton);
			this.filterGroupBox.Controls.Add(this.ageCheckBox);
			this.filterGroupBox.Controls.Add(this.ageGroupBox);
			this.filterGroupBox.Controls.Add(this.genderCheckBox);
			this.filterGroupBox.Controls.Add(this.GenderGroupBox);
			this.filterGroupBox.Location = new System.Drawing.Point(279, 426);
			this.filterGroupBox.Name = "filterGroupBox";
			this.filterGroupBox.Size = new System.Drawing.Size(438, 141);
			this.filterGroupBox.TabIndex = 48;
			this.filterGroupBox.TabStop = false;
			this.filterGroupBox.Visible = false;
			// 
			// FilterButton
			// 
			this.FilterButton.Enabled = false;
			this.FilterButton.Location = new System.Drawing.Point(186, 100);
			this.FilterButton.Name = "FilterButton";
			this.FilterButton.Size = new System.Drawing.Size(75, 30);
			this.FilterButton.TabIndex = 52;
			this.FilterButton.Text = "Filter";
			this.FilterButton.UseVisualStyleBackColor = true;
			// 
			// ageCheckBox
			// 
			this.ageCheckBox.AutoSize = true;
			this.ageCheckBox.Location = new System.Drawing.Point(10, 66);
			this.ageCheckBox.Name = "ageCheckBox";
			this.ageCheckBox.Size = new System.Drawing.Size(64, 24);
			this.ageCheckBox.TabIndex = 51;
			this.ageCheckBox.Text = "Age";
			this.ageCheckBox.UseVisualStyleBackColor = true;
			// 
			// ageGroupBox
			// 
			this.ageGroupBox.Controls.Add(this.age1RadioButton);
			this.ageGroupBox.Controls.Add(this.age2RadioButton);
			this.ageGroupBox.Controls.Add(this.age3RadioButton);
			this.ageGroupBox.Controls.Add(this.age4RadioButton);
			this.ageGroupBox.Location = new System.Drawing.Point(99, 53);
			this.ageGroupBox.Name = "ageGroupBox";
			this.ageGroupBox.Size = new System.Drawing.Size(333, 41);
			this.ageGroupBox.TabIndex = 49;
			this.ageGroupBox.TabStop = false;
			this.ageGroupBox.Visible = false;
			// 
			// age1RadioButton
			// 
			this.age1RadioButton.AutoSize = true;
			this.age1RadioButton.Checked = true;
			this.age1RadioButton.Location = new System.Drawing.Point(6, 13);
			this.age1RadioButton.Name = "age1RadioButton";
			this.age1RadioButton.Size = new System.Drawing.Size(75, 24);
			this.age1RadioButton.TabIndex = 38;
			this.age1RadioButton.TabStop = true;
			this.age1RadioButton.Text = "16-20";
			this.age1RadioButton.UseVisualStyleBackColor = true;
			// 
			// age2RadioButton
			// 
			this.age2RadioButton.AutoSize = true;
			this.age2RadioButton.Location = new System.Drawing.Point(87, 13);
			this.age2RadioButton.Name = "age2RadioButton";
			this.age2RadioButton.Size = new System.Drawing.Size(75, 24);
			this.age2RadioButton.TabIndex = 39;
			this.age2RadioButton.Text = "20-30";
			this.age2RadioButton.UseVisualStyleBackColor = true;
			// 
			// age3RadioButton
			// 
			this.age3RadioButton.AutoSize = true;
			this.age3RadioButton.Location = new System.Drawing.Point(168, 13);
			this.age3RadioButton.Name = "age3RadioButton";
			this.age3RadioButton.Size = new System.Drawing.Size(75, 24);
			this.age3RadioButton.TabIndex = 40;
			this.age3RadioButton.Text = "30-40";
			this.age3RadioButton.UseVisualStyleBackColor = true;
			// 
			// age4RadioButton
			// 
			this.age4RadioButton.AutoSize = true;
			this.age4RadioButton.Location = new System.Drawing.Point(249, 13);
			this.age4RadioButton.Name = "age4RadioButton";
			this.age4RadioButton.Size = new System.Drawing.Size(61, 24);
			this.age4RadioButton.TabIndex = 41;
			this.age4RadioButton.Text = "40+";
			this.age4RadioButton.UseVisualStyleBackColor = true;
			// 
			// genderCheckBox
			// 
			this.genderCheckBox.AutoSize = true;
			this.genderCheckBox.Location = new System.Drawing.Point(10, 23);
			this.genderCheckBox.Name = "genderCheckBox";
			this.genderCheckBox.Size = new System.Drawing.Size(89, 24);
			this.genderCheckBox.TabIndex = 50;
			this.genderCheckBox.Text = "Gender";
			this.genderCheckBox.UseVisualStyleBackColor = true;
			// 
			// GenderGroupBox
			// 
			this.GenderGroupBox.Controls.Add(this.famaleRadioButton);
			this.GenderGroupBox.Controls.Add(this.maleRadioButton);
			this.GenderGroupBox.Location = new System.Drawing.Point(99, 10);
			this.GenderGroupBox.Name = "GenderGroupBox";
			this.GenderGroupBox.Size = new System.Drawing.Size(177, 42);
			this.GenderGroupBox.TabIndex = 48;
			this.GenderGroupBox.TabStop = false;
			this.GenderGroupBox.Visible = false;
			// 
			// famaleRadioButton
			// 
			this.famaleRadioButton.AutoSize = true;
			this.famaleRadioButton.Location = new System.Drawing.Point(87, 13);
			this.famaleRadioButton.Name = "famaleRadioButton";
			this.famaleRadioButton.Size = new System.Drawing.Size(87, 24);
			this.famaleRadioButton.TabIndex = 35;
			this.famaleRadioButton.Text = "Famale";
			this.famaleRadioButton.UseVisualStyleBackColor = true;
			// 
			// maleRadioButton
			// 
			this.maleRadioButton.AutoSize = true;
			this.maleRadioButton.Checked = true;
			this.maleRadioButton.Location = new System.Drawing.Point(6, 13);
			this.maleRadioButton.Name = "maleRadioButton";
			this.maleRadioButton.Size = new System.Drawing.Size(68, 24);
			this.maleRadioButton.TabIndex = 36;
			this.maleRadioButton.TabStop = true;
			this.maleRadioButton.Text = "Male";
			this.maleRadioButton.UseVisualStyleBackColor = true;
			// 
			// imageSmallDataGridViewImageColumn
			// 
			this.imageSmallDataGridViewImageColumn.DataPropertyName = "ImageSmall";
			this.imageSmallDataGridViewImageColumn.HeaderText = "Image";
			this.imageSmallDataGridViewImageColumn.Name = "imageSmallDataGridViewImageColumn";
			this.imageSmallDataGridViewImageColumn.ReadOnly = true;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// genderDataGridViewTextBoxColumn
			// 
			this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
			this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
			this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
			this.genderDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// AgeColunm
			// 
			this.AgeColunm.HeaderText = "Age";
			this.AgeColunm.Name = "AgeColunm";
			// 
			// relationshipStatusDataGridViewTextBoxColumn
			// 
			this.relationshipStatusDataGridViewTextBoxColumn.DataPropertyName = "RelationshipStatus";
			this.relationshipStatusDataGridViewTextBoxColumn.HeaderText = "RelationshipStatus";
			this.relationshipStatusDataGridViewTextBoxColumn.Name = "relationshipStatusDataGridViewTextBoxColumn";
			this.relationshipStatusDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// religionDataGridViewTextBoxColumn
			// 
			this.religionDataGridViewTextBoxColumn.DataPropertyName = "Religion";
			this.religionDataGridViewTextBoxColumn.HeaderText = "Religion";
			this.religionDataGridViewTextBoxColumn.Name = "religionDataGridViewTextBoxColumn";
			this.religionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// findARideUI
			// 
			this.ClientSize = new System.Drawing.Size(728, 793);
			this.Controls.Add(this.filterGroupBox);
			this.Controls.Add(this.friendsResultDataGrid);
			this.Controls.Add(this.workComboBox);
			this.Controls.Add(this.academicComboBox);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.fromLocationLabel);
			this.Controls.Add(this.eventsComboBox);
			this.Controls.Add(this.locationsListBox);
			this.Controls.Add(this.eventButton);
			this.Controls.Add(this.workButton);
			this.Controls.Add(this.academicInstitutionButton);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			((System.ComponentModel.ISupportInitialize)(this.friendsResultDataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceRideFriendsGrid)).EndInit();
			this.filterGroupBox.ResumeLayout(false);
			this.filterGroupBox.PerformLayout();
			this.ageGroupBox.ResumeLayout(false);
			this.ageGroupBox.PerformLayout();
			this.GenderGroupBox.ResumeLayout(false);
			this.GenderGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void eventButton_Click(object sender, EventArgs e)
		{
			eventsComboBox.Enabled = true;
			ICollection<string> allEventsNames = DataManagerWrapper.DataManager.GetEventsNames();

			foreach (string currEventName in allEventsNames)
			{
				eventsComboBox.Items.Add(currEventName);
			}
		}

		private void eventsComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			visibleTableAndFilter();

			try
			{
				ICollection<User> allFriendsFromStartPoint = DataManagerWrapper.DataManager.Ride.getFriendsFromChosenEvent((sender as ComboBox).SelectedItem.ToString());
				fillFriendsResultDataTable(allFriendsFromStartPoint);
			}
			catch (Exception)
			{
				FacebookApp.showFacebookError();
			}
		}

		private void workButton_Click(object sender, EventArgs e)
		{
			workComboBox.Enabled = true;
			ICollection<string> allWorkPlacesNames = DataManagerWrapper.DataManager.GetWorkPlacesNames();

			foreach (string currWorkPlaceName in allWorkPlacesNames)
			{
				workComboBox.Items.Add(currWorkPlaceName);
			}
		}

		private void workComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			visibleTableAndFilter();

			try
			{
				ICollection<User> allFriendsFromStartPoint = DataManagerWrapper.DataManager.Ride.getFriendsFromWork((sender as ComboBox).SelectedItem.ToString());
				fillFriendsResultDataTable(allFriendsFromStartPoint);
			}
			catch (Exception)
			{
				FacebookApp.showFacebookError();
			}
		}

		private void academicInstitutionButton_Click(object sender, EventArgs e)
		{
			academicComboBox.Enabled = true;
			ICollection<string> allAcademicInstitutionsNames = DataManagerWrapper.DataManager.GetAcademicInstitutionsNames();

			foreach (string currAcademicInstitution in allAcademicInstitutionsNames)
			{
				academicComboBox.Items.Add(currAcademicInstitution);
			}
		}

		private void academicComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			visibleTableAndFilter();

			try
			{
				ICollection<User> allFriendsFromStartPoint = DataManagerWrapper.DataManager.Ride.getFriendsFromAcademicInstitution((sender as ComboBox).SelectedItem.ToString());
				fillFriendsResultDataTable(allFriendsFromStartPoint);
			}
			catch (Exception)
			{
				FacebookApp.showFacebookError();
			}
		}

		private void genderCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if(genderCheckBox.Checked)
			{
				GenderGroupBox.Visible = true;
				FilterButton.Enabled = true;
			}
			else
			{
				GenderGroupBox.Visible = false;
				if(ageCheckBox.Checked == false)
				{
					FilterButton.Enabled = false;
				}
			}
		}

		private void ageCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (ageCheckBox.Checked)
			{
				ageGroupBox.Visible = true;
				FilterButton.Enabled = true;
			}
			else
			{
				ageGroupBox.Visible = false;
				if (genderCheckBox.Checked == false)
				{
					FilterButton.Enabled = false;
				}
			}
		}

		private void FilterButton_Click(object sender, EventArgs e)
		{
			if(genderCheckBox.Checked)
			{
				RadioButton genderPreferenceRadioButton = GenderGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
				DataManagerWrapper.DataManager.Ride.AddFilter(new GenderFilter(genderPreferenceRadioButton.Text));
			}

			if(ageCheckBox.Checked)
			{
				RadioButton agePreferenceRadioButton = ageGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
				DataManagerWrapper.DataManager.Ride.AddFilter(new AgeFilter(agePreferenceRadioButton.Text));
			}

			ICollection<User> friendsAfterFilter = DataManagerWrapper.DataManager.Ride.Filter();
			bindingSourceRideFriendsGrid.DataSource = friendsAfterFilter;
		}

		public void backButton_AddListener(EventHandler i_EventHandler)
		{
			this.backButton.Click += i_EventHandler;
		}

		private void locationsListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if ((sender as ListBox).SelectedItem != null)
			{
				m_RideFromLocationName = (sender as ListBox).SelectedItem.ToString();

				try
				{
					handlePageAfterStartPointSelected();
					DataManagerWrapper.DataManager.InitializeRide(m_RideFromLocationName);
				}
				catch (Exception ex)
				{
					FacebookApp.showFacebookError(ex.Message);
				}
			}
		}

		private void fillFriendsResultDataTable(ICollection<User> i_AllFriendsFromStartPoint)
		{
			bindingSourceRideFriendsGrid.DataSource = i_AllFriendsFromStartPoint;
			int counter = 0;
			foreach (User currentUser in i_AllFriendsFromStartPoint)
			{
				DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
				cell.Value = AgeFilter.GetAgeFromUserBirthday(currentUser.Birthday);
				friendsResultDataGrid.Rows[counter++].Cells[AgeColunm.Index] = cell;
			}
		}

		private void handlePageAfterStartPointSelected()
		{
			bool isFacebookError = false;
			string errorMessage = "Couldn't fetch the following data: " + Environment.NewLine;

			if (DataManagerWrapper.DataManager.GetEducations() != null)
			{
				academicInstitutionButton.Enabled = true;
			}
			else
			{
				isFacebookError = true;
				errorMessage += "Educations" + Environment.NewLine;
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

		private void visibleTableAndFilter()
		{
			friendsResultDataGrid.Visible = true;
			filterGroupBox.Visible = true;
		}
	}
	*/
}
