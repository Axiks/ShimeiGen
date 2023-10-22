// See https://aka.ms/new-console-template for more information
using JapaneseNameGenerator;
using JapaneseNameGenerator.Models;

Console.WriteLine("Hello, World!");
Console.OutputEncoding = System.Text.Encoding.Unicode;

ShimeiGenerator jpGenerator = new ShimeiGenerator();

while (true)
{
    Person person = await jpGenerator.GetRandomPerson();

    Console.WriteLine($"{ person.RomanjiFullName } : {person.KanjiFullName} : {person.Sex}");
    Console.ReadLine();
}