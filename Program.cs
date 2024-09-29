//start main
using System.ComponentModel.DataAnnotations;

double menuChoice = 0;
while (menuChoice != 4)
{
    DisplayMenu();
    Pause();
}
//end main


static void DisplayMenu()
{
    Console.WriteLine("Please enter a menu option.\n1. Plain Pizza\n2. Cheese Pizza\n3. Pepperoni Pizza.");

    try
    {
        double menuChoice = Double.Parse(Console.ReadLine());
        RouteMenuChoice(menuChoice);
    }
    catch{
        Console.WriteLine("Invalid option. Please try again.\nPress any key to continue.");
    }
}

static void RouteMenuChoice(double menuChoice)
{
    switch(menuChoice)
    {
        case 1:
            PlainPizza();
            break;
        case 2:
            CheesePizza();
            break;
        case 3:
            PepPizza();
            break;
    }
}

static void PlainPizza()
{
    Random rnd = new Random();
    int randomNum = rnd.Next(8, 13);
    int rows = randomNum;

    for(int i=rows; i>=1; i--)
    {
        for(int j=1; j <= i; j++)
        {
            Console.Write("*");
        }
            Console.WriteLine();
    }
        Pause();
    }

static void CheesePizza()
{
    Random rnd = new Random();
    int randomNum = rnd.Next(8, 13);
    int rows = randomNum;

    for(int k=0; k <= rows; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();

    for(int i=rows; i>=1; i--)
    {
        for(int j=1; j <= i; j++)
        {
            if(j == 1 || j == i)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write("#");
            }
        }
        Console.WriteLine();
    }
    Pause();
}

static void PepPizza()
{
    Random rnd = new Random();
    int randomNum = rnd.Next(8, 13);
    int rows = randomNum;

    for(int k=0; k <= rows; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();

    for(int i=rows; i>=1; i--)
    {
        for(int j=1; j <= i; j++)
        {
            if(j == 1 || j == i)
            {
                Console.Write("*");
            }
            else
            {
                int randomPepperoni = rnd.Next(1,10);
                if(randomPepperoni == 1)
                {
                    Console.Write("✪");
                }
                else
                {
                    Console.Write("#");
                }
            }
        }
        Console.WriteLine();
    }
    Pause();
}



static void Pause()
{
    Console.ReadKey();
}