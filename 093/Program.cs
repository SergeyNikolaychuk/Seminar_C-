//93 Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int[,] array1 = new int[,] { { 1, 2 },
                             { 3, 4 } ,
                              };

int[,] array2 = new int[,] { { 5, 6 },
                             { 7, 8 } };

int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        array3[i, j] = array3[i, j] + array1[i, j] * array2[i, j];
    }
}

for (int i = 0; i < array3.GetLength(0); i++)
{
    for (int j = 0; j < array3.GetLength(1); j++)
    {
        Console.Write(array3[i, j] + " ");
    }
    Console.WriteLine();
}

