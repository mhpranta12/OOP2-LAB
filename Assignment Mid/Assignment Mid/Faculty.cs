using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Mid
{
    class Faculty
    {
        private int sccount = 0;
        private string facultyName;

        public string FacultyName
        {
            get { return facultyName; }
            set { facultyName = value; }
        }
        private string facultyId;

        public string FacultyId
        {
            get { return facultyId; }
            set { facultyId = value; }
        }
        private float teachHr;

        public float TeachHr
        {
            get { return teachHr; }
            set { teachHr = value; }
        }


        public Faculty (string facultyName,string facultyId)
            {
            this.facultyName = facultyName;
            this.facultyId = facultyId;
            seclist = new Section[100];
            }

        Section [] seclist;

        public void AddSection(Section sc)
        {
            seclist[sccount++] = sc;
        }

        public void ShowSection()
        {
            for (int i = 0; i < sccount; i++)
            {
                seclist[i].showInfo();

            }
        }

        public void AddTeachHour(Section sc)
        {
            if (teachHr+sc.secHr>21)
            {
                Console.WriteLine("Sorry Can't Add more Section . Because it will exceed 21 hrs in a week !!");
            }
            else
            {
                this.teachHr = this.teachHr + sc.secHr;
            }
        }

        public void showInfo()
        {
            Console.WriteLine("Teacher's Name :"+facultyName);
            Console.WriteLine(facultyId);
            Console.WriteLine(teachHr);
            FShowSection();
        }

        public void FShowSection()
        {
            for (int i = 0; i < sccount; i++)
            {
                seclist[i].showInfo();

            }
        }

    }
}
