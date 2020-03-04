using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
    class Vet : Staff
    {
        public Vet(string name) : base (name)
        {
            Role = "Vet";
        }

        public void Treat(Animal reviveanimal)
        {
            reviveanimal.medicine();
        }
    }
}
