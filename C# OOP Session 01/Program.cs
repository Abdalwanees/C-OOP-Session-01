namespace C__OOP_Session_01
{
    //Enum
    //01
    enum WeekDays
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

    //07
    struct Person
    {
        public string Name;
        public int Age;

        // Constructor to initialize the Person struct
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------01---------------");

            #region 01 Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            Console.WriteLine("WeekDays with the days of the week (Monday to Sunday) : ");
            foreach (var Day in Enum.GetNames(typeof(WeekDays)))
            {
                Console.WriteLine($" {Day} ");
            }
            #endregion
           
            Console.WriteLine("-----------------02---------------");
           
            #region 02 Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            Person[] people = new Person[3];

            people[0] = new Person("Wanees", 30);
            people[1] = new Person("Omer", 25);
            people[2] = new Person("Saeed", 35);

            // Display the details of all persons in the array
            Console.WriteLine("Details of Persons:");
            foreach (Person person in people)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
            #endregion
        }
    }
}
