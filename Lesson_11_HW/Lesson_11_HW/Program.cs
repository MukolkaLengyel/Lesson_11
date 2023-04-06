namespace Lesson_11_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Car Mechanic shop");
            Employee employee = new Employee();
            employee.Name = "Garry";
            employee.Age = 30;

            Vehicle myCar = new Vehicle();
            myCar.carBrand = "BMW";
            myCar.carEngine = "1.6–1.8 L \tFuel injection ";
            myCar.carWheels = 4;

            Employee.EmployeeInfo(employee.Name, employee.Age);
            Person.PersonInfo(person.DepartmentName);
            Vehicle.CarInfo(myCar.carBrand, myCar.carEngine, myCar.carWheels);
        }

        public class Vehicle
        {
            public string carBrand { get; set; }
            public string carEngine { get; set; }
            public int carWheels { get; set;}

            public static void CarInfo(string carBrand, string carEngine, int carWheels) => Console.WriteLine($"Car Brend Name: {carBrand}, Car Engine Type {carEngine}, Car Wheels: {carWheels}");
        }

        public class Employee
        {
            internal string Name { get; set; }
            internal int Age { get; set; }

            public static void EmployeeInfo (string Name, int Age) => Console.WriteLine ($"Employee Name: {Name}, Employee Age: {Age}");
        }

        public class Person : Employee
        {
            internal protected string _departmentName;

            public string DepartmentName
            {
                get => $"Work Place: {_departmentName}";
                set => _departmentName = value;
            }

            public Person(string departmentName)
            {
                DepartmentName = departmentName;

            }
            public static void PersonInfo(string departmentName) => Console.WriteLine($"Employee Department {departmentName}");
        }
    }
}