using System.Diagnostics;
using System.Reflection;
using System.Xml.Linq;
#region functions
string get(string name = "yo")
{
    Console.WriteLine(name); return name;
}
void fun()
{
    Console.WriteLine("Osama");
}
int sum()
{
    int n1 = 23, n2 = 9, n3 = 7, sum;
    return sum = n1 + n2 + n3;
}
double empSalary()
{
    double mainSalary = 500, eng = 790, sum;
    return sum = mainSalary + eng;
}
double bonuses()
{
    double bon = 75, fly = 300, sum;
    sum = bon + fly;
    return sum;
}
string fuName(string name)
{
    return name;
}

int max(int n, int t)
{
    if (n > t) return n;
    else if (n < t) return t;
    else if (t == n) return t;
    else return 1;
}

void info(string name, string gender, int age)
{
    if ((gender == "M" || gender == "m") && age >= 18)
    {
        Console.WriteLine("\nAccess granted! ..." + "\n\nWelcome Mr " + name + "Your age is: " + age);
    }
    else if ((gender == "F" || gender == "f") && age >= 18)
    {
        Console.WriteLine("\nAccess granted! ..." + "\n\nWelcome Ms " + name + "Your age is: " + age);
    }
    else if (age < 18)
    {
        Console.WriteLine("\nAccess denied!");
    }
    else
    {
        Console.WriteLine("\nInvalid input!");
    }
}
#endregion

get();
fun();
Console.WriteLine(sum() + bonuses());

Console.WriteLine("//------------------------------------------");
Console.Write("Write your full name: ");
string nameFull = Console.ReadLine();
Console.WriteLine(fuName(nameFull));

Console.WriteLine("//------------------------------------------");
Console.Write("Enter 1st num: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter 2nd num: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Larger is: " + max(n1, n2));

Console.WriteLine("//------------------------------------------");

Console.Write("Enter your name: "); 
string name = Console.ReadLine();

Console.Write("Enter your gender: [M/f] "); 
string gender = Console.ReadLine();

Console.Write("Age: "); 
int age = Convert.ToInt32(Console.ReadLine());

info(name, gender, age);


