using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Facebook;

namespace _523116184522448
{
    public partial class MainForm : Form
    {
        private User m_LoggedInUser;
        private EventImagesForm m_ImagesFromEventsFrom;
        private FormDanielFeature m_DanielFeatureForm;

        public MainForm()
        {
            InitializeComponent();
            buttonGetEvents.Enabled = false;
            buttonGetImagesStats.Enabled = false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {            
            // Login
            LoginResult result = FacebookService.Login(
                "523116184522448",
                "public_profile",
                "user_posts",
                "user_photos", 
                "user_events");

            // Verify input
            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
                fetchUserInfo();
                buttonLogin.Enabled = false;
                buttonGetEvents.Enabled = true;
                buttonGetImagesStats.Enabled = true;
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void fetchUserInfo()
        {
            picture_profilePictureBox.LoadAsync(m_LoggedInUser.PictureNormalURL);
        }

        private void buttonGetImagesStats_Click(object sender, EventArgs e)
        {
            m_DanielFeatureForm = new FormDanielFeature();
            m_DanielFeatureForm.User = m_LoggedInUser;
            m_DanielFeatureForm.Show();
        }

        private void buttonGetEvents_Click(object sender, EventArgs e)
        {
            m_ImagesFromEventsFrom = new EventImagesForm();
            m_ImagesFromEventsFrom.User = m_LoggedInUser;
            m_ImagesFromEventsFrom.Show();
        }
    }
}
