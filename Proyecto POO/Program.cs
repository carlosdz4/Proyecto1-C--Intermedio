// See https://aka.ms/new-console-template for more information
using Juego_Dado;
using Programa1_Club;
using programa2_Banco;

Console.WriteLine("Hello, World!");

int opcion;


Console.WriteLine(
    "Introduzca el Programa que desea probar" +
    "\n 1- Programa Dado" +
    "\n 2- Programa Club " +
    "\n 3-Programa banco");

opcion = Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
    case 1:
        randomJuego obj = new randomJuego();

        Console.WriteLine(obj.JuegoDelDado());
        break;
    case 2:
        club clubObj = new club();

        Console.WriteLine("\n El Socio mas Antiguo del club es " + clubObj.socioMasAntiguo());
        break;

    case 3:
        Banco bancoObj = new Banco();

        bancoObj.depositos(1000, 123);
        bancoObj.depositos(3000, 123);

        bancoObj.extracciones(5000, 123);

        Console.WriteLine("El total del dinero que hay depositado en el banco es " + bancoObj.TotalDeposito());
        break;
    default:
        break;
}