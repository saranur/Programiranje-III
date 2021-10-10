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
        public static void Pokreni() {   //Metoda Pokreni 

            // TipoviPodataka(); 
            // Pokazivaci();
            //Klase();
            ValueIReference();
        }

        private static void ValueIReference()
        {
            //C# -Managed okruzenje je zaduzeno da upostupnosti upravlja memorijskim resursima
            //On vodi racuna o alokaciji i dealokaciji memorije za nas
            //Value tipovi (primitivni tipovi podataka): int, bool, float... se pohranjuju na stacku
            int a = 10;
            int b = a; //ovdje je b samo preuzela vrijednost a, ukoliko a promijenimo, b ce ostati nepromjenjeno
            a = 2000;

            Ispisi();
            /*
            int a = new int(); 
            //ova linija koda inicijalizuje varijablu a nekom defaultnom vrijednoscu 
            int b; 
            //Obje su na stacku samo varijabla a ima neko defualtnu vrijednost 
            if(a==0)
                Console.WriteLine();
            if(b==0) // ne da nam da koristimo varijablu b jer nije inicijalizovana, stoga ne mozemo je porediti
                Console.WriteLine();
            */


            //Reference tipovi se u svakom slucaju pohranjuju na heap-u
            Student Sara = new Student(200002, "Sara", "Nur");
            Student student = Sara;
            student.Ime = "Student";
            student.Prezime = "Nur";
            Console.WriteLine(Sara); // ispis ce biti samo putanje do klase odnosno tipa objekta koji se zeli ispisati
            //Koristimo overrride u Student klasi da bi mogli ispisati vrijednosti objekta Student (Sara)
            //Svi tipovi, bez obzira da li oni bili value ili reference tipovi imaju jedan jedinstveni bazni tip podatka, a to je object
            object objA = a;
            object objSara = Sara;
            //Provjeravamo kojeg je tipa
            //if(objSara is Student)
            //sve vrijednosti koje su objekat ce imati pored svojih, metode objekta tipa ToString();
            Ispisi(objA);
            Ispisi(objSara);
           
        }

        private static void Ispisi(object obj)
        {
            throw new NotImplementedException();
        }

        private static void Klase()
        {
            Student Sara = new Student(200002, "Sara", "Nur");
            Console.WriteLine(Sara.GetIndeks());
            Sara.SetIndeks(210021);
            Console.WriteLine(Sara.GetIndeks());
            Sara.Indeks = 300003;
            Console.WriteLine(Sara.Indeks);
            Sara.Ime = "Rasasa";
            Console.WriteLine(Sara.Ime);

            Student jasmin = new Student(indeks: 200014, prezime: "Jasminovic", ime: "Jamin");
            //Mozemo raditi bilo kojim redoslijedom, samo trebamo naglasiti koji parametar saljemo 
            Console.WriteLine(jasmin.Indeks);

        }
        //Dvije vrste podataka koje cemo korisiti: value i reference tipovi

        private static void Pokazivaci()
        {
            int indeks = 210021;
            unsafe {
                int* pok = &indeks;
                *pok = 21022;
            }
            //U C# su dodani dodatni mehanizmi za pokazivace radi boljeg shvatanja koristenja pokazivaca
            //Da bi koristili pokazivace taj kod moramo oznaciti kao nesiguran kod - unsafe
            //Nakon toga u properties-ima DLWMS.ConsoleApp > Properties > Build > Allow unsafe code, dakle naznacimo da zelimo da dozvolimo unsafe code
        }

        private static void TipoviPodataka() 
        {
            int indeks = 210021;
            string ime = "Denis";
            bool aktivan = true;
            double prosjek = 6.8;

            if (aktivan)
                Console.WriteLine($"{ime} je aktivan sa prosjekom {prosjek}"); //dodajemo ${ime} i na prvom mjestu se umetne vrijednost pod nazivom ime

            //String interpolation - generisanje i formiranje odredjenog stringa na osnovu razlicitih vrijedosti koji su dostupni u odredjenoj liniji koda. 
            //Interpolation se vrsi dodavanjem znaka '$'
            // snippet za Console.WriteLine(); je cw + tab tab
        
        }
    }

        
}
