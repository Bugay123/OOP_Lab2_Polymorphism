namespace Task4;

/*Індексатори. В клас Student додати масив з 10 елементів –
Оцінки за кредит з різних дисциплін. Ініціалізувати масив за
допомогою індексатора. Розробити метод розрахунку
середнього рейтингу студента.*/

class Student
{
    private int[] marks = new int[10];
    public int this[int index]
    {
        get
        {
            return marks[index];
        }
        set
        {
            marks[index] = value;
        }
    }
    public double GPA()
    {
        double avg = 0;
        for (int i = 0; i < marks.Length; i++)
        {
            avg += marks[i];
        }
        return avg/marks.Length;
    }
}


class Program
{
    static void Main(string[] args)
    {
        Student stud = new Student();
        Random rnd = new Random();
        for (int i = 0; i < 10; i++)
        {
            stud[i] = rnd.Next(50, 100);
        }
        
        Console.WriteLine("Середній бал студента "+stud.GPA());
    }
}

