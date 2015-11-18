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
    public partial class FormDanielFeature : Form
    {
        private User m_LoggedInUser;
        private EventDetails m_EventDetails;
        private Event m_Event;

        public User User 
        {
            set { m_LoggedInUser = value; }
        }

        internal Event Event
        {
            get
            {
                return m_Event;
            }

            set
            {
                m_Event = value;
            }
        }

        internal EventDetails EventDetails
        {
            get
            {
                return m_EventDetails;
            }

            set
            {
                m_EventDetails = value;
            }
        }

        public FormDanielFeature()
        {
            InitializeComponent();
            this.m_EventDetails = new EventDetails();

        }

        public FormDanielFeature(FacebookWrapper.ObjectModel.User i_LoggedInUser)
        {
            // TODO: Complete member initialization
            this.m_LoggedInUser = i_LoggedInUser;
            this.m_EventDetails = new EventDetails();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            m_Event = new Event();
            m_Event.Description = "Nedsfsf";

        }

        private void listBoxRepetitionPattern_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(m_EventDetails.RepetitionPattern);
            m_EventDetails.RepetitionPattern = (eEventRepetitionPattern)Enum.Parse(typeof(eEventRepetitionPattern), listBoxRepetitionPattern.Text);
            Console.WriteLine(m_EventDetails.RepetitionPattern);
            m_EventDetails.RepetitionPattern = (eEventRepetitionPattern)listBoxRepetitionPattern.SelectedItem;
            Console.WriteLine(m_EventDetails.RepetitionPattern);
        }
    }
}
