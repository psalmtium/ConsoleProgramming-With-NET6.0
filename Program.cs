// See https://aka.ms/new-console-template for more information

string fullName = string.Empty;
int age;
double salary;
char gender = char.MinValue;
bool working;

Console.Write("Please enter your Name: ");
fullName = Console.ReadLine();

Console.Write("Please enter your Age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("please enter your Salary: ");
salary = Convert.ToDouble(Console.ReadLine());

Console.Write("Please enter your Gender(M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working (True or False): ");
working = Convert.ToBoolean(Console.ReadLine());


Console.WriteLine("Your name is: " + fullName);
Console.WriteLine("Your age is: {0}", age);
Console.WriteLine($"Your salary is: {salary}");
Console.WriteLine($"Your Gender is: {gender} ");
Console.WriteLine($"You are employed: {working}");
