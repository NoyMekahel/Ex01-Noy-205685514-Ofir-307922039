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
			this.SuspendLayout();
			// 
			// m_AcademicInstitutionButton
			// 
			this.m_AcademicInstitutionButton.Location = new System.Drawing.Point(28, 285);
			this.m_AcademicInstitutionButton.Name = "m_AcademicInstitutionButton";
			this.m_AcademicInstitutionButton.Size = new System.Drawing.Size(167, 23);
			this.m_AcademicInstitutionButton.TabIndex = 0;
			this.m_AcademicInstitutionButton.Text = "Ride To Academic Institution";
			this.m_AcademicInstitutionButton.UseVisualStyleBackColor = true;
			this.m_AcademicInstitutionButton.Click += new System.EventHandler(this.AcademicInstitutionButton_Click);
			// 
			// m_WorkButton
			// 
			this.m_WorkButton.Location = new System.Drawing.Point(28, 314);
			this.m_WorkButton.Name = "m_WorkButton";
			this.m_WorkButton.Size = new System.Drawing.Size(167, 23);
			this.m_WorkButton.TabIndex = 1;
			this.m_WorkButton.Text = "Ride To Work";
			this.m_WorkButton.UseVisualStyleBackColor = true;
			this.m_WorkButton.Click += new System.EventHandler(this.m_WorkButton_Click);
			// 
			// m_EventButton
			// 
			this.m_EventButton.Location = new System.Drawing.Point(28, 343);
			this.m_EventButton.Name = "m_EventButton";
			this.m_EventButton.Size = new System.Drawing.Size(167, 23);
			this.m_EventButton.TabIndex = 2;
			this.m_EventButton.Text = "Ride To An Event";
			this.m_EventButton.UseVisualStyleBackColor = true;
			this.m_EventButton.Click += new System.EventHandler(this.m_EventButton_Click);
			// 
			// m_LocationsListBox
			// 
			this.m_LocationsListBox.FormattingEnabled = true;
			this.m_LocationsListBox.Location = new System.Drawing.Point(28, 12);
			this.m_LocationsListBox.Name = "m_LocationsListBox";
			this.m_LocationsListBox.Size = new System.Drawing.Size(181, 251);
			this.m_LocationsListBox.TabIndex = 3;
			// 
			// m_AcademicInstitutionLabel
			// 
			this.m_AcademicInstitutionLabel.AutoSize = true;
			this.m_AcademicInstitutionLabel.Location = new System.Drawing.Point(223, 290);
			this.m_AcademicInstitutionLabel.Name = "m_AcademicInstitutionLabel";
			this.m_AcademicInstitutionLabel.Size = new System.Drawing.Size(16, 13);
			this.m_AcademicInstitutionLabel.TabIndex = 5;
			this.m_AcademicInstitutionLabel.Text = "...";
			// 
			// m_WorkPlaceLabel
			// 
			this.m_WorkPlaceLabel.AutoSize = true;
			this.m_WorkPlaceLabel.Location = new System.Drawing.Point(223, 319);
			this.m_WorkPlaceLabel.Name = "m_WorkPlaceLabel";
			this.m_WorkPlaceLabel.Size = new System.Drawing.Size(16, 13);
			this.m_WorkPlaceLabel.TabIndex = 6;
			this.m_WorkPlaceLabel.Text = "...";
			// 
			// m_EventsComboBox
			// 
			this.m_EventsComboBox.FormattingEnabled = true;
			this.m_EventsComboBox.Location = new System.Drawing.Point(28, 372);
			this.m_EventsComboBox.Name = "m_EventsComboBox";
			this.m_EventsComboBox.Size = new System.Drawing.Size(181, 21);
			this.m_EventsComboBox.TabIndex = 7;
			// 
			// FindARideForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(531, 492);
			this.Controls.Add(this.m_EventsComboBox);
			this.Controls.Add(this.m_WorkPlaceLabel);
			this.Controls.Add(this.m_AcademicInstitutionLabel);
			this.Controls.Add(this.m_LocationsListBox);
			this.Controls.Add(this.m_EventButton);
			this.Controls.Add(this.m_WorkButton);
			this.Controls.Add(this.m_AcademicInstitutionButton);
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
	}
}