// 54.С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1

int a = Convert.ToInt32(Console.ReadLine());

    int first = 0;
    int second = 1;
    int sum = 0;
    while(a >= sum){
        sum = first + second;
         Console.Write("{0} ", sum);
        first = second;
        second = sum;
        
    }

  
    
