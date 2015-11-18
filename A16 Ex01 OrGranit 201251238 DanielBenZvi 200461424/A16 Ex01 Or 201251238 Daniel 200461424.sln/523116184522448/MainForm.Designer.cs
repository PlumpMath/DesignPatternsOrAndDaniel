namespace _523116184522448
{
    public partial class MainForm
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
            ((System.ComponentModel.ISupportInitialize)(this.picture_profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.AllowDrop = true;
            this.buttonLogin.Location = new System.Drawing.Point(118, 140);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 100);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonGetImagesStats
            // 
            this.buttonGetImagesStats.Location = new System.Drawing.Point(12, 140);
            this.buttonGetImagesStats.Name = "buttonGetImagesStats";
            this.buttonGetImagesStats.Size = new System.Drawing.Size(100, 100);
            this.buttonGetImagesStats.TabIndex = 6;
            this.buttonGetImagesStats.Text = "Images Stats";
            this.buttonGetImagesStats.UseVisualStyleBackColor = true;
            this.buttonGetImagesStats.Click += new System.EventHandler(this.buttonGetImagesStats_Click);
            // 
            // buttonGetEvents
            // 
            this.buttonGetEvents.Location = new System.Drawing.Point(224, 140);
            this.buttonGetEvents.Name = "buttonGetEvents";
            this.buttonGetEvents.Size = new System.Drawing.Size(100, 100);
            this.buttonGetEvents.TabIndex = 7;
            this.buttonGetEvents.Text = "Event Images";
            this.buttonGetEvents.UseVisualStyleBackColor = true;
            this.buttonGetEvents.Click += new System.EventHandler(this.buttonGetEvents_Click);
            // 
            // picture_profilePictureBox
            // 
            this.picture_profilePictureBox.Location = new System.Drawing.Point(118, 12);
            this.picture_profilePictureBox.Name = "picture_profilePictureBox";
            this.picture_profilePictureBox.Size = new System.Drawing.Size(100, 100);
            this.picture_profilePictureBox.TabIndex = 8;
            this.picture_profilePictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 263);
            this.Controls.Add(this.picture_profilePictureBox);
            this.Controls.Add(this.buttonGetEvents);
            this.Controls.Add(this.buttonGetImagesStats);
            this.Controls.Add(this.buttonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.picture_profilePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonGetImagesStats;
        private System.Windows.Forms.Button buttonGetEvents;
        private System.Windows.Forms.PictureBox picture_profilePictureBox;
    }
}
