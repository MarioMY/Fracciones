using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class Fraccion
    {
        private int entero;

        public int Entero
        {
            get
            {
                return entero;
            }
            set
            {
                entero = value;
            }
        }

        private int numerador;

        public int Numerador
        {
            get
            {
                return numerador;
            }
            set
            {
                numerador = value;
            }
        }
        private int denominador;

        public int Denominador
        {
            get
            {
                return denominador;
            }
            set
            {
                denominador = value;
            }
        }

        public Fraccion(int e, int n, int d)
        {
            entero = e;
            numerador = n;
            if (d == 0)
            {
                d = 1;
            }
            denominador = d;
        }

        public Fraccion(int n, int d)
        {
            entero = 0;
            numerador = n;
            if (d == 0)
            {
                d = 1;
            }
            denominador = d;
        }

        public Fraccion Sumar(Fraccion otra)
        {
            int denominadorComun = denominador * otra.denominador;
            int e1 = entero * denominadorComun;
            int n1 = (denominadorComun / denominador) * numerador;
            n1 += e1;
            int e2 = entero * denominadorComun;
            int n2 = (denominadorComun / otra.denominador) * otra.numerador;
            Fraccion resultado = new Fraccion(n1 + n2, denominadorComun);
            n2 += e2;
            resultado = Simplificar(resultado);
            return resultado;
        }



        public Fraccion Restar(Fraccion otra)
        {
            int denominadorComun = denominador * otra.denominador;
            int e1 = entero * denominadorComun;
            int n1 = (denominadorComun / denominador) * numerador;
            n1 += e1;
            int e2 = entero * denominadorComun;
            int n2 = (denominadorComun / otra.denominador) * otra.numerador;
            Fraccion resultado = new Fraccion(n1 - n2, denominadorComun);
            n2 += e2;
            resultado = Simplificar(resultado);
            return resultado;
        }

        public Fraccion Multplicar(Fraccion otra)
        {
            int n1 = numerador + (entero * denominador);
            int n2 = otra.numerador + (otra.entero * otra.denominador);
            Fraccion resultado = new Fraccion(n1 * n2, denominador * otra.denominador);
            resultado = Simplificar(resultado);
            return resultado;
        }

        public Fraccion Dividir(Fraccion otra)
        {
            int n1 = numerador + (entero * denominador);
            int n2 = otra.numerador + (otra.entero * otra.denominador);
            Fraccion resultado = new Fraccion(n1 * otra.denominador, n2 * denominador);
            resultado = Simplificar(resultado);
            return resultado;
        }



        public Fraccion Simplificar(Fraccion f)
        {

            Fraccion fraccionSimplificada;

            //Agregar la parte entera a la fraccion
            int n = (f.Entero * f.Denominador) + f.Numerador;
            int d = f.Denominador;
            int e = 0;
            bool negativo = false;
            if (n < 0)
            {
                negativo = true;
                n *= -1;
            }
            //Calcular el Max Comun divisor
            int mcd = MaximoComunDivisor(n, d);

            //Reducir la fraccion en base al MCD
            n = n / mcd;
            d = d / mcd;

            if (n >= d)
            {
                e = n / d;
                n = e % d;
            }

            if (negativo && e > 0)
            {
                e *= -1;
            }

            if (negativo && e == 0)
            {
                n *= -1;
            }
            fraccionSimplificada = new Fraccion(e, n, d);
            //regresar la fraccion reducida
            return fraccionSimplificada;
        }

        public int MaximoComunDivisor(int n, int d)
        {
            while (d != 0)
            {
                int t = d;
                d = n % d; //residuo de la division
                n = t;
            }
            return n;

        }



        public override string ToString()
        {
            if (entero == 0)
            {
                return numerador + "/" + denominador;
            }
            if (numerador == 0)
            {
                return entero + " ";
            }
            return entero + " " + numerador + "/" + denominador;
        }

    }
}

