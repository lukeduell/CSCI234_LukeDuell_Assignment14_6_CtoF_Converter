/* Luke Duell
 * Instructor: Professor Hanoudi
 * CSCI 234: Object Oriented Programming w/C#
 * Assignment 14.6
 * Description: This program takes in the user integer for
 *              fahrenheit and outputs the value for celcius
 */

using System;

class WritetoConsole
{
    static void Main()
    {
        double celcius_1 = 0, celcius_2 = 0;

        Console.WriteLine("Enter current fahrenheit");
        string fahrenheit = Console.ReadLine();
        int fahr_int = int.Parse(fahrenheit);

        celcius_1 = 0.55555555555;
        celcius_2 = celcius_1 * (fahr_int - 32);

        Console.WriteLine($"\nCelcius Value: {celcius_2}");
    }
}
