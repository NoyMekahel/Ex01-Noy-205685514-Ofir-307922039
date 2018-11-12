using System.Windows.Forms;

namespace UI
{
	partial class RidePageControl
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
			this.fromLocationLabel = new System.Windows.Forms.Label();
			this.eventsComboBox = new System.Windows.Forms.ComboBox();
			this.locationsListBox = new System.Windows.Forms.ListBox();
			this.eventButton = new System.Windows.Forms.Button();
			this.workButton = new System.Windows.Forms.Button();
			this.academicInstitutionButton = new System.Windows.Forms.Button();
			this.academicComboBox = new System.Windows.Forms.ComboBox();
			this.workComboBox = new System.Windows.Forms.ComboBox();
			this.bindingSourceRideFriendsGrid = new System.Windows.Forms.BindingSource(this.components);
			this.filterControl = new UI.FilterControl();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceRideFriendsGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// fromLocationLabel
			// 
			this.fromLocationLabel.AutoSize = true;
			this.fromLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.fromLocationLabel.Location = new System.Drawing.Point(13, 36);
			this.fromLocationLabel.Name = "fromLocationLabel";
			this.fromLocationLabel.Size = new System.Drawing.Size(168, 20);
			this.fromLocationLabel.TabIndex = 29;
			this.fromLocationLabel.Text = "Choose Starting Point:";
			// 
			// eventsComboBox
			// 
			this.eventsComboBox.Enabled = false;
			this.eventsComboBox.FormattingEnabled = true;
			this.eventsComboBox.Location = new System.Drawing.Point(420, 492);
			this.eventsComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.eventsComboBox.Name = "eventsComboBox";
			this.eventsComboBox.Size = new System.Drawing.Size(187, 21);
			this.eventsComboBox.TabIndex = 28;
			this.eventsComboBox.SelectedIndexChanged += new System.EventHandler(this.eventsComboBox_SelectedIndexChanged);
			// 
			// locationsListBox
			// 
			this.locationsListBox.FormattingEnabled = true;
			this.locationsListBox.Location = new System.Drawing.Point(13, 61);
			this.locationsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.locationsListBox.Name = "locationsListBox";
			this.locationsListBox.Size = new System.Drawing.Size(187, 355);
			this.locationsListBox.TabIndex = 25;
			this.locationsListBox.SelectedIndexChanged += new System.EventHandler(this.locationsListBox_SelectedIndexChanged);
			// 
			// eventButton
			// 
			this.eventButton.Enabled = false;
			this.eventButton.Location = new System.Drawing.Point(420, 460);
			this.eventButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.eventButton.Name = "eventButton";
			this.eventButton.Size = new System.Drawing.Size(187, 22);
			this.eventButton.TabIndex = 24;
			this.eventButton.Text = "Ride To Your Event";
			this.eventButton.UseVisualStyleBackColor = true;
			this.eventButton.Click += new System.EventHandler(this.eventButton_Click);
			// 
			// workButton
			// 
			this.workButton.Enabled = false;
			this.workButton.Location = new System.Drawing.Point(216, 460);
			this.workButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.workButton.Name = "workButton";
			this.workButton.Size = new System.Drawing.Size(187, 22);
			this.workButton.TabIndex = 23;
			this.workButton.Text = "Ride To Your Work";
			this.workButton.UseVisualStyleBackColor = true;
			this.workButton.Click += new System.EventHandler(this.workButton_Click);
			// 
			// academicInstitutionButton
			// 
			this.academicInstitutionButton.Enabled = false;
			this.academicInstitutionButton.Location = new System.Drawing.Point(13, 460);
			this.academicInstitutionButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.academicInstitutionButton.Name = "academicInstitutionButton";
			this.academicInstitutionButton.Size = new System.Drawing.Size(187, 22);
			this.academicInstitutionButton.TabIndex = 22;
			this.academicInstitutionButton.Text = "Ride To Your Academic Institution";
			this.academicInstitutionButton.UseVisualStyleBackColor = true;
			this.academicInstitutionButton.Click += new System.EventHandler(this.academicInstitutionButton_Click);
			// 
			// academicComboBox
			// 
			this.academicComboBox.Enabled = false;
			this.academicComboBox.FormattingEnabled = true;
			this.academicComboBox.Location = new System.Drawing.Point(13, 492);
			this.academicComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.academicComboBox.Name = "academicComboBox";
			this.academicComboBox.Size = new System.Drawing.Size(187, 21);
			this.academicComboBox.TabIndex = 31;
			this.academicComboBox.SelectedIndexChanged += new System.EventHandler(this.academicComboBox_SelectedIndexChanged);
			// 
			// workComboBox
			// 
			this.workComboBox.Enabled = false;
			this.workComboBox.FormattingEnabled = true;
			this.workComboBox.Location = new System.Drawing.Point(216, 492);
			this.workComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.workComboBox.Name = "workComboBox";
			this.workComboBox.Size = new System.Drawing.Size(187, 21);
			this.workComboBox.TabIndex = 32;
			this.workComboBox.SelectedIndexChanged += new System.EventHandler(this.workComboBox_SelectedIndexChanged);
			// 
			// bindingSourceRideFriendsGrid
			// 
			this.bindingSourceRideFriendsGrid.DataSource = typeof(FacebookWrapper.ObjectModel.User);
			// 
			// filterControl
			// 
			this.filterControl.Location = new System.Drawing.Point(205, 42);
			this.filterControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.filterControl.Name = "filterControl";
			this.filterControl.Size = new System.Drawing.Size(426, 406);
			this.filterControl.TabIndex = 33;
			this.filterControl.Visible = false;
			// 
			// RidePageControl
			// 
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.filterControl);
			this.Controls.Add(this.workComboBox);
			this.Controls.Add(this.academicComboBox);
			this.Controls.Add(this.fromLocationLabel);
			this.Controls.Add(this.eventsComboBox);
			this.Controls.Add(this.locationsListBox);
			this.Controls.Add(this.eventButton);
			this.Controls.Add(this.workButton);
			this.Controls.Add(this.academicInstitutionButton);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "RidePageControl";
			this.Size = new System.Drawing.Size(636, 628);
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceRideFriendsGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}


		private Label fromLocationLabel;
		private ComboBox eventsComboBox;
		private ListBox locationsListBox;
		private Button eventButton;
		private Button workButton;
		private Button academicInstitutionButton;
		private ComboBox academicComboBox;
		private ComboBox workComboBox;
		private BindingSource bindingSourceRideFriendsGrid;

		#endregion

		private FilterControl filterControl;
	}
}
