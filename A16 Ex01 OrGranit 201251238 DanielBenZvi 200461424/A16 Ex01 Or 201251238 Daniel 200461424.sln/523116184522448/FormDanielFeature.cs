using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using GMap.NET.WindowsForms;
using GMap.NET;

namespace _523116184522448
{
    public partial class FormDanielFeature : Form
    {
        private User m_LoggedInUser;
        private GMapOverlay m_MarkersOverlay;

        public User User 
        {
            set { m_LoggedInUser = value; }
        }

        public FormDanielFeature()
        {
            InitializeComponent();
        }

        private void LoadMap()
        {
            gMapControl.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMapControl.SetPositionByKeywords("dubnov, Tel Aviv, Israel");

            m_MarkersOverlay = new GMapOverlay("markers");
            foreach (Event fbEvent in m_LoggedInUser.Events)
            {
                Location location = fbEvent.Place.Location;
                if (location != null)
                {
                    PointLatLng point = getLatLong(location);
                    GMap.NET.WindowsForms.Markers.GMarkerGoogle marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                        point,
                        GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_small);
                    marker.ToolTipText = fbEvent.Name;
                    m_MarkersOverlay.Markers.Add(marker);
                }
            }

            gMapControl.Overlays.Add(m_MarkersOverlay);
            gMapControl.ZoomAndCenterMarkers(null);
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

            LoadMap();
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Event selectedEvent = listBoxEvents.SelectedItem as Event;
            Location location = selectedEvent.Place.Location;

            if (location != null)
            {
                gMapControl.Position = getLatLong(location);
            }
            else
            {
                gMapControl.ZoomAndCenterMarkers(null);
            }
        }

        private PointLatLng getLatLong(Location i_location)
        {
            PointLatLng coordinates;

            if(i_location == null)
            {
                throw new Exception("Null location.");
            }
            else
            {
                coordinates = new PointLatLng(i_location.Latitude.Value, i_location.Longitude.Value);
            }

            return coordinates;
        } 
    }
}
