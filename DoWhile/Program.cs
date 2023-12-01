Random random = new Random();
Random otherRandom = new();
int current = 0;
int current01 = otherRandom.Next(1, 11);

do
{
    current = random.Next(1, 11);
    if (current >= 8) continue; //contintue to the next iteration
    Console.WriteLine(current);
} while (current != 7);

Console.WriteLine();
Console.WriteLine();
while (current01 >= 3)
{
    Console.WriteLine(current01);
    current01 = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current01}");

//Notes:
/*
As you saw in this last step, the continue statement transfers execution to the end of the current iteration. 
This behavior is different than the behavior we saw with the break statement. 
The break statement terminates the iteration (or switch) and transfers control to the statement that follows the terminated statement. 
If there is no statement after the terminated statement, then control transfers to the end of the file or method.
*/