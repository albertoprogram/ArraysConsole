using System;

namespace ArraysConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Sample an element of an array\n");

            Console.ReadKey();

            byte[] testScoresForStudents;

            testScoresForStudents = new byte[25];

            testScoresForStudents[0] = 75;

            byte firsTestScore = testScoresForStudents[0];

            Console.WriteLine("The first value of the array is: {0}", firsTestScore.ToString());

            Console.ReadKey();

            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Traversal of a array of integers\n");

            Console.ReadKey();

            int[] myArray = { 5, 9, 2, 4, 8 };

            foreach (int item in myArray)
            {
                Console.WriteLine("The processed item is: {0}", item.ToString());
            }

            Console.ReadKey();

            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Two-dimensional array\n");

            Console.ReadKey();

            byte[,] scoreForStudents;

            scoreForStudents = new byte[10, 25];

            scoreForStudents[0, 24] = 79;

            byte scoreStudent = scoreForStudents[0, 24];

            Console.WriteLine("Student's score of 25 on his first exam is: {0}", scoreStudent);

            Console.ReadKey();

            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Other Two-dimensional matrix\n");

            Console.ReadKey();

            int[,] myMultiArray = { { 15, 25, 35 },
                                    { 40, 60, 80 } };

            int currentValue = 0;

            int numberOfRows = myMultiArray.GetLength(0);

            int numberOfColumns = myMultiArray.GetLength(1);

            for (int currentRow = 0; currentRow < numberOfRows; currentRow++)
            {
                for (int currentColumn = 0; currentColumn < numberOfColumns; currentColumn++)
                {
                    currentValue = myMultiArray[currentRow, currentColumn];

                    Console.WriteLine(currentValue);
                }
            }

            Console.ReadKey();

            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Other traversal of the same array\n");

            Console.WriteLine("Array as a Table\n");

            Console.ReadKey();

            string arrayAsATable = string.Empty;

            currentValue = 0;

            for (int currentRow = 0; currentRow < numberOfRows; currentRow++)
            {
                if (currentRow > 0)
                {
                    arrayAsATable = arrayAsATable.Remove(arrayAsATable.Length - 1);
                    arrayAsATable = arrayAsATable + "\n";
                }

                for (int currentColumn = 0; currentColumn < numberOfColumns; currentColumn++)
                {
                    arrayAsATable += myMultiArray[currentRow, currentColumn].ToString() + ";";
                }
            }

            arrayAsATable = arrayAsATable.Remove(arrayAsATable.Length - 1);

            Console.WriteLine(arrayAsATable);

            Console.ReadKey();

            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Echelon array\n");

            Console.ReadKey();

            byte[][] arraysOfTestScores;

            arraysOfTestScores = new byte[3][];

            arraysOfTestScores[0] = new byte[1];
            arraysOfTestScores[1] = new byte[2];
            arraysOfTestScores[2] = new byte[3];

            arraysOfTestScores[0][0] = 18;
            arraysOfTestScores[1][0] = 22;
            arraysOfTestScores[1][1] = 31;
            arraysOfTestScores[2][0] = 43;
            arraysOfTestScores[2][1] = 57;
            arraysOfTestScores[2][2] = 62;

            Console.WriteLine("The first value in the echelon array is: {0}", arraysOfTestScores[0][0].ToString());

            Console.ReadKey();

            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Echelon array as a table\n");

            Console.WriteLine("Please, press Enter\n");

            Console.ReadKey();

            currentValue = 0;

            int rowCount = arraysOfTestScores.GetLength(0);

            arrayAsATable = string.Empty;

            for (int currentRow = 0; currentRow < rowCount; currentRow++)
            {
                if (currentRow > 0)
                {
                    arrayAsATable = arrayAsATable.Remove(arrayAsATable.Length - 1);
                    arrayAsATable = arrayAsATable + "\n";
                }

                for (int currentColumn = 0; currentColumn < arraysOfTestScores[currentRow].GetLength(0); currentColumn++)
                {
                    arrayAsATable += arraysOfTestScores[currentRow][currentColumn].ToString() + ";";
                }
            }

            arrayAsATable = arrayAsATable.Remove(arrayAsATable.Length - 1);

            Console.WriteLine(arrayAsATable);

            Console.ReadKey();
        }
    }
}
