namespace MatrixRefactoring
{
    using System;

    public class SquareMatrix
    {
        private const int MinSize = 1;

        private const int MaxSize = 100;

        private const int DirectionsCount = 8;

        private int size;

        private int[,] matrix;

        public SquareMatrix(int size)
        {
            this.Size = size;

            this.matrix = new int[size, size];
            this.Row = 0;
            this.Column = 0;
            this.StepRow = 1;
            this.StepCol = 1;
            this.CurrentNumber = 1;

            this.FillTheWholeMatrix();
        }

        public int Size
        {
            get
            {
                return this.size;
            }

            private set
            {
                if (value < MinSize || value > MaxSize)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Size must be a number between {0} and {1}.", MinSize, MaxSize));
                }

                this.size = value;
            }
        }

        private int Row { get; set; }

        private int Column { get; set; }

        private int StepRow { get; set; }

        private int StepCol { get; set; }

        private int CurrentNumber { get; set; }

        public int this[int x, int y]
        {
            get
            {
                if (this.CheckIfPositionOutOfRange(x, y))
                {
                    throw new IndexOutOfRangeException("No such position exists.");
                }

                return this.matrix[x, y];
            }
        }

        public void PrintOnConsole()
        {
            Console.WriteLine("Matrix:");

            for (int row = 0; row < this.Size; row++)
            {
                for (int col = 0; col < this.Size; col++)
                {
                    Console.Write("{0,3}", this.matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        private void FillTheWholeMatrix()
        {
            this.MainFill();
            this.FindEmptyCell();

            if (this.Row != 0 && this.Column != 0)
            {
                this.StepRow = 1;
                this.StepCol = 1;
                this.MainFill();
            }
        }

        private void UpdateSteps()
        {
            int[] directionsRow = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionsCol = { 1, 0, -1, -1, -1, 0, 1, 1 };

            int updateValue = 0;

            for (int count = 0; count < DirectionsCount; count++)
            {
                if (directionsRow[count] == this.StepRow && directionsCol[count] == this.StepCol)
                {
                    updateValue = count;
                    break;
                }
            }

            if (updateValue == (DirectionsCount - 1))
            {
                this.StepRow = directionsRow[0];
                this.StepCol = directionsCol[0];
                return;
            }

            this.StepRow = directionsRow[updateValue + 1];
            this.StepCol = directionsCol[updateValue + 1];
        }

        private bool CheckIfCanContinue()
        {
            int[] directionsRow = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionsCol = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < DirectionsCount; i++)
            {
                if (this.Row + directionsRow[i] >= this.Size || this.Row + directionsRow[i] < 0)
                {
                    directionsRow[i] = 0;
                }

                if (this.Column + directionsCol[i] >= this.Size || this.Column + directionsCol[i] < 0)
                {
                    directionsCol[i] = 0;
                }
            }

            for (int i = 0; i < DirectionsCount; i++)
            {
                if (this.matrix[this.Row + directionsRow[i], this.Column + directionsCol[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private void FindEmptyCell()
        {
            for (int r = 0; r < this.Size; r++)
            {
                for (int c = 0; c < this.Size; c++)
                {
                    if (this.matrix[r, c] == 0)
                    {
                        this.Row = r;
                        this.Column = c;
                        return;
                    }
                }
            }

            this.Row = 0;
            this.Column = 0;
        }

        private void MainFill()
        {
            while (true)
            {
                this.matrix[this.Row, this.Column] = this.CurrentNumber;
                this.CurrentNumber++;

                bool canContinue = this.CheckIfCanContinue();
                if (!canContinue)
                {
                    break;
                }

                bool positionIsOutOfRange = this.CheckIfPositionOutOfRange(this.Row + this.StepRow, this.Column + this.StepCol);
                while (positionIsOutOfRange || this.matrix[this.Row + this.StepRow, this.Column + this.StepCol] != 0)
                {
                    this.UpdateSteps();
                    positionIsOutOfRange = this.CheckIfPositionOutOfRange(this.Row + this.StepRow, this.Column + this.StepCol);
                }

                this.Row += this.StepRow;
                this.Column += this.StepCol;
            }
        }

        private bool CheckIfPositionOutOfRange(int nextRow, int nextCol)
        {
            bool rowIsOut = nextRow < 0 || nextRow >= this.Size;
            bool colIsOut = nextCol < 0 || nextCol >= this.Size;

            bool positionIsOut = rowIsOut || colIsOut;
            return positionIsOut;
        }
    }
}
