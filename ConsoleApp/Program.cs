//1.) Napisz funkcję, która oblicza pole powierzchni P i objętość O kuli.Promień r wczytaj od użytkownika. P = 4*Pi*r*r, O = (4 / 3) * Pi * r * r * r.Wyniki wypisz na ekran.	

//2.) Napisz funkcję, która przyjmie dowolną ilość parametrów a następnie wypisz je grupami po trzy, oddzielone ukośnikiem. Grupy oddziel od siebie spacjami. 
//Jeśli parametry nie dają pełnej grupy, wypisz je a po nich dodaj trzy gwiazdki (***). Wypisz tekst na ekran.	

//3.) Stwórz klasę Kolarz. Dodaj do niej właściwości NumerZawodnika, Nazwisko i takie pola by zapisać sumę czasów kilku etapów wyścigu (godzin, minut i sekund). 
//Dodaj metodę Etap, która wczyta czas i doda go do sumy. Zabezpiecz metodę by czas był poprawny (np. nieujemny). 
//Jesli będzie błędny, rzuć dowolny wyjątek. Stwórz dwa obiekty klasy Kolarz i wpisz im dowolne czasy trzech etapów. Wypisz numer i nazwisko zwycięzcy i różnicę czasu względem rywala.
//Punkty


using System;



namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Kula();
            test2();
            test3();
            //test4();

            //K1.Etap(new TimeSpan(10, 10, 5));
            //K2.Etap(new TimeSpan(6, 5, 15));

        }

        static void test3()
        {
            Kolarz K1 = new Kolarz(1, "jedynka");
            Kolarz K2 = new Kolarz(2, "Dwójka");

            K1.Etap();
            K2.Etap();
            K1.Etap();

            Console.WriteLine(K1.Czas);
            Console.WriteLine(K2.Czas);
            Console.WriteLine("Różnica czasu między kolarzami");
            Console.WriteLine(K1.Czas - K2.Czas);
        }
        static void test2()
        {
            int length = int.Parse(Console.ReadLine());
            double[] lista = new double[length];
            for (int i = 0; i < length; i++)
            {
                lista[i] = double.Parse(Console.ReadLine());
            }
            Parametry(lista);
        }

        static void test4()
        {
            string[] values = { "12", "31.", "5.8:32:16", "12:12:15.95", ".12" };
            foreach (string value in values)
            {
                try
                {
                    TimeSpan ts = TimeSpan.Parse(value);
                    Console.WriteLine("'{0}' --> {1}", value, ts);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to parse '{0}'", value);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("'{0}' is outside the range of a TimeSpan.", value);
                }
            }
        }

        static void Kula()
        {
            Console.Write("Podaj promień kuli:");
            double R = double.Parse(Console.ReadLine());
            double pole = 4 * Math.PI * Math.Pow(R, 2);
            double obj = (4 / 3) * Math.PI * Math.Pow(2, 3);
            Console.WriteLine(@$"Kula
Pole: {pole,3:N3} 
Objętość {obj,3:N3}");
        }

        static void Parametry(params double[] lista)
        {
            if ((lista.Length - 1) % 3 == 0)
            {
                for (int i = 0; i < lista.Length - 1; i += 3)
                {
                    Console.WriteLine($"{lista[i]} + {lista[i + 1]} + {lista[i + 2]}");

                }
                Console.WriteLine("***");
            }
            else if ((lista.Length - 2) % 3 == 0)
            {
                for (int i = 0; i < lista.Length - 2; i += 3)
                {
                    Console.WriteLine($"{lista[i]} + {lista[i + 1]} + {lista[i + 2]}");
                }
                Console.WriteLine("***");
            }
            else if (lista.Length % 3 == 0)
            {
                for (int i = 0; i < lista.Length - 1; i += 3)
                {
                    Console.WriteLine($"{lista[i]} + {lista[i + 1]} + {lista[i + 2]}");
                }
            }
        }

        class Kolarz
        {
           public Kolarz(int NZ, string nazwisko)
            {
                _numerZawodnika = NZ;
                _nazwisko = nazwisko;
            }

            int _numerZawodnika;
            private string _nazwisko;
            public int NumerZawodnika
            {
                get
                {
                    return _numerZawodnika;
                }
                set
                {
                    _numerZawodnika = value;
                }
            }
            public string Nazwisko
            {
                get
                {
                    return _nazwisko;
                }
                private set
                {
                    _nazwisko = value;
                }
            }

            TimeSpan _czasEtap;
           public TimeSpan Czas
            {
                get
                {
                    return _czasEtap;
                }

            }

            //public void Etap(TimeSpan czas)
            public void Etap()
            {
                try
                {
                    Console.WriteLine("Godziny: ");
                    int godziny = int.Parse(Console.ReadLine());
                    if (godziny < 0)
                    {
                        throw new Exception("Ujemny czas");
                    }

                    Console.WriteLine("Minuty: ");
                    int minuty = int.Parse(Console.ReadLine());
                    if (minuty < 0)
                    {
                        throw new Exception("Ujemny czas");
                    }
                    Console.WriteLine("Sekundy: ");
                    int sekundy = int.Parse(Console.ReadLine());
                    if (sekundy < 0)
                    {
                        throw new Exception("Ujemny czas");
                        
                    }
                    TimeSpan czasDoSprawdzenia = new TimeSpan(godziny, minuty, sekundy);
                    if (czasDoSprawdzenia > new TimeSpan(0))
                    {
                        _czasEtap += czasDoSprawdzenia;
                    }

                }
                catch 
                {
                    Console.WriteLine("Wprowadzono ujemny czas");
                    System.Environment.Exit(0);
                };
                
            }

        }
    }
}
