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
        public User User 
        {
            set { m_LoggedInUser = value; }
        }

        public FormDanielFeature()
        {
            //TODO: remove writelines
            Console.WriteLine("initializing");
            InitializeComponent();
            Console.WriteLine("loading");
            LoadMap();
            
        }

        private void LoadMap()
        {
            //TODO: remove writelines
            Console.WriteLine("LOADING!!");
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMapControl1.SetPositionByKeywords("dubnov, Tel Aviv, Israel");


            GMapOverlay markersOverlay = new GMapOverlay("markers");
            GMap.NET.WindowsForms.Markers.GMarkerGoogle marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle((new PointLatLng(31.98, 34.76)), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.green);
            GMap.NET.WindowsForms.Markers.GMarkerGoogle marker2 = new GMap.NET.WindowsForms.Markers.GMarkerGoogle((new PointLatLng(31.40, 34.30)), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue);
            markersOverlay.Markers.Add(marker);
            markersOverlay.Markers.Add(marker2);
            gMapControl1.Overlays.Add(markersOverlay);


            gMapControl1.ZoomAndCenterMarkers(null);





        }

        public FormDanielFeature(FacebookWrapper.ObjectModel.User m_LoggedInUser)
        {
            // TODO: Complete member initialization
            this.m_LoggedInUser = m_LoggedInUser;
        }

    }
}
