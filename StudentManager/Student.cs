﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class Student
    {
        //crtl+c+k: coment
        //crtl+k+u:uncoment
        //crtl+k+d: format code
        public int StudentID { get; set; }
        public string FullName { get; set; }
        public float Mark  { get; set; }
        public string Falculty { get; set; }
        public Student()
        {

        }
        public Student(int studentID,string fullName,float mark,string falculty)
        {
            StudentID = studentID;
            FullName = fullName;
            Mark = mark;
            Falculty = falculty;

        }
    }
}
