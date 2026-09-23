using Making_Classes;
int dieTotal;

Die die1 = new Die();
die1.Color = ConsoleColor.Red;
//Console.WriteLine(die1);
die1.RollDie();

Die die2 = new Die();
//Console.WriteLine(die1);
die2.RollDie();
die1.DrawRoll();
die2.DrawRoll();
dieTotal = (die1.Roll + die2.Roll);


    if (die1.Roll == die2.Roll)
    {
        Console.WriteLine("Doubles!");
    }
    else
    {
        Console.WriteLine("Cool!");
    }


if (die1.Roll == 1 && die2.Roll == 1)
    {
    Console.WriteLine("Snake Eyes!");
    }


if dieTotal = (7)
{
    Console.WriteLine("Lucky 7!");
}


if dieTotal = (2, 4, 6, 8, 10, 12) 
{
    Console.WriteLine("Even sum!");
}

if (die1.Roll < die2.Roll)
{
    Console.WriteLine($"{die2.Roll} is greater than {die1.Roll}");
   
} 
else
    {
        Console.WriteLine($"{die1.Roll} is greater than {die2.Roll}");
    }