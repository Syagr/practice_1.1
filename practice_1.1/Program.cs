var students = new List<Student>()
{
    new Student("Иван", 22),
    new Student("Мария", 20),
    new Student("Петр", 28),
    new Student("Анна", 24),
    new Student("Сергей", 30),
};

bool hasSeniorStudent = students.Any(student => student.Age > 25);

if (hasSeniorStudent)
{
    Console.WriteLine("Есть хотя бы один студент старше 25 лет.");
}
else
{
    Console.WriteLine("Нет студентов старше 25 лет.");
}

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }
}