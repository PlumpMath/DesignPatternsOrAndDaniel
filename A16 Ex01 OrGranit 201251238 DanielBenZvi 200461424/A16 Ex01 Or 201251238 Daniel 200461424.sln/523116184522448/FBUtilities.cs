using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Drawing;

namespace _523116184522448
{
    public class FBUtilities
    {
        private User m_LoggedInUser;
        private LoginResult m_result;
        private List<Photo> m_photosToDisplay;
        private Photo m_selectedPhoto;

        public FBUtilities()
        {
        }

        internal bool Login()
        {
            bool isLoggedIn = false;

            // Login
            m_result = FacebookService.Login(
                "523116184522448",
                "public_profile",
                "user_posts",
                "user_photos", 
                "user_events");

            // Verify input
            if (!string.IsNullOrEmpty(m_result.AccessToken))
            {
                isLoggedIn = true;
                m_LoggedInUser = m_result.LoggedInUser;
            }

            return isLoggedIn;
        }

        internal string getLoggedInError()
        {
            return m_result.ErrorMessage;
        }

        internal string getUserPicture()
        {
            return m_LoggedInUser.PictureNormalURL;
        }

        public IEnumerable<Event> Events 
        {
            get { return m_LoggedInUser.Events; }     
        }

        internal bool HasAlbums(object p)
        {
            bool hasAlbums = false;
            Event selectedEvent = p as Event;
            Page location = selectedEvent.Place;
            FacebookObjectCollection<Album> locationAlbums;

            if (location != null)
            {
                try
                {
                    locationAlbums = location.Albums;
                    if (locationAlbums != null)
                    {
                        hasAlbums = locationAlbums.Count > 0;
                    }
                }
                catch (Facebook.FacebookApiException)
                {
                    // in some pages when trying to get to their albums facebook api throws an exception
                }
            }

            return hasAlbums;
        }

        internal void GenerateRandomPhotos(object p, int k_NumOfImages)
        {
            Event selectedEvent = p as Event;
            FacebookObjectCollection<Album> locationAlbums = selectedEvent.Place.Albums;
            m_photosToDisplay = new List<Photo>();

            for (int i = 0; i < k_NumOfImages; i++)
            {
                Random rnd = new Random();
                int albumNum = rnd.Next(locationAlbums.Count);
                if (locationAlbums[albumNum].Count > 0)
                {
                    int photoNum = rnd.Next(locationAlbums[albumNum].Photos.Count);
                    Photo selectedPhoto = locationAlbums[albumNum].Photos[photoNum];
                    m_photosToDisplay.Add(selectedPhoto);
                }

                m_photosToDisplay = m_photosToDisplay.Distinct().ToList();
            }
        }

        public List<string> PhotosNames 
        { 
            get 
            { 
                List<string> names = new List<string>();
                foreach (Photo photo in m_photosToDisplay)
                {
                    names.Add(photo.Name);
                }
                return names;
            } 
        }

        public List<string> PhotosUrls
        {
            get
            {
                List<string> urls = new List<string>();
                foreach (Photo photo in m_photosToDisplay)
                {
                    urls.Add(photo.PictureNormalURL);
                }
                return urls;
            }
        }

        public Object SelectedPhoto { 
            set 
            {
                m_selectedPhoto = m_photosToDisplay[(int) value];
            } 
        }

        public IEnumerable<object> Comments { get { return m_selectedPhoto.Comments; } }

        internal void resetSelectedPhoto()
        {
            m_selectedPhoto = null;
        }

        public bool HasSelectedPhoto { get { return m_selectedPhoto != null; } }

        internal bool Comment(string p)
        {
            Comment comment =  m_selectedPhoto.Comment(p);
            return comment != null;
        }

        public bool LikedByUser { 
            get 
            { 
                return m_selectedPhoto.LikedBy.Contains(m_LoggedInUser); 
            } 
        }

        internal bool Like()
        {
            return m_selectedPhoto.Like();
        }

        internal bool HasLocation(object p)
        {
            Event selectedEvent = p as Event;
            Page page = selectedEvent.Place;

            if (page != null) 
            {
                return page.Location != null;
            }
            else
            {
                return false;
            }
        }

        internal double[] getLatLong(object p)
        {
            double[] point = null;
            Event selectedEvent = p as Event;
            Location location = selectedEvent.Place.Location;
            if (location != null)
            {
                point = new double[2];
                point[0] = location.Latitude.Value;
                point[1] = location.Longitude.Value;
            }

            return point;            
        }

        internal string getName(object obj)
        {
            Event selectedEvent = obj as Event;
            return selectedEvent.Name;
        }
    }
}
