
Console.OutputEncoding = System.Text.Encoding.Unicode;
//Знайдіть всі парні числа в масиві numbers і виведіть їх у зростаючому порядку.
int[] numbers = { 56, 1, 4, 9, 16, 25, 36, 49, 56, 49, 1};

var filteredNumbers = numbers.Where(number => number % 2 == 0).OrderBy(number => -1*number); // момент створення LINQ запиту

foreach (var number in filteredNumbers)
{
    Console.WriteLine(number);
}

// негайне та відкладене виконання LINQ запитів
// виконання LINQ запитів відбувається в момент або перебору в циклі foreach
// або в момент виклику методів ToList(), ToDictionary(), To.., Count(), ...

string[] stringArray = { "Tom", "Bob", "Roy" };
// створюємо запит
var filteredArray = stringArray.Where(name => name.Length == 3);

stringArray[2] = "Alex";

foreach (var name in filteredArray) // відкладене виконання
{
    Console.WriteLine(name);
}


string[] stringArray_2 = { "Tom", "Bob", "Roy" };
var filteredArray_2 = stringArray_2.Where(name => name.Length == 3).ToList(); // негайне виконання

stringArray_2[2] = "Alex";

foreach (var name in filteredArray_2)
{
    Console.WriteLine(name);
}


// Знайдіть максимальний та мінімальний елементи в масиві numbers та виведіть їх.
var min = numbers.Min();
var max = numbers.Max();
Console.WriteLine(min);
Console.WriteLine(max);

// Знайдіть суму всіх чисел в масиві numbers.
var sum = numbers.Sum();
Console.WriteLine(sum);

// Знайдіть середнє арифметичне чисел в масиві numbers.
var average = numbers.Average();
Console.WriteLine(average);

// Знайдіть всі унікальні елементи у списку values та виведіть їх.
var distinctNumbers = numbers.Distinct();
Console.WriteLine(string.Join(", ", distinctNumbers));

//Знайдіть кількість кожного типу фрукту у списку fruits та виведіть результат.
List<string> fruits = new List<string>
{
    "яблуко", "банан", "апельсин", "яблуко", "апельсин", "груша", "банан"
};
Console.WriteLine();
var groupFruits = fruits.GroupBy(fruit => fruit);
foreach (var group in groupFruits)
{
    Console.WriteLine(group.Key);
    Console.WriteLine(group.Count());
}


// Знайдіть найбільше слово в рядку sentence:
string sentence = "Це речення має декілька слів, і ми шукаємо найдовше.";
// 1. колекція слів із sentence
var collectionWords = sentence.Split(new char[] { ' ', ',', '.', '?' }, StringSplitOptions.RemoveEmptyEntries);
var maxWord = collectionWords.OrderByDescending(word => word.Length).FirstOrDefault();
Console.WriteLine(maxWord);


//Знайдіть всі числа в масиві data, які діляться на 3 або 5:
int[] data = { 15, 9, 7, 30, 45, 21, 10 };
var filteredData = data.Where(num => num % 3 == 0 || num % 5 == 0);
Console.WriteLine(string.Join(", ", filteredData));

// Знайдіть всі слова в списку words, які починаються на літеру "а" і закінчуються на "я":
List<string> words = new List<string> { "автомобіля", "банан", "ананас", "комп'ютер", "аркуш" };
var newWordList = words.Where(word => word.StartsWith('а') && word.EndsWith('я'));
Console.WriteLine(string.Join(", ", newWordList));

//Знайдіть усі рядки у списку strings, які мають довжину менше ніж 6 символів та закінчуються на "це":
List<string> strings = new List<string>
{
    "книга",
    "стіл",
    "картина",
    "сонце",
    "чайник"
};

Console.WriteLine(string.Join(", ", strings.Where(word => word.Length < 6 && word.EndsWith("це"))));

//Знайдіть всі числа в масиві numbers, які закінчуються на цифру 7:
int[] nums = { 7, 17, 27, 35, 47, 78, 99, 123, 567 };
Console.WriteLine(string.Join(", ", nums.Where(num => num%10 == 7)));

Console.WriteLine(0.7 % 10);

//Знайдіть всі числа в масиві numbers, які є квадратами інших чисел:
int[] num = { 1, 4, 9, 10, 16, 20, 25, 36, 49, 50 };
Console.WriteLine(string.Join(", ", num.Where(n => Math.Sqrt(n) % 1 == 0)));
