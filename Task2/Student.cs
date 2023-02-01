namespace Task2;

/*В розробленому в лаб. 1 класі Персона створити 2
перевизначені методи.
Перший метод перевантажує метод 2 з лаб. 1 і виводить на
консоль: ім’я, вік, стать персони.
Другий метод перевантажує перший метод з лаб.1 (EditPerson)
і дозволяє змінювати тільки 2 поля: ім’я, вік.*/

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Role { get; set; }
    public int Course { get; set; }
    public double Rating { get; set; }
    public string Sex { get; set; }

    public Student(string n, int a, int c, double rat, string s)
    {
        Name = n;
        Age = a;
        Course = c;
        Rating = rat;
        Sex = s;
    }

    public void EditStudent(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void EditStudent(string name, int age, double rating)
    {
        Name = name;
        Age = age;
        Rating = rating;
    }

    public void GetRole() { Console.WriteLine($"{Name} {Age} {Sex}"); }
    public string GetRole(int course)
    {
        if (course <= 4)
            Role = "бакалавр";
        else
            Role = "магістр";
        return Role;
    }

    public void Student_Rating()
    {
        if (Rating >= 82)
            Console.WriteLine("Привіт відмінникам");
        else
            if (Rating <= 60)
            Console.WriteLine("Перездача! Треба краще вчитися!");
        else
            Console.WriteLine("Можна вчитися ще краще!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student stud = new Student("Tom", 20, 3, 83, "male");
        stud.EditStudent("Bot", 23, 50);
        stud.Student_Rating();
        stud.GetRole();
        Console.WriteLine(stud.GetRole(3));
    }
}