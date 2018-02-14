using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSpec
{
    class Play
    {
        private int m_playid;
        private string m_playName;
        private DateTime m_startDate;
        private DateTime m_endDate;
        private int[] seatPrices = new int[3];
        private Seat[][] upperCircle = {
            new Seat[22],
            new Seat[25],
            new Seat[25],
            new Seat[25],
            new Seat[10],
        };
        private Seat[][] dressCircle = {
            new Seat[35],
            new Seat[37],
            new Seat[19],
            new Seat[23],
            new Seat[23],
        };
        private Seat[][] stalls = {
            new Seat[17],
            new Seat[18],
            new Seat[20],
            new Seat[22],
            new Seat[22],
            new Seat[22],
            new Seat[22],
            new Seat[22],
            new Seat[22],
            new Seat[20],
            new Seat[20],
            new Seat[20],
        };

        public string PlayName {
            get
            {
                return m_playName;
            }
            set
            {
                m_playName = value;
            }
        }
        public DateTime StartDate
        {
            get
            {
                return m_startDate;
            }
            set
            {
                m_startDate = value;
            }
        }
        public DateTime EndDate
        {
            get
            {
                return m_endDate;
            }
            set
            {
                m_endDate = value;
            }
        }

        public Play(string p_PlayName, DateTime p_StartDate, DateTime p_EndDate, int[] p_Prices)
        {
            PlayName = p_PlayName;
            StartDate = p_StartDate;
            EndDate = p_EndDate;
            seatPrices = p_Prices;
        }
        public void AddBooking()
        {

        }
        public void RemoveBooking()
        {

        }
    }
}
