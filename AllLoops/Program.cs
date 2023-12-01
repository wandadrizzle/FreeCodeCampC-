string? readResult;
bool validEntry = false;
// capture user input in a string variable named readResult
Console.Clear();
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);

Console.WriteLine();
Console.WriteLine();

string readNumberResult;
int numericValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do{
    readNumberResult = Console.ReadLine();
    validNumber = int.TryParse(readNumberResult, out numericValue);

    if(readNumberResult != null){

        if(validNumber)
        {
            if(numericValue > 5 && numericValue < 10)
            {
            Console.WriteLine($"Your input value ({numericValue}) has been accepted.");
            validNumber = true;
            }
            else
            {
            Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
            validNumber = false;
            }
        }
        else
        {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
        validNumber = false;
        }
    }
}while(validNumber == false);