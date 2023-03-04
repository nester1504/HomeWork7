double[,] GetMatrix(int rows, int cols)
{
    double[,] matrix = new double[rows, cols]; 
    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().NextDouble() * new Random().Next(-100, 101); 
            matrix[i, j] = Math.Round(matrix[i, j], 1);
        }
    }
    return matrix; 
}

void PrintMatrix(double[,] matr) 
{
    int sizeRows = matr.GetLength(0);
    int sizeCols = matr.GetLength(1);
    for (int i = 0; i < sizeRows; i++) 
    {
        for (int m = 0; m < sizeCols; m++) 
        {
            Console.Write(matr[i, m] + "\t"); 
        }
        Console.WriteLine();
    }
}

double[,] matrix = GetMatrix(4, 4);
PrintMatrix(matrix);