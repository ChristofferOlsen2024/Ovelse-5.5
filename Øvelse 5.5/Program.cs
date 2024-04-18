// See https://aka.ms/new-console-template for more information

int korrekt = 7;
int gaet;
do
{
    Console.WriteLine("Hvad gætter du på?");
    gaet = Convert.ToInt32(Console.ReadLine());
} while (gaet != korrekt);
