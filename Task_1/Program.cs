bool check = false;
int number = 0;

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

int ReadNumber()
{
    while (check == false)
    {
        string text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            check = true;
        }
        else
        {
            Console.WriteLine("Не удалось распознать число, поробуйте ещё раз");
        }
    }
    check = false;
    return number;
}

Console.WriteLine("Введите количество строк массива");
int sizeRows = ReadNumber();
Console.WriteLine("Введите количество столбцов массива");
int sizeСols = ReadNumber();
double[,] matrix = GetMatrix(sizeRows, sizeСols);
PrintMatrix(matrix);