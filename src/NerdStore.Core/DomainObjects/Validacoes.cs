using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NerdStore.Core.DomainObjects
{
    public class Validacoes
    {
        public static void ValidarSeIgual(object object1, object object2, string messagem)
        {
            if(!object1.Equals(object2))
            {
                throw new DomainException (messagem);
            }
        }

        public static void ValidarSeDiferente(object object1, object object2, string messagem)
        {
            if (object1.Equals(object2))
            {
                throw new DomainException(messagem);
            }
        }

        public static void ValidarCaracteres(string valor, int maximo, string messagem)
        {
            var length = valor.Trim().Length;
            if (length > maximo)
            {
                throw new DomainException(messagem);
            }
        }

        public static void ValidarCaracteres(string valor, int maximo, int minimo, string messagem)
        {
            var length = valor.Trim().Length;
            if (length < minimo ||length > maximo)
            {
                throw new DomainException(messagem);
            }
        }

        public static void ValidarExpressao(string pattern, string valor, string messagem)
        {
            var regex   = new Regex(pattern);

            if (!regex.IsMatch(valor))
            {
                throw new DomainException(messagem);
            }
        }

        public static void ValidarSeVazio(string valor, string messagem)
        {
            if (valor == null || valor.Trim().Length == 0)
            {
                throw new DomainException(messagem);
            }
        }

        public static void ValidarSeNulo(string valor, string messagem)
        {
            if (valor == null )
            {
                throw new DomainException(messagem);
            }
        }

        public static void ValidarMinimoMaximo(double valor, double maximo, double minimo, string messagem)
        {
           
            if (valor < minimo || valor > maximo)
            {
                throw new DomainException(messagem);
            }
        }

        public static void ValidarMinimoMaximo(float valor, float maximo, float minimo, string messagem)
        {

            if (valor < minimo || valor > maximo)
            {
                throw new DomainException(messagem);
            }
        }

        public static void ValidarMinimoMaximo(int valor, int maximo, int minimo, string messagem)
        {

            if (valor < minimo || valor > maximo)
            {
                throw new DomainException(messagem);
            }
        }

        public static void ValidarMinimoMaximo(long valor, long maximo, long minimo, string messagem)
        {

            if (valor < minimo || valor > maximo)
            {
                throw new DomainException(messagem);
            }
        }

        public static void ValidarMinimoMaximo(decimal valor, decimal maximo, decimal minimo, string messagem)
        {

            if (valor < minimo || valor > maximo)
            {
                throw new DomainException(messagem);
            }
        }

        public static void ValidarSeigualMinimo(double valor, double minimo, string messagem)
        {

            if (valor < minimo )
            {
                throw new DomainException(messagem);
            }
        }

        public static void ValidarSeigualMinimo(decimal valor, decimal minimo, string messagem)
        {

            if (valor < minimo)
            {
                throw new DomainException(messagem);
            }
        }

        public static void ValidarSeigualMinimo(int valor, int minimo, string messagem)
        {

            if (valor < minimo)
            {
                throw new DomainException(messagem);
            }
        }

        public static void ValidarSeFalso(bool boolValor, string messagem)
        {

            if (boolValor)
            {
                throw new DomainException(messagem);
            }
        }

        public static void ValidarSeVerdadeiro(bool boolValor, string messagem)
        {

            if (!boolValor)
            {
                throw new DomainException(messagem);
            }
        }
    }
}
