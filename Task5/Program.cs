namespace Task5;

/*Перевизначення операцій. Виконати і розібратися з
прикладами л. 3.*/

class ThreeD
{
    int x, y, z; // трехмерные координаты
    public ThreeD() { x = y = z = 0; }
    public ThreeD(int i, int j, int k)
    { x = i; y = j; z = k; }
    // Перегрузить бинарный оператор + .
    public static ThreeD operator +(ThreeD opl, ThreeD op2)
    {
        ThreeD result = new ThreeD();
        /* Сложить координаты двух точек и возвратить результат. */
        result.x = opl.x + op2.x; // Эти операторы выполняют
        result.y = opl.y + op2.y; // целочисленное сложение,
        result.z = opl.z + op2.z; //сохраняя свое исходное назначение.
        return result;
    }
    // Перегрузить бинарный оператор -.
    public static ThreeD operator -(ThreeD opl, ThreeD op2)
    {
        ThreeD result = new ThreeD();
        /* Обратите внимание на порядок следования операндов:
        opl — левый операнд, а ор2 — правый операнд. */
        result.x = opl.x - op2.x; // Эти операторы
        result.y = opl.y - op2.y; // выполняют целочисленное
        result.z = opl.z - op2.z; // вычитание
        return result;
    }
    // Вывести координаты X, Y, Z.
    public void Show()
    {
        Console.WriteLine($"{x}, {y}, {z}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ThreeD a = new ThreeD(1, 2, 3);
        ThreeD b = new ThreeD(10, 10, 10);
        ThreeD c;
        Console.Write("Координаты точки а: ");
        a.Show();
        Console.WriteLine();
        Console.Write("Координаты точки b: ");
        b.Show();
        Console.WriteLine();
        c = a + b; // сложить координаты точек а и b
        Console.Write("Результат сложения а + Ь: ");
        c.Show();
        Console.WriteLine();
        c = a + b + c; // сложить координаты точек a, b и с
        Console.Write("Результат сложения а + b + с: ");
        c.Show();
        Console.WriteLine();
        c = c - a; // вычесть координаты точки а
        Console.Write("Результат вычитания с - а: ");
        c.Show();
        Console.WriteLine();
        c = c - b; // вычесть координаты точки b
        Console.Write("Результат вычитания с - b: ");
        c.Show();
    }
}

