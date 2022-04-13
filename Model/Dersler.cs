using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Dersler
    {
        private int dersID;
        private string dersKodu;
        private int bolumID;
        private int donemID;

        public int DersID
        {
            get
            {
                return dersID;
            }

            set
            {
                dersID = value;
            }
        }

        public string DersKodu
        {
            get
            {
                return dersKodu;
            }

            set
            {
                dersKodu = value;
            }
        }

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
    }
}
