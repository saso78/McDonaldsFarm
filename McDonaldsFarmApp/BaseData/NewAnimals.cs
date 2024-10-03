using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonaldsFarmApp.BaseData
{
    public class Horse : FarmAnimal
    {
        public Horse() : base("horse", "neigh") { }
    }

    public class Sheep : FarmAnimal
    {
        public Sheep() : base("sheep", "mee") { }
    }

    public class Goat : FarmAnimal
    {
        public Goat() : base("goat", "bee") { }
    }

    public class Rooster : FarmAnimal
    {
        public Rooster() : base("rooster", "cock-a-doodle-doo") { }
    }

    public class Turkey : FarmAnimal
    {
        public Turkey() : base("turkey", "gobble") { }
    }

    public class Donkey : FarmAnimal
    {
        public Donkey() : base("donkey", "hee-haw") { }
    }

    public class Owl : FarmAnimal
    {
        public Owl() : base("owl", "hoo") { }
    }

    public class Frog : FarmAnimal
    {
        public Frog() : base("frog", "ribbit") { }
    }

    public class Elephant : FarmAnimal
    {
        public Elephant() : base("Elephant", "trumpet") { }
    }
    public class Rabbit : FarmAnimal
    {
        public Rabbit() : base("Rabbit", "thump") { }
    }
}
