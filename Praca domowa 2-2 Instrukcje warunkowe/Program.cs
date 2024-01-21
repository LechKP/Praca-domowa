using System.ComponentModel.Design;

namespace Praca_domowa_2_2_Instrukcje_warunkowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // zadanie Nr. 1 Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są one równe czy nie.
            

            int a = 5; 
            int b = 5;

            if (a == b) 
            {
                Console.WriteLine($"{a} i {b} sa rowne");
            }
            
            // zadanie Nr. 2 Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta.

            int d; 
            Console.WriteLine("Podaj liczbe calkowita, aby program mogl okreslic czy jest parzysta");
            string c = Console.ReadLine();
            int.TryParse( c, out d );
            switch (d % 2)
            { 
            case 0:
                    Console.WriteLine($"{d} jest liczba parzysta");
                    break;
            case not 0:
                    Console.WriteLine($"{d} jest liczba nieparzysta");
                    break;
            }
            
            // zadanie Nr. 3 Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna.
            float e; 

            Console.WriteLine("Podaj liczbe calkowita, aby program mogl okreslic czy jest dodatnia, czy ujemna");
            string f = Console.ReadLine();
            float.TryParse(f, out e);
            if (e > 0)
            {
            Console.WriteLine("Podana przez ciebie liczba jest dodatnia");
            }
            else
            {
            Console.WriteLine("Podana przez ciebie liczba jest ujemna");
            }

            //zadanie nr. 4 Napisz program w C#, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym.

            Console.WriteLine("Podaj rok w celu okreslenia czy jest przestepny");
            string g = Console.ReadLine(); 
            int h;
            int.TryParse(g, out h);
            
            switch (h % 4) 
            {
                case 0:
                    Console.WriteLine("Podany przez ciebie rok jest przestepny");
                    break;
                case not 0:
                    Console.WriteLine("Podany przez ciebie rok nie jest przestepny");
                    break;
            }

            // zadanie nr. 5 Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora, prezydenta.

            Console.WriteLine("Podaj swoj wiek, aby okreslic czy przysluguje Ci bierne prawo wyborcze");
            string i = Console.ReadLine(); 
            int i2;
            int.TryParse(i, out i2);
            if (i2 == 0) 
            {
                Console.WriteLine("Podales bledny wiek");
            }
            else if (i2 > 0 && i2 < 21)
            {
                Console.WriteLine("Narazie nie przysluguje Ci prawo wyborcze");
            }

            else if (i2 >= 21 && i2 < 30)
            {
                Console.WriteLine("Mozesz byc poslem");
            }
            
            else if (i2 >= 30 && i2 < 35)
            {
                Console.WriteLine("Mozesz byc poslem albo senatorem");
            }
           
            else if (i2 >= 35)
            {
                Console.WriteLine("Mozesz byc poslem, senatorem albo prezydentem");
            }

            // zadanie nr. 6 Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu  wymyśloną kategorię wzrostu

            Console.WriteLine("Podaj swoj wzrostw cm");
            float j;
            float.TryParse(Console.ReadLine(), out j);
            if (j == 0)
            {
            Console.WriteLine("Podales bledne dane");
            }
            else if (j > 0 && j < 140)
            {
            Console.WriteLine("Chyba nie istniejesz");
            }
            else if (j >=140 && j < 160)
            {
            Console.WriteLine("Jestes krasnoludkiem");
            }
            else if (j >= 160 && j < 177)
            {
                Console.WriteLine("Jestes pigmejem");
            }
            else if (j >= 177 && j < 185)
            {
                Console.WriteLine("Jestes przystojniakiem");
            }
            else if (j >= 185 && j < 200)
            {
                Console.WriteLine("Ciacho...");
            }
            else if (j >= 200 )
            {
                Console.WriteLine("Dlugi do nieba, dalej dokoncz se sam");
            }

            // zadanie nr. 7 Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi, która jest największa


            Console.WriteLine("Podaj liczbe a");
            float k, k1, k2;
            float.TryParse((string)Console.ReadLine(), out k);
            Console.WriteLine("Podaj liczbe b do porownania z a");
            float.TryParse((string)Console.ReadLine(), out k1);
            Console.WriteLine("Podaj liczbe c do porownania z a i b");
            float.TryParse((string)Console.ReadLine(), out k2);

            if (k > k1 && k > k2)
            {
                Console.WriteLine($"{k} jest najwieksza z podanych");
            }
            else if (k1 > k && k1 > k2)
            {
                Console.WriteLine($"{k1} jest najwieksza z podanych");
            }
            else if (k2 > k && k2 > k1)
            {
                Console.WriteLine($"{k2} jest najwieksza z podanych");
            }
            else
            {
                Console.WriteLine("Pradobodobie podales identyczne liczby do porownania lub inne bledne dane");
            }

            // zadanie nr. 8 Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce na studiach

            int l, l1, l2;
            Console.WriteLine("Podaj wynik z matury z matematyki");
            int.TryParse(Console.ReadLine(), out l);
            Console.WriteLine("Podaj wynik z matury z fizyki");
            int.TryParse(Console.ReadLine(), out l1);
            Console.WriteLine("Podaj wynik z matury z chemii");
            int.TryParse(Console.ReadLine(), out l2);

            if (l > 70 && l1 > 55 && l2 > 45 && l + l1 + l2 > 180)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else if (l + l1 > 150 || l + l2 > 150)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
                Console.WriteLine("Kandydat nie dopuszczony do rekrutacji");

            // zadanie nr. 9 Napisz program, który odczyta temperaturę I zwróci nazwę jak w  poniższych kryteriach

            int m;
            Console.WriteLine("Wpisztemperature w stopniach Celsjusza");
            int.TryParse((string)Console.ReadLine(), out m);
            if (m < 0)
            {
                Console.WriteLine("Cholernie piździ");   
            }
            else if (m >= 0 && m < 10)
            {
                Console.WriteLine("Zimno");
            }
            else if (m >= 10 && m < 20)
            {
                Console.WriteLine("Chlodno");
            }
            else if (m >= 20 && m < 30)
            {
                Console.WriteLine("W sam raz");
            }
            else if (m >= 30 && m < 40)
            {
                Console.WriteLine("Zaczyna byc slabo, bo goraco");
            }
            else if (m >= 40)
            {
                Console.WriteLine("A weź wyprowadzam się na Alaskę");
            }
            //zadanie nr. 10 Napisz program, który sprawdzi, czy z 3 podanych długości można stworzyć trójkąt

            int n, n1, n2;
            string A, B, C;
            Console.WriteLine("Podaj trzy dlugosci bokow przyszlego trojkata w cm oddzielajac je od siebie spacja");
            string[] wartosci = Console.ReadLine().Split(' ');
            int.TryParse(wartosci[0], out n);
            int.TryParse(wartosci[1], out n1);
            int.TryParse(wartosci[2], out n2);
            if (n > n1 && n > n2 && n < n1 + n2 || n1 > n && n1 > n2 && n1 < n + n2 || n2 > n1 && n2 > n && n2 < n + n1)
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else
            {
                Console.WriteLine(" Nie da sie zbudowac trojkata");
            }
            Console.WriteLine($"{n} {n1} {n2}");

            // zadanie nr. 11 Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli
            int o;
            string o1;
            Console.WriteLine("Podaj ocene, aby program mogl wyswietlic jej opis");
            int.TryParse(Console.ReadLine(), out o);
                        switch (o)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczajacy");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujacy");
                    break;
                default:
                    Console.WriteLine("Podales nieodpowiednia wartosc");
                    break;
            }

            // zadanie nr. 12 Napisz program, który pobierze numer dnia tygodnia i wyświetli jego nazwę


            Console.Write("Podaj numer dnia 1-7, aby program mogl wyswietlic jego nazwe");
            int.TryParse(Console.ReadLine(), out int day);
            string Dzien = day switch
            {
                1 => "Poniedzialek",
                2 => "Wtorek",
                3 => "Sroda",
                4 => "Czwartek",
                5 => "Piatek",
                6 => "Sobota",
                7 => "Niedziela",
                _ => "Podales niewlasciwe dane"
            };
            Console.WriteLine($"Wpisany przez ciebie dzien to {Dzien}");

            // zadanie nr. 13 Napisz program, który będzie posiadał proste menu (wg. Wzoru poniżej) I będzie prostym kalkulatorem


            Console.Write("Podaj dwie cyfry oddzielone od siebie spacja, zeby wykonac dzialanie matematyczne (dzialanie do wyboru pozniej)");
            string[] Cyfry = Console.ReadLine().Split(' ');
            float.TryParse(Cyfry[0], out float p);
            float.TryParse(Cyfry[1], out float p1);
            Console.Write("Podaj numer operacji do wykonania: 1. dodawanie; 2. odejmowanie; 3 mnozenie; 4 dzielenie");
            Console.WriteLine("{p},{p1}");
            string operation = Console.ReadLine();
            float p3 = 0;
            if (operation == "1")
            {
                p3 = p + p1;
            }
            else if (operation == "2")
            {
                p3 = p - p1;
            }
            else if (operation == "3")
            {
                p3 = p * p1;
            }
            else if (operation == "4" && p1 != 0)
            {
                p3 = p / p1;
            }
            else if (operation == "4" && p1 == 0)       
            {
                Console.WriteLine("Nie mozna dzielic przez 0");  
            }
                Console.Write($"Twoj wynik to {p3}");
        }
    }
}
