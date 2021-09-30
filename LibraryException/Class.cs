using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryException
{
    
    struct Student
    {
        public string StudName;
        public int RollNum;
        public int Bookcount;

        public Student(string name, int rollNum, int bookcount)
        {
            StudName = name;
            RollNum = rollNum;
            Bookcount = bookcount;
        }
    };
    class Class
    {
        Student student;
        protected List<Student> Classroom = new List<Student>();

        public void AddStudent(Student student)
        {
            Classroom.Add(student);
        }

        public void BorrowBook()
        {
            Library lib = new Library();

            Console.WriteLine("Enter student roll number: ");
            int rollNum = Convert.ToInt32(Console.ReadLine());
            bool result = lib.VerifyStudent(rollNum);

            if(result == true)
            {
                for(int i =0; i< Classroom.Count; i++)
                {
                    if(Classroom[i].RollNum == rollNum)
                    {
                        if(student.Bookcount == 0)
                        {
                            lib.IssueBook(rollNum);
                        }
                        else
                        {
                            Console.WriteLine("You already have a book issued!");
                            Console.WriteLine();
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("The roll number " + rollNum + " is not in the registry!");
                Console.WriteLine("Please enter a valid roll number!");
                Console.WriteLine();
            }
        }

        public void PrintStudentDetails(Student student)
        {
            Console.WriteLine("Student Name: " + student.StudName);
            Console.WriteLine("Student RollNumber: " + student.RollNum);
            Console.WriteLine("Book borrowed: " + student.Bookcount);
            Console.WriteLine();
        }
     
    }
}
