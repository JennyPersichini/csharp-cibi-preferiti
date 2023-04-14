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

string[] favoriteFoods = { "pizza", "frozen yogurt", "piadina", "bomba alla crema", "timballo", "broccoli", "polenta" };

//stampo a video la lunghezza della classifica

Console.WriteLine("Lunghezza: " + favoriteFoods.Length);

//stampo l'intera classifica

Console.WriteLine("La classifica ufficiale: ");

for (int i = 0; i < favoriteFoods.Length; i++)
{
    Console.WriteLine($"{i + 1} - {favoriteFoods[i]}");
}

//stampo il cibo top



//stampo il cibo preferito ma non troppo