﻿namespace Rogue_Runner
{
    partial class MenuScreen
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
            this.playButton = new System.Windows.Forms.Button();
            this.controlsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.leaderboardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatAppearance.BorderSize = 3;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.Location = new System.Drawing.Point(19, 379);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(290, 72);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.Enter += new System.EventHandler(this.playButton_Enter);
            // 
            // controlsButton
            // 
            this.controlsButton.BackColor = System.Drawing.Color.Black;
            this.controlsButton.FlatAppearance.BorderSize = 3;
            this.controlsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlsButton.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlsButton.ForeColor = System.Drawing.Color.Transparent;
            this.controlsButton.Location = new System.Drawing.Point(19, 457);
            this.controlsButton.Name = "controlsButton";
            this.controlsButton.Size = new System.Drawing.Size(290, 72);
            this.controlsButton.TabIndex = 2;
            this.controlsButton.Text = "Controls";
            this.controlsButton.UseVisualStyleBackColor = false;
            this.controlsButton.Click += new System.EventHandler(this.controlsButton_Click);
            this.controlsButton.Enter += new System.EventHandler(this.controlsButton_Enter);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Black;
            this.exitButton.FlatAppearance.BorderSize = 3;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(19, 613);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(290, 72);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.Enter += new System.EventHandler(this.exitButton_Enter);
            // 
            // leaderboardButton
            // 
            this.leaderboardButton.BackColor = System.Drawing.Color.Black;
            this.leaderboardButton.FlatAppearance.BorderSize = 3;
            this.leaderboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leaderboardButton.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaderboardButton.ForeColor = System.Drawing.Color.White;
            this.leaderboardButton.Location = new System.Drawing.Point(19, 535);
            this.leaderboardButton.Name = "leaderboardButton";
            this.leaderboardButton.Size = new System.Drawing.Size(290, 72);
            this.leaderboardButton.TabIndex = 3;
            this.leaderboardButton.Text = "Leaderboard";
            this.leaderboardButton.UseVisualStyleBackColor = false;
            this.leaderboardButton.Click += new System.EventHandler(this.leaderboardButton_Click);
            this.leaderboardButton.Enter += new System.EventHandler(this.leaderboardButton_Enter);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Rogue_Runner.Properties.Resources.big_room;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.leaderboardButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.controlsButton);
            this.Controls.Add(this.playButton);
            this.DoubleBuffered = true;
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(900, 700);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button controlsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button leaderboardButton;
    }
}
