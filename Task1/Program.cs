
using System;
using System.Security.Cryptography.X509Certificates;

class Task1
{
    static void Main()
    {
        int hours;
        int minutes;
        int degrees;

        do
        {
            Console.Write("Please enter hours: ");
            hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter minutes: ");
            minutes = Convert.ToInt32(Console.ReadLine());

            if (hours > 24 || hours < 0 || minutes > 60 || minutes < 0)
                Console.WriteLine("Invalid input. Please try again!" + "\n");

        } while (hours > 24 || hours < 0 || minutes > 60 || minutes < 0);

        if (hours > 12)
            hours -= 12;

        int x = Math.Abs(minutes - hours * 5);
        degrees = x * 6;
      
        if (degrees > 180)
            degrees = 360 - degrees;

        Console.WriteLine("Lesser angle of two arrows is " + degrees + " degrees.");
        
    }
}