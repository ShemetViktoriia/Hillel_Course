namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // 1. Виведемо всі парні числа від 0 до 100
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write(i + "\t");
            //    }
            //}


            // 1. Виведемо всі парні числа від 0 до 100
            //for (int i = 0; i <= 100; i+=2)
            //{
            //    Console.Write(i + "\t");
            //}

            // 2. Виведемо всі парні числа від 100 до 0
            //for (int i = 100; i >=0; i -= 2)
            //{
            //    Console.Write(i + "\t");
            //}


            //3. Знайти суму чисел наприклад від нуля до 100
            //int sum = 0;
            //// 0 + 1 +2 +...+100 
            //for (int i = 0; i < 101; i++)
            //{
            //    sum += i;
            //    //sum = sum + i;
            //}
            //Console.WriteLine(sum);


            //4. Перевірка чи є введене натуральне число простим
            //Random random = new Random();
            //int genNum = random.Next(2, 1000);

            //int indicator = 1;
            //for (int i = 2; i < genNum; i++)
            //{
            //    if (genNum % i == 0)
            //    {
            //        Console.WriteLine("Not simple");
            //        indicator = 0;
            //        break;
            //    }
            //}
            //if (indicator == 1)
            //{
            //    Console.WriteLine("Simple");
            //}


            //5. У гусей та кроликів разом 64 лапи. Скільки може бути кроликів та гусей (вказати всі поєднання)?
            for (int i = 0; i <= 32; i++) // 1 ітерація  i=0 - j = 0,1,...,16
                                          // 2 ітерація  i=1 - j = 0,1,...,16
            {
                for (int j = 0; j <= 16; j++)
                {
                    if (i * 2 + j * 4 == 64)
                    {
                        Console.WriteLine($"гус {i} -  крол {j}");
                    }
                }
            }



            Console.ReadKey();
        }
    }
}