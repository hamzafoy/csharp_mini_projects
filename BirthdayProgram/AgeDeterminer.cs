//This application takes three pieces of user input: user's birth month, day, and year.
//This application calculates the age of the user based on this information provided.

Console.WriteLine("Input the month you were born in its numerical form [ex: 07]");
//User input via Console.WriteLine always stores as a string, so must be converted to an integer.
int userSubmittedBirthMonth = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the day you were born in its numerical form [ex: 28]");
int userSubmittedBirthDay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your birth year in its full 4 digits");
int userSubmittedBirthYear = Convert.ToInt32(Console.ReadLine());

DateTime userBirth = new DateTime(userSubmittedBirthYear, userSubmittedBirthMonth, userSubmittedBirthDay);
Console.WriteLine(userBirth.ToString());

//The mathematical operation to produce the age of the user requires getting the number of days between
//the current date and the user's birth and dividing that by 365 (number of days in a year).
TimeSpan age = ((startHour - userBirth) / 365);
Console.WriteLine(age.Days.ToString());