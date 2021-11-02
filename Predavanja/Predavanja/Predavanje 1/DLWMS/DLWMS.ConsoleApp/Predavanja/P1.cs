using DLWMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.ConsoleApp.Predavanja
{
    internal class P1
    {
        public static void Pokreni()
        {
            // TipoviPodataka();
            // Pokazivaci();
            // Klase();
            ValueIReference();
        }

        private static void ValueIReference()
        {
            int a = new int(); //new int() inicijalizuje varijablu a nekom defaultnom vrijednoscu
            int b; //ne mozemo korisiti varijablu b jer joj nije dodjeljena nikakva vrijednost 

            
            Student sara = new Student(200002, "Sara", "Nur");
            Student student = sara;
            student.Ime = "Student";

            Console.WriteLine(sara);  //ako bi samo ovo ispisali dobili bi ispis gdje se nazali objekat sara, odnosno putanju  (DLWMS.Data.Student), 
            //Ovo je bazna ToString metoda, ukoliko ne zelimo da se to desava i zelimo da ispisemo propertije objekta, moramo napraviti override u klasi Student
            Console.WriteLine(sara.ToString()); //ova metoda i metoda iznad su identicne 
            object objA = a;
            object objSara = sara;

            Ispisi(objA); //mozemo joj poslati sta god zelimo
            //To je moguce jer je tip object bazni tip svim tipovima sto znaci da ih u svakom momentu mozemo pretvoriti u taj tip i vratiti 
            Ispisi(objSara); 

        }

        private static void Ispisi(object obj)
        {
            throw new NotImplementedException();
        }

        private static void Klase()
        {
            Student sara = new Student(200002, "Sara", "Nur"); //nemamo defualtni konstruktor stoga moramo poslati tri vrijednosti, indeks, ime i prezime 
            Console.WriteLine(sara.GetIndeks());
            sara.SetIndeks(210012);
            Console.WriteLine(sara.GetIndeks());
            Console.WriteLine(sara.Ime);
            Console.WriteLine(sara.Prezime);
            sara.Ime = "SARA";
            sara.Prezime = "Nuredinovski";
            Console.WriteLine(sara.Ime);
            Console.WriteLine(sara.Prezime);

            Student jasmin = new Student(indeks: 200001, prezime: "Azemovic",ime: "Jamin"); //mozemo mijenjati mjesta atributima tako sto navedemo ime atributa i 
        }

        private static void Pokazivaci()
        {
            int indeks = 210021;
            unsafe
            {
            int* pok = &indeks;
                *pok = 210022;
            }
        }

        private static void TipoviPodataka()
        {
            int indeks = 210021;
            string ime = "Sara";
            bool aktivan = true;
            double prosjek = 6.8;
            if(aktivan)
                Console.WriteLine($"{ ime}  je aktivan sa prosjekom {prosjek}");
       }
    }
}
