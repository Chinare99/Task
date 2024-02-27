using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _26._02_Ev_Tapşırığı.Models
{
    public class Student
    {
        int i;
        int item;
        public int[] Grades { get; set; }
        public Student()
        {
            Grades = new int[0];
            {

                int[] grades = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, };
                {   for (int i = 0; i < grades.Length; i++)
                    {
                        if (item % 2 == 0)
                        {
                            Grades[i] = grades[i];
                        }
                    }
                }
            }
        }

    }
}
