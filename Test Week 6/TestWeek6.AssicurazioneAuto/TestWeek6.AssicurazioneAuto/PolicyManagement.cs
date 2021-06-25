using System;
using TestWeek6.Assicurazione.Models;
using TestWeek6.Assicurazione.Repository;

namespace TestWeek6.Assicurazione
{
    internal class PolicyManagement
    {
        static IRepository<Customer> repoCustomer = new RepoCustomer();

        public static void GestioneScelta()
        {
            int scelta = SchermoMenu();
            while (scelta > 0 || scelta < 3)
            { 
                switch (scelta)
                {
                    case 1:
                        AddCustomer();
                        break;
                    case 2:
                        //aggiungi polizza
                        break;
                    case 3:
                        //stampa dettaglio
                        break;
                }
            }
        }

        private static void AddCustomer()
        {
            Customer newCustomer;
            Console.WriteLine("Inserisci un nuovo Cliente");
            Console.WriteLine("Inserisci il codice fiscale");
            string CF = Console.ReadLine();
            Console.WriteLine("Inserisci il nome");
            string firstName = Console.ReadLine();
            Console.WriteLine("Inserisci il cognome");
            string lastName = Console.ReadLine();
            Console.WriteLine("Inserisci indirizzo");
            string address = Console.ReadLine();
            newCustomer = repoCustomer.Create(new Customer
            {
                CF = CF,
                FirstName = firstName,
                LastName = lastName,
                Address = address
            });
            if (newCustomer != null)
            {
                Console.WriteLine(newCustomer);
            }
            else
            {
                Console.WriteLine("Operazione non riuscita");
            }
        }

        public static int SchermoMenu()
        {
            Console.WriteLine("Benvenuto");
            Console.WriteLine("1. Aggiungi Cliente");
            Console.WriteLine("2. Aggiungi Polizza");
            Console.WriteLine("3. Stampa Dettaglio");
            Console.WriteLine("0. Per uscire");
            
            bool verifica = Int32.TryParse(Console.ReadLine(), out int scelta);
            while (!verifica)
            {
                Console.WriteLine("Inserisci di nuovo");
                verifica = Int32.TryParse(Console.ReadLine(), out scelta);
            }
            return scelta;
        }



        



        
    }
}