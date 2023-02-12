// 46.Создать массив из 123 элементов. Заполнить случайными положительными числами от 0 до 1000. Найти количество элементов которые принадлежат отрезку [10,99].

int [] a = new int[123];
Random rand1 = new Random();
for( int i=0;i<a.Length;i++)
a[i] = rand1.Next(0,1001);

int randomNumber = 0;
for( int i=0;i<a.Length;i++){
    if(a[i] >= 10 && a[i] <= 99){
        randomNumber = randomNumber + 1;
    
    }
    

}

System.Console.WriteLine (randomNumber);



