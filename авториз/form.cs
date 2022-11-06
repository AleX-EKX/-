using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avtoriz
{
    class data
    {
        public static  bron bron;
        public static string vremy;

        internal static bool pn16 = false; internal static bool vt16 = false; internal static bool cr16 = false; internal static bool cht16 = false;
        internal static bool pn17 = false; internal static bool vt17 = false; internal static bool cr17 = false; internal static bool cht17 = false;
        internal static bool pn18 = false; internal static bool vt18 = false; internal static bool cr18 = false; internal static bool cht18 = false;
        internal static bool pn19 = false; internal static bool vt19 = false; internal static bool cr19 = false; internal static bool cht19 = false;
        internal static bool pn20 = false; internal static bool vt20 = false; internal static bool cr20 = false; internal static bool cht20 = false;
        internal static bool pn21 = false; internal static bool vt21 = false; internal static bool cr21 = false; internal static bool cht21 = false;
        internal static bool pn22 = false; internal static bool vt22 = false; internal static bool cr22 = false; internal static bool cht22 = false;

        internal static bool pt16 = false; internal static bool pt17 = false; internal static bool pt18 = false; internal static bool pt19 = false;
        internal static bool pt20 = false; internal static bool pt21 = false; internal static bool pt22 = false;

        internal static bool sb8 = false; internal static bool sb15 = false; internal static bool vs8 = false; internal static bool vs15 = false;
        internal static bool sb9 = false; internal static bool sb16 = false; internal static bool vs9 = false; internal static bool vs16 = false;
        internal static bool sb10 = false; internal static bool sb17 = false; internal static bool vs10 = false; internal static bool vs17 = false;
        internal static bool sb11 = false; internal static bool sb18 = false; internal static bool vs11 = false; internal static bool vs18 = false;
        internal static bool sb12 = false; internal static bool sb19 = false; internal static bool vs12 = false; internal static bool vs19 = false;
        internal static bool sb13 = false; internal static bool sb20 = false; internal static bool vs13 = false; internal static bool vs20 = false;
        internal static bool sb14 = false; internal static bool sb21 = false; internal static bool vs14 = false; internal static bool vs21 = false;
        internal static bool sb22 = false; internal static bool vs22 = false;


        internal static bool vse = false;
    }
    public enum bron
    {
        ponedelnik16 = 1,
        ponedelnik17 = 2,
        ponedelnik18 = 3,
        ponedelnik19 = 4,
        ponedelnik20 = 5,
        ponedelnik21 = 6,
        ponedelnik22 = 7,
        vtornik16 = 8,
        vtornik17 = 9,
        vtornik18 = 10,
        vtornik19 = 11,
        vtornik20 = 12,
        vtornik21 = 13,
        vtornik22 = 14,
        creda16=15,
        creda17 = 16,
        creda18 = 17,
        creda19 = 18,
        creda20 = 19,
        creda21 = 20,
        creda22 = 21,
        chetverg16 = 22,
        chetverg17 = 23,
        chetverg18 = 24,
        chetverg19 = 25,
        chetverg20 = 26,
        chetverg21 = 27,
        chetverg22 = 28,
        pyatnitsa16=29,
        pyatnitsa17 = 30,
        pyatnitsa18 = 31,
        pyatnitsa19 = 32,
        pyatnitsa20 = 33,
        pyatnitsa21 = 34,
        pyatnitsa22 = 35,
        subbota8=36,
        subbota9 = 37,
        subbota10 = 38,
        subbota11 = 39,
        subbota12 = 40,
        subbota13 = 41,
        subbota14 = 42,
        subbota15 = 43,
        subbota16 = 44,
        subbota17 = 45,
        subbota18 = 46,
        subbota19 = 47,
        subbota20 = 48,
        subbota21 = 49,
        subbota22 = 50,
        voskresene8=51,
        voskresene9 = 52,
        voskresene10 = 53,
        voskresene11 = 54,
        voskresene12 = 55,
        voskresene13 = 56,
        voskresene14 = 57,
        voskresene15 = 58,
        voskresene16 = 59,
        voskresene17 = 60,
        voskresene18 = 61,
        voskresene19 = 62,
        voskresene20 = 63,
        voskresene21 = 64,
        voskresene22 = 65,

        //nul = ,
        Denied = 0

    }

}
