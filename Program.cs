using System;

namespace MagicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm[] storms = new Storm[10];
            int stormIndex = 0;

            // Storm object
            Storm s = new Storm("wind", false, "Zul'rajas");

            Console.WriteLine(s.Announce());

            // Pupil object
            Pupil p = new Pupil("Mezil-kree", "Icecrown");
            storms[stormIndex] = p.CastWindStorm();
            stormIndex++;


            // Mage object
            Mage m = new Mage("Gul'dan", "Draenor");
            storms[stormIndex] = m.CastRainStorm();
            stormIndex++;

            // Archmage object
            Archmage a = new  Archmage("Nielas Aran", "Storwind");

            storms[stormIndex] = a.CastWindStorm();
            stormIndex++;

            storms[stormIndex] = a.CastRainStorm();
            stormIndex++;

            storms[stormIndex] = a.CastLightningStorm();
            stormIndex++;

            for (int i = 0; i < stormIndex; i++)
            {
                Console.WriteLine(storms[i].Announce());
            }

            //pupil object
            Pupil pu = new Pupil("mezil-kree");
            Storm windstorm = pu.CastWindStorm();
            Console.WriteLine(windstorm.Announce());

            // mage object
            Mage ma = new Mage("gul'dan");
            Storm rainstorm = ma.CastRainStorm();
            Console.WriteLine(rainstorm.Announce());

            // archmage object
            Archmage ar = new Archmage("nielas aran");
            Storm rainstormar = ar.CastRainStorm();
            Storm lightningstorm = ar.CastLightningStorm();
            Console.WriteLine(rainstormar.Announce());
            Console.WriteLine(lightningstorm.Announce());
        }
    }
}