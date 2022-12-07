var arr = FillMatrix(4,4);
PrintMatrix(arr);
ChangeRows(arr);
Console.WriteLine();
PrintMatrix(arr);

void ChangeRows(int[,] matrix)
{
    int rowCount = matrix.GetLength(0) - 1;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0,i];
        matrix[0,i] = matrix[rowCount,i];
        matrix[rowCount,i] = temp;     
    }
}
 
int[,] FillMatrix(int rows, int colums)
{
    int[,] matrix = new int [rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++ )
    {
        for (int j = 0; j < matrix.GetLength(1); j++ )
        {
            matrix[i, j] = rnd.Next(1, 6);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}, ");
        }
        Console.WriteLine();
    }
}