﻿namespace A18_Ex01_Noy_205685514_Ofir_307922039
{
	partial class findARideUI
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
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
			this.imageSmallDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PhoneColunm = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.relationshipStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.religionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.filterGroupBox = new System.Windows.Forms.GroupBox();
			this.FilterButton = new System.Windows.Forms.Button();
			this.ageCheckBox = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.age1RadioButton = new System.Windows.Forms.RadioButton();
			this.age2RadioButton = new System.Windows.Forms.RadioButton();
			this.age3RadioButton = new System.Windows.Forms.RadioButton();
			this.age4RadioButton = new System.Windows.Forms.RadioButton();
			this.genderCheckBox = new System.Windows.Forms.CheckBox();
			this.GenderGroupBox = new System.Windows.Forms.GroupBox();
			this.famaleRadioButton = new System.Windows.Forms.RadioButton();
			this.maleRadioButton = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.friendsResultDataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceRideFriendsGrid)).BeginInit();
			this.filterGroupBox.SuspendLayout();
			this.groupBox1.SuspendLayout();
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
            this.PhoneColunm,
            this.genderDataGridViewTextBoxColumn,
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
			// PhoneColunm
			// 
			this.PhoneColunm.HeaderText = "Phone";
			this.PhoneColunm.Name = "PhoneColunm";
			// 
			// genderDataGridViewTextBoxColumn
			// 
			this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
			this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
			this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
			this.genderDataGridViewTextBoxColumn.ReadOnly = true;
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
			// filterGroupBox
			// 
			this.filterGroupBox.Controls.Add(this.FilterButton);
			this.filterGroupBox.Controls.Add(this.ageCheckBox);
			this.filterGroupBox.Controls.Add(this.groupBox1);
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
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.age1RadioButton);
			this.groupBox1.Controls.Add(this.age2RadioButton);
			this.groupBox1.Controls.Add(this.age3RadioButton);
			this.groupBox1.Controls.Add(this.age4RadioButton);
			this.groupBox1.Location = new System.Drawing.Point(99, 53);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(333, 41);
			this.groupBox1.TabIndex = 49;
			this.groupBox1.TabStop = false;
			this.groupBox1.Visible = false;
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
			// findARideUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(912, 980);
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
			this.Name = "findARideUI";
			this.Text = "Form2";
			((System.ComponentModel.ISupportInitialize)(this.friendsResultDataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceRideFriendsGrid)).EndInit();
			this.filterGroupBox.ResumeLayout(false);
			this.filterGroupBox.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.GenderGroupBox.ResumeLayout(false);
			this.GenderGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button backButton;
		private System.Windows.Forms.Label fromLocationLabel;
		private System.Windows.Forms.ComboBox eventsComboBox;
		private System.Windows.Forms.ListBox locationsListBox;
		private System.Windows.Forms.Button eventButton;
		private System.Windows.Forms.Button workButton;
		private System.Windows.Forms.Button academicInstitutionButton;
		private System.Windows.Forms.ComboBox academicComboBox;
		private System.Windows.Forms.ComboBox workComboBox;
		private System.Windows.Forms.DataGridView friendsResultDataGrid;
		private System.Windows.Forms.BindingSource bindingSourceRideFriendsGrid;
		private System.Windows.Forms.DataGridViewImageColumn imageSmallDataGridViewImageColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn PhoneColunm;
		private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn relationshipStatusDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn religionDataGridViewTextBoxColumn;
		private System.Windows.Forms.GroupBox filterGroupBox;
		private System.Windows.Forms.Button FilterButton;
		private System.Windows.Forms.CheckBox ageCheckBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton age1RadioButton;
		private System.Windows.Forms.RadioButton age2RadioButton;
		private System.Windows.Forms.RadioButton age3RadioButton;
		private System.Windows.Forms.RadioButton age4RadioButton;
		private System.Windows.Forms.CheckBox genderCheckBox;
		private System.Windows.Forms.GroupBox GenderGroupBox;
		private System.Windows.Forms.RadioButton famaleRadioButton;
		private System.Windows.Forms.RadioButton maleRadioButton;
	}
}