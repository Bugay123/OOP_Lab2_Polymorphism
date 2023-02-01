namespace Task3;

/*3.Індексатори. Виконати та продемонструвати приклади л.3.*/

class TempR
{
    private float[] temps = new float[10] { 56.2F, 56.7F, 56.5F, 56.9F, 58.8F, 61.3F, 65.9F, 62.1F, 59.2F, 57.5F };

    public float this[int index]
    {
        get
        {
            return temps[index];
        }
        set
        {
            temps[index] = value;
        }
    }
}

class DayOfWeek
{
    string[] days = { "Понеділок", "Вівторок", "Середа", "Четверг", "Пʼятниця", "Субота", "Неділя" };
    private int GetDay(string testDay)
    {
        for (int j = 0; j < days.Length; j++)
        {
            if (days[j] == testDay)
            {
                return j;
            }
        }
        throw new System.ArgumentOutOfRangeException(testDay, "неправильно вказаний день тижня");
    }

    public int this[string days]
    {
        get
        {
            return (GetDay(days));
        }
    }
}

class PwrOfTwo
{
    public int this[int index]
    {
        get
        {
            if ((index >= 0) && (index <= 16))
            {
                return pwr(index);
            }
            else
            {
                return -1;
            }
        }
    }
    int pwr(int p)
    {
        int result = 1;
        for (int i = 0; i < p; i++)
        {
            result *= 2;
        }
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Приклад 1
        TempR tempR = new TempR();
        tempR[0] = 11111;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Element {i} = {tempR[i]}");
        }

        //Приклад 2
        DayOfWeek dayOfWeek = new DayOfWeek();
        Console.WriteLine(dayOfWeek["Середа"]);

        //Приклад 3
        PwrOfTwo pwr = new PwrOfTwo();
        Console.Write("Первые 8 степеней числа 2: ");
        for (int i = 0; i < 8; i++)
            Console.Write(pwr[i] + " ");
    }
}
