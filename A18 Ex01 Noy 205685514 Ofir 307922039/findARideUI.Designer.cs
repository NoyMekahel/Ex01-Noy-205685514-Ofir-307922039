namespace A18_Ex01_Noy_205685514_Ofir_307922039
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
			this.backButton = new System.Windows.Forms.Button();
			this.fromLocationLabel = new System.Windows.Forms.Label();
			this.eventsComboBox = new System.Windows.Forms.ComboBox();
			this.workPlaceLabel = new System.Windows.Forms.Label();
			this.academicInstitutionLabel = new System.Windows.Forms.Label();
			this.locationsListBox = new System.Windows.Forms.ListBox();
			this.eventButton = new System.Windows.Forms.Button();
			this.workButton = new System.Windows.Forms.Button();
			this.academicInstitutionButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// backButton
			// 
			this.backButton.Location = new System.Drawing.Point(23, 472);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(75, 23);
			this.backButton.TabIndex = 30;
			this.backButton.Text = "<- Back";
			this.backButton.UseVisualStyleBackColor = true;
			// 
			// fromLocationLabel
			// 
			this.fromLocationLabel.AutoSize = true;
			this.fromLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.fromLocationLabel.Location = new System.Drawing.Point(9, 6);
			this.fromLocationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.fromLocationLabel.Name = "fromLocationLabel";
			this.fromLocationLabel.Size = new System.Drawing.Size(45, 20);
			this.fromLocationLabel.TabIndex = 29;
			this.fromLocationLabel.Text = "from:";
			// 
			// eventsComboBox
			// 
			this.eventsComboBox.Enabled = false;
			this.eventsComboBox.FormattingEnabled = true;
			this.eventsComboBox.Location = new System.Drawing.Point(23, 364);
			this.eventsComboBox.Name = "eventsComboBox";
			this.eventsComboBox.Size = new System.Drawing.Size(181, 21);
			this.eventsComboBox.TabIndex = 28;
			this.eventsComboBox.SelectedIndexChanged += new System.EventHandler(this.eventsComboBox_SelectedIndexChanged);
			// 
			// workPlaceLabel
			// 
			this.workPlaceLabel.AutoSize = true;
			this.workPlaceLabel.Location = new System.Drawing.Point(218, 311);
			this.workPlaceLabel.Name = "workPlaceLabel";
			this.workPlaceLabel.Size = new System.Drawing.Size(16, 13);
			this.workPlaceLabel.TabIndex = 27;
			this.workPlaceLabel.Text = "...";
			// 
			// academicInstitutionLabel
			// 
			this.academicInstitutionLabel.AutoSize = true;
			this.academicInstitutionLabel.Location = new System.Drawing.Point(218, 282);
			this.academicInstitutionLabel.Name = "academicInstitutionLabel";
			this.academicInstitutionLabel.Size = new System.Drawing.Size(16, 13);
			this.academicInstitutionLabel.TabIndex = 26;
			this.academicInstitutionLabel.Text = "...";
			// 
			// locationsListBox
			// 
			this.locationsListBox.FormattingEnabled = true;
			this.locationsListBox.Location = new System.Drawing.Point(23, 30);
			this.locationsListBox.Name = "locationsListBox";
			this.locationsListBox.Size = new System.Drawing.Size(181, 225);
			this.locationsListBox.TabIndex = 25;
			this.locationsListBox.SelectedIndexChanged += new System.EventHandler(this.locationsListBox_SelectedIndexChanged);
			// 
			// eventButton
			// 
			this.eventButton.Enabled = false;
			this.eventButton.Location = new System.Drawing.Point(23, 335);
			this.eventButton.Name = "eventButton";
			this.eventButton.Size = new System.Drawing.Size(167, 23);
			this.eventButton.TabIndex = 24;
			this.eventButton.Text = "Ride To An Event";
			this.eventButton.UseVisualStyleBackColor = true;
			this.eventButton.Click += new System.EventHandler(this.eventButton_Click);
			// 
			// workButton
			// 
			this.workButton.Enabled = false;
			this.workButton.Location = new System.Drawing.Point(23, 306);
			this.workButton.Name = "workButton";
			this.workButton.Size = new System.Drawing.Size(167, 23);
			this.workButton.TabIndex = 23;
			this.workButton.Text = "Ride To Work";
			this.workButton.UseVisualStyleBackColor = true;
			this.workButton.Click += new System.EventHandler(this.workButton_Click);
			// 
			// academicInstitutionButton
			// 
			this.academicInstitutionButton.Enabled = false;
			this.academicInstitutionButton.Location = new System.Drawing.Point(23, 277);
			this.academicInstitutionButton.Name = "academicInstitutionButton";
			this.academicInstitutionButton.Size = new System.Drawing.Size(167, 23);
			this.academicInstitutionButton.TabIndex = 22;
			this.academicInstitutionButton.Text = "Ride To Academic Institution";
			this.academicInstitutionButton.UseVisualStyleBackColor = true;
			this.academicInstitutionButton.Click += new System.EventHandler(this.academicInstitutionButton_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(486, 516);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.fromLocationLabel);
			this.Controls.Add(this.eventsComboBox);
			this.Controls.Add(this.workPlaceLabel);
			this.Controls.Add(this.academicInstitutionLabel);
			this.Controls.Add(this.locationsListBox);
			this.Controls.Add(this.eventButton);
			this.Controls.Add(this.workButton);
			this.Controls.Add(this.academicInstitutionButton);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button backButton;
		private System.Windows.Forms.Label fromLocationLabel;
		private System.Windows.Forms.ComboBox eventsComboBox;
		private System.Windows.Forms.Label workPlaceLabel;
		private System.Windows.Forms.Label academicInstitutionLabel;
		private System.Windows.Forms.ListBox locationsListBox;
		private System.Windows.Forms.Button eventButton;
		private System.Windows.Forms.Button workButton;
		private System.Windows.Forms.Button academicInstitutionButton;
	}
}