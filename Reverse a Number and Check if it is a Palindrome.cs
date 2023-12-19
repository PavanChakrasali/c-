using System;
class Program
{
    public static void Main()
    {
        int num, temp, rem, reverse = 0;
        Console.WriteLine("Enter an integer \n");
        num = int.Parse(Console.ReadLine());
        temp = num;
        while (num > 0)
        {
            rem = num % 10;
            Console.WriteLine(rem);
            reverse = reverse * 10 + rem;
            Console.WriteLine(reverse);
            num /= 10;
            Console.WriteLine(num);
        }
        Console.WriteLine("Given number is = {0}", temp);
        Console.WriteLine("Its reverse is  = {0}", reverse);
        if (temp == reverse)
            Console.WriteLine("Number is a palindrome \n");
        else
            Console.WriteLine("Number is not a palindrome \n");
        Console.ReadLine();
    }
}
