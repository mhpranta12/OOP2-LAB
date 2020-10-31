using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3task_new
{
    class Student
    {

        string name;
        string id;
        string department;
        float cgpa;
        public string Name
        {
            get { return name; }
            set { value = name; }
        }

        public string Id
        {
            get { return id; }
            set { value = id; }
        }

        public string Department
        {
            get { return department; }
            set { value = department; }
        }

        public float Cgpa
        {
            get { return cgpa; }
            set { value = cgpa; }
        }

       

        public Student (string name, string id,string department,float cgpa) 
            {
            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;
            }
        public void showinfo ()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("ID :" + id);
            Console.WriteLine("Department :" + department);
            Console.WriteLine("cgpa :" + cgpa);
            
        }

        static void Main(string[] args)
        {
            Student s1 = new Student("pranta","12","cse",12);
            s1.showinfo();
        }
    }
}
