C# -Managed okruzenje je zaduzeno da upostupnosti upravlja memorijskim resursima
On vodi racuna o alokaciji i dealokaciji memorije za nas
Value tipovi (primitivni tipovi podataka): int, bool, float... se pohranjuju na stacku



` int a = 10;
  int b = a; //ovdje je b samo preuzela vrijednost a, ukoliko a promijenimo, b ce ostati nepromjenjeno
   a = 2000;`

``int a = new int(); //ova linija koda inicijalizuje varijablu a nekom defaultnom vrijednoscu`

`int b; //Obje su na stacku samo varijabla a ima neko defualtnu vrijednosti (a==0)Console.WriteLine();`

`if(b==0) // ne da nam da koristimo varijablu b jer nije inicijalizovana, stoga ne mozemo je porediti`

`Console.WriteLine();`

Reference tipovi se u svakom slucaju pohranjuju na heap-u

Dvije vrste podataka koje cemo korisiti: value i reference tipovi

