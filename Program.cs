#region Q1

enum WeekDays
{
    Sunday = 0,
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thursday = 3,
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Days of the Week:");


        foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
        {
            Console.WriteLine(day);
        }
    }
}
#endregion

#region Q2
public struct Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Program
{
    static void Main()
    {
        Person[] person = new Person[3];

        person[0] = new Person("Ahmed", 25);
        person[1] = new Person("Ali", 30);
        person[2] = new Person("Moaz", 22);


        Console.WriteLine("List of Persons:");
        for (int i = 0; i < person.Length; i++)
        {
            Console.WriteLine($"Name = {person[i].Name}, Age = {person[i].Age}");
        }
    }
}

#endregion


#region Q3

enum Seasons
{
    Spring = 0,
    Summer = 1,
    Autumn = 2,
    Winter = 3
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the season Name : ");
        string seasonName = Console.ReadLine();

        seasonName = seasonName.ToLower();

        if (seasonName == "spring")
        {
            Seasons seasons = Seasons.Spring;
            Console.WriteLine("march to may");
        }
        else if (seasonName == "summer")
        {
            Seasons seasons = Seasons.Summer;
            Console.WriteLine("june to august");
        }
        else if (seasonName == "autumn")
        {
            Seasons seasons = Seasons.Autumn;
            Console.WriteLine("September to November");
        }
        else if (seasonName == "winter")
        {
            Seasons seasons = Seasons.Winter;
            Console.WriteLine("December to February");
        }
        else Console.WriteLine("Enter a valid name of seasons ");
    }
}

#endregion


#region Q4
enum Colors
{
    Red = 0,
    Green = 1,
    Blue = 2,
}
class Program
{
    static void Main()
    {
        Console.Write("Enter a color name: ");
        string input = Console.ReadLine();


        if (Enum.TryParse(typeof(Colors), input, true, out object result))
        {
            Console.WriteLine($"{input} is a primary color.");
        }
        else
        {
            Console.WriteLine($"{input} is not a primary color.");
        }
    }
}
#endregion

#region Q6
using System;

struct Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Program
{
    static void Main()
    {
        Person[] person = new Person[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter name of person {0}: ", i + 1);
            string name = Console.ReadLine();

            Console.Write("Enter age of person {0}: ", i + 1);
            int age = int.Parse(Console.ReadLine());

            person[i] = new Person(name, age);
        }

        Person oldest = person[0];

        for (int i = 1; i < person.Length; i++)
        {
            if (person[i].Age > oldest.Age)
            {
                oldest = person[i];
            }
        }

        Console.WriteLine($"\nThe oldest person is {oldest.Name} and Age: {oldest.Age}");
    }
}

#endregion