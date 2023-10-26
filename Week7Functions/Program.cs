Console.WriteLine("Are we coming or leaving? (in/out):");
string userCoice = Console.ReadLine();

if (userCoice == "in")
{ PrintHello(); }
else
{ PrintGoodBye(); }



static void PrintHello() /// function / method
{
    Console.WriteLine("Hello, world!");
}


static void PrintGoodBye()
{
    Console.WriteLine("See you later, aligator.");
}