using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSpec
{
    static class Theatre
    {
        private static List<Play> plays = new List<Play>();

        public static bool AddPlay(string p_PlayName, DateTime p_StartDate, DateTime p_EndDate, string p_UpperCirclePrice, string p_DressCirclePrice, string p_StallPrice)
        {
            plays.Add(new Play(p_PlayName, p_StartDate, p_EndDate, new int[] { int.Parse(p_UpperCirclePrice), int.Parse(p_DressCirclePrice), int.Parse(p_StallPrice) }));
            return true;
        }

        public static void RemovePlay()
        {

        }

        public static void Save()
        {

        }

        public static void Load()
        {

        }
    }
}
