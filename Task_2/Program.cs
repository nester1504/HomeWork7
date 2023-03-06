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

void GetElement(int[,] matrixElement, int line, int column)
{
    int sizeLine = matrixElement.GetLength(0);
    int sizeColumn = matrixElement.GetLength(1);
    if (line > sizeLine || column > sizeColumn)
    {
        Console.WriteLine($"{line}(строчка) {column} (столбец) -> такого числа в массиве нет");
    }
    else if (line < 0 || column < 0)
    {
        Console.WriteLine("Строчки или столбцы не могут быть отрицательными");
    }
    else
    {
        Console.WriteLine($"{line}(строчка) {column} (столбец) -> число {matrixElement[line - 1, column - 1]}");
    }
}

Console.WriteLine("Введите количество строк массива");
int sizeRows = ReadNumber();
Console.WriteLine("Введите количество столбцов массива");
int sizeСols = ReadNumber();

int[,] matrix = GetMatrix(sizeRows, sizeСols);

Console.WriteLine("Введите строку массива");
int lineRead = ReadNumber();
Console.WriteLine("Введите столбец массива");
int columnRead = ReadNumber();

PrintMatrix(matrix);

GetElement(matrix, lineRead, columnRead);