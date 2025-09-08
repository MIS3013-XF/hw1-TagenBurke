// HW1b Grade

// Your Name:
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    /*
     * Sylabuss weights
     * Assignments 20%
     * Exam 1 15%
     * Exam 2 25%
     * Exam 3 25%
     * Participation 15%
     * Quizzes 0%
     * 
     * Ouptput
     * String First Name
     * String Last Name
     * String Student ID
     * String percentage for Assignments 
     * String percentage for Participation
     * String percentage for Quizzes
     * String percentage for Exam 1
     * String percentage for Exam 2
     * String percentage for Exam 3
     * Final Concation First Name + Last Name + Student ID + Final Grade
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //Weights
            double AssignmentsWeight = 0.20;
            double Exam1Weight = 0.15;
            double Exam2Weight = 0.25;
            double Exam3Weight = 0.25;
            double ParticipationWeight = 0.15;
            double QuizzesWeight = 0;



            //Strings
            string firstNameString = "Enter your first name:";
            string FirstName;

            string lastNameString = "Enter your last name:";
            string LastName;

            string studentIDString = "Enter your student ID:";
            string StudentID;

            string assignmentsString = "Enter your percentage for Assignments:";
            string participationString = "Enter your percentage for Participation:";
            string quizzesString = "Enter your percentage for Quizzes:";
            string exam1String = "Enter your percentage for Exam 1:";
            string exam2String = "Enter your percentage for Exam 2:";
            string exam3String = "Enter your percentage for Exam 3:";
            string finalGradeString = "Your final grade is: ";

            Console.WriteLine(firstNameString);
            FirstName = Console.ReadLine();

            Console.WriteLine(lastNameString);
            LastName = Console.ReadLine();

            Console.WriteLine(studentIDString);
            StudentID = Console.ReadLine();

            Console.WriteLine(assignmentsString);
            double assignments = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(participationString);
            double participation = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(quizzesString);
            double quizzes = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(exam1String);
            double exam1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(exam2String);
            double exam2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(exam3String);
            double exam3 = Convert.ToDouble(Console.ReadLine());

            double FinaleGrade = (assignments * AssignmentsWeight) + (participation * ParticipationWeight) + (quizzes * QuizzesWeight) + (exam1 * Exam1Weight) + (exam2 * Exam2Weight) + (exam3 * Exam3Weight);

            Console.WriteLine(finalGradeString);
            Console.WriteLine(FinaleGrade);
            
            Console.Write(FirstName + " " + LastName + " " + "(" + StudentID + ")" +", " + "your final grade is" + " " + $"{FinaleGrade:F2}%");
        
        }
    }
}
