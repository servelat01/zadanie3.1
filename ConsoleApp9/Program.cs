using ConsoleApp2 ;


internal class Program
{
    public static void Main(string[] args)
    {
        List<Employee> people = new List<Employee>()
        {
            new Employee("Жуков Антон Павлович", 1, 13500),
            new Employee("Миклашевский Данила Сергеевич", 2, 15954),
            new Employee("Косых Иван Андреевич", 3, 14500),
            new Employee("Облепихова Дарья Анатольевна", 4, 6799),
            new Employee("Махлепова Кристина Андреевна", 5, 9800),
            new Employee("Шевченко Макар Николаевич", 1, 5777),
            new Employee("Чанин Дмитрий Додопицевич", 2, 27650),
            new Employee("Хомяков Никита Джугашвилевич", 3, 1554),
            new Employee("Нурминский Сурен Хачинович", 4, 1200),
            new Employee("Нагиев Дмитрий Генадьевич", 5, 80000)
        };
        void test()
        {
            foreach (var emp in people)
            {
                Console.WriteLine($"{emp.FIO}");
            }
        }
        test();
    }
}