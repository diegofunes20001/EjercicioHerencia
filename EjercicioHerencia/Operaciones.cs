using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    // Clase padre Operaciones
    public abstract class Operaciones
    {
        /// <summary>
        /// Calcular de Area
        /// </summary>
        public abstract double CalcularArea();
        /// <summary>
        /// Calcular de Longitud
        /// </summary>
        public abstract double CalcularLongitud();
        /// <summary>
        ///  Calcular de Volumen
        /// </summary>
        public abstract double CalcularVolumen();

        public void Imprimir() { }
    }
}
