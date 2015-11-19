using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET;

namespace _523116184522448
{
    public partial class FormDanielFeature : Form
    {
        private FBUtilities m_utils;
        private GMapOverlay m_MarkersOverlay;

        public FBUtilities FBUtilities 
        {
            set { m_utils = value; }
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
            foreach (Object obj in m_utils.Events)
            {
                if (m_utils.HasLocation(obj))
                {
                    PointLatLng point = getLatLong(m_utils.getLatLong(obj));
                    GMap.NET.WindowsForms.Markers.GMarkerGoogle marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                        point,
                        GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_small);
                    marker.ToolTipText = m_utils.getName(obj);
                    m_MarkersOverlay.Markers.Add(marker);
                }
            }

            gMapControl.Overlays.Add(m_MarkersOverlay);
            gMapControl.ZoomAndCenterMarkers(null);
        }

        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fetchCollection(listBoxEvents, m_utils.Events, "Name");
            LoadMap();
            Cursor.Current = Cursors.Default;
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

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (m_utils.HasLocation(listBoxEvents.SelectedItem))
            {
                gMapControl.Position = getLatLong(m_utils.getLatLong(listBoxEvents.SelectedItem));
            }
            else
            {
                gMapControl.ZoomAndCenterMarkers(null);
            }
        }

        private PointLatLng getLatLong(double[] i_location)
        {
            PointLatLng coordinates;

            if(i_location == null)
            {
                throw new Exception("Null location.");
            }
            else
            {
                coordinates = new PointLatLng(i_location[0], i_location[1]);
            }

            return coordinates;
        } 
    }
}
