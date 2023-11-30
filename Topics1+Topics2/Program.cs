//C# Task / array 
//Create console application that read string from user and print the same string
using System.ComponentModel;
using System.Xml.Linq;

string str = Console.ReadLine();
Console.WriteLine(str);

//Define variables with kind of
// Double
//String 
//Char
//Bool
//Int
//Const
//Then display it in console application
Console.WriteLine("---------------------------------------------------------------");
double x = 1.0;
string name = "Suhib";
char vowelLetter='A';
bool check=false;
int number = 1;
const int number2 = 1;
Console.WriteLine($"x={x},name={name},vowelLetter={vowelLetter},check={check},number={number},number2={number2}");
Console.WriteLine("---------------------------------------------------------------");
//Define array with name car that hold more than 3 kinds on cars, then print all the cars with the array length.
string []cars=new string[3] {"Marceds","Opel","Toyota"};
Console.WriteLine($"The cars in array: that has length {cars.Length}");
foreach(var pointer in cars)
{
    Console.WriteLine(pointer);
}

Console.WriteLine("---------------------------------------------------------------");
//Write a program in C that reads a first name, surname and year of birth and display the names and the year one after another sequentially. Go to the editor
//Input your firstname: Sami
//Input your lastname: Ali
//Input your year of birth: 1999
//Sami Ali 1999

string firstName,sureName,birthDate;
string[] contentsKey = new string[3] { "firstName", "sureName", "birthDate" };
string[] contents=new string[3];
for(int i=0;i<contents.Length ;i++)
{
    Console.WriteLine($"Please input your {contentsKey[i]}");
    contents[i] = Console.ReadLine();
}

for(int i=0;i< contents.Length; i++)
{
    Console.Write(contents[i]+" ");
}
Console.WriteLine();

//Write a program in C # to store elements in an array and print it. 
//Test Data :	
//Input 10 elements in the array :
//element - 0 : 1
//element - 1 : 1
//element - 2 : 2.......
//Expected Output :
//Elements in array are: 1 1 2 3 4 5 6 7 8 9

int[] num = new int[10];
for(int i=0;i<num.Length ;i++)
{
    Console.WriteLine($"Define the values that you want to save in the array the has length = {num.Length}");
    num[i] = Convert.ToInt32(Console.ReadLine());
}
foreach(var pointer in num)
{
    Console.Write(pointer+" ");
}
