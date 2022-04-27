using System;

namespace Calculadora
{
    public class Funcoes
    {
        public static void Menu()
            {
             Console.Clear();
             Console.WriteLine("Digite a opção desejada: ");
             Console.WriteLine("0 - Sair ; 1 - Somar ; 2 - Subtração ; 3 - Divisão ; 4 - Multiplicação ; 5 - Media");

            int.TryParse(Console.ReadLine(), out int opcao);
            switch(opcao){
            case 0 : System.Environment.Exit(0); break;
            case 1 : Soma();break;
            case 2 : Subtracao(); break;
            case 3 : Divisao(); break;
            case 4 : Multiplicacao();break;
            case 5 : Media1();break;
            default : Menu();break;
            }
        }
        public static void Divisao()
        { 
            Console.Clear();
            Console.WriteLine("Digite o primeiro numero : ");
            float.TryParse(Console.ReadLine(),out float N1);

            Console.WriteLine("Digite o segundo numero : ");
            float.TryParse(Console.ReadLine(),out float N2);
        
            float resultado = N1 / N2;
            Console.WriteLine("");
            
            Console.WriteLine($"O resultado da divisão é : {resultado}");
            Console.ReadKey();
            Menu();
        }
        public static void Media1()
        { 
            Console.Clear();
            Console.WriteLine("Digite o primeiro numero : ");
            float.TryParse(Console.ReadLine(),out float N1);

            Console.WriteLine("Digite o segundo numero : ");
            float.TryParse(Console.ReadLine(),out float N2);

            float resultado = (N1 + N2)/2;
            Console.WriteLine("");

            Console.WriteLine($"O resultado da media é : {resultado}");
            Console.ReadKey();
            Menu();
        }
        public static void Multiplicacao()
        { 
            Console.Clear();
            Console.WriteLine("Digite o primeiro numero : ");
            float.TryParse(Console.ReadLine(),out float N1);

            Console.WriteLine("Digite o segundo numero : ");
            float.TryParse(Console.ReadLine(),out float N2);

            float resultado = N1 * N2;
            Console.WriteLine("");

            Console.WriteLine($"O resultado da multiplicação é : {resultado}");
            Console.ReadKey();
            Menu();
        }
        public static void Soma()
        { 
            Console.Clear();
            Console.WriteLine("Digite o primeiro numero : ");
            float.TryParse(Console.ReadLine(),out float N1);

            Console.WriteLine("Digite o segundo numero : ");
            float.TryParse(Console.ReadLine(),out float N2);

            float resultado = N1 + N2;
            Console.WriteLine("");

            Console.WriteLine($"O resultado da soma é : {resultado}");
            Console.ReadKey();
            Menu();
        }
        public static void Subtracao()
        { 
            Console.Clear();
            Console.WriteLine("Digite o primeiro numero : ");
            float.TryParse(Console.ReadLine(),out float N1);

            Console.WriteLine("Digite o segundo numero : ");
            float.TryParse(Console.ReadLine(),out float N2);

            float resultado = N1 - N2;
             
            Console.WriteLine("");

            Console.WriteLine($"O resultado da subtração é : {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}