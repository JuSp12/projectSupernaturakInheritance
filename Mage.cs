﻿// Mage.cs
using System;
using System.Security.Cryptography.X509Certificates;

namespace MagicalInheritance
{
    class Mage : Pupil
    {
        public Mage(string title) : base(title)
        
        {
        }

        public Mage(string title, string origin) : base(title, origin)
        { }

        public virtual Storm CastRainStorm()
        {
            return new Storm("rain", false, Title);
        }
    }
        
}
