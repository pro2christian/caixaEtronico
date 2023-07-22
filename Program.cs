

class program
{
    static void Main(string[] args)
    {
        int op;
        Controle c = new Controle();
        c.Saldo = 100;
        Console.WriteLine("Escolha a operação\r\n1- Deposito\r\n2- Saque");
        op = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        if (op == 1)
        {
            Console.WriteLine("Digite o valor do deposito");
            c.Deposito = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Saldo atual é de " + c.valor().ToString("C"));
            Console.ReadKey();
        }
        else if (op == 2)
        {
            
            Console.WriteLine("Digite o valor do saque");
            c.Saque = Convert.ToDouble(Console.ReadLine());
            Console.Clear();    
            Console.WriteLine("Saldo atual é de " + c.valor2().ToString("C"));
        }
        Console.ReadKey();



    }
}