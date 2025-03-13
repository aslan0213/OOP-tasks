using OOP.Library;
using OOP.Vehicles;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Easy tasks
            //Task1
            TemperatureConverter tc = new TemperatureConverter(100);
            Console.WriteLine(tc.Fahrenheit);
            //Task2
            Product p = new Product("Pen", 20, 1000);
            Console.WriteLine($"Product name: {p.Name}, price: {p.Price}, stock: {p.Stock}");
            //Task3 
            Employee emp1 = new Employee("Aslan", 2.5, 2000);
            Console.WriteLine($"Name: {emp1.name}; salary: {emp1.CalculateSalary()}");
            #endregion


            #region Additional tasks
            //Task 1 (vehicles)
            Vehicle car = new Car();
            Vehicle motorcycle = new Motorcycle();
            Vehicle bicycle = new Bicycle();
            car.StartEngine();
            car.StopEngine();
            motorcycle.StartEngine();
            motorcycle.StopEngine();
            bicycle.StartEngine();
            bicycle.StopEngine();


            //Task 2 (kitabxana)
            EBook ebook = new EBook("PHP", "Aslan Memmedov", 300, 2.5);
            PrintedBook printedBook = new PrintedBook("Kotlin programming", "Razil Cavadov", 464);
            ebook.Read();       
            printedBook.Read();  
            #endregion
        }
    }
}
