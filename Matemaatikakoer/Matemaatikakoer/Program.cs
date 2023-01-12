namespace Matemaatikakoer
{
    internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Matemaatikakoer");

        Console.WriteLine("Palun sisesta esimene arv");
        float firstNr = int.Parse(Console.ReadLine());

        Console.WriteLine("Palun sisesta tehe: ");
        string operation = Console.ReadLine();

        Console.WriteLine("Palun sisesta teine arv");
        float secondNr = int.Parse(Console.ReadLine());



        try
        {
            switch (operation)
            {
                case "+":
                    float resultAdd = firstNr + secondNr;
                    Console.WriteLine("Kahe numbri liitmisel on vastus: " + resultAdd);
                    break;

                default:
                    break;

            }
                switch (operation)
                {
                    case "-":
                        float resultAdd = firstNr - secondNr;
                        Console.WriteLine("Kahe numbri lahutamisel on vastus: " + resultAdd);
                        break;

                    default:
                        break;

                }
                switch (operation)
                {
                    case "/":
                        float resultAdd = firstNr / secondNr;
                        Console.WriteLine("Kahe numbri jagamisel on vastus: " + resultAdd);
                        break;

                    default:
                        break;

                }
                switch (operation)
                {
                    case "*":
                        float resultAdd = firstNr * secondNr;
                        Console.WriteLine("Kahe numbri korrutamisel on vastus: " + resultAdd);
                        break;

                    default:
                        break;

                }
            }
        catch (FormatException)
        {
            Console.WriteLine("Vale numbri formaat.");
            //throw1;
            //123
        }
        catch (OverflowException)
        {
            Console.WriteLine("ERROR. Sisestatud number on liiga suur.");
        }
    }
}
}