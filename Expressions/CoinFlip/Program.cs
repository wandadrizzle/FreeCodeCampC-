Random coin = new();
int flippedValue = coin.Next(1,3);

Console.WriteLine($"You have rolled {((flippedValue == 1)?"heads":"tails")}\n\n");

//1 = heads
//2 = tails

string permission = "Admin|Manager";
int level = 55;
string message = "";

if(permission.Contains("Admin")){
    message =  level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user.";
}
else if(permission.Contains("Manager")){
    message =level >= 20 ? "Contact an Admin for access" : "You do not have sufficient privileges.";
}
else {
    message = "You do not have sufficient privileges.";
}

Console.WriteLine(message + "\n\n");

//A locally scoped variable is only accessible inside of the code block in which it's defined.
bool flag = true;
int value = 0;//This needs to be instantiated 

if (flag)
{
    value = 10;
    Console.WriteLine("Inside of code block: " + value);
}
Console.WriteLine($"Outside of code block: {value} \n\n");

//update problematic code in the code editor
int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
foreach (int number in numbers)
{
    total += number;

    if (number == 42)
    {
       bool found = true;
       if (found) 
          Console.WriteLine("Set contains 42");
    }
}



Console.WriteLine($"Total: {total}  \u263A 🍎🍌🍇");


#region Notes on readability
//Never use single-line form (for example: if (flag) Console.WriteLine(flag);
//Using braces is always accepted, and required if any block of an if/else if/.../else compound statement uses braces or if a single statement body spans multiple lines.
//Braces may be omitted only if the body of every block associated with an if/else if/.../else compound statement is placed on a single line.
#endregion