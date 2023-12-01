string fruit = "banana";
switch (fruit)
{
    case "apple":
        Console.WriteLine($"App will display information for apple.");
        break;

    case "banana":
        Console.WriteLine($"App will display information for banana.");
        break;

    case "cherry":
        Console.WriteLine($"App will display information for cherry.");
        break;
}

int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
        /*title = "Junior Associate";
        break;*/
    case 200:
        title = "Senior Associate";
        break; //The break keyword is one of several ways to end a switch section before it gets to the next section
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"\n{employeeName}, {title}");

//CHALLENGE:
string sku = "01-MN-L";
    string[] parts = sku.Split('-');
    string part1 = parts[0]; // "01"
    string part2 = parts[1]; // "MN"
    string part3 = parts[2]; // "L"

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch(part1){
case "01":
type = "Sweat Shirt";
break;
case "02":
type = "T-Shirt";
break;
case "03":
type = "Sweat pants";
break;
default:
type = "Other";
break;
}
switch(part2){
    case "BL":
    color ="Black";
    break;
    case "MN":
    color = "Maroon" ;
    break;
    default:
    color = "White";
    break;
}
switch(part3){

    case "S":
      size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}\n\n");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
     if (i == 7) break; //Used if we need to exit the iteration statement prematurely based on some condition
}
Console.WriteLine();
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}
Console.WriteLine();
//You can't update a value via a foreach loop
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    if (names[i] == "David") names[i] = "Sammy";
    Console.WriteLine(names[i]);
}

//Incrementing differently: i += 3