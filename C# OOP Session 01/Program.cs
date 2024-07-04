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

    //04
    [Flags]
    public enum Permissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }

    //05
    public enum Colors
    {
        Red,
        Green,
        Blue
    }

    //Struct
    //02 &06
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

    //06
    struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        // Constructor
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static double Distance(Point p1, Point p2)
        {
            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;
            return Math.Sqrt(dx * dx + dy * dy);
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
        
            Console.WriteLine("-----------------04---------------");

            #region 04 Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.

            //Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable

            // Create a variable with some permissions
            Permissions userPermissions = Permissions.Read | Permissions.Write;

            // Add a permission
            userPermissions |= Permissions.Execute;
            Console.WriteLine("Permissions after adding Execute: " + userPermissions);

            // Remove a permission
            userPermissions &= ~Permissions.Write;
            Console.WriteLine("Permissions after removing Write: " + userPermissions);

            // Check if a specific permission is present
            bool hasReadPermission = (userPermissions & Permissions.Read) == Permissions.Read;
            Console.WriteLine("Has Read permission: " + hasReadPermission);

            bool hasDeletePermission = (userPermissions & Permissions.Delete) == Permissions.Delete;
            Console.WriteLine("Has Delete permission: " + hasDeletePermission);

            #endregion

            Console.WriteLine("-----------------05---------------");

            #region 05 Create an enum called "Colors" with the basic colors(Red, Green, Blue) as its members.Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            Console.WriteLine("Enter a color name:");
            string inputColor = Console.ReadLine();

            bool isPrimaryColor = Enum.TryParse(inputColor, true, out Colors color);

            if (isPrimaryColor)
            {
                Console.WriteLine($"{inputColor} is a primary color.");
            }
            else
            {
                Console.WriteLine($"{inputColor} is not a primary color.");
            }

            #endregion

            Console.WriteLine("-----------------06---------------");

            #region 06 Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Frist Point
            Console.WriteLine("Enter the coordinates for the first point:");
            Console.Write("X: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            //Second point
            Console.WriteLine("Enter the coordinates for the second point:");
            Console.Write("X: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Point point1 = new Point(x1, y1);
            Point point2 = new Point(x2, y2);
            double distance = Point.Distance(point1, point2);
            Console.WriteLine($"The distance between the points is: {distance}");
            #endregion

            #region 07 Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            Person[] people1 = new Person[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter details for person {i + 1}:");

                string name = GetName();
                int age = GetAge();

                people1[i] = new Person(name, age);
            }
            Person oldestPerson = FindOldestPerson(people1);

            Console.WriteLine($"The oldest person is {oldestPerson.Name} with an age of {oldestPerson.Age}.");
            #endregion

        }
        #region 07

        //Get Name
        static string GetName()
        {
            while (true)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(name))
                {
                    return name;
                }
                else
                {
                    Console.WriteLine("Name cannot be empty. Please enter a valid name.");
                }
            }
        }

        //Get Age
        static int GetAge()
        {
            while (true)
            {
                Console.Write("Age: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int age))
                {
                    return age;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid age.");
                }
            }
        }

        //Clalc oldest person
        static Person FindOldestPerson(Person[] people)
        {
            if (people.Length == 0)
            {
                throw new ArgumentException("The array of people cannot be empty.");
            }

            Person oldest = people[0];

            for (int i = 1; i < people.Length; i++)
            {
                if (people[i].Age > oldest.Age)
                {
                    oldest = people[i];
                }
            }

            return oldest;
        }
        #endregion
    }
}
