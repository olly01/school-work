using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
    class Vet : Staff
    {
        public void Treat(Animal reviveanimal)
        {
            reviveanimal.medicine();
        }
    }
}
