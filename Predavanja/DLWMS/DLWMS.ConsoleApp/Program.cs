using DLWMS.ConsoleApp.Predavanja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//include 
namespace DLWMS.ConsoleApp
{
    internal class Program //internal znaci da je ta klasa dostupna na nivou odredjenog namespace-a
    {
        static void Main(string[] args) //staticki elementi klase - dostupni su na nivou klase, za pristup njima nam nije potreban objekat i pristupamo diretkno preko klase. 
        {

            P1.Pokreni();
        }
    }
}
