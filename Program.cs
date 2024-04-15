using System;

public class oddMagicPolygon
{
    public static void Main(string[] args)
    {
        int e = 0;  // Eingabewert
        int s = 0;  // Summe aus drei Zahlen
        int n = 0;  // 2 * e
        int min = 1;
        int z1 = 0; // letzte Zahl
        int z2 = 0; // erste Zahl 
        int sz = 0; // Summe z1 & z2
        int i = 0;  // indexvariable
        int summeg = 0; // Summe der geraden Zahlen
        int summeu = 0; // Summe der ungeraden Zahlen
        int summegu = 0; // Summe der Summe der geraden und ungeraden Zahlen


      
            
            bool validInput = false;

            while (!validInput)
            {
                try
                {
                    Console.WriteLine("Bitte geben Sie eine ungerade ganze Zahl ein:");
                    e = int.Parse(Console.ReadLine());
                    n = 2 * e;
                    if (e % 2 == 0)
                    {
                        throw new ArgumentException("Sie haben eine gerade Zahl eingegeben.");
                    }

                    validInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Sie haben keine Zahl eingegeben.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("Die eingegebene ungerade Zahl ist: " + e);
        



        while (i < (n + 1))
        {

            if (i % 2 == 0)
            {
                summeg = summeg + 2 * i; // jede gerade Zahl wird mit 2 multipliziert, weil sie sich auf den Ecken befinden 
                i++;
            }

            else
            {
                summeu = summeu + i; // die ungeraden Zahlen befinden sich auf den Kanten und werden deshalb nur einfach gezählt
                i++;
            }
        }

        summegu = summeg + summeu;


        s = summegu / e; // die Gesamtsumme aller doppelt gewichteten geraden Zahlen und aller einfach gewichteten ungeraden Zahlen wird durch die Anzahl der Ecken geteilt
                         // daraus ergibt sich die Summe der drei Zahlen
        z1 = n; // erste Zahl ist das Maximum
        z2 = s - z1 - min; // die zweite Zahl ergibt sich aus der Summe der drei Zahlen s minus Maximum und Minimum 
        sz = z1 + z2; // 10+6 beim Fünfeck

        Console.WriteLine(z2 + " + " + min + " + " + z1 + " = " + s);

        while (min < (n - 1))
        {

            min = min + 2; // das Minmum wird immer um 2 größer
            sz = sz - 2; // deswegen muss die Summe aus den beiden geraden Zahlen um 2 kleiner werden, wenn die Gesamtsumme der drei Zahlen gleich bleiben soll
            z2 = sz - z1;

            Console.WriteLine(z1 + " + " + min + " + " + z2 + " = " + s);

            z1 = z2; // im nächsten Durchlauf nimmt z1 den Wert von z2 an
        }
    }
}
