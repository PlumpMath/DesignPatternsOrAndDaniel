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
        public User User 
        {
            set { m_LoggedInUser = value; }
        }

        public FormDanielFeature()
        {
            InitializeComponent();
        }

        public FormDanielFeature(FacebookWrapper.ObjectModel.User m_LoggedInUser)
        {
            // TODO: Complete member initialization
            this.m_LoggedInUser = m_LoggedInUser;
        }

    }
}
