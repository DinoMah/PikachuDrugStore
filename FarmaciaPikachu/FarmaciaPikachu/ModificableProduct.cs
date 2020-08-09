using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaPikachu
{
    class ModifiableProduct : Product
    {
        public bool Changed { get; set; } = false;
    }
}
