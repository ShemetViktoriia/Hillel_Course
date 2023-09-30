using System;

namespace Figure
{
    /*
     * Потрібно: Створити класи Point та Figure. 
Клас Point повинен містити два цілих поля і одне рядкове поле. 
Створити три властивості з одним методом доступу get. Створити власний конструктор,
у тілі якого проініціалізуйте поля значеннями аргументів. 
Клас Figure повинен містити конструктори, які приймають від 3 до 5 аргументів типу Point. 
Створити два методи: double LengthSide(Point A, Point B), що розраховує довжину сторони багатокутника; 
    void PerimeterCalculator(), що розраховує периметр багатокутника. 
    Написати програму, яка виводить на екран назву та периметр багатокутника.
     * */
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Figure rectangle = new Figure(
                new Point(2, 3, "A"), 
                new Point(5, 3, "B"),
                new Point(5, 8, "C"),
                new Point(2, 8, "D"), "Rectangle");

            Console.WriteLine("Периметр для фігури {0} = {1}", rectangle.Name, rectangle.PerimeterCalculator());
        }
    }
}