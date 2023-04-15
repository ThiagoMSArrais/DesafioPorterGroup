using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Linq.Expressions;

namespace DesafioPorterGroup.Console
{
    public class Desafios
    {
        #region Desafio ObterNumeroPorExtenso
        public static string ObterNumeroPorExtenso(int numero)
        {
            int quantidadeDigitos = numero.ToString().Length;
            string valorPorExtenso = string.Empty;

            for (int posicao = quantidadeDigitos - 1; posicao >= 0; posicao--)
            {
                if (posicao == Convert.ToInt32(PosicaoNumericaEnum.CentenasDeMilhoes))
                {
                    valorPorExtenso += DefinirValorDeCentenasPorExtenso(Convert.ToInt32(numero.ToString().ToArray()[quantidadeDigitos - (posicao + 1)].ToString()));
                }
                else if (posicao == Convert.ToInt32(PosicaoNumericaEnum.DezenasDeMilhoes))
                {
                    int valorPosicao = Convert.ToInt32(numero.ToString().ToArray()[quantidadeDigitos - (posicao + 1)].ToString());
                    
                    valorPorExtenso += DefinirValorDeDezenasPorExtenso(Convert.ToInt32(numero.ToString().ToArray()[quantidadeDigitos - (posicao + 1)].ToString()));

                    if (valorPosicao > 0)
                    {
                        valorPorExtenso += " e ";
                    }
                }
                else if (posicao == Convert.ToInt32(PosicaoNumericaEnum.UnidadesDeMilhoes))
                {
                    int valorPosicao = Convert.ToInt32(numero.ToString().ToArray()[quantidadeDigitos - (posicao + 1)].ToString());

                    valorPorExtenso += DefinirValorUnidadePorExtenso(Convert.ToInt32(numero.ToString().ToArray()[quantidadeDigitos - (posicao + 1)].ToString()));
                    valorPorExtenso += " milhões";

                    if (valorPosicao > 0)
                    {
                        valorPorExtenso += " e ";
                    }

                }
                else if (posicao == Convert.ToInt32(PosicaoNumericaEnum.CententasDeMilhar))
                {
                    int valorPosicao = Convert.ToInt32(numero.ToString().ToArray()[quantidadeDigitos - (posicao + 1)].ToString());

                    valorPorExtenso += DefinirValorDeCentenasPorExtenso(Convert.ToInt32(numero.ToString().ToArray()[quantidadeDigitos - (posicao + 1)].ToString()));

                    if (valorPosicao > 0)
                    {
                        valorPorExtenso += " e ";
                    }
                }
                else if (posicao == Convert.ToInt32(PosicaoNumericaEnum.DezenasDeMilhar))
                {
                    int valorPosicao = Convert.ToInt32(numero.ToString().ToArray()[quantidadeDigitos - (posicao + 1)].ToString());

                    valorPorExtenso += DefinirValorDeDezenasPorExtenso(Convert.ToInt32(numero.ToString().ToArray()[quantidadeDigitos - (posicao + 1)].ToString()));

                    if (valorPosicao > 0)
                    {
                        valorPorExtenso += " e ";
                    }
                }
                else if (posicao == Convert.ToInt32(PosicaoNumericaEnum.UnidadesDeMilhar))
                {
                    int valorPosicao = Convert.ToInt32(numero.ToString().ToArray()[quantidadeDigitos - (posicao + 1)].ToString());

                    valorPorExtenso += DefinirValorUnidadePorExtenso(Convert.ToInt32(numero.ToString().ToArray()[quantidadeDigitos - (posicao + 1)].ToString()));
                    valorPorExtenso += " mil";

                    if (valorPosicao > 0)
                    {
                        valorPorExtenso += " e ";
                    }
                }
                else if (posicao == Convert.ToInt32(PosicaoNumericaEnum.Centenas))
                {
                    int valorPosicao = Convert.ToInt32(numero.ToString().ToArray()[quantidadeDigitos - (posicao + 1)].ToString());

                    valorPorExtenso += DefinirValorDeCentenasPorExtenso(Convert.ToInt32(numero.ToString().ToArray()[quantidadeDigitos - (posicao + 1)].ToString()));

                    if (valorPosicao > 0)
                    {
                        valorPorExtenso += " e ";
                    }
                }
                else if (posicao == Convert.ToInt32(PosicaoNumericaEnum.Dezenas))
                {
                    int valorPosicao = Convert.ToInt32(numero.ToString().ToArray()[quantidadeDigitos - (posicao + 1)].ToString());

                    valorPorExtenso += DefinirValorDeDezenasPorExtenso(Convert.ToInt32(numero.ToString().ToArray()[quantidadeDigitos - (posicao + 1)].ToString()));

                    if (valorPosicao > 0)
                    {
                        valorPorExtenso += " e ";
                    }
                }
                else if (posicao == Convert.ToInt32(PosicaoNumericaEnum.Unidades))
                {
                    int valorPosicao = Convert.ToInt32(numero.ToString().ToArray()[quantidadeDigitos - (posicao + 1)].ToString());

                    valorPorExtenso += DefinirValorUnidadePorExtenso(Convert.ToInt32(numero.ToString().ToArray()[quantidadeDigitos - (posicao + 1)].ToString()));
                }
            }

            return valorPorExtenso;
        }

