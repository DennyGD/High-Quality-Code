namespace MatrixRefactoring
{
    using System;

    public class Start
    {
        public static void Main()
        {
            int matrixSize = GetMatrixSize();
            var myMatrix = new SquareMatrix(matrixSize);
            myMatrix.PrintOnConsole();
        }

        public static int GetMatrixSize()
        {
            Console.WriteLine("Please enter an integer in range [1, 100].");
            
            string input = Console.ReadLine();
            int size = 0;

            while (!int.TryParse(input, out size) || size < 0 || size > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                input = Console.ReadLine();
            }

            return size;
        }
    }
}
