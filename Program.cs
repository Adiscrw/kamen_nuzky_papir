// See https://aka.ms/new-console-template for more information

Console.WriteLine("Vitejte v Casinu, Mate 5 000 minci");
int zustatek = 5000;
int sazka;
int vklad;
Random rnd = new Random();
int nahoda;
int kamen = 1;
int nuzky = 2;
int papir = 3;

while (zustatek != 0)
{
    Console.WriteLine("Pro sazku na kamen stisknete 1, na nuzky 2, na papir 3");
    sazka = Convert.ToInt32(Console.ReadLine());
    if (sazka == 1||sazka == 2||sazka == 3)
    {
        Console.WriteLine("Vlozte sazku, k dispozici mate " + zustatek + " minci");
        vklad = Convert.ToInt32(Console.ReadLine());
        if (vklad < zustatek)
        {
            nahoda = rnd.Next(1, 4);
            if (nahoda == sazka)
            {
                Console.WriteLine("Remiza, k dispozici mate " + zustatek + " minci");
            }
            if (nahoda == kamen && sazka == nuzky || nahoda == papir && sazka == kamen || nahoda == nuzky && sazka == papir)
            {
                zustatek += vklad;
                Console.WriteLine("Gratuluji, vyhrali jste, k dispozici mate " + zustatek + " minci");
            }
            else
            {
                zustatek -= vklad;
                Console.WriteLine("Ajajaj, neni holt kazdy den posviceni, k dispozici mate " + zustatek + " minci");
            }
        }
        else
        {
            Console.WriteLine("Vas vklad je vetsi nez vas zustatek, vlozte mensi castku");
        }
    }
    else 
    {
        Console.WriteLine("Vami zvolene cislo neni na vyber");
    }
}
Console.WriteLine("Kdo nehraje, nevyhraje, ale vy jste prave prohrali uplne vsechno, zmacknete klavesu pro ukonceni");
Console.ReadKey();

