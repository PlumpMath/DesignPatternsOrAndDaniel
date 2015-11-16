namespace _523116184522448
{
    partial class MainForm
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonGetImagesStats = new System.Windows.Forms.Button();
            this.buttonGetEvents = new System.Windows.Forms.Button();
            this.picture_profilePictureBox = new System.Windows.Forms.PictureBox();
            this.panelImagesStats = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelEvents = new System.Windows.Forms.Panel();
            this.buttonBackFromImages = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_profilePictureBox)).BeginInit();
            this.panelImagesStats.SuspendLayout();
            this.panelEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.AllowDrop = true;
            this.buttonLogin.Location = new System.Drawing.Point(258, 125);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonGetImagesStats
            // 
            this.buttonGetImagesStats.Location = new System.Drawing.Point(107, 201);
            this.buttonGetImagesStats.Name = "buttonGetImagesStats";
            this.buttonGetImagesStats.Size = new System.Drawing.Size(134, 23);
            this.buttonGetImagesStats.TabIndex = 6;
            this.buttonGetImagesStats.Text = "Images Stats";
            this.buttonGetImagesStats.UseVisualStyleBackColor = true;
            this.buttonGetImagesStats.Click += new System.EventHandler(this.buttonGetImagesStats_Click);
            // 
            // buttonGetEvents
            // 
            this.buttonGetEvents.Location = new System.Drawing.Point(422, 209);
            this.buttonGetEvents.Name = "buttonGetEvents";
            this.buttonGetEvents.Size = new System.Drawing.Size(124, 23);
            this.buttonGetEvents.TabIndex = 7;
            this.buttonGetEvents.Text = "Event Images";
            this.buttonGetEvents.UseVisualStyleBackColor = true;
            this.buttonGetEvents.Click += new System.EventHandler(this.buttonGetEvents_Click);
            // 
            // picture_profilePictureBox
            // 
            this.picture_profilePictureBox.Location = new System.Drawing.Point(245, 32);
            this.picture_profilePictureBox.Name = "picture_profilePictureBox";
            this.picture_profilePictureBox.Size = new System.Drawing.Size(104, 87);
            this.picture_profilePictureBox.TabIndex = 8;
            this.picture_profilePictureBox.TabStop = false;
            // 
            // panelImagesStats
            // 
            this.panelImagesStats.Controls.Add(this.buttonBackFromImages);
            this.panelImagesStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImagesStats.Location = new System.Drawing.Point(0, 0);
            this.panelImagesStats.Name = "panelImagesStats";
            this.panelImagesStats.Size = new System.Drawing.Size(637, 311);
            this.panelImagesStats.TabIndex = 9;
            this.panelImagesStats.Visible = false;
            // 
            // buttonBack
            // 
            this.panelEvents.Controls.Add(this.buttonBackFromImages);
            this.buttonBack.Location = new System.Drawing.Point(27, 20);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click_1);
            // 
            // panelEvents
            // 
            this.panelEvents.Controls.Add(this.buttonBack);
            this.panelEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEvents.Location = new System.Drawing.Point(0, 0);
            this.panelEvents.Name = "panelEvents";
            this.panelEvents.Size = new System.Drawing.Size(637, 311);
            this.panelEvents.TabIndex = 1;
            this.panelEvents.Visible = false;
            // 
            // buttonBackFromImages
            // 
            this.buttonBackFromImages.Location = new System.Drawing.Point(17, 15);
            this.buttonBackFromImages.Name = "buttonBackFromImages";
            this.buttonBackFromImages.Size = new System.Drawing.Size(75, 23);
            this.buttonBackFromImages.TabIndex = 0;
            this.buttonBackFromImages.Text = "Back";
            this.buttonBackFromImages.UseVisualStyleBackColor = true;
            this.buttonBackFromImages.Click += new System.EventHandler(this.buttonBackFromImages_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 311);
            this.Controls.Add(this.panelImagesStats);
            this.Controls.Add(this.panelEvents);
            this.Controls.Add(this.picture_profilePictureBox);
            this.Controls.Add(this.buttonGetEvents);
            this.Controls.Add(this.buttonGetImagesStats);
            this.Controls.Add(this.buttonLogin);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.picture_profilePictureBox)).EndInit();
            this.panelImagesStats.ResumeLayout(false);
            this.panelEvents.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonGetImagesStats;
        private System.Windows.Forms.Button buttonGetEvents;
        private System.Windows.Forms.PictureBox picture_profilePictureBox;
        private System.Windows.Forms.Panel panelImagesStats;
        private System.Windows.Forms.Panel panelEvents;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonBackFromImages;
    }
}

