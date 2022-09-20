using PontOOP;

Pont pont1 = new Pont();
Pont pont2 = new Pont(3, 4);
Pont pont3 = new Pont(100);

Console.WriteLine(pont1);
Console.WriteLine(pont2);
Console.WriteLine(pont3);

Pont[] pontok = new Pont[100];
for (int i = 0; i < pontok.Length; i++)
{
    pontok[i] = new Pont(10);
}
foreach (var pont in pontok)
{
    Console.WriteLine(pont);
}
int legtavolabbiIndex = 0;
for (int i = 1; i < pontok.Length; i++)
{
    if (pontok[legtavolabbiIndex].TavolsagAzOrigotol 
        < pontok[i].TavolsagAzOrigotol)
    {
        legtavolabbiIndex = i;
    }
}
Console.WriteLine("A(z) {0}. pont {1} van a legtávolabb az origótól. " +
    "A távolsága az origótól {2:0.000}", legtavolabbiIndex + 1, 
    pontok[legtavolabbiIndex], pontok[legtavolabbiIndex].TavolsagAzOrigotol);
/* LinQ-s megoldás
Pont legtavolabbi = pontok.First(pont =>
pont.TavolsagAzOrigotol == pontok.Max(pont => pont.TavolsagAzOrigotol));
Console.WriteLine(pontok.ToList().IndexOf(legtavolabbi));
Console.WriteLine(legtavolabbi);
*/