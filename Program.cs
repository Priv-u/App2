// See https://aka.ms/new-console-template for more information
namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Ни как не удается настроить запуск приложения в консоли VSCode");
            Console.WriteLine("Вот теперь всё получилось. Причина была в том, что нужно переменную окружения добавить путь .Net SDK");
            Console.ReadKey();
        }
    }
}