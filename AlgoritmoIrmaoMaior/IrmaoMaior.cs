using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmoIrmaoMaior
{
    public class IrmaoMaior
    {
        public int Obter(int n)
        {
            if (n > 100000000) return -1;

            var listaNumeros = n.ToString().ToCharArray();
            Array.Sort(listaNumeros);
            Array.Reverse(listaNumeros);

            var valorFinal = Convert.ToInt32(String.Join("", listaNumeros));
            return valorFinal < 100000000 ? valorFinal : -1;
        }
    }
}
