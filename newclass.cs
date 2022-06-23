namespace ejercicioCartasEspaniolas
{
    public class CartasEspañolas
    {
        private int _contJ=-1, _contadorCartas=40;
        private List<string> _cartasUsadas=new List<string>();
        private List<string> _cartasU=new List<string>();
        
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
            _contJ=_contJ+1;
            _contadorCartas--;
            if(_contJ==40) return "no quedan mas cartas";
            else{
                var aux=_cartasU[_contJ];
                _cartasUsadas.Add(aux);
                return aux;
                }  
        }

        //cartas que toavia quedan disponibles

        public void CartasDisponibles()
        {
            Console.WriteLine($"te quedan {_contadorCartas} cartas");
        }

        //damos cartas que pida el usuario

        public void DarCartas(int x)
        {
            if(x>_contadorCartas){Console.WriteLine($"lo siento solo quedan {_contadorCartas} cartas");}
            else{
                for(int i=0;i<x;i++)
                {
                    _contJ++;
                    _contadorCartas--;
                    Console.WriteLine(_cartasU[_contJ]);
                    _cartasUsadas.Add(_cartasU[_contJ]);    
                }
            }
        }

        //mostramos cartas que salieron
        public void CartasMonton()
        {
            if(_cartasUsadas.Count==0)
                Console.WriteLine("todavia no usaste ninguna carta");
            else{
                Console.WriteLine("Las cartas que usaste son");
                foreach (var carta in _cartasUsadas)
                {
                    Console.WriteLine(carta);
                }
            }
            
        }
        //mostramos cartas de la baraja
        public void MostrarBaraja()
        {
            Console.WriteLine("las cartas que quedaron son:");
            int x=_contJ+1;
            for(int i=x;i<_cartasU.Count;i++)
            {
                Console.WriteLine(_cartasU[i]);
            }  
        }
    }
}