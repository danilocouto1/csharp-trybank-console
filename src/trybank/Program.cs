using System;
using Trybank.Lib;

namespace Trybank.App;

class Program
{
    static void Main(string[] args)
    {
        TrybankLib bank = new();

        try
        {
            // Registrando uma nova conta
            bank.RegisterAccount(12345, 1001, 1234);

            // Fazendo login
            bank.Login(12345, 1001, 1234);
            Console.WriteLine("Login bem-sucedido!");

            // Verificando saldo
            int saldo = bank.CheckBalance();
            Console.WriteLine("Saldo atual: " + saldo);

            // Realizando um depósito
            bank.Deposit(100);
            Console.WriteLine("Depósito de 100 realizado com sucesso!");

            // Verificando saldo novamente
            saldo = bank.CheckBalance();
            Console.WriteLine("Saldo atual: " + saldo);

            // Realizando um saque
            bank.Withdraw(50);
            Console.WriteLine("Saque de 50 realizado com sucesso!");

            // Verificando saldo após o saque
            saldo = bank.CheckBalance();
            Console.WriteLine("Saldo atual: " + saldo);

            // Realizando uma transferência
            bank.Transfer(54321, 1002, 30);
            Console.WriteLine("Transferência de 30 para conta 54321 realizada com sucesso!");

            // Verificando saldo após a transferência
            saldo = bank.CheckBalance();
            Console.WriteLine("Saldo atual: " + saldo);

            // Fazendo logout
            bank.Logout();
            Console.WriteLine("Logout bem-sucedido!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
    }
}
