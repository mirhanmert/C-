using System;

public class Class1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Your Age");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age <= 12)
        {
            Console.WriteLine("Child");
        }
        else if (age <= 19) {
            Console.WriteLine("Teenager");
        }
        else if (age <= 59)
        {
            Console.WriteLine("Adult");
        }
        else
        {
            Console.WriteLine("Elder");
        }

    }
}
