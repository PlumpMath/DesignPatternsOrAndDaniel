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

        public User User 
        {
            set {m_LoggedInUser = value; }
        }

        public EventImagesForm()
        {
            InitializeComponent();
        }

        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fetchEvents();
            Cursor.Current = Cursors.Default;         
        }

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

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            displaySelectedEventImages();
            Cursor.Current = Cursors.Default;

        }

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
                    // in some pages when trying to get to its albums facebook throws an exception
                }

            }

            // if we succeeded to retrieve images we now can display them
            if (photosToDisplay.Count > 0)
            {
                DisplayPhotos(photosToDisplay);
            }
            else
            {
                MessageBox.Show("No photos to display.");
            }
        }

        private void DisplayPhotos(List<Photo> photosRetrives)
        {
            // Remove duplicte elements from the list of photos
            List<Photo> photosToDisplay = photosRetrives.Distinct().ToList();
            int i = 0;
            foreach (Photo photo in photosToDisplay)
            {
                imageListEventImages.Images.Add(LoadImage(photo.PictureNormalURL));
                listView.Items.Add(photo.Name, i);
                i++;
            }
        }


        private void fetchRandomPhotos(FacebookObjectCollection<Album> locationAlbums, List<Photo> photosToRetrive,
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

    }
}
