// 82. C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки
string text = Console.ReadLine();
{
    int before = text.IndexOf('.');
   Console.WriteLine($"До точки {before}" + " символов");
}