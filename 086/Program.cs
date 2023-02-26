// 86.Подсчитать сколько раз определенный символ (например 'a') встречается в строке.

string  text = Console.ReadLine(); 
char[] array = text.ToCharArray();
int k = 0;
    for(int i = 0;i<array.Length;i++){
     if(array[i] =='a'){
        k = k +1;
     }
     }
    System.Console.WriteLine(k);
    
   
