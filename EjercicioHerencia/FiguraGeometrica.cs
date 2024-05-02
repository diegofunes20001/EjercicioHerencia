using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class FiguraGeometrica : Operaciones
    {
        /// <summary>
        /// lado
        /// </summary>
        private double lado;
        /// <summary>
        /// altura
        /// </summary>
        private double altura;
        /// <summary>
        /// profundidad
        /// </summary>
        private double profundidad;

        public override double CalcularArea()
        {
            return lado * altura;
        }

        public override double CalcularLongitud()
        {
            return 2 * (lado + altura);
        }

        public override double CalcularVolumen()
        {
            return lado * altura * profundidad;
        }
        /// <summary>
        /// Imprimir
        /// </summary>
        public void Imprimir()
        {
            Console.WriteLine("Área: " + CalcularArea());
            Console.WriteLine("Longitud: " + CalcularLongitud());
            Console.WriteLine("Volumen: " + CalcularVolumen());
        }
    }
}
