using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARCH_PRODUCTO
{
    public struct Reg
    {
        public int nr;
        public double dato;
    }
    class Tabla
    {
        const int max = 100;
        private Reg[] v;
        private int n;

        public Tabla()
        {
            n = 0;
            v = new Reg[max];
        }
        public void Cargar(Reg r1)
        {
            n++;
            v[n] = r1;
        }
        public void Inter(int p1, int p2)
        {
            Reg aux;
            aux = v[p1];
            v[p1] = v[p2];
            v[p2] = aux;
        }
        public void Ord()
        {
            int p, d;
            for(p=1; p <= n - 1; p++)
            {
                for(d=p+1;d<= n; d++)
                {
                    if (v[d].dato < v[p].dato)
                    {
                        Inter(d, p);
                    }
                }
            }
        }
        public void RetReg(int p, ref Reg r1)
        {
            r1 = v[p];
        }
        public int RetDim()
        {
            return n;
        }

    }
}
