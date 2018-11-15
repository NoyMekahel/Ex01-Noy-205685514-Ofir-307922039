﻿namespace UI
{
	partial class CollageFrameOptionsForm
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
			this.panelMain = new System.Windows.Forms.Panel();
			this.radioButton8Images = new System.Windows.Forms.RadioButton();
			this.radioButton7Images = new System.Windows.Forms.RadioButton();
			this.radioButton6Images = new System.Windows.Forms.RadioButton();
			this.radioButton5Images = new System.Windows.Forms.RadioButton();
			this.radioButton4Images = new System.Windows.Forms.RadioButton();
			this.radioButton3Images = new System.Windows.Forms.RadioButton();
			this.buttonSave = new System.Windows.Forms.Button();
			this.panelMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.radioButton8Images);
			this.panelMain.Controls.Add(this.radioButton7Images);
			this.panelMain.Controls.Add(this.radioButton6Images);
			this.panelMain.Controls.Add(this.radioButton5Images);
			this.panelMain.Controls.Add(this.radioButton4Images);
			this.panelMain.Controls.Add(this.radioButton3Images);
			this.panelMain.Location = new System.Drawing.Point(13, 13);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(635, 426);
			this.panelMain.TabIndex = 0;
			// 
			// radioButton8Images
			// 
			this.radioButton8Images.AutoSize = true;
			this.radioButton8Images.Location = new System.Drawing.Point(502, 234);
			this.radioButton8Images.Name = "radioButton8Images";
			this.radioButton8Images.Size = new System.Drawing.Size(68, 17);
			this.radioButton8Images.TabIndex = 5;
			this.radioButton8Images.Text = "8 Images";
			this.radioButton8Images.UseVisualStyleBackColor = true;
			// 
			// radioButton7Images
			// 
			this.radioButton7Images.AutoSize = true;
			this.radioButton7Images.Location = new System.Drawing.Point(276, 234);
			this.radioButton7Images.Name = "radioButton7Images";
			this.radioButton7Images.Size = new System.Drawing.Size(68, 17);
			this.radioButton7Images.TabIndex = 4;
			this.radioButton7Images.Text = "7 Images";
			this.radioButton7Images.UseVisualStyleBackColor = true;
			// 
			// radioButton6Images
			// 
			this.radioButton6Images.AutoSize = true;
			this.radioButton6Images.Location = new System.Drawing.Point(66, 234);
			this.radioButton6Images.Name = "radioButton6Images";
			this.radioButton6Images.Size = new System.Drawing.Size(68, 17);
			this.radioButton6Images.TabIndex = 3;
			this.radioButton6Images.Text = "6 Images";
			this.radioButton6Images.UseVisualStyleBackColor = true;
			// 
			// radioButton5Images
			// 
			this.radioButton5Images.AutoSize = true;
			this.radioButton5Images.Location = new System.Drawing.Point(496, 31);
			this.radioButton5Images.Name = "radioButton5Images";
			this.radioButton5Images.Size = new System.Drawing.Size(68, 17);
			this.radioButton5Images.TabIndex = 2;
			this.radioButton5Images.Text = "5 Images";
			this.radioButton5Images.UseVisualStyleBackColor = true;
			// 
			// radioButton4Images
			// 
			this.radioButton4Images.AutoSize = true;
			this.radioButton4Images.Location = new System.Drawing.Point(276, 31);
			this.radioButton4Images.Name = "radioButton4Images";
			this.radioButton4Images.Size = new System.Drawing.Size(68, 17);
			this.radioButton4Images.TabIndex = 1;
			this.radioButton4Images.Text = "4 Images";
			this.radioButton4Images.UseVisualStyleBackColor = true;
			// 
			// radioButton3Images
			// 
			this.radioButton3Images.AutoSize = true;
			this.radioButton3Images.Checked = true;
			this.radioButton3Images.Location = new System.Drawing.Point(66, 31);
			this.radioButton3Images.Name = "radioButton3Images";
			this.radioButton3Images.Size = new System.Drawing.Size(68, 17);
			this.radioButton3Images.TabIndex = 0;
			this.radioButton3Images.TabStop = true;
			this.radioButton3Images.Text = "3 Images";
			this.radioButton3Images.UseVisualStyleBackColor = true;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(544, 445);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 1;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// CollageFrameOptionsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(663, 480);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.panelMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "CollageFrameOptionsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FrameOptionsForm";
			this.panelMain.ResumeLayout(false);
			this.panelMain.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.RadioButton radioButton8Images;
		private System.Windows.Forms.RadioButton radioButton7Images;
		private System.Windows.Forms.RadioButton radioButton6Images;
		private System.Windows.Forms.RadioButton radioButton5Images;
		private System.Windows.Forms.RadioButton radioButton4Images;
		private System.Windows.Forms.RadioButton radioButton3Images;
		private System.Windows.Forms.Button buttonSave;
	}
}