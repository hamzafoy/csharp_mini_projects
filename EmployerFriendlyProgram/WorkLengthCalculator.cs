using System;

class WorkLengthCalculator
{
    static void Main(string [] args)
    {
        //Determine what time you'll get off work.
        //`startHour` collects your current time.
        DateTime startHour = DateTime.Now;
        //The user will input the # of hours he/she expects to work.
        //The input will be converted from string to int.
        //The hour will be used in the TimeSpan typed variable
        string userInputtedHour;
        Console.Write("How many hours will you work today? ");
        userInputtedHour = Console.ReadLine();
        int hourAsInteger = Convert.ToInt32(userInputtedHour);
        TimeSpan lengthOfWork = new TimeSpan(hourAsInteger, 00, 00);
        //This last variable will add the work time's length to the determined start time.
        //This variable stores the expected time the employee will end their day's shift.
        DateTime endHour = startHour.Add(lengthOfWork);

        Console.WriteLine("Expect to leave at: {0}", endHour.ToString("hh:mm tt"));
    }
}