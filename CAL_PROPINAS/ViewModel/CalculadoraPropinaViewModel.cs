using CAL_PROPINAS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace CAL_PROPINAS.ViewModel { 

    public class CalculadoraPropinaViewModel : BindableObject
    {
        private double costoServicio;
        private int numeroPersonas;
        private double porcentajePropina;
        private string resultado;

        public double CostoServicio
        {
            get => costoServicio;
            set
            {
                costoServicio = value;
                OnPropertyChanged(nameof(CostoServicio));
            }
        }

        public int NumeroPersonas
        {
            get => numeroPersonas;
            set
            {
                numeroPersonas = value;
                OnPropertyChanged(nameof(NumeroPersonas));
            }
        }

        public double PorcentajePropina
        {
            get => porcentajePropina;
            set
            {
                porcentajePropina = value;
                OnPropertyChanged(nameof(PorcentajePropina));
            }
        }

        public string Resultado
        {
            get => resultado;
            set
            {
                resultado = value;
                OnPropertyChanged(nameof(Resultado));
            }
        }

        private CalculadoraPropinaModel calculadoraModel;

        public CalculadoraPropinaViewModel()
        {
            calculadoraModel = new CalculadoraPropinaModel();
        }

        public void CalcularPropina()
        {
            double propina = calculadoraModel.CalcularPropina(costoServicio, numeroPersonas, porcentajePropina);

            Resultado = $"Propina: {propina:C2}";
        }

        public void Limpiar()
        {
            CostoServicio = 0;
            NumeroPersonas = 0;
            PorcentajePropina = 0;
            Resultado = string.Empty;
        }
    }
}

