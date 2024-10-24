// 1 - Namespace = Conjunto de Classe
namespace Calc;

// 2 - Bibliotecas

// 3 - Classe = Entidade que vamos criar (nosso programa)
public class Calculadora
{

    // 3.1 - Atributos = Características / Campos

    // 3.2 - Funções e Métodos
    public static int SomarDoisNumero(int num1, int num2)
    {
        return num1 + num2;
    }

    public static int SubtrairDoisNumeros(int num1, int num2)
    {
        return num1 - num2;
    }

    public static int MultiplicarDoisNumeros(int num1, int num2)
    {
        return num1 * num2;
    }

    public static int DividirDoisNumeros(int num1, int num2)
    {
        return num1 / num2;
    }

    public static void Main() 
    {
        // chamar as 4 operacoes
        Console.WriteLine("5 + 7 = " + SomarDoisNumero(5, 7));
        Console.WriteLine("5 - 7 = " + SubtrairDoisNumeros(5, 7));
        Console.WriteLine("5 * 7 = " + MultiplicarDoisNumeros(5, 7));
        Console.WriteLine("5 / 7 = " + DividirDoisNumeros(5, 7));
    }

}