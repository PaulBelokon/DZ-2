/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6

Задача 15: Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/




// 1 Задание 
/*
Console.WriteLine("Введите трехзначное число");
 int number = int.Parse(Console.ReadLine());
 int result = number/10%10;
 Console.Write("Ваша 2 цифра в трехназначном числе: ");
 Console.WriteLine(result); 
 */



// ЗАДАНИЕ 2
 /*Console.WriteLine("Введите трехзначное число");
 int number = int.Parse(Console.ReadLine());
if  ( number>1000)
{
    string number1 = number.ToString();
    Console.WriteLine(number1[2]);
   
}
else if  (number<100)
  {
    Console.WriteLine("Ваше число не имеет 3 цифры");
   
  }
else   
   {
    int result = number%10;
  Console.WriteLine(result);
   } 
*/




//ЗАДАНИЕ 3
Console.WriteLine("Введите день недели");
int number = int.Parse(Console.ReadLine());
if (number==1) 
Console.WriteLine("Monday,This day is work:(");
if (number==2) 
Console.WriteLine("Thuesday,This day is work:(");
if (number==3) 
Console.WriteLine("Thriday,This day is work:(");
if (number==4) 
Console.WriteLine("Tuesday,This day is work:(");
if (number==5) 
Console.WriteLine("Friday,This day is work:(");
if (number==6) 
Console.WriteLine("Saturday,This day is work:(");
if (number==7) 
Console.WriteLine("Sunday,This day is weekend!!!:D");
