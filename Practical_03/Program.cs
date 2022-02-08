using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_03
{
    internal class Students
    {
       
            int roll_no;
            string name;
            int[] marks = new int[3];
            public void percentage()
            {
                int per=0;
                per = marks.Sum()/3;
                Console.WriteLine(grade(per));
                Console.WriteLine(per);
            }
            private string grade(int per)
            {
            if (per >= 80 && per <= 100)
            {
                return "First Class";
            }
            else if (per >= 70 && per <= 79)
            {
                return "Second Class";
            }
            else if(per>=60 &&per <= 69)
            {
                return "Pass";
            }
            else
            {
                return "Fail";
            }
            }
        static void Main(string[] args)
        {
            Students students = new Students();
            Console.WriteLine("Enter student roll number");
            students.roll_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student name");
            students.name = Console.ReadLine();
            Console.WriteLine("Enter student marks");
            for(int i = 0; i < 3; i++)
            {
                students.marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            students.percentage();
            Console.ReadLine();
        }
    }
}
