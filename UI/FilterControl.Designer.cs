namespace UI
{
	partial class FilterControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterControl));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.friendsResultDataGrid = new System.Windows.Forms.DataGridView();
			this.bindingSourceRideFriendsGrid = new System.Windows.Forms.BindingSource(this.components);
			this.maleRadioButton = new System.Windows.Forms.RadioButton();
			this.famaleRadioButton = new System.Windows.Forms.RadioButton();
			this.GenderGroupBox = new System.Windows.Forms.GroupBox();
			this.genderCheckBox = new System.Windows.Forms.CheckBox();
			this.age4RadioButton = new System.Windows.Forms.RadioButton();
			this.age3RadioButton = new System.Windows.Forms.RadioButton();
			this.age2RadioButton = new System.Windows.Forms.RadioButton();
			this.age1RadioButton = new System.Windows.Forms.RadioButton();
			this.ageGroupBox = new System.Windows.Forms.GroupBox();
			this.ageCheckBox = new System.Windows.Forms.CheckBox();
			this.FilterButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.imageSmallDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AgeColunm = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.relationshipStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.religionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.friendsResultDataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceRideFriendsGrid)).BeginInit();
			this.GenderGroupBox.SuspendLayout();
			this.ageGroupBox.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
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
			this.friendsResultDataGrid.Location = new System.Drawing.Point(17, 19);
			this.friendsResultDataGrid.Name = "friendsResultDataGrid";
			this.friendsResultDataGrid.RowTemplate.Height = 28;
			this.friendsResultDataGrid.Size = new System.Drawing.Size(397, 256);
			this.friendsResultDataGrid.TabIndex = 49;
			// 
			// bindingSourceRideFriendsGrid
			// 
			this.bindingSourceRideFriendsGrid.DataSource = typeof(FacebookWrapper.ObjectModel.User);
			// 
			// maleRadioButton
			// 
			this.maleRadioButton.AutoSize = true;
			this.maleRadioButton.Checked = true;
			this.maleRadioButton.Location = new System.Drawing.Point(6, 13);
			this.maleRadioButton.Name = "maleRadioButton";
			this.maleRadioButton.Size = new System.Drawing.Size(48, 17);
			this.maleRadioButton.TabIndex = 36;
			this.maleRadioButton.TabStop = true;
			this.maleRadioButton.Text = "Male";
			this.maleRadioButton.UseVisualStyleBackColor = true;
			// 
			// famaleRadioButton
			// 
			this.famaleRadioButton.AutoSize = true;
			this.famaleRadioButton.Location = new System.Drawing.Point(87, 13);
			this.famaleRadioButton.Name = "famaleRadioButton";
			this.famaleRadioButton.Size = new System.Drawing.Size(59, 17);
			this.famaleRadioButton.TabIndex = 35;
			this.famaleRadioButton.Text = "Famale";
			this.famaleRadioButton.UseVisualStyleBackColor = true;
			// 
			// GenderGroupBox
			// 
			this.GenderGroupBox.Controls.Add(this.famaleRadioButton);
			this.GenderGroupBox.Controls.Add(this.maleRadioButton);
			this.GenderGroupBox.Location = new System.Drawing.Point(81, 3);
			this.GenderGroupBox.Name = "GenderGroupBox";
			this.GenderGroupBox.Size = new System.Drawing.Size(177, 34);
			this.GenderGroupBox.TabIndex = 48;
			this.GenderGroupBox.TabStop = false;
			this.GenderGroupBox.Visible = false;
			// 
			// genderCheckBox
			// 
			this.genderCheckBox.AutoSize = true;
			this.genderCheckBox.Location = new System.Drawing.Point(14, 17);
			this.genderCheckBox.Name = "genderCheckBox";
			this.genderCheckBox.Size = new System.Drawing.Size(61, 17);
			this.genderCheckBox.TabIndex = 50;
			this.genderCheckBox.Text = "Gender";
			this.genderCheckBox.UseVisualStyleBackColor = true;
			this.genderCheckBox.CheckedChanged += new System.EventHandler(this.genderCheckBox_CheckedChanged);
			// 
			// age4RadioButton
			// 
			this.age4RadioButton.AutoSize = true;
			this.age4RadioButton.Location = new System.Drawing.Point(249, 13);
			this.age4RadioButton.Name = "age4RadioButton";
			this.age4RadioButton.Size = new System.Drawing.Size(43, 17);
			this.age4RadioButton.TabIndex = 41;
			this.age4RadioButton.Text = "40+";
			this.age4RadioButton.UseVisualStyleBackColor = true;
			// 
			// age3RadioButton
			// 
			this.age3RadioButton.AutoSize = true;
			this.age3RadioButton.Location = new System.Drawing.Point(168, 13);
			this.age3RadioButton.Name = "age3RadioButton";
			this.age3RadioButton.Size = new System.Drawing.Size(52, 17);
			this.age3RadioButton.TabIndex = 40;
			this.age3RadioButton.Text = "30-40";
			this.age3RadioButton.UseVisualStyleBackColor = true;
			// 
			// age2RadioButton
			// 
			this.age2RadioButton.AutoSize = true;
			this.age2RadioButton.Location = new System.Drawing.Point(87, 13);
			this.age2RadioButton.Name = "age2RadioButton";
			this.age2RadioButton.Size = new System.Drawing.Size(52, 17);
			this.age2RadioButton.TabIndex = 39;
			this.age2RadioButton.Text = "20-30";
			this.age2RadioButton.UseVisualStyleBackColor = true;
			// 
			// age1RadioButton
			// 
			this.age1RadioButton.AutoSize = true;
			this.age1RadioButton.Checked = true;
			this.age1RadioButton.Location = new System.Drawing.Point(6, 13);
			this.age1RadioButton.Name = "age1RadioButton";
			this.age1RadioButton.Size = new System.Drawing.Size(52, 17);
			this.age1RadioButton.TabIndex = 38;
			this.age1RadioButton.TabStop = true;
			this.age1RadioButton.Text = "16-20";
			this.age1RadioButton.UseVisualStyleBackColor = true;
			// 
			// ageGroupBox
			// 
			this.ageGroupBox.Controls.Add(this.age1RadioButton);
			this.ageGroupBox.Controls.Add(this.age2RadioButton);
			this.ageGroupBox.Controls.Add(this.age3RadioButton);
			this.ageGroupBox.Controls.Add(this.age4RadioButton);
			this.ageGroupBox.Location = new System.Drawing.Point(81, 43);
			this.ageGroupBox.Name = "ageGroupBox";
			this.ageGroupBox.Size = new System.Drawing.Size(297, 37);
			this.ageGroupBox.TabIndex = 49;
			this.ageGroupBox.TabStop = false;
			this.ageGroupBox.Visible = false;
			// 
			// ageCheckBox
			// 
			this.ageCheckBox.AutoSize = true;
			this.ageCheckBox.Location = new System.Drawing.Point(14, 57);
			this.ageCheckBox.Name = "ageCheckBox";
			this.ageCheckBox.Size = new System.Drawing.Size(45, 17);
			this.ageCheckBox.TabIndex = 51;
			this.ageCheckBox.Text = "Age";
			this.ageCheckBox.UseVisualStyleBackColor = true;
			this.ageCheckBox.CheckedChanged += new System.EventHandler(this.ageCheckBox_CheckedChanged);
			// 
			// FilterButton
			// 
			this.FilterButton.Enabled = false;
			this.FilterButton.Location = new System.Drawing.Point(168, 86);
			this.FilterButton.Name = "FilterButton";
			this.FilterButton.Size = new System.Drawing.Size(75, 30);
			this.FilterButton.TabIndex = 52;
			this.FilterButton.Text = "Filter";
			this.FilterButton.UseVisualStyleBackColor = true;
			this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.FilterButton);
			this.panel1.Controls.Add(this.genderCheckBox);
			this.panel1.Controls.Add(this.ageGroupBox);
			this.panel1.Controls.Add(this.ageCheckBox);
			this.panel1.Controls.Add(this.GenderGroupBox);
			this.panel1.Location = new System.Drawing.Point(17, 281);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(397, 127);
			this.panel1.TabIndex = 51;
			// 
			// imageSmallDataGridViewImageColumn
			// 
			this.imageSmallDataGridViewImageColumn.DataPropertyName = "ImageSmall";
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
			this.imageSmallDataGridViewImageColumn.DefaultCellStyle = dataGridViewCellStyle1;
			this.imageSmallDataGridViewImageColumn.HeaderText = "Image";
			this.imageSmallDataGridViewImageColumn.Name = "imageSmallDataGridViewImageColumn";
			this.imageSmallDataGridViewImageColumn.ReadOnly = true;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// genderDataGridViewTextBoxColumn
			// 
			this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			this.genderDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
			this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
			this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
			this.genderDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// AgeColunm
			// 
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			this.AgeColunm.DefaultCellStyle = dataGridViewCellStyle4;
			this.AgeColunm.HeaderText = "Age";
			this.AgeColunm.Name = "AgeColunm";
			// 
			// relationshipStatusDataGridViewTextBoxColumn
			// 
			this.relationshipStatusDataGridViewTextBoxColumn.DataPropertyName = "RelationshipStatus";
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			this.relationshipStatusDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
			this.relationshipStatusDataGridViewTextBoxColumn.HeaderText = "RelationshipStatus";
			this.relationshipStatusDataGridViewTextBoxColumn.Name = "relationshipStatusDataGridViewTextBoxColumn";
			this.relationshipStatusDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// religionDataGridViewTextBoxColumn
			// 
			this.religionDataGridViewTextBoxColumn.DataPropertyName = "Religion";
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			this.religionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
			this.religionDataGridViewTextBoxColumn.HeaderText = "Religion";
			this.religionDataGridViewTextBoxColumn.Name = "religionDataGridViewTextBoxColumn";
			this.religionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// FilterControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.friendsResultDataGrid);
			this.Name = "FilterControl";
			this.Size = new System.Drawing.Size(427, 421);
			((System.ComponentModel.ISupportInitialize)(this.friendsResultDataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceRideFriendsGrid)).EndInit();
			this.GenderGroupBox.ResumeLayout(false);
			this.GenderGroupBox.PerformLayout();
			this.ageGroupBox.ResumeLayout(false);
			this.ageGroupBox.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView friendsResultDataGrid;
		private System.Windows.Forms.RadioButton maleRadioButton;
		private System.Windows.Forms.RadioButton famaleRadioButton;
		private System.Windows.Forms.GroupBox GenderGroupBox;
		private System.Windows.Forms.CheckBox genderCheckBox;
		private System.Windows.Forms.RadioButton age4RadioButton;
		private System.Windows.Forms.RadioButton age3RadioButton;
		private System.Windows.Forms.RadioButton age2RadioButton;
		private System.Windows.Forms.RadioButton age1RadioButton;
		private System.Windows.Forms.GroupBox ageGroupBox;
		private System.Windows.Forms.CheckBox ageCheckBox;
		private System.Windows.Forms.Button FilterButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.BindingSource bindingSourceRideFriendsGrid;
		private System.Windows.Forms.DataGridViewImageColumn imageSmallDataGridViewImageColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn AgeColunm;
		private System.Windows.Forms.DataGridViewTextBoxColumn relationshipStatusDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn religionDataGridViewTextBoxColumn;
	}
}
