internal class Program
{
    private static void Main(string[] args)
    {
        /*string[] fraudulentOrderIDs = new string[3];

        fraudulentOrderIDs[0] = "A123";
        fraudulentOrderIDs[1] = "B456";
        fraudulentOrderIDs[2] = "C789";*/
        //fraudulentOrderIDs[3] = "D000"; //Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.

        string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

        Console.WriteLine($"First: \t\t{fraudulentOrderIDs[0]}");
        Console.WriteLine($"Second: \t{fraudulentOrderIDs[1]}");
        Console.WriteLine($"Third: \t\t{fraudulentOrderIDs[2]}");

        fraudulentOrderIDs[0] = "F000";

        Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");     
        Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.\n");
        //ITERATION!!
        Console.WriteLine("FOREACH LOOP: Names");

        string[] names = { "Rowena", "Robin", "Bao" };
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine("\nFOREACH LOOP: Sum of an Array");
        int sum = 0;
        int bin = 0;
        int[] inventory = { 200, 450, 700, 175, 250 };
        foreach (int items in inventory)
        {
          sum += items;
          bin++;
          Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
        }
        Console.WriteLine($"We have {sum} items in inventory.");
    }
}