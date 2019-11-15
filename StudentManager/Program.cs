using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class Program
    {
       static Student[] studentList;
        static void Main(string[] args)
        {
            //nhap tong so sinh vien
            int numOfStudent;
            
            try
            {
                Console.Write("Num of Student: ");
                numOfStudent = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {

                Console.WriteLine("Invalid Input Number Of Student!!!(0)",ex.Message);
                Console.ReadKey();
                return;
                    
            }
            //tao danh sach sinh vien
            InputStudentList(numOfStudent);
            OutputStudentList();
            Console.ReadKey();

        }
        /// <summary>
        /// ham xuat ds sinh vien
        /// </summary>
        private static void OutputStudentList()
        {
            foreach (var student in studentList)
            {
                Console.WriteLine("Student ID = [0]", student.StudentID);
                Console.WriteLine("Student FullName = [0]", student.FullName);
                Console.WriteLine("Student Mark = [0]", student.Mark);
                Console.WriteLine("Student Falculty = [0]", student.Falculty);
            }
        }

        private static void InputStudentList(int numOfStudent)
        {
            //tao mang luu danh sach sinh vien

            studentList =new Student[numOfStudent];
            Student student;
            for (int i = 0; i < numOfStudent; i++)
            {
                student = new Student();
                Console.Write("Student ID = ");
                student.StudentID = int.Parse(Console.ReadLine());
                Console.Write("Student FullName = ");
                student.FullName = Console.ReadLine();
                Console.Write("Student Mark = ");
                student.Mark = float.Parse(Console.ReadLine());
                Console.Write("Student Falculty = ");
                student.Falculty = Console.ReadLine();
            }
        }
    }
}
