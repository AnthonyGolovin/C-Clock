using System;
using System.Threading;
using System.Collections.Generic;

public class Clock
{
    public int Hour;
    public int Minute;

    public Clock(int hour, int minute)
    {
        Hour = hour;
        Minute = minute;
    }

    public double degrees()
    {
    if (Hour == 12)
    {
        double hourDegree = Minute * .5;
        Console.WriteLine(hourDegree);

        double minuteDegree = Minute * 6;
        Console.WriteLine(minuteDegree);

        double difference = hourDegree - minuteDegree;
        return Math.Abs(difference);
    } 
    else
    {
        double hourDegree = Hour * 30;
        Console.WriteLine(hourDegree);
        double minuteDegree = Minute * 6;
        Console.WriteLine(minuteDegree);

        double difference = hourDegree - minuteDegree;
        return Math.Abs(difference);
    }


}
}
class Program
{
 
 static void Main()
    {
        Console.WriteLine("What hour is it?");
        int whatHour = int.Parse(Console.ReadLine());
        Console.WriteLine("What minute is it?");
        int whatMinute = int.Parse(Console.ReadLine());

        Clock newClock =new Clock(whatHour, whatMinute);
        double answer = newClock.degrees();
        Console.WriteLine("The difference between the hour and minute hand is " + answer);
    }
}