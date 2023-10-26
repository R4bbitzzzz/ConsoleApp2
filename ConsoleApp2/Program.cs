int[] ints = new int[10];
Random rnd = new Random();
for (int i = 0; i < ints.Length; i++)
{
    ints[i] = rnd.Next(1,1000);
    
}
Console.WriteLine("A tömb elemeinek a kétszeresei: ");
//Foreach - Változója csak egy másolat a tömb aktuális eleméről.
foreach (int i in ints) {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"{i} ");
    Console.ForegroundColor= ConsoleColor.White;
} 
Console.WriteLine();
Console.WriteLine("A tömb elemeinek a kétszeresei: ");
foreach (int i in ints)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"{i * 2} ");
    Console.ForegroundColor = ConsoleColor.White;
}
Console.WriteLine();