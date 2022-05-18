using System;

namespace csharp_eccezioni
{
    internal class Program
    {
        
        //Esempi di eccezzioni

        static void Main(string[] args)  //entry point
        {
            /*
            //Un esempio di codice che genera eccezione (dividendo 0   oppure stringa non intero in input)

            try
            {
                
                Console.WriteLine("Inserisci il divisore:");
                string a = Console.ReadLine();
                Console.WriteLine("Inserisci il dividendo:");
                string b = Console.ReadLine();
                int iDivisore = Convert.ToInt32(a);
                int iDividendo = Convert.ToInt32(b);
                int iRes = EseguiDivisione(iDivisore, iDividendo);
                Console.WriteLine($"Risultato della divisione: {iRes}");
            }

            catch (Exception ex)
            {
                // Codice da eseguire in caso di eccezione.
                Console.WriteLine("È avvenuta la seguente eccezione: {0}", ex.Message);
                // Proprietà interessanti nella gestione dell'eccezione.
                Console.WriteLine("Message: " + ex.Message);
                Console.WriteLine("Source: " + ex.Source);
                Console.WriteLine("StackTrace: " + ex.StackTrace);
            }

            */

            /*
            // Personalizzare un eccezzione con trow 

            int b = 1; int c = 5;
            try
            {
                var a = 1;
                b = a - 1;
                c = a / b;
                a = a / c;
            }
            catch (DivideByZeroException dEx) when (b == 0)
            {
                // we're throwing the same kind of exception
                throw new DivideByZeroException("Cannot divide by b because it is zero", dEx);
            }
            catch (DivideByZeroException dEx) when (c == 0)
            {
                // we're throwing the same kind of exception
                throw new DivideByZeroException("Cannot divide by c because it is zero", dEx);
            }

            */


            /*
            //Eccezione di tipo NullReference

            // va messo in un try /catch

            try
            {
                string text = null;
                int length = text.Length;
                Console.WriteLine(length);
                Console.ReadLine();

            }
            catch (Exception ex) { Console.WriteLine(ex.StackTrace); }
            
            */









        }

        static int EseguiDivisione(int a, int b)
        {
            return a / b;
        }

        static string hello(string name)
        {
            if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            return "Hello " + name;
        }

    }
}