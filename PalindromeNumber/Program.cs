// See https://aka.ms/new-console-template for more information

Console.WriteLine("Insert a integer number if you want to know if it´s a palindrome");

int number = Int32.Parse(Console.ReadLine());

int temporalNumber = number;
int reverseNumber = 0;

if (number < 0)
{
    Console.WriteLine("The number is negative, it isn't a palindrome");
}

while (temporalNumber > 0)
{
    reverseNumber = (reverseNumber * 10) + (temporalNumber % 10);
    temporalNumber /= 10;

}

if (number == reverseNumber)
{
    Console.WriteLine("True");
} else { Console.WriteLine("False"); }