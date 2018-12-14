using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatumAbfrage
{
    class Program
    {
        static void Main(string[] args)
        {
            int tag, monat, jahr;
            double zwischen1, zwischen2, zwischen3, pruf;
            string eingabe;

            Console.WriteLine("Bitte geben Sie den Tag des zu überprüfenden Datums an!");
            eingabe = Console.ReadLine();
            tag = Convert.ToInt16(eingabe);

            if ((tag > 0) && (tag <= 31))//Überprüfung eines gültigen Tages
            {
                Console.WriteLine("Bitte geben Sie den Monat des zu überprüfenden Datums an!");
                eingabe = Console.ReadLine();
                monat = Convert.ToInt16(eingabe);

                if ((monat > 0) && (monat <= 12))//Überprüfung eines gültigen Monats
                {
                    Console.WriteLine("Bitte geben die das Jahr des zu überprüfenden Datums an!");
                    eingabe = Console.ReadLine();
                    jahr = Convert.ToInt16(eingabe);

                    if (jahr > 0)//Überprüfung eines gültigen Jahres größer 0
                    {
                        zwischen1 = jahr % 4; //Berechnung des Rests für das Schaltjahr
                        zwischen2 = jahr % 100;
                        zwischen3 = jahr % 400;
                        pruf = zwischen1 + zwischen2 + zwischen3;
                        if ((monat == 2) && (tag == 29) && (((zwischen1 == 0) && (zwischen2 > 0)) || (pruf == 0)))
                        {
                            Console.WriteLine(tag + "." + monat + "." + jahr + " ist ein GÜLTIGES Schaltjahr!");
                            Console.ReadKey();
                        }
                        else if ((monat == 2) && (tag <= 28))
                        {
                            Console.WriteLine(tag + "." + monat + "." + jahr + " ist GÜLTIG!");
                            Console.ReadKey();
                        }
                        else if (((monat == 1) || (monat == 3) || (monat == 5) || (monat == 7) || (monat == 8) || (monat == 10) || (monat == 12)) && (tag <= 31))
                        {
                            Console.WriteLine(tag + "." + monat + "." + jahr + " ist GÜLTIG!");
                            Console.ReadKey();
                        }
                        else if (((monat == 4) || (monat == 6) || (monat == 9) || (monat == 1)) && (tag <= 30))
                        {
                            Console.WriteLine(tag + "." + monat + "." + jahr + " ist GÜLTIG!");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine(tag + "." + monat + "." + jahr + " ist KEIN gültiges Datum!");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Bitte gib ein Jahr größer als 0 an!");
                        Console.ReadKey();

                    }
                }
                else
                {
                    Console.WriteLine("Wählen Sie bitte ein Monat zwischen 1 und 12!");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Wählen Sie bitte ein Tag zwischen 1 und 31!");
                Console.ReadKey();
            }



        }
    }
}