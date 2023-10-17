// Колекції Collections
// Контейнер для зберігання обєктів
using Collections;
using System.Collections;
using System.Collections.Generic;

// Динамічний масив - ArrayList - неузагальнена колекція, System.Collections

int[] intArray = { 1,2,3};
ArrayList array = new ArrayList() {12, "hello", true};
ArrayList array2 = new ArrayList(20);
ArrayList array3 = new ArrayList(intArray) { 12, "hello", true };

array.Add(100); // Add
foreach (var arr in array)
{
    Console.WriteLine(arr);
}
Console.WriteLine();
array[array.Count - 1] = 89; // Index

foreach (var arr in array)
{
    Console.WriteLine(arr);
}

Console.WriteLine();
foreach (var arr in array3)
{
    Console.WriteLine(arr);
}

// Динамічний масив - List<T> - узагальнена колекція, System.Collections.Generic

List<int> ints = new List<int>() {1,2,3,4,5};
List<string> strList = new List<string>() { "ab", "df" };
List<int> ints2 = new List<int>(intArray) { 1, 2, 3, 4, 5 };
List<int> ints3 = new List<int>(20);

List<Student> studentList = new List<Student>();
studentList.Add(new Student(1, "Maria"));
Student st1 = new Student(2, "Mark");
studentList.Add(st1);

Console.WriteLine();
foreach (var item in studentList)
{
    Console.WriteLine(item);
}

Console.WriteLine();
studentList.RemoveAt(0);
for (int i = 0; i < studentList.Count; i++)
{
    Console.WriteLine(studentList[i]);
}

// Черга - Queue - FIFO first in first out
Queue queue = new Queue(); // неузагальнена черга 
// 1 , 2 , 3 , 4 <--------------
queue.Enqueue(45); // додавання в чергу
queue.Enqueue(50);
Console.WriteLine(queue.Peek()); // повертає поточний елемент в черзі
Console.WriteLine(queue.Dequeue()); // видаляє і повертає поточний елемент в черзі
Console.WriteLine(queue.Dequeue());
if (queue.Count > 0)
{
    Console.WriteLine(queue.Peek()); // Peek and Dequeue на пустій черзі викличуть ексепшн
}
//Console.WriteLine(queue.Peek()); // Peek and Dequeue на пустій черзі викличуть ексепшн


Queue<string> queueString = new Queue<string>(); // узагальнена черга 


// Стек - Stack - LIFO last in first out
Stack stack = new Stack(intArray);
// 1, 2, 3, 4  --------> 
stack.Peek(); // повертає елемент на вершині стеку
Console.WriteLine(stack.Peek());
Console.WriteLine(stack.Pop()); // видаляє елемент на вершині стеку та повертає його
Console.WriteLine(stack.Peek());
stack.Push("Hello"); // додає новий елемент на вершину стеку
Console.WriteLine(stack.Peek());
if (stack.Count > 0)
{
    Console.WriteLine(stack.Peek()); // Peek and Pop на стеку із Count = 0 викличуть ексепшн
}

Stack<string> stackString = new Stack<string>();


// Словник - Dictionary<TKey, TValue>
// номер телефона  - імя 
// Ключ Key - унікальний
Dictionary<int, string> keyValuePairs = new Dictionary<int, string>()
{
    {1, "Alex"},
    {2, "Oleg" }
    // {1, "Jack" } Exception
};


Dictionary<int, string> keyValuePairs2 = new Dictionary<int, string>()
{
    [1] = "Fiona", // [1] - not index, KEY
    [2] = "Vlad"
};

keyValuePairs.Add(3, "Jack");
keyValuePairs[3] = "Oleg"; // переписуємо в словнику елемент із ключем 3
keyValuePairs[4] = "Sergiy";
Console.WriteLine();
keyValuePairs.Remove(1);
foreach (var item in keyValuePairs)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

bool result;
string name = string.Empty; 
Console.WriteLine(default(bool));
Console.WriteLine();

result = keyValuePairs.TryGetValue(3, out name);
if (result)
{
    Console.WriteLine(keyValuePairs[3]);
    Console.WriteLine(name);
}

