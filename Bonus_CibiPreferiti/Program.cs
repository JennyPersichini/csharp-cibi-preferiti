// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
 * BONUS
 * Chiedere all'utente quanti cibi preferiti ha, e farglieli inserite da input della Console nell'array.
 * Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione mediana.
 */

Console.Write("Quanti cibi preferiti hai? ");
uint numeroCibi = uint.Parse(Console.ReadLine());

string[] arrayCibi = new string[numeroCibi];

for (int i = 0; i < numeroCibi; i++)
{
    Console.Write("Inserisci il cibo: ");
    string food = Console.ReadLine();
}