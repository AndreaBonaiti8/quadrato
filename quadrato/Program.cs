using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadrato
{
    internal class Program
    {
        class quadrato
        { 
          protected double _lato { get; set; }
          public quadrato(double _lato)
          {
                this._lato = _lato;  
          }
            public void Perimetro () 
            {
               double peri = 0;
               peri = _lato * 4;
                Console.WriteLine("Il perimetro del quadrato è: " + peri + "cm");
            }
            public void Area()
            {
                double area = 0;
                area = _lato * _lato;
                Console.WriteLine("L'area del quadrato è: " + area + "cm^2");
            }
        }
        class Cubo : quadrato
        {
            public Cubo(double _lato) : base(_lato)
            {

            }
            public void AreaCubo()
            {
                double a = _lato * _lato * 6;
                Console.WriteLine("L'area del cubo è " + a);
            }
            public void VolumeCubo()
            {
                double vol = _lato * _lato * _lato;
                Console.WriteLine("Il volume del cubo è " + vol);
            }
        }
        static void Main(string[] args)
        {
            quadrato q = new quadrato(10);
            q.Area();
            q.Perimetro();
            Cubo c = new Cubo(10);
            c.AreaCubo();
            c.VolumeCubo();
        }
    }
}
