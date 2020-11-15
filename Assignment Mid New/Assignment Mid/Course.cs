using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Mid
{
    class Course
    {
        int sccount = 0;
        private string cName;
        
        public  string CName
        {
            get { return cName; }
            set { cName = value; }
        }

        public int cteachingHr;

        public int CTeachingHr
        {
            get { return cteachingHr; }
            set { cteachingHr = value; }
        }

        private  string courseId;

        public  string CourseId
        {
            get { return courseId; }
            set { courseId = value; }
        }
    
        public void AddSection(Section sc)
        {
           sectionlist [sccount++] = sc;
        }
        Section[] sectionlist;
        public Course ()
        {
            sectionlist = new Section[100];
        }
        public Course(string cName,string courseId ,int cteachingHr)
        {
            this.cName = cName;
            this.courseId = courseId;
            this.cteachingHr = cteachingHr;
            sectionlist = new Section[100];
        }
        public void showInfo()
        {
            Console.WriteLine("Course Name : " +cName);
            Console.WriteLine("Course ID : " +courseId);
            Console.WriteLine("Course Teaching Hour : "+cteachingHr+ "hrs");
        }
        public void ShowSection()
        {
            Console.WriteLine("This Course has :");
            for (int i = 0; i < sccount; i++)
                {
                    sectionlist[i].showInfo();
                   
                }
        }

    }
}
