// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] strings = new string[] { "Russia", "2", "Ufa", "Omsk", "Novosibirsk", "Kazan", "Chelyabinsk", "Voronezh", ":-)"};
string[] strings2 = new string[10]; 
int j = 0;
for (int i = 0; i < strings.Length; i++)
{
    if (strings[i].Length <= 3)
    {
        strings2[j] = strings[i];
        j++;     
    }
}
//проверка содержания массива
Console.WriteLine(string.Join(" ", strings2)); 