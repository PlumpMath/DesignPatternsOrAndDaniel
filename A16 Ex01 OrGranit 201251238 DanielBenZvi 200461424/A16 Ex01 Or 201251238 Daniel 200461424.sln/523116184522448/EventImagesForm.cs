using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace _523116184522448
{
    public partial class EventImagesForm : Form
    {
        protected const int k_NumOfImages = 5;
        private User m_LoggedInUser;
        private List<Photo> m_PhotosToDisplay;
        private Photo m_SelectedPhoto;

        public User User 
        {
            set { m_LoggedInUser = value; }
        }

        public EventImagesForm()
        {
            InitializeComponent();
        }

        // button 'buttonFetchEvents' clicked
        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fetchEvents();
            Cursor.Current = Cursors.Default;         
        }

        // new selected item in 'listBoxEvents'
        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_SelectedPhoto = null;
            listBoxComments.Items.Clear();
            Cursor.Current = Cursors.WaitCursor;
            displaySelectedEventImages();
            Cursor.Current = Cursors.Default;
        }

        // new selected item in 'listView' (which contains the photos)
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                listBoxComments.Items.Clear();
                int selectedIndex = listView.SelectedItems[0].ImageIndex;
                m_SelectedPhoto = m_PhotosToDisplay[selectedIndex];
                displayComments(m_SelectedPhoto.Comments);
            }         
        }

        // button 'buttonlikePhoto' clicked
        private void buttonlikePhto_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            likeSelectedPhoto();
            Cursor.Current = Cursors.Default;
        }

        // button 'buttonPostComment' clicked
        private void buttonPostComment_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            postCommentOnSelectedPhoto();
            Cursor.Current = Cursors.Default;
        }

        // adds all the comments in from 'i_comments' to 'listBoxComments'
        private void displayComments(FacebookObjectCollection<Comment> i_comments)
        {
            listBoxComments.DisplayMember = "Message";
            foreach (Comment comment in i_comments)
            {
                if (!string.IsNullOrEmpty(comment.Message))
                {
                    listBoxComments.Items.Add(comment);
                }
            }
        }

        // post text from 'textBoxCommentPhoto' as a comment to 'm_SelectedPhoto'
        private void postCommentOnSelectedPhoto()
        {
            if (m_SelectedPhoto != null)
            {
                if (!string.IsNullOrEmpty(textBoxCommentPhoto.Text))
                {
                    Comment comment = m_SelectedPhoto.Comment(textBoxCommentPhoto.Text);
                    if (comment != null)
                    {
                        MessageBox.Show("Comment Succeded!");
                        textBoxCommentPhoto.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Try again please.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a Photo!");
            }
        }

        // like 'm_SelectedPhoto'
        private void likeSelectedPhoto()
        {
            if (m_SelectedPhoto != null)
            {
                if (m_SelectedPhoto.LikedBy.Contains(m_LoggedInUser))
                {
                    MessageBox.Show("You already like this photo");
                }
                else if (m_SelectedPhoto.Like())
                {
                    MessageBox.Show("Liked!");
                }
            }
            else
            {
                MessageBox.Show("Select a Photo!");
            }
        }

        // adds up to 'k_NumOfImages' random images from 'listBoxEvents.SelectedItem' ('selectedEvent')
        // to  'imageListEventImages'
        private void displaySelectedEventImages()
        {
            // Clear Images
            imageListEventImages.Images.Clear();
            listView.Items.Clear();

            // the event location is usually a FB page if not we cant show any photos
            Event selectedEvent = listBoxEvents.SelectedItem as Event;
            Page location = selectedEvent.Place;
            FacebookObjectCollection<Album> locationAlbums;
            List<Photo> photosToDisplay = new List<Photo>();

            // if location (page) exits we try to retrive some random photos from its Albums
            if (location != null)
            {
                try
                {
                    locationAlbums = location.Albums;
                    if (locationAlbums != null)
                    {
                        fetchRandomPhotos(locationAlbums, photosToDisplay, k_NumOfImages);
                    }
                }
                catch (Facebook.FacebookApiException)
                {
                    // in some pages when trying to get to their albums facebook api throws an exception
                }
            }

            // if we succeeded to retrieve images we now can display them
            if (photosToDisplay.Count > 0)
            {
                displayPhotos(photosToDisplay);
            }
            else
            {
                MessageBox.Show("No photos to display.");
            }
        }

        private void displayPhotos(List<Photo> photosRetrives)
        {
            // Remove duplicte elements from the list of photos
            m_PhotosToDisplay = photosRetrives.Distinct().ToList();
            int i = 0;
            foreach (Photo photo in m_PhotosToDisplay)
            {
                imageListEventImages.Images.Add(LoadImage(photo.PictureNormalURL));
                listView.Items.Add(photo.Name, i);
                i++;
            }
        }

        private void fetchRandomPhotos(
            FacebookObjectCollection<Album> locationAlbums, 
            List<Photo> photosToRetrive, 
            int k_NumOfImages)
        {
            for (int i = 0; i < k_NumOfImages; i++)
            {
                Random rnd = new Random();
                int albumNum = rnd.Next(locationAlbums.Count);
                if (locationAlbums[albumNum].Count > 0)
                {
                    int photoNum = rnd.Next(locationAlbums[albumNum].Photos.Count);
                    Photo selectedPhoto = locationAlbums[albumNum].Photos[photoNum];
                    photosToRetrive.Add(selectedPhoto);
                }
            }
        }

        // adds 'm_LoggedInUser' events to 'listBoxEvents'
        private void fetchEvents()
        {
            listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = "Name";
            foreach (Event fbEvent in m_LoggedInUser.Events)
            {
                listBoxEvents.Items.Add(fbEvent);
            }

            if (m_LoggedInUser.Events.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
            }
        }

        private Image LoadImage(string url)
        {
            System.Net.WebRequest request = System.Net.WebRequest.Create(url);
            System.Net.WebResponse response = request.GetResponse();
            System.IO.Stream responseStream = response.GetResponseStream();
            Bitmap bmp = new Bitmap(responseStream);

            responseStream.Dispose();

            return bmp;
        }
    }
}
