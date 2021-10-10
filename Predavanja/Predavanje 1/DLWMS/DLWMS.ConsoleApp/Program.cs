//using DLWMS.ConsoleApp.Helper;
using DLWMS.ConsoleApp.Predavanja;
using System; //Console je definisana unutar dijela koji se zove System
using System.Collections.Generic;
using System.Linq;
using System.Text; //Encoder je neka klasa koja se nalazi u namespace\u System.Text, postao je aktivan
using System.Threading.Tasks;
//Ovi "using" zapravo zamjenjuju #include 
namespace DLWMS.ConsoleApp  //novi namespace je definisan prema samom nazivu projekta, zelimo da u okviru jednog prostora osiguramo unikatnost imena
    //U programiranju ne mogu biti dvosmislenosti, 
{
    class Program
    {
        static void Main(string[] args)
        //Main funkcija treba biti oznacena kao static;
        //Staticki elementi klase nisu oni elementi koji su dostupni na nivou objekta, vec su sada oni dostupni na nivou klase
        //Za pristup njima nije nam potreban objekat vec pristupamo direktno preko klase. npr  Program.Main(args);
        {

            //Encoder encoder;
            //DLWMS.ConsoleApp.Helper.Encoder encoder2; - s ozbzirom da se nalazimo u namespace  DLWMS.ConsoleApp ovaj dio nam nije potreban
            //Helper.Encoder encoder2; //ukoliko zelimo da koristimo i nas Encoder koji smo kreirali, moramo navesti kompetnu putanju do njega
            //Ukoliko zelimo da koristimo oba Encodera, do jednog mozemo navesti putanju u using segmentu koga, a za drugi mozemo navesti kompletnu putanju 

            /*    string prIII = "Programiranje III";
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine(args[i]); //ovim brojimo koliko ima elemenata 
                    //Ovim ce prikazati sve vrijednosti koje su dosle kao ulazne unutar main metode 
                }
                Console.WriteLine(prIII); //ova linija zamjenjuje cout<<prIII<<endl; 
            */
            //Za klase se kao i inace navodi: private, public, a sada i internal
            //Internal oznacava da je ta klasa dostupna na nivou odredjenog namespace-a;

            // P1 p1 = new P1(); - upravo zbog ovoga smo kreirali staticke metode tako da mozemo uraditi sljedece:
            P1.Pokreni();

        }
    }
}

//Funkcija i metoda
//U okviru C# nema koncepta globalnih funkcija, u C# funkcije su organizovane unutar klasa. 
//Funkcije koje su clanice klase se nazivaju metode. 
