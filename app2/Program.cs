using System;
using System.Data.Objects;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            DipendenteRepository repo = new DipendenteRepository();
            Dipendente dip = new Dipendente();
            dip.Nome = "GIORGIO";
            dip.Cognome = "GIORGI";

            repo.Add(ref dip);

            Console.WriteLine("Dipendente {0} {1} inserito con id {2}", dip.Nome, dip.Cognome, dip.Id);
        }
    }
}
