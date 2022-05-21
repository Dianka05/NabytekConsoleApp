using System;
using System.Collections.Generic;
using NabytekPJ;

namespace NabytekConsoleApp
{
    class Program
    {
        static Mebels mebels = new Mebels(); //vytvaři instanci třidy Mebels
        static NabytekStr[] nabytek = new NabytekStr[10]; //Vytvaři strukturu pro uložení informaci
        static void Main(string[] args)
        {
            string varianta, typ, material, barva;
            int x, y;
            bool nextNb = true; 

            int[] indColor = { 15, 12, 10, 14, 9, 0, 7, 5 }; //index barev třidy Console

            while (nextNb)
            {
                Console.Clear();
                for (int i = 0; i < mebels.Varianta.Length; i++)//Vypiše varianty nabytku
                {
                    Console.WriteLine($"{mebels.Varianta[i]} = {i}");
                }
                varianta = Console.ReadLine();

                switch (int.Parse(varianta))//Vybere nabytek z 5
                {
                    case 0://Stul
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine($"{mebels.Typ[i]} = {i}");
                        }
                        typ = Console.ReadLine();
                        for (int i = 0; i < 3; i++)
                        {
                            if (int.Parse(typ) == i)
                            {
                                typ = mebels.Typ[i];
                                break;
                            }
                        }
                        //material
                        for (int i = 0; i < 2; i++)
                        {
                            Console.WriteLine($"{mebels.Material[i]} = {i}");
                        }
                        material = Console.ReadLine();
                        for (int i = 0; i < 2; i++)
                        {
                            if (int.Parse(material) == i)
                            {
                                material = mebels.Material[i];
                                break;
                            }
                        }
                        //barva
                        for (int i = 0; i < mebels.Barva.Length; i++)
                        {
                            Console.ForegroundColor = (ConsoleColor)indColor[i];
                            Console.WriteLine($"{mebels.Barva[i]} = {i}");
                        }
                        barva = Console.ReadLine();
                        for (int i = 0; i < mebels.Barva.Length; i++)
                        {
                            if (int.Parse(barva) == i)
                            {
                                barva = mebels.Barva[i];
                                break;
                            }
                        }
                        //pozice
                        Console.ForegroundColor = ConsoleColor.White;
                        bool isUnCorrectPosition = true;
                        while (isUnCorrectPosition)
                        {
                            Console.WriteLine("Zadej pozice x a y");
                            x = int.Parse(Console.ReadLine());
                            y = int.Parse(Console.ReadLine());

                            if (JeLiObsazenoMisto(x, y))
                            {
                                varianta = mebels.Varianta[0];
                                Console.WriteLine(CreateNabytek(x, y, varianta, typ, barva, material, mebels.StulSirkaVyska[0], mebels.StulSirkaVyska[1]));
                                isUnCorrectPosition = false;
                            }
                            else
                            {
                                isUnCorrectPosition = true;
                            }
                        }
                        break;

                    case 1://Zidle
                           //typ
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine($"{mebels.Typ[i]} = {i}");
                        }
                        typ = Console.ReadLine();
                        for (int i = 0; i < 3; i++)
                        {
                            if (int.Parse(typ) == i)
                            {
                                typ = mebels.Typ[i];
                                break;
                            }
                        }
                        //material
                        for (int i = 0; i < 2; i++)
                        {
                            Console.WriteLine($"{mebels.Material[i]} = {i}");
                        }
                        material = Console.ReadLine();
                        for (int i = 0; i < 2; i++)
                        {
                            if (int.Parse(material) == i)
                            {
                                material = mebels.Material[i];
                                break;
                            }
                        }
                        //barva
                        for (int i = 0; i < mebels.Barva.Length; i++)
                        {
                            Console.ForegroundColor = (ConsoleColor)indColor[i];
                            Console.WriteLine($"{mebels.Barva[i]} = {i}");
                        }
                        barva = Console.ReadLine();
                        for (int i = 0; i < mebels.Barva.Length; i++)
                        {
                            if (int.Parse(barva) == i)
                            {
                                barva = mebels.Barva[i];
                                break;
                            }
                        }
                        //pozice
                        Console.ForegroundColor = ConsoleColor.White;
                        isUnCorrectPosition = true;
                        while (isUnCorrectPosition)
                        {
                            Console.WriteLine("Zadej pozice x a y");
                            x = int.Parse(Console.ReadLine());
                            y = int.Parse(Console.ReadLine());

                            if (JeLiObsazenoMisto(x, y))
                            {
                                varianta = mebels.Varianta[1];
                                Console.WriteLine(CreateNabytek(x, y, varianta, typ, barva, material, mebels.ZidleKresloSirkaVyska[0], mebels.ZidleKresloSirkaVyska[1]));
                                isUnCorrectPosition = false;
                            }
                            else
                            {
                                isUnCorrectPosition = true;
                            }
                        }
                        break;

                    case 2://krelo
                        //typ
                        for (int i = 2; i < mebels.Typ.Length; i++)
                        {
                            Console.WriteLine($"{mebels.Typ[i]} = {i}");
                        }
                        typ = Console.ReadLine();
                        for (int i = 2; i < mebels.Typ.Length; i++)
                        {
                            if (int.Parse(typ) == i)
                            {
                                typ = mebels.Typ[i];
                                

                                break;
                            }
                            if (typ == "1" || typ == "0" || typ == "4")
                            {
                                typ = "none";
                                break;
                            }
                        }
                        //material
                        for (int i = 2; i < mebels.Material.Length; i++)
                        {
                            Console.WriteLine($"{mebels.Material[i]} = {i}");
                        }
                        material = Console.ReadLine();
                        for (int i = 2; i < mebels.Material.Length; i++)
                        {
                            if (int.Parse(material) == i)
                            {
                                material = mebels.Material[i];
                                break;
                            }
                        }
                        //barva
                        for (int i = 0; i < mebels.Barva.Length; i++)
                        {
                            Console.ForegroundColor = (ConsoleColor)indColor[i];
                            Console.WriteLine($"{mebels.Barva[i]} = {i}");
                        }
                        barva = Console.ReadLine();
                        for (int i = 0; i < mebels.Barva.Length; i++)
                        {
                            if (int.Parse(barva) == i)
                            {
                                barva = mebels.Barva[i];
                                break;
                            }
                        }
                        //pozice
                        Console.ForegroundColor = ConsoleColor.White;
                        isUnCorrectPosition = true;
                        while (isUnCorrectPosition)
                        {
                            Console.WriteLine("Zadej pozice x a y");
                            x = int.Parse(Console.ReadLine());
                            y = int.Parse(Console.ReadLine());

                            if (JeLiObsazenoMisto(x, y))
                            {
                                varianta = mebels.Varianta[2];
                                Console.WriteLine(CreateNabytek(x, y, varianta, typ, barva, material, mebels.ZidleKresloSirkaVyska[0], mebels.ZidleKresloSirkaVyska[1]));
                                isUnCorrectPosition = false;
                            }
                            else
                            {
                                isUnCorrectPosition = true;
                            }
                        }
                        break;
                    case 3://Skrin
                           //typ
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine($"{mebels.Typ[i]} = {i}");
                        }
                        typ = Console.ReadLine();
                        for (int i = 0; i < 3; i++)
                        {
                            if (int.Parse(typ) == i)
                            {
                                typ = mebels.Typ[i];
                                break;
                            }
                        }
                        //material
                        for (int i = 0; i < 2; i++)
                        {
                            Console.WriteLine($"{mebels.Material[i]} = {i}");
                        }
                        material = Console.ReadLine();
                        for (int i = 0; i < 2; i++)
                        {
                            if (int.Parse(material) == i)
                            {
                                material = mebels.Material[i];
                                break;
                            }
                        }
                        //barva
                        for (int i = 0; i < mebels.Barva.Length; i++)
                        {
                            Console.ForegroundColor = (ConsoleColor)indColor[i];
                            Console.WriteLine($"{mebels.Barva[i]} = {i}");
                        }
                        barva = Console.ReadLine();
                        for (int i = 0; i < mebels.Barva.Length; i++)
                        {
                            if (int.Parse(barva) == i)
                            {
                                barva = mebels.Barva[i];
                                break;
                            }
                        }
                        //pozice
                        Console.ForegroundColor = ConsoleColor.White;
                        isUnCorrectPosition = true;
                        while (isUnCorrectPosition)
                        {
                            Console.WriteLine("Zadej pozice x a y");
                            x = int.Parse(Console.ReadLine());
                            y = int.Parse(Console.ReadLine());

                            if (JeLiObsazenoMisto(x, y))
                            {
                                varianta = mebels.Varianta[3];
                                Console.WriteLine(CreateNabytek(x, y, varianta, typ, barva, material, mebels.SkrinSirkaVyska[0], mebels.SkrinSirkaVyska[1]));
                                isUnCorrectPosition = false;
                            }
                            else
                            {
                                isUnCorrectPosition = true;
                            }
                        }
                        break;
                    case 4://Valenda
                           //typ
                        for (int i = 2; i < mebels.Typ.Length; i++)
                        {
                            Console.WriteLine($"{mebels.Typ[i]} = {i}");
                        }
                        typ = Console.ReadLine();
                        for (int i = 2; i < mebels.Typ.Length; i++)
                        {
                            if (int.Parse(typ) == i)
                            {
                                typ = mebels.Typ[i];
                                break;
                            }
                        }
                        //material
                        for (int i = 2; i < mebels.Material.Length; i++)
                        {
                            Console.WriteLine($"{mebels.Material[i]} = {i}");
                        }
                        material = Console.ReadLine();
                        for (int i = 2; i < mebels.Material.Length; i++)
                        {
                            if (int.Parse(material) == i)
                            {
                                material = mebels.Material[i];
                                break;
                            }
                        }
                        //barva
                        for (int i = 0; i < mebels.Barva.Length; i++)
                        {
                            Console.ForegroundColor = (ConsoleColor)indColor[i];
                            Console.WriteLine($"{mebels.Barva[i]} = {i}");
                        }
                        barva = Console.ReadLine();
                        for (int i = 0; i < mebels.Barva.Length; i++)
                        {
                            if (int.Parse(barva) == i)
                            {
                                barva = mebels.Barva[i];
                                break;
                            }
                        }
                        //pozice
                        Console.ForegroundColor = ConsoleColor.White;
                        isUnCorrectPosition = true;
                        while (isUnCorrectPosition)
                        {
                            Console.WriteLine("Zadej pozice x a y");
                            x = int.Parse(Console.ReadLine());
                            y = int.Parse(Console.ReadLine());

                            if (JeLiObsazenoMisto(x, y))
                            {
                                varianta = mebels.Varianta[4];
                                Console.WriteLine(CreateNabytek(x, y, varianta, typ, barva, material, mebels.ValendaSirkaVyska[0], mebels.ValendaSirkaVyska[1]));
                                isUnCorrectPosition = false;
                            }
                            else
                            {
                                isUnCorrectPosition = true;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Zadali jste nespravne cislo");
                        break;
                }
                
                Console.WriteLine("Chcete pokračovat - stisknete Enter\npro ukončení stisknite libovolnou klavesu\nESC pro vypočet kolik se vejde židle do pokoje s určitymi rozměry" +
                    "\nTAB - Pro otočení nabytku");
                ConsoleKeyInfo consoleKey = Console.ReadKey();
                if (consoleKey.Key == ConsoleKey.Enter)
                {
                    nextNb = true;
                }
                else if(consoleKey.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Zadejte rozmery pokoje v poradi x a y");
                    int xR = int.Parse(Console.ReadLine());
                    int yR = int.Parse(Console.ReadLine());
                    Console.WriteLine(KolikSeVejdeZidleDoPokoje(xR, yR));
                    Console.ReadKey();
                }
                else if(consoleKey.Key == ConsoleKey.Tab)
                {
                    Console.WriteLine("Zadejte hodnotu ID");
                    int ID = int.Parse(Console.ReadLine());
                    Console.WriteLine(OtocitNabytek(ID));
                    for (int i = 0; i < mebels.IsObjCreate; i++)
                    {
                        Console.WriteLine($"Varianta: {nabytek[i].varianta}\nTyp: {nabytek[i].typ}\nMaterial: {nabytek[i].material}\nBarva: {nabytek[i].barva}\nRozmer: {nabytek[i].sirka}x{nabytek[i].vyska}\nX: {nabytek[i].x}\nY: {nabytek[i].y}\n\n");
                    }
                    Console.ReadKey();
                }
                else
                {
                    nextNb = false;
                }
            }
        }
        public static string KolikSeVejdeZidleDoPokoje(int rozmerX, int rozmerY)//Metoda pro výpočet kolik se vejde židli s rozměry 20x20 do pokoju s určitymi rozměry
        {
            int rozmerZidleY = (int)mebels.ZidleKresloSirkaVyska[1];
            int rozmerZidleX = (int)mebels.ZidleKresloSirkaVyska[0];

            int pocetZidle = (rozmerX + rozmerY) / (rozmerZidleX + rozmerZidleY);

            return $"Do pokoju s rozmery {rozmerX}x{rozmerY} se veslo {pocetZidle} zidle";
        }
        public static string CreateNabytek(int x, int y, string varianta, string typ, string barva, string material, double sirka, double vyska)//Vytvaři nabytek a zavádí ho do pole structury nabyytek
        {
            nabytek[mebels.IsObjCreate].sirka = sirka;
            nabytek[mebels.IsObjCreate].vyska = vyska;

            nabytek[mebels.IsObjCreate].varianta = varianta;
            nabytek[mebels.IsObjCreate].typ = typ;
            nabytek[mebels.IsObjCreate].material = material;
            nabytek[mebels.IsObjCreate].barva = barva;
            nabytek[mebels.IsObjCreate].x = x;
            nabytek[mebels.IsObjCreate].y = y;
            

            mebels.IsObjCreate++;

            return $"Varianta: {varianta} ID: {mebels.IsObjCreate - 1} \nTyp: {typ}\nMaterial: {material}\nBarva: {barva}\nRozmer: {sirka}x{vyska}\nX: {x}\nY: {y}";
        }
        public static bool JeLiObsazenoMisto(int x, int y)//Ověří zda jsou pozice pro nový nabytek obsazené nebo ne
        {
            bool isEmpty = true;
            for (int i = 0; i < mebels.IsObjCreate; i++)
            {
                if (x == nabytek[i].x)
                {
                    isEmpty = false;
                    break;
                }
                else if (y == nabytek[i].y)
                {
                    isEmpty = false;
                    break;
                }
                else
                {
                    isEmpty = true;
                    break;
                }
            }
            return isEmpty;
        }
        public static string OtocitNabytek(int ID)//Otoči nabytek podle ID, které je napsano při vytvaření nabytku
        {

            Nabytek mebel = new Nabytek(mebels.IsObjCreate, nabytek[ID].varianta, nabytek[ID].sirka, nabytek[ID].vyska);

            nabytek[ID].sirka = mebel.vyska;
            nabytek[ID].vyska = mebel.sirka;

            return $"Varianta: {nabytek[ID].varianta}\nRozmer: {nabytek[ID].vyska}x{nabytek[ID].sirka} \n-upraveno na\n";
        }
        struct NabytekStr//struktura do které se ukládá vytvořeny nabytek
        {
            public string varianta;
            public string typ;
            public string material;
            public string barva;
            public double sirka;
            public double vyska;
            public int x;
            public int y;
        }
    }
}
