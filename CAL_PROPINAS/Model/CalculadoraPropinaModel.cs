using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAL_PROPINAS.Model
{
    internal class CalculadoraPropinaModel
    {
        public double CalcularPropina(double costoServicio, int numeroPersonas, double porcentajePropina)
        {
            double propina = costoServicio * (porcentajePropina / 100);
            double totalPagar = costoServicio + propina;
            double totalPagarPorPersona = totalPagar / numeroPersonas;

            return propina;
        }
    }
}


