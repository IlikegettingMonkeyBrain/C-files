using System;
class Program {
  public static void Main (string[] args) {
    int num1; 
    int num2;
    
   Console.WriteLine("Enter 2 numbers");
    num1= Convert.ToInt32(Console.ReadLine());
    num2= Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Enter the operation");
    string exp =(Console.ReadLine());


    switch (exp)
    {
      case "+": Console.WriteLine("Addition is {0}",(num1+num2)); 
    break; 
      case "-": Console.WriteLine("Substraction is {0}",(num1-num2));
        break; 
      case "*": Console.WriteLine("Multiplication is {0}",(num1*num2));
    break; 
     case "/": Console.WriteLine("Division is {0}",(num1/num2));
    break; 
     case "%": Console.WriteLine("Modulo is {0}",(num1%num2));
    break; 

    }

    }
  }