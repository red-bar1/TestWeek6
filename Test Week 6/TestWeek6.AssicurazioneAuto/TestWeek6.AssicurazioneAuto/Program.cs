using System;
using TestWeek6.Assicurazione.Models;
using TestWeek6.Assicurazione.Repository;

namespace TestWeek6.Assicurazione
{
    public class Program
    {
        //Mi dà uno strano errore per la migration.

        //"Your target project 'TestWeek6.Assicurazione' doesn't reference EntityFramework.
        //This package is required for the Entity Framework Core Tools to work.
        //Ensure your target project is correct, install the package, and try again."

        //Ad ogni modo: Add-Migration InitialMigration
        // Update-Database


        static void Main(string[] args)
        {
            PolicyManagement.GestioneScelta();
        }

        
    }
}
