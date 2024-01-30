using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1_Club
{
    public class socio
    {
        private string name;
        private DateTime DateClub;

        public socio(string name, DateTime DateClub)
        {
            this.name = name;
            this.DateClub = DateClub;
        }

        public DateTime obtenerDate()
        {

            return DateClub;
        }

        public string obtenerName()
        {
            return name;
        }
    }
}
