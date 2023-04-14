// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/* 
 * Nel programma inizializzate un array con la classifica dei vostri cibi preferiti (minimo 5, massimo 10 elementi). 
 * L’array deve essere già inizializzato nel programma ordinato già con i cibi dal più preferito al meno preferito, e i vostri cibi preferiti non vanno chiesti all’utente tramite input (hard-coded).
 * Una volta dichiarato l’array di cibi preferiti, stampate a video le seguenti informazioni:
 * La lunghezza della classifica
 * La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
 * Il vostro cibo top (prima posizione della classifica)
 * Il vostro cibo preferito ma non troppo (ultima posizione della classifica)
 */


//inizializzo l'array

string[] favoriteFoods = { "pizza", "frozen yogurt", "piadina", "bomba alla crema", "timballo", "kafferep", "broccoli", "polenta" };

//stampo a video la lunghezza della classifica

Console.WriteLine("Lunghezza: " + favoriteFoods.Length);

//stampo l'intera classifica

Console.WriteLine("La classifica ufficiale: ");

for (int i = 0; i < favoriteFoods.Length; i++)
{
    Console.WriteLine($"{i + 1} - {favoriteFoods[i]}");
}

//stampo il cibo top

Console.WriteLine($"Il cibo top del top: {favoriteFoods[0]}");

//stampo il cibo preferito ma non troppo

Console.WriteLine("Il cibo che mi piace ma non mi fa fare wow: " + favoriteFoods[favoriteFoods.Length - 1]);




Console.Write("Quanti cibi preferiti hai? ");
uint numeroCibi = uint.Parse(Console.ReadLine());

string[] arrayCibi = new string[numeroCibi];

for (int i = 0; i < numeroCibi; i++)
{
    Console.Write("Inserisci il cibo: ");
    string food = Console.ReadLine();
}

//Attenzione: gestire anche il caso se aveste una classifica con un numero di elementi pari.
//In questo caso vanno stampati i 2 elementi in centro alla vostra classifica. 

if (arrayCibi.Length % 2 == 0)
{
    Console.WriteLine("In mezzo troveremo: " + arrayCibi[(arrayCibi.Length - 1) / 2] + ", " + arrayCibi[(arrayCibi.Length) / 2]);
}
else
{
    Console.WriteLine("In mezzo troveremo: " + arrayCibi[(arrayCibi.Length) / 2]);
}