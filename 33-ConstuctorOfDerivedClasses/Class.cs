﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_ConstuctorOfDerivedClasses
{
    public sealed class Pozisyon
    {
        public int x { get; set; }
        public int y { get; set; }

        public override string ToString() => $" x : {x}, y: {y}";

    }
    public class Boyut
    {
        public int Genislik { get; set; }
        public int Yukseklik { get; set; }
        public override string ToString()
        {
            return $"Genislik : {Genislik}" +
                $"Yukseklik : {Yukseklik}";
        }
    }
    public abstract class Sekil
    {
        public Sekil()
        {
            Console.WriteLine("Base class -> constructor");
        }
        public Sekil(int genislik,int yukseklik,int x,int y)
        {
            Boyut = new Boyut
            {
                Genislik = genislik,
                Yukseklik = yukseklik,

            };
            Pozisyon = new Pozisyon
            {
                x = x,
                y = y
            };
        }
        public Pozisyon Pozisyon { get; } = new Pozisyon();
        public Boyut Boyut { get; } = new Boyut();
        public virtual void Ciz() => Console.WriteLine($"Sekil {Pozisyon} - {Boyut}");
        /*
        public virtual void Tasi(int x,int y)
        {
            Console.WriteLine("temel sınıf");
            Pozisyon.x = x;
            Pozisyon.y = y;
        }
        */
        public virtual void Tasi(Pozisyon yenipozisyon)
        {
            Pozisyon.x = yenipozisyon.x;
            Pozisyon.y = yenipozisyon.y;
            Console.WriteLine($"taşındı {Pozisyon.x} - {Pozisyon.y}");
        }

        public abstract void YenidenBoyutlandir(int genislik, int yukseklik);
    }
}
