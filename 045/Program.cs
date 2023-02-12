// 45.Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] a;
a=new int[7];
Random rand1=new Random();
for(int i=0;i<a.Length;i++)
a[i]=rand1.Next(111,999);

int resultEven = 0;
int resultNotEven = 0;
for(int i=0;i<a.Length;i++){
    if (a[i] % 2 == 0){
        resultEven = resultEven + 1;
    } else {
        resultNotEven = resultNotEven + 1;
    }
}

System.Console.WriteLine("количество четных чисел " + $"{resultEven}"+ ", количество нечетных чисел " + $"{resultNotEven}");



