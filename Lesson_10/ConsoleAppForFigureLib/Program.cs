using MyFigureLibrary;
using System.Text;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.OutputEncoding = System.Text.Encoding.Unicode;
Figure rectangle = new Figure(
    new Point(2, 3, "A"),
    new Point(5, 3, "B"),
    new Point(5, 8, "C"),
    new Point(2, 8, "D"), "Rectangle");

Console.WriteLine("Периметр для фігури {0} = {1}", rectangle.Name, rectangle.PerimeterCalculator());

string infoRectangle = rectangle.ToString();

Console.WriteLine(infoRectangle);


//StringBuilder strBuilder = new StringBuilder();

//Console.WriteLine(strBuilder.Length);
//Console.WriteLine(strBuilder.Capacity);

//StringBuilder strBuilder1 = new StringBuilder("Hello");

//Console.WriteLine(strBuilder1.Length);
//Console.WriteLine(strBuilder1.Capacity);

//StringBuilder strBuilder2 = new StringBuilder("Hello Hello Hello Hello");

//Console.WriteLine(strBuilder2.Length);
//Console.WriteLine(strBuilder2.Capacity);

//StringBuilder strBuilder3 = new StringBuilder("Hello Hello Hello Hello", 50);

//Console.WriteLine(strBuilder3.Length);
//Console.WriteLine(strBuilder3.Capacity);

//strBuilder.Append("Hello Hillel \n");
//strBuilder.Append("Hello World \n");
//strBuilder.Append("Hello Me \n");

//string str = strBuilder.ToString();
//Console.WriteLine(strBuilder);
//Console.WriteLine(str);

//string strTest = string.Empty;

//for (int i = 0; i < 1000; i++)
//{
//    strTest += "test\t";
//}

//Console.WriteLine(strTest);


