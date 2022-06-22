using System;
namespace EjercicioCartasEspaniolas
{
    class CartasEspañolas
    {
        private string [,] _cartas= new string[4,10];
        private int _contI=0, _contJ=-1, _contadorCartas=40;
        private List<string> _cartasUsadas=new List<string>();
        private List<string> _cartasU=new List<string>();
        
        //intento propiedades
        private int jj {get{
                return _contJ;}}
        //private int jj {get{ return _contJ;}}
        
        //creo un constructor el cual va a cargar las cartas
        public CartasEspañolas()
        {
            string[] palo=new string[4]{"espada","basto","copa","oro"};
            for(int i=0;i<4;i++)
            {
                int cont=0;
                for(int j=0;j<10;j++)
                {
                    if(j+1==8)
                    {
                        cont+=2;
                        _cartasU.Add(palo[i]+" "+(cont+1));
                    }else{
                        _cartasU.Add(palo[i]+" "+(cont+1));  
                    }
                    cont ++;
                }
            } 
        }
        //creamos el metodo barajar
        public void Barajar()
        {
            for(int i=0;i<_cartasU.Count;i++)
            {
                var c= new Random().Next(0,40);
                var aux=_cartasU[i];
                _cartasU[i]=_cartasU[c];
                _cartasU[c]=aux;
            }
        }
        //mostramos la siguiente carta
        public string SiguienteCarta()
        {
            _contJ ++;
            _contadorCartas--;
            if(_contJ==40) return "no quedan mas cartas";
            else{
                var aux=_cartasU[_contJ];
                _cartasUsadas.Add(_cartasU[_contJ]);
                //_cartasU.Remove(aux);
                return aux;
                }
            
        }

        //cartas que toavia quedan disponibles

        public void CartasDisponibles()
        {
            Console.WriteLine(_contadorCartas);
        }

        //damos cartas que pida el usuario

        public void DarCartas(int x)
        {
            if(x>_contadorCartas){Console.WriteLine($"lo siento solo quedan {_cartasU.Count} cartas");}
            else{
                for(int i=0;i<x;i++)
                {
                    _contJ++;
                    _contadorCartas--;
                    Console.WriteLine(_cartasU[jj]);
                    _cartasUsadas.Add(_cartasU[jj]);    
                }
            }
        }

        //mostramos cartas que salieron
        public void CartasMonton()
        {
            Console.WriteLine("Las cartas que usaste son");
            foreach (var carta in _cartasUsadas)
            {
                Console.WriteLine(carta);
            }
        }


        //mostramos cartas de la baraja
        public void MostrarBaraja()
        {
            foreach (var item in _cartasU)
            {
                Console.WriteLine(item);
            }   
        }
        public void mostrarCartas()
        {
            foreach (var item in _cartasU)
            {
                Console.WriteLine(item);
            }
        }



        public static void Main(string[] args)
        {
            var prueba=new CartasEspañolas();
            prueba.mostrarCartas();
            
            Console.WriteLine("barajamos");
            prueba.Barajar();
            prueba.mostrarCartas();
            Console.WriteLine("mostramos siguiente cartas");
            Console.WriteLine($"primera {prueba.SiguienteCarta()}");
            Console.WriteLine($"segunda {prueba.SiguienteCarta()}");
            Console.WriteLine($"tercera {prueba.SiguienteCarta()}");
            
            
            prueba.CartasDisponibles();
            Console.WriteLine("damos cartas");
            prueba.DarCartas(5);
            Console.WriteLine($"nsdncsnkzkxncncsnc");
            Console.WriteLine($"tercera {prueba.SiguienteCarta()}");
            prueba.CartasMonton();
            
          
            
        }
    }
}