        private static string DefinirValorUnidadePorExtenso(int numero)
        {
            string valorPorExtensoUnitario = string.Empty;

            switch (numero)
            {
                case 1:
                    valorPorExtensoUnitario = "um";
                    break;

                case 2:
                    valorPorExtensoUnitario = "dois";
                    break;

                case 3:
                    valorPorExtensoUnitario = "três";
                    break;

                case 4:
                    valorPorExtensoUnitario = "quatro";
                    break;

                case 5:
                    valorPorExtensoUnitario = "cinco";
                    break;

                case 6:
                    valorPorExtensoUnitario = "seis";
                    break;

                case 7:
                    valorPorExtensoUnitario = "sete";
                    break;

                case 8:
                    valorPorExtensoUnitario = "oito";
                    break;

                case 9:
                    valorPorExtensoUnitario = "nove";
                    break;
            }

            return valorPorExtensoUnitario;
        }

        private static string DefinirValorDeDezenasPorExtenso(int numero)
        {
            string valorPorExtensoDezenas = string.Empty;

            switch (numero)
            {
                case 1:
                    valorPorExtensoDezenas = "dez";
                    break;

                case 2:
                    valorPorExtensoDezenas = "vinte";
                    break;

                case 3:
                    valorPorExtensoDezenas = "trinta";
                    break;

                case 4:
                    valorPorExtensoDezenas = "quarenta";
                    break;

                case 5:
                    valorPorExtensoDezenas = "cinquenta";
                    break;

                case 6:
                    valorPorExtensoDezenas = "sessenta";
                    break;

                case 7:
                    valorPorExtensoDezenas = "setenta";
                    break;

                case 8:
                    valorPorExtensoDezenas = "oitenta";
                    break;

                case 9:
                    valorPorExtensoDezenas = "noventa";
                    break;
            }

            return valorPorExtensoDezenas;
        }

        private static string DefinirValorDeCentenasPorExtenso(int numero)
        {
            string valorPorExtensoCentenas = string.Empty;

            switch (numero)
            {
                case 1:
                    valorPorExtensoCentenas = "cento";
                    break;

                case 2:
                    valorPorExtensoCentenas = "duzentos";
                    break;

                case 3:
                    valorPorExtensoCentenas = "trezentos";
                    break;

                case 4:
                    valorPorExtensoCentenas = "quatrocentos";
                    break;

                case 5:
                    valorPorExtensoCentenas = "quinhentos";
                    break;

                case 6:
                    valorPorExtensoCentenas = "seiscentos";
                    break;

                case 7:
                    valorPorExtensoCentenas = "setecentos";
                    break;

                case 8:
                    valorPorExtensoCentenas = "oitocentos";
                    break;

                case 9:
                    valorPorExtensoCentenas = "novecentos";
                    break;
            }

            return valorPorExtensoCentenas;
        }

        #endregion


        #region Desafio SomarValoresDeUmaArray
        public static int SomarValores(int[] numeros)
        {
            if (numeros.Count() > 1000000)
            {
                throw new Exception("Limite de arrays de um milhão");
            }

            return numeros.Sum();
        }
        #endregion

        #region Desafio CalcularExpressaoMatematica
        public static double CalcularExpressaoMatematica(string expressaoMatematica)
        {
            DataTable tabela = new DataTable();
            return Convert.ToDouble(tabela.Compute(expressaoMatematica, ""));
        }
        #endregion
    }
}
