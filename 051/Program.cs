// 51.С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры

int a = Convert.ToInt32(Console.ReadLine());
int result = 0;
    for(int i=0;i<a; i++){
    int b =  Convert.ToInt32(Console.ReadLine());
    if(b>0){
        result = result + 1;
 }
    }

System.Console.WriteLine(result);


      