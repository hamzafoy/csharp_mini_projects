using System;

class WorkLengthCalculator
{
    static void Main(string [] args)
    {
        //Determine what time you'll get off work.
        //`startHour` collects your current time.
        DateTime startHour = DateTime.Now;
        //The `TimeSpan` typed variable is given the hours and minutes that the employee expects to work.
        TimeSpan lengthOfWork = new TimeSpan(12, 11, 00);
        //This last variable will add the work time's length to the determined start time.
        //This variable stores the expected time the employee will end their day's shift.
        DateTime endHour = startHour.Add(lengthOfWork);

        Console.WriteLine(endHour);
    }
}