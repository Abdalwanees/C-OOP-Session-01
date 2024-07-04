namespace C__OOP_Session_01
{
    //Enum
    //01
    enum WeekDays
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    //03
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    //Struct
    //02
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

            Console.WriteLine("-----------------03---------------");

            #region 03 Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            Console.Write("Enter Season Name: ");
            string seasonEntered = Console.ReadLine();
            Season season;
            if (Enum.TryParse(seasonEntered, true, out season))
            {
                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine($"{season} starts from March to May.");
                        break;
                    case Season.Summer:
                        Console.WriteLine($"{season} starts from June to August.");
                        break;
                    case Season.Autumn:
                        Console.WriteLine($"{season} starts from September to November.");
                        break;
                    case Season.Winter:
                        Console.WriteLine($"{season} starts from December to February.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid season name entered.");
            }
            #endregion
        }
    }
}
