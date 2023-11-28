
Random dice = new();
int dice1 = dice.Next(1,7);
int dice2 = dice.Next(1,7);
int dice3 = dice.Next(1,7);

int diceTotal = dice1 + dice2 + dice3;
int bonus = 0;

if(dice1 == dice2 && dice2 == dice3){
    Console.WriteLine("You rolled triples! +6 bonus to total!"); 
    bonus = 6;
}
else if (dice1 == dice2 || dice1 == dice3 || dice2 == dice3){
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    bonus = 2;
}

//This could have been nested:
/*
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}
*/

int score = diceTotal + bonus;
Console.WriteLine ("1st die: " + dice1);
Console.WriteLine ("2nd die: " + dice2);
Console.WriteLine ("3rd die: " + dice3);
Console.WriteLine ("You rolled a total of: " + diceTotal);
Console.WriteLine ("Your bonus is: " + bonus);
Console.WriteLine ("Your final score is: " + score);


if (score > 14){
    //This is a code block
    Console.WriteLine("\nYou win!");
}
else {
    Console.WriteLine("\nSorry, You lose.");
}

/*
if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}
*/

//Other boolean expression examples:
string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine("\nDoes the hidden message contain the word fox? " + result);

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}