using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AkedemikBirimler
    {
        private int akedemik_Birim_ID;
        private string ad;

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

        public string Ad
        {
            get
            {
                return ad;
            }

            set
            {
                ad = value;
            }
        }
    }
}
