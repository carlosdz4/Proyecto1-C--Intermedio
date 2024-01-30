using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa2_Banco
{
    public class Banco
    {
        private decimal dineroBanco { get; set; }

        List<Cliente> clientes = new List<Cliente>() {


            new Cliente { dinero = 2000 , LastName= "Shephard" , Name= "carlos" , Id = 123 },
            new Cliente { dinero = 5000 , LastName= "diaz" , Name= "pedro" , Id = 456 },
            new Cliente { dinero = 8000 , LastName= "Cruz" , Name= "maria" , Id = 789 },

        };

        public decimal depositos(int dinero, int id)
        {

            var resultado = clientes.Find(x => x.Id == id);

            if (resultado == null)
            {
                return 0;
            }
            resultado.dinero += dinero;


            return resultado.dinero;

        }

        public decimal extracciones(int dinero, int id)
        {

            var resultado = clientes.Find(x => x.Id == id);

            if (resultado == null || (resultado.dinero - dinero) <= 0)
            {
                return 0;
            }

            resultado.dinero -= dinero;



            return resultado.dinero;

        }

        public decimal TotalDeposito()
        {

            foreach (var cliente in clientes)
            {
                dineroBanco += cliente.dinero;
            }

            return dineroBanco;

        }

    }
}
