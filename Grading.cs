using System;

class Program
{
    public static void Main(string[] args)
    {
        int grade = 100;


        if (grade > 90)
        {
            Console.WriteLine("above 90");
        }

        else if (grade > 80)
        {
            Console.WriteLine("above 80 but below 90");
        }

        else if (grade > 70)
        {
            Console.WriteLine("above 70 but below 80");
        }

        else if (grade > 60)
        {
            Console.WriteLine("above 50 but below 70");
        }

        else if (grade > 49)
        {
            Console.WriteLine("You barely passed");

        }

        else if (grade < 50)
        {
            Console.WriteLine("fail");
        }

    }
}