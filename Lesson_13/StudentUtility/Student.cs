namespace StudentUtility
{
    internal class Student
    {
        public string Name { get; set; } = string.Empty; 
        public int[] Grades { get; set; } = new int[5];

        public Student(string name, int[] grades)
        {
            Name = name;
            Grades = grades;
         }
        public override string ToString()
        {
            // масив в стрінгу
            string gradesInString = string.Join(',', Grades);

            return $"Name - {Name}, Grades - [{gradesInString}]";
        }
    }
}
