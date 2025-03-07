﻿namespace RecordTypes.Console;
using System;
using System.Data.Common;
using System.Text.Json;

public static class Program
{
    static void Main(string[] args)
    {
        var person1 = new Person("Wdson", "Correia")
        {
            Address = new("Rua forte do triunfo", "12345678")
        };

        var person2 = new Person("Wdson", "Correia");

        var personJson = JsonSerializer.Serialize(person1, options: new() { WriteIndented = true });
        System.Console.WriteLine(personJson); 
 
        Console.WriteLine(person1);
        System.Console.WriteLine(person1.FullName);
 
        //Equal values
        Console.WriteLine($"Entitys equals? {person1 == person2}");

        //Deconstruc
        var (firstName, lastName) = person1;

        System.Console.WriteLine(firstName);
        System.Console.WriteLine(lastName);

        var person3 = person1 with {FirstName = "Joao"};
        Console.WriteLine(person3.FirstName);
        Console.WriteLine(person3.LastName);
    }
}
