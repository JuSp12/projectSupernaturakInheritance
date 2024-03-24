using System;

namespace MagicalInheritance
{
    abstract class Spell
    {
        public string Essence
        { get; protected set; }

        public string IsStrong
        { get; protected set; }

        public string Caster
        { get; protected set; }

        public abstract string Announce();

    }
}