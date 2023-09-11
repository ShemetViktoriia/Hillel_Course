namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Виводить усі елементи масиву у зворотному порядку.
            //char[] charArray = { 'a', 'b', 'c', 'd' };

            //for (int i = charArray.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine($"Index {i} - element {charArray[i]}");
            //}
            // char t = charArray[4]; IndexOutOfRangeException
            #endregion


            //Виводить парні елементи масиву.
            //int[] nums = { -100, 2, 3, 4, 5, 6, 70, 8, 9, 10 };
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i]%2==0)
            //    {
            //        Console.WriteLine(nums[i]);
            //    }
            //}


            //Виводить усі елементи масиву через 1.
            //int[] nums = { -100, 2, 3, 4, 5, 6, 70, 8, 9, 10 };
            //for (int i = 0; i < nums.Length; i+=2)
            //{
            //    Console.WriteLine(nums[i]);
            //}

            //До масиву додається елемент у кінець.
            //int[] nums = { -100, 2, 3, 4, 5, 6, 70, 8, 9, 10 };
            //int a = 1000;
            //int[] largerArray = new int[nums.Length + 1];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    largerArray[i] = nums[i];
            //}
            //largerArray[largerArray.Length - 1] = a;

            //foreach (var elem in largerArray)
            //{
            //    Console.WriteLine(elem);
            //}


            //string s = "Hello world!";
            //for (int i = 0; i < s.Length; i++)
            //{
            //    Console.WriteLine(s[i]);
            //}

            //string s1 = "123";
            //Console.WriteLine($"{s1[2]}{s1[1]}{s1[0]}");



            // Створимо двовимірний масив і виведемо його елементи в консоль
            //int[,] array = new int[3, 3] { {1, 2, 3 }, {4, 5, 6 }, {7, 8, 9} };

            // 1 2 3
            // 4 5 6
            // 7 8 9
            //Console.WriteLine(array.Rank);
            //Console.WriteLine(array[1, 1]);

            //Console.WriteLine(array.GetUpperBound(0));
            //Console.WriteLine(array.GetUpperBound(1));

            //for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            //{
            //    for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
            //    {
            //        Console.Write(array[i,j] + "\t");
            //    }
            //    Console.Write("\n");
            //}



            //Знайдемо кількість позитивних чисел у масиві
            //int[] nums = { -100, 2, 3, 4, -5, 6, -70, 8, -9, -10 };
            //int counter = 0;
            //foreach (int elem in nums)
            //{
            //    if (elem>0)
            //    {  counter++; }
            //}
            //Console.WriteLine(counter);


            //Інверсія масиву, тобто переворот його у зворотному порядку
            //int[] nums = { -100, 2, 3, 4, -5, 6, -70, 8, -9, -10, 5 }; //Length = 11
            //int n = nums.Length;
            //for (int i = 0; i < nums.Length/2; i++)
            //{
            //    int temp = nums[i];
            //    nums[i] = nums[n -1 -i];
            //    nums[n -1 -i] = temp;
            //}

            //foreach (int elem in nums) { Console.WriteLine(elem); }


            //найпростіше сортування масиву
            //int[] nums = { 100, 2, 3, 4, -5, 6, -70, 8, 2, -10, 5 }; //Length = 11
            //for (int i = 0; i < nums.Length - 1; i++) 
            //{
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        if (nums[i] > nums[j])
            //        {
            //            int temp = nums[i];
            //            nums[i] = nums[j];
            //            nums[j] = temp;
            //        }
            //    }
            //}

            //PrintArray(nums);


            //Створити 25 рандомних інтових чисел, розрахувати їх середнє та вивести користувачу.
            Random rand = new Random();
            int[] randNumbers = new int[25];

            for (int i = 0; i < randNumbers.Length; i++)
            {
                randNumbers[i] = rand.Next(101);
            }

            //int sum = 0;
            //foreach (var elem in randNumbers)
            //{
            //    sum += elem;
            //}
            PrintArray(randNumbers);
            //Console.WriteLine((double)sum/randNumbers.Length);

            Console.WriteLine(randNumbers.Sum());
            Console.WriteLine(randNumbers.Sum() / 25.0);
            Console.WriteLine(randNumbers.Average());

            Console.ReadKey();
        }

        private static void PrintArray(int[] nums)
        {
            foreach (int elem in nums) { Console.WriteLine(elem); }
        }
    }
}