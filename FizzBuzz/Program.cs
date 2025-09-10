// See https://aka.ms/new-console-template for more information
// For operationen att kolla om ett tal är delbart med 3 och 5 så används modulus operatorn (%). Denna operator returnerar resten av en division.
// Om resten är 0 betyder det att talet är delbart med det andra talet. Allt annat betyder "False"

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}



