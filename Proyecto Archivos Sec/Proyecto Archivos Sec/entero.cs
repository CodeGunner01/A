using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Archivos_Sec
{
    class entero
    {
        private int n;

        public entero()
        {
            n = 0;
        }
        public void cargar(int d)
        {
            n = d;
        }
        public int descargar()
        {
            return n;
        }


        // VERIFICAR PRIMO----------------------
        public bool VerifPri()
        {
            int i, cont;
            cont = 0;
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    cont++;
                }
            }
            return (cont == 2);
        }
    }
}
