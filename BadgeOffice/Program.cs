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

Console.WriteLine("What is the dorm's X coord? ");
double dormXCoord = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("What is the dorm's Y coord? ");
double dormYCoord = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("What is the classroom's X coord? ");
double classXCoord = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("What is the classroom's Y coord? ");
double classYCoord = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("What is your walking speed in feet per second? ");
double walkingSpeed = Convert.ToDouble(Console.ReadLine());

double distance1 = Math.Pow(classXCoord, 2) - Math.Pow(dormXCoord, 2);
double distance2 = Math.Pow(classYCoord, 2) - Math.Pow(dormYCoord, 2);
double distanceFinal = Math.Sqrt(distance1 + distance2);
Double trueDistance = Math.Round(distanceFinal, 1);

double time = distanceFinal / walkingSpeed;

int timeInt = Convert.ToInt32(time);

int timeMinutes = timeInt / 60;
int timeSeconds = timeInt % 60;

Console.WriteLine("Name on badge: " + firstName + " " + lastName);
Console.WriteLine("Username: " + username3 + username2);
Console.WriteLine("Initials: " + initials1 + "." + initials3 + ".");
Console.WriteLine("Letters in last name: " + nameNumber);
Console.WriteLine(" ");
Console.WriteLine("student ID: " + studentNumber);
Console.WriteLine("Locker: " + lockerNumber);
Console.WriteLine(" ");
Console.WriteLine("Distance: " + trueDistance);
Console.WriteLine("Walk Time: " + timeMinutes + " Minutes " + timeSeconds + " Seconds");

string nameBadge = "NAME";
string marginsName = nameBadge.PadRight(10);

string usernameBadge = "USERNAME";
string userMargins = usernameBadge.PadRight(10);

string IDBadge = "ID";
string IDMargins = IDBadge.PadRight(10);

string lockerBadge = "LOCKER";
string lockerMargins = lockerBadge.PadRight(10);

string walkBadge = "WALK";
string walkMargins = walkBadge.PadRight(10);

int checkDigit = studentNumber % 9;

Console.WriteLine("========================================");
Console.WriteLine("           ETSU STUDENT BADGE           ");
Console.WriteLine("========================================");
Console.WriteLine(marginsName + fullName);
Console.WriteLine(userMargins + username3 + username2);
Console.WriteLine(IDMargins + studentNumber + "-" + checkDigit);
Console.WriteLine(lockerMargins + lockerNumber);
Console.WriteLine(walkMargins + timeMinutes + " min " + timeSeconds + " sec");
Console.WriteLine("========================================");
