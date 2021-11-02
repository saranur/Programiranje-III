### **Namespace**

<hr> 

Namespace - za cilj ima da u okviru jednog prostora (logicne cjeline) osigura unikatnost imena. U programiranju ne mogu biti dvosmislenosti i moramo tačno znati na šta se odnosi. 

U C# namespace koji cemo korisiti imati ce ime naseg solutiona. npr solution nam se zove DLWMS.ConsoleApp pa se i namespace naziva DLWMS.ConsoleApp.

U različtim namespaceovima možemo imati istoimene entitete odnosno tipove podataka mada moramo voditi računa kada pristupamo određenom tipu na koji način to radimo.

`    internal class Program //internal znaci da je ta klasa dostupna na nivou odredjenog namespace-a.`

`static void Main(string[] args) //staticki elementi klase - dostupni su na nivou klase, za pristup njima nam nije potreban objekat i pristupamo diretkno preko klase. `



### **Funkcija i metoda**

<hr>

U okviru C# nema koncepta globalnih funckija kao što je to slučaj u C++, u C++ smo mogli kreirati globalne funkcije koje ne pripadaju nikome i koje je svako mogao pozivati. 

**U C# funkcije su organiziovane unutar klasa.** Funkcije koje su članice npr. main je članica Program klase, nazivamo **metode**. 



### Main metoda

<hr> 

Metoda Main je oznacena kao static, tipa void i prima niz stringova. 

**args** omogućava da našem programu pošaljemo set ulaznih vrijednosti na osnovu kojih on može započeti izvršenje programa.

Također u Debug dijelu (Path: right click na solution name> Properties> Debug) možemo navesti ulazne argumente prilikom testiranja aplikacije, odvajamo razmakom i ako unesemo fit mostar unmo, ovo će postati tri stringa koji će biti ulazne vrijednosti u ovaj naš program.

Console.WriteLine(); //<<cout<<" "<<endl; je metoda koja pripada klasi Console, WriteLine() je staticka metoda koja je javna i koja ne vraća ništa. 

Za ispis vrijednosti koje su dosle kao ulazne unutar main metode

`for (int i = 0; i < args.Length; i++)
            {
            Console.WriteLine(args[i]); 
            }`

### Tipovi podataka

<hr>

//Tip: ctrl + . (generise dio koda) + enter

`private static void TipoviPodataka()
        {
            throw new NotImplementedException();
        }`

Generise dio koda koji nije implementiran, defaultna implementacija  throw new NotImplementedException();  - javlja nam da dio koda nije implementiran i smanjuje mogućnost padanja programa ukoliko zaboravimo da uradimo implementaciju određene metode. 



### Interpolation

<hr>

Interpolation - omogućava generisanje i formiranje određenog stringa na osnovu različitih vrijednosti koji su dostupni u određenoj liniji koda. Interpolation podrazumijeva korištenja znaka $ prije sadržaja koji želimo povezati. 

npr. 

`  Console.WriteLine($"{ ime}  je aktivan sa prosjekom {prosjek}");`



### Pokazivači 

<hr>

Da bi u C# koristili pokazivače moramo nazna;iti pokazivače kao nesiguran kod. Želimo da osiguramo da znamo da koristimo pokazivače i imamo dvije preventivne mjere. 

npr. da bi koristili 

`int* pok = &indeks;`

moramo taj dio coda označiti kao unsafe 

` unsafe
            {
            int* pok = &indeks;
            }`

te nakon toga moramo u propertijima omogućiti unsafe code. 



### Properti

<hr> 

Omogućava nam da u jednoj liniji koda napišemo i getter i setter. Snnipet: prop

`         public int Indeks { get ; set }`

Ukoliko zelimo da dodatno implementiramo getter i setter: 

 `        public int Indeks { get { return _indeks; } set { _indeks = value  } } ` 

ključna riječ value - vrijednost koja se nalazi s desne strane ovog propertija, npr mozemo reci 

`sara.Indeks = 30003; // mogli bi da koristimo kao javno dostupan atribut, a ne kao metodu.`   

  npr. 

`public int Indeks {
            get { return _indeks; } 
            set {
                if(value>200000 && value<400000)
                _indeks = value; }
        } //snippet je prop, zamjenjene metode settera i gettera`

   

### Vrste podataka - Value i reference tipovi

<hr>

Dvije vrste podataka koje cemo korisiti: value i reference tipovi

U programskom jeziku C++ imali smo ključnu riječ new koja nam je sugerisala da smo izašli sa stacka na heap (u dinamiču memoriju). 

C# predstavlja managed okruženje tj. razvojno okruženje u kojem se izvršava aplikacija - zaduženo je da upotpunosti upravlja memorijskim resursima. On vodi računa o alokaciji i dealokaciji u memoriji.

**Value tipovi (vrijednosni tipovi)** - tipovi podataka koji se uvijek pohranjuju na stacku, dakle tu govorimo o primitivnom tipu podataka: int, float, bool... 

` int a = 10;
  int b = a; //ovdje je b samo preuzela vrijednost a, ukoliko a promijenimo, b ce ostati nepromjenjeno
   a = 2000;`

``int a = new int(); //ova linija koda inicijalizuje varijablu a nekom defaultnom vrijednoscu`

`int b; //Obje su na stacku samo varijabla a ima neko defualtnu vrijednosti (a==0)Console.WriteLine();`

`if(b==0) // ne da nam da koristimo varijablu b jer nije inicijalizovana, stoga ne mozemo je porediti`

`Console.WriteLine();`



**Reference tipovi**

Reference tipovi kao što su klase, gdje se njihovi objekti odnosno vrijednosti pohranjuju na heap-u (u dinamickoj memoriji). 



Svi tipovi podataka bili oni value ili reference imaju jedan jedinstveni bazni tip podatka, a to je **object**. 

**Object** predstavlja najveći nivo u hijerarhiji nasljeđivanja. Kada imamo neki izvedeni tip njega možemo konvertovati u bazni, npr. 

`object objA = a;
 object objSara = sara;`

Kada je nešto tipa object imamo par metoda koje su nam dostupne, npr Equals, ToString, GetType... Svi objekti odnosno sve vrijednosti tipa object će pored svojih propertija i metoda imati i ove dodatne metode bez obzira što one nisu implementirane unutar klase npr. unutar klase Student nemamo ToString ali ga možemo korisiti. 



 `Console.WriteLine(sara);  //ako bi samo ovo ispisali dobili bi ispis gdje se nazali objekat sara, odnosno putanju  (DLWMS.Data.Student),//Ovo je bazna ToString metoda, ukoliko ne zelimo da se to desava i zelimo da ispisemo propertije objekta, moramo napraviti override u klasi Student`



`Ispisi(objA); //mozemo joj poslati sta god zelimo
            //To je moguce jer je tip object bazni tip svim tipovima sto znaci da ih u svakom momentu mozemo pretvoriti u taj tip i vratiti 
            Ispisi(objSara); `

### Dodatne informacije

<hr> 

Ukoliko imamo više projekata, da bi koristili neki projekat u drugom projektu moramo dodati referencu u drugi projekat. npr. ako imamo projekat DLWMS.ConsoleApp i projekat DLWMS.Data, da bi koristili projekat DLWMS.Data trebamo dodati referencu u DLWMS.ConsoleApp.








