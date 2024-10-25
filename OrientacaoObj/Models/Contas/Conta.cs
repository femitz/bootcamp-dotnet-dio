namespace OrientacaoObj.Models
{
    public abstract class Conta
    {
        protected decimal Saldo;

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo é: {Saldo}");
        }
    }
}
