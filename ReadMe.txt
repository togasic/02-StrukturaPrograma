StrukturaPrograma
=================

Main
----
Unutar klase smije biti samo jedna metoda Main (bez obzira što se metode u C# 
mogu preopterećivati).

Unutar izvedbenog (.EXE) modula može biti više metoda Main u različitim 
klasama, ali tada prevoditelju treba navesti koja klasa će biti "početna", tj. 
od koje Main metode treba program pokrenuti.

ZADATAK 1: Iz klase Program treba ukloniti suvišne metode Main
ZADATAK 2: U postavkama prevoditelja promijeniti ulaznu metodu tako da
           se pokreće Class1.Main()


Dokumentacijski komentari
-------------------------
Primjer dokumentacijskih komentara - opis funkcije Kvadrat

ZADATAK: Za funkciju DuljinaDvijeRiječi napisati dokumentacijske komentare
         i provjeriti pojavljuje li se opis u oblačiću funkcije.


Imenici
-------
Ilustracija kako se istoimeni objekti iz različitih imenika mogu dohvaćati.

ZADATAK: Modificirati kod u Program.Main tako da može koristiti obje klase
         MojaKlasa iz imenika PrviImenik i imenika DrugiImenik


Promjena postavki imenika
-------------------------
Primjer kako se promijeni podrazumijevani imenik nakon kreiranja projekta
u svojstvima projekta (Properties)

ZADATAK: 1. Kreirati projekt za konzolnu aplikaciju s imenom PostavkeImenika. 
         2. U postavkama projekta promijeniti podrazumijevani imenik u 
		    Vsite.CSharp 
		 3. Ispraviti imenik u automatski generiranom kodu
		 3. Definirati dvije nove klase: MojaKlasa1 i MojaKlasa2 te
		    instancirati objekte tih klasa u metodi Program.Main


Identifikatori
--------------
Primjer kako se neke ključne i rezervirane riječi mogu koristiti za 
identifikatore.

ZADATAK 1: U metodu Program.Main dodati varijablu s imenom "string"
           Provjeriti javlja li prevoditelj pogrešku za ime varijable. 
		   Ako javlja, napraviti potrebnu promjenu da se ime može 
		   koristiti.

ZADATAK 2: U istu metodu dodati varijablu s imenom "get". Ponoviti
           postupke iz ZADATKA 1.

ZADATAK 3: U istu metodu dodati varijablu s imenom "Main". Ponoviti
           postupke iz ZADATKA 1.

ZADATAK 4: U istu metodu dodati varijablu sa hrvatskim dijakritičkim
           znakovima (npr. "četrdesetšest"). Ponoviti postupke iz
		   ZADATKA 1.

ZADATAK 5: U prethodnoj varijabli slovo 'č' zamijeniti njegovim Unicode
           kodom \u0161 i provjeriti prihvaća li prevoditelj takav
		   oblik imena.

ZADATAK 6: U istu metodu dodati cjelobrojnu varijablu s imenom "бројШест" te 
           provjeriti prihvaća li prevoditelj to ime.

ZADATAK 7: U istu metodu dodati varijablu "你好" tipa string te provjeriti 
           prihvaća li prevoditelj to ime.
