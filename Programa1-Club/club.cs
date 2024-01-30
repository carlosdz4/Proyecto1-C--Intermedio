using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1_Club
{
    public class club
    {
        List<socio> socioList = new List<socio>() {

            new socio("carlos", new DateTime(1990,11,06)),
            new socio("Pedro", new DateTime(1990,11,05)),
            new socio("Maria", new DateTime(2024,11,04))

        };


        public string socioMasAntiguo()
        {

            var resultado = socioList.OrderBy(x => x.obtenerDate().Date).First();

            return resultado.obtenerName();
        }
    }
}
