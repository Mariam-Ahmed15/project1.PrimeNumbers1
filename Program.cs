// See https://aka.ms/new-console-template for more information


Console.WriteLine("This programe finds prime numbers whithen given range.");
Console.WriteLine("Please, Give me the range from num1 to num2 .");
Console.WriteLine("num1= ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("num2= ");
int num2 = int.Parse(Console.ReadLine());
int startPoint = Math.Min(num1, num2);
int endPoint = Math.Max(num1, num2);
Boolean isPrime = false; 

Console.WriteLine("Prime numbers between "
+ num1 + " and " + num2);
for (int k = startPoint; k <= endPoint; k++)
{
    //  loop the iterations for k-1 times
    for (int i = 2; i <= k; i++)
    {
        isPrime = true;
        if (k == i)
           Console.WriteLine(k);
        if ((k % i) == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime == true)
    {
        Console.WriteLine(k);
    }
    
}
        
    



