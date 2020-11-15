using System;


//1.) Napisz funkcję, która oblicza pole powierzchni P i objętość O kuli.Promień r wczytaj od użytkownika. P = 4*Pi*r*r, O = (4 / 3) * Pi * r * r * r.Wyniki wypisz na ekran.	

//2.) Napisz funkcję, która przyjmie dowolną ilość parametrów a następnie wypisz je grupami po trzy, oddzielone ukośnikiem. Grupy oddziel od siebie spacjami. 
//Jeśli parametry nie dają pełnej grupy, wypisz je a po nich dodaj trzy gwiazdki (***). Wypisz tekst na ekran.	




namespace P3_LAB5_KOL1
{
    class Program
    {
        static void Main(string[] args)
        {
            test1();
            test2();
            test3();
        }

        static void test1()
        {
            Console.WriteLine("Podaj promień");
            PoleKuli((double.Parse(Console.ReadLine())));
        }

        
        static void test2()
        {
            GrupyParam(3, 4, 56, 2, 7, 8, 2, 21, 1);
        }
        static void test3() { 
        
        }
        static void PoleKuli(double promien)
        {
            double P = 4 * Math.PI * promien * promien;
            double O = (4 / 3) * Math.PI * promien * promien * promien;

            Console.WriteLine($"Pole kuli {P,3:N3}j^2, objetość kuli  {O,3:N3}j^3");
        }

        static void GrupyParam(params int[] parametr)
        {

            for (int i = 0; i < parametr.Length; i += 3)
            {
                //if ((parametr.Length - 2) %1== parametr.Length)
                //{
                //    Console.WriteLine(parametr[i] + parametr[i + 1] + " *");
                //}
                //if ((parametr.Length - 1) %2==0)
                //{
                //    Console.WriteLine(parametr[i] + " * *");
                //}

                Console.WriteLine(parametr[i] + " " + parametr[i + 1] + " " + parametr[i + 2]);
            }
        }
    }


    //3.) Stwórz klasę Kolarz. Dodaj do niej właściwości NumerZawodnika, Nazwisko i takie pola by zapisać sumę czasów kilku etapów wyścigu (godzin, minut i sekund). 
    //Dodaj metodę Etap, która wczyta czas i doda go do sumy. Zabezpiecz metodę by czas był poprawny (np. nieujemny). 
    //Jesli będzie błędny, rzuć dowolny wyjątek. Stwórz dwa obiekty klasy Kolarz i wpisz im dowolne czasy trzech etapów. Wypisz numer i nazwisko zwycięzcy i różnicę czasu względem rywala.
    //Punkty
    class kolarz { 
     int NumerZawodnika {
            get;
            set;
        }
        string Nazwisko {
            get; 
            set; 
        }
        double czasGodziny;
        double czasMinuty;
        double czasSekundy;
        void Etap() {
 
                Console.WriteLine("Podaj Godziny");
                double czasT1 = double.Parse(Console.ReadLine());
                if (czasT1 > 0)
                {
                    czasGodziny += czasT1;

                }
                Console.WriteLine("Podaj Minuty");
                double czasT2 = double.Parse(Console.ReadLine());
                if (czasT2 > 0)
                {
                    czasMinuty += czasT2;

                }
                Console.WriteLine("Podaj Sekundy");
                double czasT3 = double.Parse(Console.ReadLine());
                if (czasT3 > 0)
                {
                    czasSekundy += czasT3;

                }


        }
    }
}
