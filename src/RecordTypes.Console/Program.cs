namespace RecordTypes.Console;
using System;

public static class Program
{
    static void Main(string[] args)
    {
        var person1 = new Person("Wdson", "Correia");
        var person2 = new Person("Wdson", "Correia");

        //Equal values
        Console.WriteLine(person1 == person2);

        //Deconstruc
        var (firstName, lastName) = person1;

        System.Console.WriteLine(firstName);
        System.Console.WriteLine(lastName);

        var person3 = person1 with {FirstName = "Joao"};
        Console.WriteLine(person3.FirstName);
        Console.WriteLine(person3.LastName);
    }
}
