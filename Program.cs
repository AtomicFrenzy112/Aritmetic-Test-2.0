using System;

namespace Arithmetic_Test_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A primary school teacher wants a computer program to test the basic
             * arithmetic skills of her students. Generate random questions (2 numbers only) 
             * consisting of addition, subtraction, multiplication and division.

            The system should ask the student’s name and then ask ten questions. 
            The program should feed back if the answers are correct or not, and 
            then generate a final score at the end.

            Extensions:

            1. Extend your program so that it stores the results somewhere.
            The teacher has three classes, so you need to enable the program
            to distinguish between them.

            2. The teacher wants to be able to log student performance in
            these tests. The teacher would like the program to store the last 
            three scores for each student and to be able to output the results 
            in alphabetical order with the student’s highest score first out
            of the three.*/

            Console.WriteLine("Enter full name");
            string pupilName = Console.ReadLine();
            

            int score = 0;
            

            string[,] testArray = new string[,]
            {
                {"What is 35 + 9","44"},
                {"What is 48 + 20","68"},
                {"What is 67 - 31","36"},
                {"What is 6 x 4","24"},
                {"What is 56 / 8","7"},
                {"What is 98 - 31","67"},
                {"What is 7 x 7","49"},
                {"What is 43 x 2","86"},
                {"What is 81 / 9","9"},
                {"What is 21 / 3","7"}

            };
            for(int i = 0; i<= 9; i++)
            {
                Console.WriteLine("");
                Console.WriteLine(testArray[i,0]);
                string studentAnswer = Console.ReadLine();
                if (studentAnswer == testArray[i, 1])
                {
                    Console.WriteLine("Correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect. The answer is "+testArray[i,1]);
                }

            }
            
            Console.WriteLine("");
            Console.WriteLine("Pupil "+pupilName+" scored "+score+"/10");

        }
    }
}
