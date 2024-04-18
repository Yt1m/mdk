using System;

public class Program
{
    public struct Time
    {
        public int Hours;
        public int Minutes;
        public int Seconds;

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
    }

    public static int CalculateCallDuration(Time startTime, Time endTime)
    {
   
        int startTimeInSeconds = startTime.Hours * 3600 + startTime.Minutes * 60 + startTime.Seconds;
        int endTimeInSeconds = endTime.Hours * 3600 + endTime.Minutes * 60 + endTime.Seconds;


        int durationInSeconds = endTimeInSeconds - startTimeInSeconds;


        if (durationInSeconds % 60 != 0)
        {
            durationInSeconds += 60 - (durationInSeconds % 60);
        }

        int durationInMinutes = durationInSeconds / 60;

        return durationInMinutes;
    }

    public static void Main(string[] args)
    {

        Time startTime = new Time(10, 15, 30);
        Time endTime = new Time(11, 0, 45);

        int callDuration = CalculateCallDuration(startTime, endTime);
        Console.WriteLine("Продолжительность разговора: " + callDuration + " минут");
    }
}
