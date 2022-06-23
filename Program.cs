using System;
using ejercicioCartasEspaniolas;
namespace EjercicioCartasEspaniolas
{
    class ejercicioClase14
    {
        public static void Main(string[] args)
        {
            var cartas=new CartasEspañolas(); 
            int a;
            do
            {
                Console.WriteLine("Elije una de las siguientes opciones");
                Console.WriteLine("1.- Barajar");
                Console.WriteLine("2.- Mostrar siguiente carta");
                Console.WriteLine("3.- Mostrar cartas disponibles");
                Console.WriteLine("4.- Dar cartas");
                Console.WriteLine("5.- Mostrar cartas del monton");
                Console.WriteLine("6.- Mostrar baraja");
                Console.WriteLine("7.- salir");
                a=int.Parse(Console.ReadLine());
                switch (a)
                {
                case 1:
                    cartas.Barajar();
                    break;
                case 2:
                    Console.WriteLine(cartas.SiguienteCarta());
                    break;
                case 3:
                    cartas.CartasDisponibles();
                    break;
                case 4:
                    Console.WriteLine("ingresa cuantas cartas quieres");
                    cartas.DarCartas(int.Parse(Console.ReadLine()));
                    break;
                case 5:
                    cartas.CartasMonton();
                    break;
                case 6:
                    cartas.MostrarBaraja();
                    break;
                case 7:
                    Console.WriteLine("Gracias, que tengas un buen dia!");
                    break;
                default:
                    Console.WriteLine("La opcion elejida no existe");
                    break;
                }
            } while (a!=7);
        }
    }
}
