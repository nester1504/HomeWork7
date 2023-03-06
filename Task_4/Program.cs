bool check = false;
int number = 0;

int[,] GetMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
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

void MainDiagonal(int[,] matrixElement)
{
    int sizeLine = matrixElement.GetLength(0);
    int sizeColumn = matrixElement.GetLength(1);
    int sum = 0;

    for (int i = 0; i < sizeLine; i++)
    {
        for (int j = 0; j < sizeColumn; j++)
        {
            if (i == j)
            {
                sum = sum + matrixElement[i, j];
            }
        }
    }

    Console.WriteLine($"сумма главной диаганали = {sum}");
}

Console.WriteLine("Введите количество строк массива");
int sizeRows = ReadNumber();
Console.WriteLine("Введите количество столбцов массива");
int sizeСols = ReadNumber();

int[,] matrix = GetMatrix(sizeRows, sizeСols);

PrintMatrix(matrix);

MainDiagonal(matrix);