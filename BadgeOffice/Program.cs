/*
* Name: Terry McCulley
* Course: CSCI 1250, Section 001
* Assignment: Lab 03, Badge Office
* Date: September 30, 2026
* Description: Assigning IDs and locker numbers to students.
*/

Console.WriteLine("What is your name? ");
string name = Console.ReadLine();
string fullName = name.ToUpper();

fullName = fullName.Trim();
int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);

int nameNumber = Convert.ToInt32(lastName.Length);

string username = firstName.Substring(0, 1);
string username2 = lastName.ToLower();
string username3 = username.ToLower();

string initials1 = username.ToUpper();
string initials2 = lastName.Substring(0,1);
string initials3 = initials2.ToUpper();

Random rng = new Random();

int studentNumber = rng.Next(100000, 1000000);
int lockerNumber = rng.Next(1, 501);

Console.WriteLine("Name on badge: " + firstName + " " + lastName);
Console.WriteLine("Username: " + username3 + username2);
Console.WriteLine("Initials: " + initials1 + "." + initials3 + ".");
Console.WriteLine("Letters in last name: " + nameNumber);
Console.WriteLine(" ");
Console.WriteLine("student ID: " + studentNumber);
Console.WriteLine("Locker: " + lockerNumber);

Console.WriteLine("========================================");
Console.WriteLine("           ETSU STUDENT BADGE           ");
Console.WriteLine("========================================");
