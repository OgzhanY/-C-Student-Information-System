using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Donemler
    {
        private int donemID;
        private string donemAd;

        public int DonemID
        {
            get
            {
                return donemID;
            }

            set
            {
                donemID = value;
            }
        }

        public string DonemAd
        {
            get
            {
                return donemAd;
            }

            set
            {
                donemAd = value;
            }
        }
    }
}
