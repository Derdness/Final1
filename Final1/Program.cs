﻿using System.Linq.Expressions;
//Инициализируем массив строк
string[] words = new string[] { "Дерево", "Кот" , "Пепега", "Мяу", 
                                "Эх", "Сон", "Четыре", "Три",
                                "Мир", "Труд", "Май", ":3"};
int lthan3s = 0;        //Переменная для подсчёта слов длиной 3 символа и менее
foreach(string word in words)   //Подсчитываем слова длиной <= 3
{
    if(word.Length < 4)
    {
        lthan3s++;
    }
}
string[] result = new string[lthan3s]; //Инициализируем результирующий массив
int forward = 0;                       //Индекс следующего элемента в массиве ответов
foreach(string word in words)          //Записываем слова длиной <= 3 в новый массив
{
    if(word.Length < 4)
    {
        result[forward++] = word;
    }
}
foreach(string word in result)          //Выводим результат
{
    Console.WriteLine(word);
}