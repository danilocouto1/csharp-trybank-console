namespace Trybank.Lib;

public class TrybankLib
{
    public bool Logged;
    public int loggedUser;

    //0 -> Número da conta
    //1 -> Agência
    //2 -> Senha
    //3 -> Saldo
    public int[,] Bank;
    public int registeredAccounts;
    private int maxAccounts = 50;

    public TrybankLib()
    {
        loggedUser = -99;
        registeredAccounts = 0;
        Logged = false;
        Bank = new int[maxAccounts, 4];
    }

    // 1. Construa a funcionalidade de cadastrar novas contas
    public void RegisterAccount(int number, int agency, int pass)
    {
        try
        {
            for (int i = 0; i < Bank.GetLength(0); i++)
            {
                if (Bank[i,0] == number && Bank[i,1] == agency) throw new ArgumentException("A conta já está sendo usada!");
            }
            Bank[registeredAccounts, 0] = number;
            Bank[registeredAccounts, 1] = agency;
            Bank[registeredAccounts, 2] = pass;
            Bank[registeredAccounts, 3] = 0;
            registeredAccounts++;
        }
        catch (Exception)
        {

            throw;
        }
    }

    // 2. Construa a funcionalidade de fazer Login
    public void Login(int number, int agency, int pass)
    {
        try
        {
            if (Logged)
            {
                throw new AccessViolationException("Usuário já está logado");
            }

                for (int i = 0; i < Bank.GetLength(0); i++)
                {
                    if (Bank[i, 0] == number && Bank[i, 1] == agency)
                    {
                        if (Bank[i, 2] == pass)
                        {
                            Logged = true;
                        //loggedUser = Bank[i, 0];
                            break;
                        }
                        else
                        {
                            throw new ArgumentException("Senha incorreta");
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Agência + Conta não encontrada");
                    }
                }
            
        }
        catch (Exception)
        {

            throw;
        }
    }

    // 3. Construa a funcionalidade de fazer Logout
    public void Logout()
    {
        throw new NotImplementedException();
    }

    // 4. Construa a funcionalidade de checar o saldo
    public int CheckBalance()
    {
        throw new NotImplementedException();   
    }

    // 5. Construa a funcionalidade de depositar dinheiro
    public void Deposit(int value)
    {
        throw new NotImplementedException();
    }

    // 6. Construa a funcionalidade de sacar dinheiro
    public void Withdraw(int value)
    {
        throw new NotImplementedException();
    }

    // 7. Construa a funcionalidade de transferir dinheiro entre contas
    public void Transfer(int destinationNumber, int destinationAgency, int value)
    {
        throw new NotImplementedException();
    }

   
}
