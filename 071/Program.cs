// 71.Показать натуральные числа от N до 1, N задано.
void Loop(int N, int i){

    System.Console.WriteLine($"{N,3}");
    if(i<N) Loop(N-1,i);
}
Loop(18,1);