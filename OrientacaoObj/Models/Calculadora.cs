using OrientacaoObj.Interfaces;

namespace OrientacaoObj.Models;

public class Calculadora : ICalculadora
{
    public int Multiplicar(int num1, int num2)
    {
        return num1 * num2;
    }

    public int Somar(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Subtrair(int num1, int num2)
    {
        return num1 - num2;
    }
}
