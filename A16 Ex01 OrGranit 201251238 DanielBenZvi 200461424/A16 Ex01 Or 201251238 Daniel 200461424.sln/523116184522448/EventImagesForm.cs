﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _523116184522448
{
    public partial class EventImagesForm : Form
    {
        protected const int k_NumOfImages = 5;
        private FBUtilities m_utils;

        public FBUtilities FBUtilities 
        {
            set { m_utils = value; }
        }

        public EventImagesForm()
        {
            InitializeComponent();
        }

        // button 'buttonFetchEvents' clicked
        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fetchCollection(listBoxEvents, m_utils.Events, "Name");
            Cursor.Current = Cursors.Default;
            if (listBoxEvents.Items.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
            }

        }

        // new selected item in 'listBoxEvents'
        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_utils.resetSelectedPhoto();
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
                m_utils.SelectedPhoto = selectedIndex;
                fetchCollection(listBoxComments, m_utils.Comments, "Message");
                if (listBoxComments.Items.Count == 0)
                {
                    MessageBox.Show("No comments to retrieve :(");
                }
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
            if (m_utils.HasSelectedPhoto)
            {
                fetchCollection(listBoxComments, m_utils.Comments, "Message");
            }           
            Cursor.Current = Cursors.Default;
        }

        // post text from 'textBoxCommentPhoto' as a comment to 'm_SelectedPhoto'
        private void postCommentOnSelectedPhoto()
        {
 
            if (m_utils.HasSelectedPhoto)
            {
                if (!string.IsNullOrEmpty(textBoxCommentPhoto.Text))
                {
                    if (m_utils.Comment(textBoxCommentPhoto.Text))
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
            if (m_utils.HasSelectedPhoto)
            {
                if (m_utils.LikedByUser)
                {
                    MessageBox.Show("You already like this photo");
                }
                else if (m_utils.Like())
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
            if (m_utils.HasAlbums(listBoxEvents.SelectedItem))
            {
                m_utils.GenerateRandomPhotos(listBoxEvents.SelectedItem, k_NumOfImages);
                displayPhotos(m_utils.PhotosNames, m_utils.PhotosUrls);
            }

            if (imageListEventImages.Images.Count == 0)
            {
                MessageBox.Show("No photos to display.");
            }
            
        }

        private void displayPhotos(List<string> photosNames, List<string> photosUrl)
        {
            for (int i = 0; i < photosUrl.Count; i++)
            {
                imageListEventImages.Images.Add(LoadImage(photosUrl[i]));
                listView.Items.Add(photosNames[i], i);
            }
        }

        // adds 'collection' events to 'listBox'
        private void fetchEvents()
        {
            listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = "Name";
            foreach (Object obj in m_utils.Events)
            {
                listBoxEvents.Items.Add(obj);
            }

            if (listBoxEvents.Items.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
            }
        }

        private void fetchCollection(ListBox i_Listbox, IEnumerable<object> i_Collection, string i_MemberToDisplay)
        {
            i_Listbox.Items.Clear();
            i_Listbox.DisplayMember = i_MemberToDisplay;
            foreach (Object obj in i_Collection)
            {
                i_Listbox.Items.Add(obj);
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
