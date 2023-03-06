//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lista1PR2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //exercicio 1
//            int metros, cm, mm;
//                Console.WriteLine("Digite o numero de matros: ");
//              metros = int. Parse(Console.ReadLine());
//            cm = metros * 100;    
//            mm = metros * 1000;
//            Console.WriteLine("A quantidade em cm é:  " + cm);
//            Console.WriteLine("A quantidade em mm é:  " +mm);
//            Console.ReadKey();

//        }
//    }
//}




//exrecicio 2
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lista1PR2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
////            int fa1, resint
////              float fa2, resfloat
////              Console.WriteLine("etre com a temperatura em farenheit int: ");
////            fa1 = int.Parse(Console.ReadLine());
////            Console.WriteLine("etre com a temperatura em farenheit float: ");
////            fa2 = float.Parse(Console.ReadLine());

////            resint = (fa1 - 32) * (5 / 9);
////            resfloat = (fa2 - 32.0f) * (5.0f / 9.0f);

////            Console.WriteLine("resultado float: " + resfloat);
////            Console.WriteLine("resultado int: " + resint);
////            Console.ReadKey;







////        }
////    }
////}




////exercicio 3
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lista1PR2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//float peso, altura, res;
//            Console.WriteLine("digite o peso da pessoa desejada: ");
//            peso = float.Parse(Console.ReadLine());
//            Console.WriteLine("digite a altura da pessoa desejada: ");
//            altura = float.Parse(Console.ReadLine());

//            res = peso / (altura * altura);

//            Console.WriteLine("Resultado imc: " + res);
//            Console.ReadKey();






//        }
//    }
//}


//exercicio 4
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lista1PR2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            float peso1, peso2, peso3, valor1, valor2, valor3, res;

//            Console.WriteLine("Digite o primeiro peso desejado: ");
//            peso1 = float.Parse(Console.ReadLine());
//            Console.WriteLine("Digite o segundo peso desejado: ");
//            peso2 = float.Parse(Console.ReadLine());
//            Console.WriteLine("Digite o terceiro peso desejado: ");
//            peso3 = float.Parse(Console.ReadLine());

//            Console.WriteLine("Digite o primeiro valor desejado: ");
//             valor1= float.Parse(Console.ReadLine());
//            Console.WriteLine("Digite o segundo valor desejado: ");
//             valor2= float.Parse(Console.ReadLine());
//            Console.WriteLine("Digite o terceiro valor desejado: ");
//             valor3= float.Parse(Console.ReadLine());

//            res = (peso1*valor1 +  peso2*valor2 + peso3*valor3) / (peso1 + peso2 + peso3);

//            Console.WriteLine("O valor da media ponderada é: " + res);
//            Console.ReadKey();







//        }
//    }
//}




//exerciocio 5
//ondas estacionarias
//using system;
//using system.collections.generic;
//using system.linq;
//using system.text;
//using system.threading.tasks;

//namespace lista1pr2
//{
//    internal class program
//    {
//        static void main(string[] args)
//        {
//            float tamanhoonda, frequencia, res;

//            console.writeline("digite o tamanho da onda: ");
//            tamanhoonda = float.parse(console.readline());
//            console.writeline("digite a frequencia da onda: ");
//            frequencia = float.parse(console.readline());

//            res = tamanhoonda * frequencia;
//            console.writeline("a velocidade da onda é: "  + res + "  m/s);
//            console.readkey();










//        }
//    }
//}




//exercicio 6
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lista1PR2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            float salario, res, por;

//            Console.WriteLine("Digite o salario que deseja acrescentar 25%: ");
//            salario = float.Parse(Console.ReadLine());


//            por = (salario * 25) / 100;
//            res = salario + por;


//                Console.WriteLine("Seu salario com o acrescimo de 25% é: " + res);
//                Console.ReadKey();  


//        }
//    }
//}


//EXERCICIO 7
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float dolar, real;

            Console.WriteLine("Digite um valor em Reais: ");
            real= float.Parse(Console.ReadLine());

            dolar = real / 5.20f;

            Console.WriteLine("o Valor em dolar é: " + dolar + "  dolar");
            Console.ReadKey();
            


        }
    }
}