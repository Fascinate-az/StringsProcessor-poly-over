class StringsProcessor
{
    // Lista di parole che conterrà i risultati elaborati
    public List<string> listaParole = new List<string>();

    // Metodo che prende una lista di parole in input, le elabora e le aggiunge alla listaParole
    public List<string> listaParoleMetodo(List<string> word)
    {
        // Per ogni parola nella lista passata come parametro
        foreach (var item in word)
        {
            // Aggiunge alla listaParole il risultato dell'elaborazione della parola (mediante il metodo Processar)
            listaParole.Add(Processar(item));
        }
       
        // Restituisce la lista contenente tutte le parole elaborate
        return listaParole;
    }

    
    // Attualmente ritorna semplicemente la stringa in ingresso senza modifiche
    public virtual string Processar(string word)
    {
        return word;
    }
}


class StringsUppercaseProcessor : StringsProcessor
{
    // Override del metodo Processar per convertire la parola in maiuscolo
    public override string Processar(string word)
    {
        return word.ToUpper();
    }
}


class StringsTrimmingProcessor : StringsProcessor
{
    // Override del metodo Processar per ritornare solo la prima metà della stringa
    public override string Processar(string word)
    {
        // Calcola il punto medio della stringa
        var dimezza = word.Length / 2;
        // Ritorna la sottostringa dal primo carattere fino a dimezza caratteri
        return word.Substring(0, dimezza);
    }
}
