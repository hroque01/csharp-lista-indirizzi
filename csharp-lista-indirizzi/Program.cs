using System.Text;

namespace csharp_lista_indirizzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //In questo esercizio dovrete leggere un file CSV,
            //che cambia poco da quanto appena visto nel live-coding in classe,
            //e salvare tutti gli indirizzi contenuti al sul interno all’interno di una lista di oggetti istanziati a partire dalla classe Indirizzo.
            //Attenzione: gli ultimi 3 indirizzi presentano dei possibili “casi particolari”
            //che possono accadere a questo genere di file: vi chiedo di pensarci e di gestire come meglio crediate queste casistiche.

            List<Indirizzo> indirizzi = new List<Indirizzo>();

            if (!File.Exists("addresses.csv"))
            {
                Console.WriteLine("File non trovato");
            }
            else
            {
                try
                {
                    //Apro il file
                    StreamReader sr = File.OpenText("addresses.csv");
                    

                    while (!sr.EndOfStream)
                    {
                        string? line = sr.ReadLine(); //legge la riga di un file
                        string[] campi = line.Split(","); //Suddivide la stringa in base alla virgola

                        if (campi.Length < 6)
                        {
                            continue;
                        }
                        if (line != null)
                        {
                            
                            Console.WriteLine("Utente: ");
                            Console.WriteLine($"\tNome: {campi[0]}");
                            Console.WriteLine($"\tCognome: {campi[1]}");
                            Console.WriteLine($"\tVia: {campi[2]}");
                            Console.WriteLine($"\tCitta': {campi[3]}");
                            Console.WriteLine($"\tProvincia: {campi[4]}");
                            Console.WriteLine($"\tZip: {campi[5]}");
                            indirizzi.Add(new Indirizzo(campi[0], campi[1], campi[2], campi[3], campi[4], campi[5]));
                        }
                    }
                    sr.Close();
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("Non puoi acedere al file");
                }
                catch (Exception e)
                {

                    Console.WriteLine("Si è verificato un problema: " + e.Message);
                }
            }

        }
    }
}