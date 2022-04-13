using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bolumler
    {
        private int bolumID;
        private string bolumAd;
        private int akedemik_Birim_ID;

        public int BolumID
        {
            get
            {
                return bolumID;
            }

            set
            {
                bolumID = value;
            }
        }

        public string BolumAd
        {
            get
            {
                return bolumAd;
            }

            set
            {
                bolumAd = value;
            }
        }

        public int Akedemik_Birim_ID
        {
            get
            {
                return akedemik_Birim_ID;
            }

            set
            {
                akedemik_Birim_ID = value;
            }
        }
    }
}
