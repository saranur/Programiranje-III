/*Da bi ovu klasu mogli korisitit u konzolnoj aplikaciji moramo dodati referencu
 Soultion DLWMS > References > Projects> DLWMS.Data 
Povezali smo projekat konzole app i data projekat sto je ustvari biblioteka
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data
{
    public class Student 
    {
        string _ime;
        string _prezime;
        
        int _indeks;
        public int GetIndeks() { return _indeks; }
        public void SetIndeks(int indeks) { _indeks = indeks; }
        
        //Ove tri linije koda se mogu staviti u jednu liniju koda koristeci property:  public int Indeks { get; set; }
        //public int Indeks { get; set; }
        //Ukoliko zelimo dodatno da nesto mijenjam ili dodajemo, mozemo to uraditi u vitiacstim zagradama
        public int Indeks
        {
            //Mi cemo najcesce korisiti public int Indeks{get; set;}
            get { return _indeks; }
            set
            {
                //_indeks = value; }
                //Kljucna rijec value se nalazi sa desne strane ovog propertija npr. Sara.Indeks
                //Ovjde smo mogli reci npr. 
                if (value > 200000 && value < 400000)
                    _indeks = value;
            }
        }
        //snippet je prop + tab tab
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public Student(int indeks, string ime, string prezime)
        {
            _indeks = indeks;
            _ime = ime;
            _prezime = prezime;
        }

        public override string ToString()
        {
            return $"{_indeks} {Ime} {Prezime}"; //kada budemo htjeli da pretvorimo u string objekat tipa Student, imamo metodu ponasanja metode ToString();
                
        }
    }

    
}
