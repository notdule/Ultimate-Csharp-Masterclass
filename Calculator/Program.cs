Console.WriteLine("Hello!");
Console.WriteLine("Input the first number:");
string firstAsText = Console.ReadLine();
int numOne = int.Parse(firstAsText);

Console.WriteLine("Input the second number:");
string secondAsText = Console.ReadLine();
int numTwo = int.Parse(secondAsText);

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
string userInput  = Console.ReadLine();

if (userInput == "a" || userInput == "A")
{
    int sum = numOne + numTwo;
    Console.WriteLine(
        numOne + " + " + numTwo + " = " + sum);
}
else if (userInput.ToLower() == "s")
{
    int difference = numOne - numTwo;
    Console.WriteLine(
        numOne + " - " + numTwo + " = " + difference);
}
else if (userInput.ToLower() == "m")
{
    int multiplied = numOne * numTwo;
    Console.WriteLine(
        numOne + " * " + numTwo + " = " + multiplied);
}
else
{
    Console.WriteLine("Invalid Option");
}

Console.ReadKey();
