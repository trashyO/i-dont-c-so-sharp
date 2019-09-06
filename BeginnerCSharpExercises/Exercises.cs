using System;

namespace BeginnerCSharpExercises
{
    public class Exercises
    {
        public void Question4()
        {
            int x = -1;
            int y = 4;
            int z = 6;
            int a = 11;
            int b = 7;
            Console.WriteLine($"{x} + {y} * {z} = {x + y * z}");

            x = 35;
            y = 5;
            z = 7;    
            Console.WriteLine($"({x} + {y}) % {z} = {(x + y) % z}");
            
            x = 14;
            y = -4;
            z = 6;
            Console.WriteLine($"{x} + {y} * {z} / {a} = {x + y * z / a}");
            
            x = 2;
            y = 15;
            z = 6;
            a = 1;
            Console.WriteLine($"{x} + {y} / {z} * {a} - {b} % {x} = {x + y / z * a - b % x}");
        }
        
        public void Question5()
        {
            Console.WriteLine("Please enter a number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number: ");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine($"{x} * {y} * {z} = {x*y*z}");
        }

        public void Question8()
        {
            Console.WriteLine("Please enter a number: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine($"{x} * {i} = {x*i}");
            }
        }

        // Build a dynamic square
        public void Question13()
        {
            const int FirstRow = 0;

            Console.WriteLine("Please enter a character to build square: ");
            char x = char.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the number of rows: ");
            int NumberOfRows = int.Parse(Console.ReadLine());
            int LastRow = (NumberOfRows - 1);
            Console.WriteLine("Please enter the number of columns: ");
            int NumberOfColumns = int.Parse(Console.ReadLine());
            int LastColumn = (NumberOfColumns - 1);

            
            for (int CurrentRow = FirstRow; CurrentRow <= LastRow; CurrentRow++)
            {
                    for (int CurrentColumn = FirstRow; CurrentColumn <= LastColumn; CurrentColumn++)
                    {
                        if (IsFirstOrLastColumn(CurrentColumn, FirstRow, LastColumn) || IsFirstOrLastRow(CurrentRow, FirstRow, LastRow))
                        {
                            Console.Write(x);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
            }
        }

        private static bool IsFirstOrLastRow(int CurrentRow, int FirstRow, int LastRow)
        {
            return CurrentRow == FirstRow || CurrentRow == LastRow;
        }

        private static bool IsFirstOrLastColumn(int CurrentColumn, int FirstRow, int LastColumn)
        {
            return CurrentColumn == FirstRow || CurrentColumn == LastColumn;
        }

        public void Question15()
        {
            Console.WriteLine("Enter degrees Celsius: ");
            int celsius = int.Parse(Console.ReadLine());
            
            
        }
    }

}