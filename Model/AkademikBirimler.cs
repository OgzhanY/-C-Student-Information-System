using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AkademikBirimler
    {
        private int akademikBirimID;
        private string ad;


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

        public int AkademikBirimID
        {
            get
            {
                return akademikBirimID;
            }

            set
            {
                akademikBirimID = value;
            }
        }
    }
}
