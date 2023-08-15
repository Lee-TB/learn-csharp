// a two-dimensional array with two rows and three columns
int[,] matrix = new int[2, 3] {
    {1, 2, 3},
    {4, 5, 6},
};

int[,] matrix2 = {
    { 1, 2, 3 },
    { 4, 5, 6 },
};

int[,,] tensor = new int[2, 2, 3] {
    { { 1, 2, 3 }, { 4, 5, 6 } },
    { { 7, 8, 9 }, { 10, 11, 12 } }
};

Console.WriteLine(matrix[1, 1]);
Console.WriteLine(tensor[1, 1, 2]);
Console.WriteLine(matrix2.Length);
Console.WriteLine(tensor.Length);
Console.WriteLine(tensor.GetLength(2));


for(int i = 0; i < matrix2.GetLength(0); i++)
{
    for(int j = 0; j < matrix2.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]}");
        Console.Write(j < matrix.GetLength(1) - 1 ? "," : "");
    }
    Console.WriteLine();
}