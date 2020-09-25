using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarcosProjekt
{
    class Harcos
    {
        private string nev;
        private int szint;
        private int tapasztalat;
        private int eletero;
        private int alapEletero;
        private int alapSebzes;


        public string Nev { get => nev; set => nev = value; }
        public int Szint { get => szint; set
            {
                szint = 1;
                if (Tapasztalat == SzintLepeshez)
                {
                    Tapasztalat -= SzintLepeshez;
                    szint++;
                    Eletero = MaxEletero;

                }
           szint = value; } }
        public int Tapasztalat
        {
            get => tapasztalat;
            set
            {
                if (Tapasztalat == SzintLepeshez)
                {
                    szint++;
                }
                else
                {
                    tapasztalat = value;
                }
            }
        }
        public int Eletero { get => eletero; set => eletero = value; }
        public int AlapEletero { get => alapEletero;
            set {
                if (eletero == 0)
                {
                    Tapasztalat = 0;

                }
                else { AlapEletero = value; }

                } }
        public int AlapSebzes { get => alapSebzes; set => alapSebzes = value; }
        public int Sebzes { get => alapSebzes + szint; }
        public int SzintLepeshez { get => 10 + szint * 5; }
        public int MaxEletero { get => alapEletero + szint * 3; }

        public Harcos(string nev , int statuszSablon) {
            this.nev = nev;
            this.szint = 1;
            this.tapasztalat = 0;
            if (statuszSablon == 1)
            {
                this.alapEletero = 15;
                this.alapSebzes = 3;
            }
            else if (statuszSablon == 2) {
                this.alapEletero = 12;
                this.alapSebzes = 4;
            }
            else if (statuszSablon == 3)
            {
                this.alapEletero = 8;
                this.alapSebzes = 5;
            }
            this.eletero = MaxEletero; 

        }
        public override string ToString()
        {
           
            return ""+ nev+" -- LVL: "+ szint + " -- EXP: "+ tapasztalat+" / "+SzintLepeshez + " -- HP: "+ eletero+" / "+MaxEletero+ " -- DMG: "+ Sebzes;

        }
        public void Megkuzd(Harcos masikHarcos) {
            if (this.nev == masikHarcos.nev)
            {
                Console.WriteLine("A két harcos ugyanaz, így nem lehetséges a megküzdésük");
                Console.WriteLine("A program leáll");
                Console.ReadKey();

            }
            else if (masikHarcos.eletero == 0 || this.eletero == 0)
            {
                Console.WriteLine("Egyik harcos életereje 0\nA program leáll");
                Console.ReadKey();

            }
            else {
                Console.WriteLine("A harc elkezdődött!");
                masikHarcos.eletero -= this.Sebzes;
                if (masikHarcos.eletero > 0 && this.eletero > 0)
                {
                    this.eletero -= masikHarcos.Sebzes;                
                    this.Tapasztalat += 5;
                    masikHarcos.Tapasztalat += 5;
                    Console.WriteLine(this.nev+ ": +5XP!");
                    Console.WriteLine(masikHarcos.nev + ": +5XP!");


                }
                else if (masikHarcos.eletero == 0)
                {
                    this.Tapasztalat += 5;
                    Console.WriteLine(this.nev+": +10XP!");

                }
                else if (this.eletero == 0) {
                    masikHarcos.Tapasztalat += 5;
                    Console.WriteLine(this.nev + ": +10XP!");


                }


            }
        }
        public void Gyogyul()
        {
            if (Eletero == 0)
            {
                Eletero = MaxEletero;
            }
            else {
                Eletero += 3 + Szint;
            }
        }
    }
}
