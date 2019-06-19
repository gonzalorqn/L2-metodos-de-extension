using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa.Sellada;

namespace Test
{
  class Program
  {
    static void Main(string[] args)
    {
      PersonaExternaSellada p1 = new PersonaExternaSellada("Juan", "Perez", 35, ESexo.Masculino);
      p1.Asd();
    }
  }
}
