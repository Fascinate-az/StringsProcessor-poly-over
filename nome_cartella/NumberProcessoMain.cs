class Program
{
    static void Main(string[] args)
    {
        List<int> listaNumeri = new List<int>(){1,2,3,4,5};
        
        NumberProcessor numProcessor = new NumberProcessor();
        NumberProcessor numerox2 = new NumberDoubler();
        NumberProcessor elevatoAllaPotenza = new NumberSquarer();

        List<NumberProcessor> processoNumeri = new List<NumberProcessor>() { numerox2, elevatoAllaPotenza };
        List<int>newList = listaNumeri;

        foreach (var item in processoNumeri)
        {
            newList = item.ProcessNumbers(newList);
        }

        foreach (var item in newList)
        {
            Console.WriteLine(item);
        }
    }
}
