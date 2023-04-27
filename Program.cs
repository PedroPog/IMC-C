using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float peso, altura, imc;
            char resp, sexo;
            string nome;

            Console.WriteLine("*****Calculadora de IMC*****");
            Console.WriteLine("****************************");
            Console.WriteLine("Pressione qualquer botão para dar inicio ao programa.....");
            Console.ReadLine();
            do{
                Console.Write("Insira o nome do cliente: ");
                nome=Console.ReadLine();
                Console.Write($"Qual o sexo do cliente {nome}:(F ou M) ");
                while (!char.TryParse(Console.ReadLine().ToUpper(), out sexo) || sexo != 'F' && sexo != 'M') ;
                    Console.Write("Numero invalido! por favor inserir F para Feminino e M para Masculino");
                Console.Write($"Insira o a altura do cliente {nome}: ");
                while (!float.TryParse(Console.ReadLine(), out altura) || altura > 1 && altura < 2.5);
                    Console.Write("Numero invalido! por favor inserir um numero entre 1 metro ate 2,5 metro...");
                Console.Write($"Insira o peso do cliente {nome}: ");
                while (!float.TryParse(Console.ReadLine(), out peso) || peso > 30 && peso < 200);
                    Console.Write("Numero invalido! Por favor inserir um numero entre 30kg ate 200kg...");
                imc = peso / (altura * altura);

                if (sexo == 'F')
                {
                    if (imc < 19.1)
                    {
                        Console.WriteLine("Abaixo do peso");
                    }else if(imc < 25.8)
                    {
                        Console.WriteLine("Peso normal");
                    }else if(imc < 27.3)
                    {
                        Console.WriteLine("Levemente acima do peso");
                    }else if(imc < 32.3)
                    {
                        Console.WriteLine("Acima do peso");
                    }
                    else
                    {
                        Console.WriteLine("Obeso");
                    }
                }
                else
                {
                    if (imc < 20.7)
                    {
                        Console.WriteLine("Abaixo do peso");
                    }
                    else if (imc < 26.4)
                    {
                        Console.WriteLine("Peso normal");
                    }
                    else if (imc < 27.8)
                    {
                        Console.WriteLine("Levemente acima do peso");
                    }
                    else if (imc < 31.1)
                    {
                        Console.WriteLine("Acima do peso");
                    }
                    else
                    {
                        Console.WriteLine("Obeso");
                    }
                }

                Console.Write("Gostaria de Calcular ou IMC? (S para continuar N para encerrar o uso)..");
                while(!char.TryParse(Console.ReadLine().ToUpper(), out resp)||resp!='S' && resp!='N');
                Console.Clear();

            }while (resp=='S') ;
        }
    }
}
