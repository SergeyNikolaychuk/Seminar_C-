// 68.Написать программу, которая обменивает элементы первой строки и последней строк.

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

 void Swap(ref int a,ref int b){
    int c = a;
        a = b;
        b = c;

 }

void ChangeRow(int[,] xp,int row1,int row2){
    for(int i = 0; i<xp.GetLength(1);i++){
        Swap(ref xp[row1,i],ref xp[row2,i]);
    }
}

PrintArray(matr);
FillArray(matr);
PrintArray(matr);
ChangeRow(matr,0,matr.GetLength(1));
Console.WriteLine();
PrintArray(matr);
