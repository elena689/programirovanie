﻿// Вид 1
void Method()
{
    Console.WriteLine("Автор Я!");
}
Method();


//Вид 2
void Method2(string msg)
{
    Console.WriteLine("msg");
}
Method2(msg: "Текст сообщения");

async void Method2(string msg, int count)
{
    int i = 0;
    while (i>count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method2(msg: "Текст", count: 4);

//Вид 3

int Method3()
{
    return DateTime.Now.Year;

}
int year = Method3;
Console.WriteLine(year);

//Вид 4

string Method4(int count, string text)
{
    int i =0;
    string result = string.Empty;
    while(i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10,"dfas");
Console.WriteLine(res);
