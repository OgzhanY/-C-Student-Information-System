using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Devamsizlik
    {
        private int devID;
        private int ogrID;
        private int dersID;
        DateTime Tarih;

        public int DevID
        {
            get
            {
                return devID;
            }

            set
            {
                devID = value;
            }
        }

        public int OgrID
        {
            get
            {
                return ogrID;
            }

            set
            {
                ogrID = value;
            }
        }

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
    }
}
