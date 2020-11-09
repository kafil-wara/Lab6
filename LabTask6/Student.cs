using System;
using System.Collections.Generic;
using System.Text;

namespace LabTask6
{
    class Student
    {
        //string name;
        //string id;
        //string dept;
        //float cgpa;

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string dept;

        public string Dept
        {
            get { return dept; }
            set { dept = value; }
        }

        private float cgpa;

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }

        Student()
        {
            Console.WriteLine("Default Student Constructor");
        }

        Student(string name, string id, string dept, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.dept = dept;
            this.cgpa = cgpa;
        }


        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Department: " + dept);
            Console.WriteLine("CGPA: " + cgpa);
        }

    }
}
