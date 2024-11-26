using static System.Runtime.InteropServices.JavaScript.JSType;

/* Write a program in C# Sharp
- to input a string and print it.
- to find the length of a string without using a library function.
- to separate individual characters from a string.
- to print individual characters of the string in reverse order.
- to count the total number of words in a string.
- to compare two strings without using a string library functions.
- to count the number of alphabets, digits and special characters in a string.
- to count the number of vowels or consonants in a string.
- to check whether a given substring is present in the given string.
- to search for the position of a substring within a string.
- to check whether a character is an alphabet and not and if so, check for the case.
- to find the number of times a substring appears in a given string.
- to insert a substring before the first occurrence of a string. */

class Program
{
    private static void Main()
    {
        q1();
    }

    static void q1()
    {
        Console.Write("Enter a string: ");
        string user = Console.ReadLine();
        Console.WriteLine(user);
    }
}