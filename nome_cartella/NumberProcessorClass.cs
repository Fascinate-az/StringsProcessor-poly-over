namespace ConsoleApp1x;

class NumberProcessor
{
    
    public List<int> ProcessNumbers(List<int> numbers)
    {
        List<int>listnumber = new List<int>();
        foreach (int item in numbers)
        {
            listnumber.Add(ProcessNumber(item));
        }
        return listnumber;
    }

    protected virtual int ProcessNumber(int number)
    {
        return number;
    }
    
    
}

class NumberDoubler : NumberProcessor
{
    protected override int ProcessNumber(int number)
    {
        return number*2;
    }
}
class NumberSquarer : NumberProcessor
{
    protected override int ProcessNumber(int number)
    {
        var elevato = 2;
        double potente = Math.Pow(number, elevato);
        number = (int)potente;
        return number;
    }
}
