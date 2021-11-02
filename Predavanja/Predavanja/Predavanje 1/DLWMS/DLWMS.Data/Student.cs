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
        public void SetIndeks(int indeks) { _indeks = indeks;  }

        public string Ime { get; set; } //snippet je prop, zamjenjene metode settera i gettera
        public string Prezime { get; set; } 

        public Student(int indeks , string ime, string prezime)
        {
            _indeks = indeks;
            Ime = ime;
            Prezime = prezime; 
        }

        public override string ToString()
        {
            return $"{_indeks} {Ime} {Prezime}";
        }

    }
}
