using System;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;


namespace _523116184522448
{
    internal class EventDetails
    {
        private DateTime m_StartingTime;
        private DateTime m_EndingTime;
        private eEventVisibility m_Visibility;
        private eEventRepetitionPattern m_RepetitionPattern;
        private string m_Name;
        private Location m_Location;

        public eEventRepetitionPattern RepetitionPattern
        {
            get
            {
                return m_RepetitionPattern;
            }

            set
            {
                m_RepetitionPattern = value;
            }
        }

        public EventDetails()
        {
            m_RepetitionPattern = eEventRepetitionPattern.Daily;
        }
    }
}