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
        public MainForm()
        {
            InitializeComponent();
        }

        User m_LoggedInUser;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Login
            LoginResult result = FacebookService.Login("523116184522448", "public_profile", "user_posts", "user_photos", "user_events");

            //Verify input
            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
                fetchUserInfo();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }

            //TODO: Make app buttons clickable.
        }

        private void fetchUserInfo()
        {
            picture_profilePictureBox.LoadAsync(m_LoggedInUser.PictureNormalURL);
        }

        private void buttonGetImagesStats_Click(object sender, EventArgs e)
        {
            panelImagesStats.Visible = true;
        }

        private void buttonGetEvents_Click(object sender, EventArgs e)
        {
            panelEvents.Visible = true;
        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            panelEvents.Visible = false;
        }

        private void buttonBackFromImages_Click(object sender, EventArgs e)
        {
            panelImagesStats.Visible = false;
        }
    }
}
