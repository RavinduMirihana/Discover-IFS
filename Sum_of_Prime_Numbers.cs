using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Hello Mono World");
        int SumAll = 0;
    int SumNonPrime = 1;
        for (int i =1; i < 33; i++) 
        { SumAll+=i;
            for (int j = 2; j <= (i/2); j++) {
                
                if (i % j == 0) {
                
                SumNonPrime+=i;
                break;
                }
                
            
            }
            
            
        }
        Console.WriteLine(SumAll-SumNonPrime);
    }
}