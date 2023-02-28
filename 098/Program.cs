// 98.Показать треугольник Паскаля
// *Сделать вывод в виде равнобедренного треугольника
int row = 3;
int[,] triangele = new int[row, row];
const int cellWindth =3;

//void FillTriangle()
{
    for (int i = 0; i < row; i++)
    {
        triangele[i, 0] = 1;
        triangele[i, 1] = 1;  
    } 
    for (int i = 2; i< row; i++)
    {
        for (int j = 1; j <= i; j ++)
        {
            triangele[i, j] = 
                triangele[i - 1, j - 1 ] + triangele[i - 1, j - 1];
        }
    }    
}
void PrintTriangele()
    {
        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j < row; j++)
            {
            if (triangele[i, j] != 0)
                Console.Write($"{triangele[i, j],cellWindth}");
            }
            Console.WriteLine();

        }
        
}    

Console.ReadLine();
PrintTriangele();
Console.ReadLine();
