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
        private EventImagesForm m_ImagesFromEventsFrom;
        private FormDanielFeature m_DanielFeatureForm;
        private FBUtilities m_utils;

        public MainForm()
        {
            m_utils = new FBUtilities();
            InitializeComponent();
            buttonGetEvents.Enabled = false;
            buttonGetImagesStats.Enabled = false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool isLoggedIn = false;
            isLoggedIn = m_utils.Login();
            if (isLoggedIn)
            {
                fetchUserInfo();
                buttonLogin.Enabled = false;
                buttonGetEvents.Enabled = true;
                buttonGetImagesStats.Enabled = true;
            }
            else
            {
                MessageBox.Show(m_utils.getLoggedInError());
            }
        }

        private void fetchUserInfo()
        {
            picture_profilePictureBox.LoadAsync(m_utils.getUserPicture());
        }

        private void buttonGetImagesStats_Click(object sender, EventArgs e)
        {
            m_DanielFeatureForm = new FormDanielFeature();
            m_DanielFeatureForm.FBUtilities = m_utils;
            m_DanielFeatureForm.Show();
        }

        private void buttonGetEvents_Click(object sender, EventArgs e)
        {
            m_ImagesFromEventsFrom = new EventImagesForm();
            m_ImagesFromEventsFrom.FBUtilities = m_utils;
            m_ImagesFromEventsFrom.Show();
        }
    }
}
