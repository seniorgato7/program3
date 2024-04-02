using System;
class Timemachine
{
    static void Main(string[] args)
    {
        int inputSeconds;

        Console.WriteLine("Enter the number of seconds: ");
        while (!int.TryParse(Console.ReadLine(), out inputSeconds))
        {
            Console.WriteLine("Invalid input. Please enter a valid number of seconds: ");
        }

        ConvertTime(inputSeconds);
    }
    static void ConvertTime(int seconds)
    {
        int minutes = seconds / 60;
        int remainingSeconds = seconds % 60;

        int hours = minutes / 60;
        minutes = minutes % 60;

        int days = hours / 24;
        hours = hours % 24;

        int months = days / 30;
        days = days % 30;

        Console.WriteLine($"{seconds} seconds is equal to:");
        Console.WriteLine($"{months} months {days} days, {hours} hours, {minutes} minutes, and {remainingSeconds} seconds");
    }
}