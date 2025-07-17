// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to My First Program");

Console.WriteLine();
    
        Console.Write("integer  :  ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("decimal  :  ");
        float num2 = Convert.ToSingle(Console.ReadLine());

        Console.Write("double   :  ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();

        double average = (num1 + num2 + num3) / 3;
        Console.WriteLine("Average: " + average );


