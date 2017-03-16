using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema01
{
    public class MoneyParts
    {
        public List<List<double>> build(double monto)
        {
            Math.Round(monto, 2);
            //incializar denominaciones
            List<double> listaDenominaciones = new List<double> { 0.05, 0.1, 0.2, 0.5, 1, 2, 5, 10, 20, 50, 100, 200 };
            //obtener lista para la combinacion segun monto ingresado
            List<double> listaCombina = listaDenominaciones.Where(x => x <= monto).ToList();

            List<List<double>> result = new List<List<double>>();

            for (int i = 0; i < listaCombina.Count(); i++)
            {
                var listaa= Combinaciones(monto, listaCombina[i]);
                var suma = Math.Round(listaa.Sum(),2);
                if (suma==monto)
                    result.Add(listaa.ToList());
                else
                {
                    //nueva lista

                }
            }
            return result;
        }

        public IEnumerable<double> Combinaciones(double monto,double valor)
        {
            return monto < valor ? new List<double>() : new List<double> { valor }.Concat(Combinaciones(monto - valor, valor));
        }
    }
}
