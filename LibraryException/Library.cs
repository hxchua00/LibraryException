using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryException
{
    class Library : Class
    {
        bool verified = false;

        public bool VerifyStudent(int rollNum)
        {
            for (int i=0; i < Classroom.Count; i++)
            {
                if (Classroom[i].RollNum == rollNum)
                {
                    verified = true;
                }
            }
            return verified;
        }

        public void IssueBook(int rollNum)
        {
            
        }
    }
}
