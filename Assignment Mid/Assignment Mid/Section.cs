using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Mid
{
    class Section
    {
        private string secName;

        public string SecName
        {
            get { return secName; }
            set { secName = value; }
        }

        public float secHr;

        public float SecHr
        {
            get { return secHr; }
            set { secHr = value; }
        }
        public Section(string secName , float secHr)
        {
            this.secName = secName;
            this.secHr = secHr;
        }
        public void showInfo()
        {
            Console.WriteLine("Sec Name:"+secName);
            Console.WriteLine("Sec Time :" + secHr);
        }


    }
}
