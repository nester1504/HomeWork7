bool check = false;
int number = 0;

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

int[,] GetMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];

    Console.Write("Введите двумерный массив: ");

    int sizeRows = matrix.GetLength(0);
    int sizeCols = matrix.GetLength(1);

    for (int i = 0; i < sizeRows; i++)
    {
        for (int j = 0; j < sizeCols; j++)
        {
            matrix[i, j] = ReadNumber();
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matr)
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

void ArithmeticMeanCols(int[,] matr)
{
    int sizeRows = matr.GetLength(0);
    int sizeCols = matr.GetLength(1);
    int sum = 0;
    for (int i = 0; i < sizeCols; i++)
    {
        for (int m = 0; m < sizeRows; m++)
        {
            sum = sum + matr[i, m];
        }
        sum = sum / sizeCols ;
        Console.WriteLine($" Среднее арифметическое элементов {i} слолбца = {sum}");
        sum = 0;
    }
}


Console.WriteLine("Введите количество строк массива");
int sizeRows = ReadNumber();
Console.WriteLine("Введите количество столбцов массива");
int sizeСols = ReadNumber();

int[,] matrix = GetMatrix(sizeRows, sizeСols);

PrintMatrix(matrix);

ArithmeticMeanCols(matrix);