// 60.Показать двумерный массив размером m×n заполненный целыми случайными числами

int[,] matr = new int[4,3];
void PrintArray (int [,] matr){

for(int i = 0; i < matr.GetLength(0); i++)
{
    for(int j = 0;j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i, j],3} ");
    }

    Console.WriteLine();
}
}

void FillArray (int[,]matr)
{
 for(int i = 0; i < matr.GetLength(0); i++)
{
    for(int j = 0;j < matr.GetLength(1); j++)
    {
        matr[i,j] = new Random().Next(1,10);
    }

    Console.WriteLine();
}
  

}
PrintArray(matr);
FillArray(matr);
PrintArray(matr);

