using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace _523116184522448
{
    class Utilities
    {
        private User m_LoggedInUser;
        private List<Event> m_Events;

        public Utilities(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
        }

        internal void fetchEvents()
        {
            foreach (Event fbEvent in m_LoggedInUser.Events)
            {
                m_Events.Add(fbEvent);
            }

            if (m_LoggedInUser.Events.Count == 0)
            {
                throw new Exception("No Events to retrieve :(");
            }
        }

        
    }
}
