using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    internal class Student
    {
        #region fields


        string name;
        public int age;
        string department;
        int level;
        string course;

        #endregion

        // properties

        #region Properties
        public string Name
        {
            get { return name; }
            set 
            { 
                if(!string.IsNullOrEmpty(value))
                name = value; 
            }
        }

        public int Level
        {
            get { return level; }
            set
            {
                if (value > 200)
                {
                    level = value;
                }
            }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public string School { get; set; }

        public bool isRegistered { get; }  // This is read only 
        public bool isGraduated { set { } } // Write only

        #endregion Properties

        // Define constructors for the student class
        #region Constructors
        public Student()
        {

        }
        public Student(string name, int age, string department, int level, string course)
        {
            this.name = name;
            this.age = age;
            this.department = department;
            this.level = level;
            this.course = course;
            isGraduated = false;
            isRegistered = false;
        }

        #endregion Constructors

        #region Method
        public string showInfo()
        {
            return $"{name} is {age} years old and he's in the {department} department studing {course} this sem, He's currently in level {level}. ==> school: {School}";
        } 
        #endregion Method
    }
}
