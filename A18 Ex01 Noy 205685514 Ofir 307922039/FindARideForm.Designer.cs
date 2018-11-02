namespace A18_Ex01_Noy_205685514_Ofir_307922039
{
	partial class FindARideForm
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
			this.m_AcademicInstitutionButton = new System.Windows.Forms.Button();
			this.m_WorkButton = new System.Windows.Forms.Button();
			this.m_EventButton = new System.Windows.Forms.Button();
			this.m_LocationsListBox = new System.Windows.Forms.ListBox();
			this.m_AcademicInstitutionLabel = new System.Windows.Forms.Label();
			this.m_WorkPlaceLabel = new System.Windows.Forms.Label();
			this.m_EventsComboBox = new System.Windows.Forms.ComboBox();
			this.m_FromLocationLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// m_AcademicInstitutionButton
			// 
			this.m_AcademicInstitutionButton.Enabled = false;
			this.m_AcademicInstitutionButton.Location = new System.Drawing.Point(42, 438);
			this.m_AcademicInstitutionButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.m_AcademicInstitutionButton.Name = "m_AcademicInstitutionButton";
			this.m_AcademicInstitutionButton.Size = new System.Drawing.Size(250, 35);
			this.m_AcademicInstitutionButton.TabIndex = 0;
			this.m_AcademicInstitutionButton.Text = "Ride To Academic Institution";
			this.m_AcademicInstitutionButton.UseVisualStyleBackColor = true;
			this.m_AcademicInstitutionButton.Click += new System.EventHandler(this.AcademicInstitutionButton_Click);
			// 
			// m_WorkButton
			// 
			this.m_WorkButton.Enabled = false;
			this.m_WorkButton.Location = new System.Drawing.Point(42, 483);
			this.m_WorkButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.m_WorkButton.Name = "m_WorkButton";
			this.m_WorkButton.Size = new System.Drawing.Size(250, 35);
			this.m_WorkButton.TabIndex = 1;
			this.m_WorkButton.Text = "Ride To Work";
			this.m_WorkButton.UseVisualStyleBackColor = true;
			this.m_WorkButton.Click += new System.EventHandler(this.m_WorkButton_Click);
			// 
			// m_EventButton
			// 
			this.m_EventButton.Enabled = false;
			this.m_EventButton.Location = new System.Drawing.Point(42, 528);
			this.m_EventButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.m_EventButton.Name = "m_EventButton";
			this.m_EventButton.Size = new System.Drawing.Size(250, 35);
			this.m_EventButton.TabIndex = 2;
			this.m_EventButton.Text = "Ride To An Event";
			this.m_EventButton.UseVisualStyleBackColor = true;
			this.m_EventButton.Click += new System.EventHandler(this.m_EventButton_Click);
			// 
			// m_LocationsListBox
			// 
			this.m_LocationsListBox.FormattingEnabled = true;
			this.m_LocationsListBox.ItemHeight = 20;
			this.m_LocationsListBox.Location = new System.Drawing.Point(42, 58);
			this.m_LocationsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.m_LocationsListBox.Name = "m_LocationsListBox";
			this.m_LocationsListBox.Size = new System.Drawing.Size(270, 344);
			this.m_LocationsListBox.TabIndex = 3;
			this.m_LocationsListBox.SelectedIndexChanged += new System.EventHandler(this.m_LocationsListBox_SelectedIndexChanged);
			// 
			// m_AcademicInstitutionLabel
			// 
			this.m_AcademicInstitutionLabel.AutoSize = true;
			this.m_AcademicInstitutionLabel.Location = new System.Drawing.Point(334, 446);
			this.m_AcademicInstitutionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.m_AcademicInstitutionLabel.Name = "m_AcademicInstitutionLabel";
			this.m_AcademicInstitutionLabel.Size = new System.Drawing.Size(21, 20);
			this.m_AcademicInstitutionLabel.TabIndex = 5;
			this.m_AcademicInstitutionLabel.Text = "...";
			// 
			// m_WorkPlaceLabel
			// 
			this.m_WorkPlaceLabel.AutoSize = true;
			this.m_WorkPlaceLabel.Location = new System.Drawing.Point(334, 491);
			this.m_WorkPlaceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.m_WorkPlaceLabel.Name = "m_WorkPlaceLabel";
			this.m_WorkPlaceLabel.Size = new System.Drawing.Size(21, 20);
			this.m_WorkPlaceLabel.TabIndex = 6;
			this.m_WorkPlaceLabel.Text = "...";
			// 
			// m_EventsComboBox
			// 
			this.m_EventsComboBox.Enabled = false;
			this.m_EventsComboBox.FormattingEnabled = true;
			this.m_EventsComboBox.Location = new System.Drawing.Point(42, 572);
			this.m_EventsComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.m_EventsComboBox.Name = "m_EventsComboBox";
			this.m_EventsComboBox.Size = new System.Drawing.Size(270, 28);
			this.m_EventsComboBox.TabIndex = 7;
			// 
			// m_FromLocationLabel
			// 
			this.m_FromLocationLabel.AutoSize = true;
			this.m_FromLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.m_FromLocationLabel.Location = new System.Drawing.Point(21, 22);
			this.m_FromLocationLabel.Name = "m_FromLocationLabel";
			this.m_FromLocationLabel.Size = new System.Drawing.Size(67, 29);
			this.m_FromLocationLabel.TabIndex = 12;
			this.m_FromLocationLabel.Text = "from:";
			// 
			// FindARideForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(796, 757);
			this.Controls.Add(this.m_FromLocationLabel);
			this.Controls.Add(this.m_EventsComboBox);
			this.Controls.Add(this.m_WorkPlaceLabel);
			this.Controls.Add(this.m_AcademicInstitutionLabel);
			this.Controls.Add(this.m_LocationsListBox);
			this.Controls.Add(this.m_EventButton);
			this.Controls.Add(this.m_WorkButton);
			this.Controls.Add(this.m_AcademicInstitutionButton);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FindARideForm";
			this.Text = "FindARideForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button m_AcademicInstitutionButton;
		private System.Windows.Forms.Button m_WorkButton;
		private System.Windows.Forms.Button m_EventButton;
		private System.Windows.Forms.ListBox m_LocationsListBox;
		private System.Windows.Forms.Label m_AcademicInstitutionLabel;
		private System.Windows.Forms.Label m_WorkPlaceLabel;
		private System.Windows.Forms.ComboBox m_EventsComboBox;
		private System.Windows.Forms.Label m_FromLocationLabel;
	}
}