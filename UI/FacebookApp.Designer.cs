﻿using System;

namespace UI
{
	partial class FacebookApp
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
			this.logoutButton = new System.Windows.Forms.Button();
			this.backButton = new System.Windows.Forms.Button();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.loginButton = new System.Windows.Forms.Button();
			this.mainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// logoutButton
			// 
			this.logoutButton.Location = new System.Drawing.Point(510, 15);
			this.logoutButton.Name = "logoutButton";
			this.logoutButton.Size = new System.Drawing.Size(78, 23);
			this.logoutButton.TabIndex = 7;
			this.logoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.logoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.logoutButton.FlatStyle= System.Windows.Forms.FlatStyle.Flat;
			this.logoutButton.FlatAppearance.BorderSize = 0;
			this.logoutButton.BackgroundImage = global::UI.Properties.Resources.logout_button;
			this.logoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
			this.logoutButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.logoutButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			// 
			// backButton
			// 
			this.backButton.BackgroundImage = global::UI.Properties.Resources.back_button2;
			this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.backButton.FlatAppearance.BorderSize = 0;
			this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.backButton.Location = new System.Drawing.Point(13, 595);
			this.backButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(75, 22);
			this.backButton.TabIndex = 30;
			this.backButton.UseVisualStyleBackColor = true;
			this.backButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.backButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			this.backButton.Click += new System.EventHandler(this.backButton_Click);
			// 
			// mainPanel
			// 
			this.mainPanel.BackColor = System.Drawing.Color.Transparent;
			this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.mainPanel.Controls.Add(this.loginButton);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(948, 969);
			this.mainPanel.TabIndex = 0;
			// 
			// loginButton
			// 
			this.loginButton.BackColor = System.Drawing.Color.MediumBlue;
			this.loginButton.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
			this.loginButton.ForeColor = System.Drawing.Color.White;
			this.loginButton.Location = new System.Drawing.Point(408, 587);
			this.loginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(156, 69);
			this.loginButton.TabIndex = 8;
			this.loginButton.Text = "Login";
			this.loginButton.UseVisualStyleBackColor = false;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// FacebookApp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackgroundImage = global::UI.Properties.Resources.faccebook_background;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(948, 969);
			this.Controls.Add(this.mainPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FacebookApp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FacebookApp";
			this.mainPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.Button logoutButton;
		private System.Windows.Forms.Button backButton;


	}
}