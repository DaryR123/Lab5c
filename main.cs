using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Lab5c");
    
      int num;
      int i;
      int d;

  
        Console.Write("Enter any number");
        num = Convert.ToInt32(Console.ReadLine());
 
        d = 0;
        for (i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                d = 1;
                break;
            }
        }
        if (d == 0)
            Console.WriteLine(num+ " is a Prime Number");
        else
            Console.WriteLine(num+" is a Not Prime Number");        
 
        Console.ReadLine();
    }
}