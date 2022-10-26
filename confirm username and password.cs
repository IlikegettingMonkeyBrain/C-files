using System;

class Program
{
    public static void Main(string[] args)
    {
        string password = "12345";
        string username = "Grade10";

        Console.WriteLine("Please Enter Your Username Here");
        string username1 = Console.ReadLine();
        Console.WriteLine("Please Enter Your Password Here");
        string password1 = Console.ReadLine();

        if ((username == username1) && (password == password1))
        {
            Console.WriteLine("Username and Password is correct");
        }
        else
        {
            Console.WriteLine("Username and Password is incorrect");
        }



    }
}