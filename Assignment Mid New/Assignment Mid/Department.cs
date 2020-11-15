using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Mid
{
    class Department
    {
        private int cocount = 0;
       
        private string deptname;

        public string DeptName
        {
            get { return deptname; }
            set { deptname = value; }
        }
        public Department(string deptname)
        {
            this.deptname = deptname;
            listofcourse = new Course[100];
        }


        Course [] listofcourse;
        public void AddCourse(Course cs)
        {
            listofcourse[cocount++] = cs;
        }
        public void ShowCourse()
        {
            Console.WriteLine("Dept of "+this.deptname+" has Courses :");
            for(int i=0; i<cocount;i++)
            {
                listofcourse[i].showInfo();
            }
        }

    }

}
