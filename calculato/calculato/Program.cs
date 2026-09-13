using System;

while (true)
{
  

  
    Console.Write("Enter the first number: ");
    double num1 = Convert.ToDouble(Console.ReadLine());


    Console.Write("Enter operation (+, -, *, /): ");
    string op = Console.ReadLine();

  
    Console.Write("Enter the second number: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    double result = 0;
    bool validOperation = true;

 
    switch (op)
    {
        case "+":
            result = num1 + num2;
            break;
        case "-":
            result = num1 - num2;
            break;
        case "*":
            result = num1 * num2;
            break;
        case "/":
            if (num2 == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed!");
                validOperation = false;
            }
            else
            {
                result = num1 / num2;
            }
            break;
        default:
            Console.WriteLine("Error: Invalid operation selected!");
            validOperation = false;
            break;
    }

   
    if (validOperation)
    {
        Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
    }
}