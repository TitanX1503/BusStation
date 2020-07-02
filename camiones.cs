using System;

namespace camiones
{ 
    public class Camion
    {
        public string name {get; set;}
        public string rute {get; set;}

    public Camion(string name, string rute) 
        {
            this.name = name;
            this.rute = rute;
        } 


        public override string ToString() 
        {
            
            return $"El Nombre Es: {this.name} , La Ruta Es: {this.rute}";
        }

    }
}


// https://pgramadores.blogspot.com/2012/10/queue-cola-en-c.html
//gracias al compañero rojo por aconsejarme con esta solucion :3