// 88. Заменить все вхождения подстроки w в строке st на строку v. Вывести на экран первоначальную строку и конечную строку
string text = Console.ReadLine();
//System.Console.WriteLine(text);
System.Console.WriteLine();
string tx = "w";
string tx1 = "v";
text = text.Replace(tx,tx1);
System.Console.WriteLine(text);