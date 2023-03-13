// Program, który liczy deltę dla równania kwadratowego i jeśli to możliwe
// wylicza pierwiastki tego równania (miejsca zerowe)

//deklaracja potrzebnych zmiennych
float a, b, c, delta, x1, x2;
//tekst od użytkownika
string text;
//zmienna typu prawda/fałsz do zapisywnaia wyniku konwersji - udało się czy nie
bool result;

Console.WriteLine("Dla równiania kwadratowego o postaci ax^2 + bx + c podaj wartości:");
Console.WriteLine("Wyraz a:");
// przecyztaj od użytkownika liczbę jako tekst i zapisz do zmiennej
text = Console.ReadLine();
// spróbuj przekonwertować tekst na liczbę i zapisz ją do "a",
// zapisz wynik próby (udało się czy nie) do zmiennej result
result = float.TryParse(text, out a);
//jeżeli próba była udana to w "a" jest liczba, a w result jest true
//jeżeli próba się nie powiodła to "a" będzie niezainicjowane, a result będzie równy false

//jeżeli próba była nieudana to przyjmij a = 1
if(!result)
{
    a = 1;
}

Console.WriteLine("Wyraz b:");
text = Console.ReadLine();
result = float.TryParse(text, out b);
if (!result) b = 1;

Console.WriteLine("Wyraz c:");
text = Console.ReadLine();
result = float.TryParse(text, out c);
if (!result) c = 1;

//liczymy deltę (b^2 - 4*a*c):
delta = b * b - 4 * a * c;

//3 możliwości: delta > 0, delta = 0, delta < 0
if(delta > 0)
{
    //delta dodatnia - dwa miejsca zerowe
    //musimy rzutować wynik Math.Sqrt ponieważ domyślnie jest w formacie double, a potrzebujemy float
    x1 = (-b - (float)Math.Sqrt(delta)) / (2 * a);
    x2 = (-b + (float)Math.Sqrt(delta)) / (2 * a);
    Console.WriteLine("Delta dodatnia. Równanie ma dwa miejsca zerowe:");
    Console.WriteLine("Miejsce zerowe x1 wynosi: " + x1.ToString());
    Console.WriteLine("Miejsce zerowe x2 wynosi: " + x2.ToString());
} 
else if(delta == 0)
{
    //delta równa zero
    x1 = (-b) / (2 * a);
    Console.WriteLine("Delta równa zero. Równanie ma jedno miejce zerowe");
    Console.WriteLine("Miejsce zerowe x1 wynosi: " + x1.ToString());
} 
else
{
    //delta < 0
    Console.WriteLine("Delta mniejsza od zera, brak miejsc zerowych");
}
