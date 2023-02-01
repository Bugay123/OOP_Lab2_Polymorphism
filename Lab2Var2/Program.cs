using System.Diagnostics.Metrics;

/*Реалізувати програму з лекції 3 (Приклад 5). Модифікувати
програму таким чином, щоб прочитати кожний рядок і
виконати його розбиття на окремі слова: Прізвище і ініціали,
рік народження, оклад.*/

namespace Lab2Var2;
class Program
    {
    static void Main(string[] args)
        {
        Person[] dbase = new Person[100];
        int n = 0;
        try
            {
            StreamReader f = new StreamReader("/Users/bugay/Untitled.txt"); // 4
            string s;
            int i = 0;
            while ((s = f.ReadLine()) != null) // 5
                {
                dbase[i] = new Person(s);
                Console.WriteLine(dbase[i]);
                ++i;
                }
            n = i;
            f.Close();
            }
        catch (FileNotFoundException e)
            {
            Console.WriteLine(e.Message);
            Console.WriteLine("Перевірте правильність імені і шляху до файлу!");
            return;
            }
        catch (IndexOutOfRangeException)
            {
            Console.WriteLine("Дуже великий файл!");
            return;
            }
        catch (FormatException)
            {
            Console.WriteLine("Неприпустима дата народження або оклад");
            return;
            }
        catch (Exception e)
            {
            Console.WriteLine("Помилка: " + e.Message);
            return;
            }
        int n_pers = 0;
        double mean_pay = 0;
        Console.WriteLine("Введіть прізвище співробітника");
        string name;
        while ((name = Console.ReadLine()) != "") // 6
            {
            bool not_found = true;
            for (int k = 0; k < n; ++k)
                {
                Person pers = dbase[k];
                if (pers.Compare(name) == 0)
                    {
                    Console.WriteLine(pers);
                    ++n_pers; mean_pay += pers.Pay;
                    not_found = false;
                    }
                }
            if (not_found) Console.WriteLine("Такого співробітника немає");
            Console.WriteLine("Введіть прізвище співробітника або Enter для завершення");
            }

            Console.WriteLine($"Середній оклад: {mean_pay / n_pers}");
        Console.ReadKey();
        }
    }

