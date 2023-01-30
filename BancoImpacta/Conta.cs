using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoImpacta
{
    internal class Conta
    {
        public int NConta;
        public string Titular;
        public decimal Saldo;
        public void Sacar () { }
        public void Depositar () { }
        public void Transferir () { }
        public void ExibirSaldo()
        {
            Console.WriteLine($"Numero da conta: {NConta} - Titular da Conta: {Titular} - Saldo: {Saldo} ");
        }
        public void Sacar(string novoSaque)
        {
            
        }
    }
}
