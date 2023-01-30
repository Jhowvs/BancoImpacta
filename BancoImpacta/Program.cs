namespace BancoImpacta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta();
            c1.NConta = 4323;
            c1.Titular = "Jhony";
            c1.Saldo = 1000;


            c1.ExibirSaldo();
            c1.Sacar(700);
            c1.ExibirSaldo();
            c1.Depositar(350);
            c1.ExibirSaldo();

            Console.WriteLine(new String('-', 50));
          
        }

    }
}