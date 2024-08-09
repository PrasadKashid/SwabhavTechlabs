using StateDesignPattern.Model;

class Program
{
    public static void Main(string[] args)
    {
        ATMMachine machine = new ATMMachine();
        Console.WriteLine("Current state  : " +machine.atm.GetType().Name);
        Console.WriteLine();
        machine.EnterPin();
        machine.WithdrawMoney();
        machine.InsertDebit();

        Console.WriteLine();

        Console.WriteLine("Current state  : " +machine.atm.GetType().Name);
        Console.WriteLine();
        machine.EnterPin();
        machine.WithdrawMoney();
        //machine.InsertDebit();


    }
}