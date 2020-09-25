﻿using System;
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
        public int Szint { get => szint; set => szint = value; }
        public int Tapasztalat { get => tapasztalat; set => tapasztalat = value; }
        public int Eletero { get => eletero; set => eletero = value; }
        public int AlapEletero { get => alapEletero; set => alapEletero = value; }
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
            this.eletero = alapEletero; 

        }
        public override string ToString()
        {
           
            return ""+ nev+" -- LVL: "+ szint + " -- EXP: "+ tapasztalat/SzintLepeshez + " -- HP: "+ eletero/MaxEletero+ " -- DMG: "+ Sebzes;

        }
        public void Megkuzd(Harcos masikHarcos) {
            Harcos egyikHarcos= new Harcos("Erős János", 1);
            if (masikHarcos == egyikHarcos)
            {
                Console.WriteLine("A két harcos ugyanaz, így nem lehetséges a megküzdésük");
                Console.WriteLine("A program leáll");
                Console.ReadKey();

            }
            else if (masikHarcos.eletero == 0 || egyikHarcos.eletero == 0)
            {
                Console.WriteLine("Egyik harcos életereje 0\nA program leáll");
                Console.ReadKey();

            }
            else {
                Console.WriteLine("A harc elkezdődött!");
                masikHarcos.eletero -= egyikHarcos.Sebzes;
                if (masikHarcos.eletero > 0 && egyikHarcos.eletero > 0)
                {
                    egyikHarcos.eletero -= masikHarcos.Sebzes;                
                    egyikHarcos.Tapasztalat += 5;
                    masikHarcos.Tapasztalat += 5;
                    Console.WriteLine(egyikHarcos.nev+ ": +5XP!");
                    Console.WriteLine(masikHarcos.nev + ": +5XP!");


                }
                else if (masikHarcos.eletero == 0)
                {
                    egyikHarcos.Tapasztalat += 5;
                    Console.WriteLine(egyikHarcos.nev+": +10XP!");

                }
                else if (egyikHarcos.eletero == 0) {
                    masikHarcos.Tapasztalat += 5;
                    Console.WriteLine(egyikHarcos.nev + ": +10XP!");


                }


            }
        }
    }
}