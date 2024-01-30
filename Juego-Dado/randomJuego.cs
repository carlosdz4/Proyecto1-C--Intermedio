using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Dado
{
    public class randomJuego
    {

        List<Dado> dados = new List<Dado>();

        Random random = new Random();

        public string JuegoDelDado()
        {

            for (int i = 0; i < 3; i++)
            {
                dados.Add(new Dado() { NumeroDado = random.Next(1, 7) });

            }

            foreach (var item in dados)
            {
                Console.WriteLine("\n El numero del dado " + item.NumeroDado);
            }

            if (dados.TrueForAll(x => x.Equals(dados.First())))
            {
                return "\n Ganaste";
            }

            else
            {
                return "\n Perdiste";
            }


        }


    }
}
