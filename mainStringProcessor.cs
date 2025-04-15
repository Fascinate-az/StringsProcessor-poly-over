class Program
{
    static void Main(string[] args)
    {
        List<string> listaParole = new List<string>() { "bobcat", "wolverine", "grizzly" };
        StringsProcessor stringsProcessor = new StringsProcessor();
        StringsProcessor toUpper = new StringsUppercaseProcessor();
        StringsProcessor trimming = new StringsTrimmingProcessor();

        List<StringsProcessor> processorsAll = new List<StringsProcessor>(){toUpper, trimming};

        // Inizialmente, la variabile "risultato" contiene la lista iniziale di parole
        List<string> risultato = listaParole;

       // Per ogni processore contenuto nella lista processorsAll
        foreach (var item in processorsAll)
        {
            // Applichiamo il metodo listaParoleMetodo del processore corrente
            // a "risultato" (cioè la lista di parole corrente), e aggiorniamo "risultato"
            // con la lista elaborata.
            risultato = item.listaParoleMetodo(risultato);
        }

        // Iteriamo sulla lista finale "risultato" per stampare ogni parola
        foreach (var item in risultato)
        {
            
            Console.WriteLine(item);
        }






    }
}
