

class program
{
    static void Main(string[] args)
    {
        int op;
        bool v = true;
        int resp;
        Controle c = new Controle();
        c.Saldo = 100;

       
        while (v == true)
        {
            for (op = 0; op != 1 || op != 2 || op != 3;)
            {
                Console.Clear();
                Console.WriteLine("Selecione: \r\n1- Deposito\r\n2- Saque\r\n3- Ver saldo");
                op = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (op >= 4 || op <= 0)
                {

                    Console.WriteLine("Opção Invalida!!");
                    Console.ReadKey();
                    Console.Clear();

                }
                else
                {
                    break;
                }

            }

            switch (op)
            {
                //deposito
                case 1:
                    Console.WriteLine("Digite o valor do deposito");
                    c.Deposito = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("Saldo atual é de " + c.valor().ToString("C"));
                    Console.WriteLine("Deseja continuar?\r\n1- Sim\r\n2- Não");
                    resp = Convert.ToInt32(Console.ReadLine());
                    switch(resp)
                    { case 1:
                        v = true;
                            continue;
                           
                            case 2:
                            v = false;
                            Console.WriteLine("Obrigado!");
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Opção Invalida: Digite 1 ou 2");
                            Console.ReadKey();
                            
                            break;
                            
                    }
                    break;

                case 2:
                    //saque
                    Console.WriteLine("Digite o valor do saque");
                    c.Saque = Convert.ToDouble(Console.ReadLine());
                   Console.Clear();
                    Console.WriteLine("Seu saldo atual é de "+c.valor2().ToString("C"));
                    

                    Console.WriteLine("Deseja continuar?\r\n1- Sim\r\n2- Não");
                    resp = Convert.ToInt32(Console.ReadLine());
                    switch (resp)
                    {
                        case 1:
                            v = true;
                            continue;

                        case 2:
                            v = false;
                            Console.WriteLine("Obrigado!");
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Opção Invalida: Digite 1 ou 2");
                            Console.ReadKey();

                            break;

                    }
                    break;
                case 3:
                    //ver saldo
                    Console.WriteLine("Seu saldo é de"+c.Saldo.ToString("C"));
                    
                    Console.WriteLine("Deseja continuar?\r\n1- Sim\r\n2- Não");
                    resp = Convert.ToInt32(Console.ReadLine());
                    switch (resp)
                    {
                        case 1:
                            v = true;
                            continue;

                        case 2:
                            v = false;
                            Console.WriteLine("Obrigado!");
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Opção Invalida: Digite 1 ou 2");
                            Console.ReadKey();

                            break;

                    }
                    
                    break;
                default:
                    Console.WriteLine("Opção Invalida: Digite 1,2 ou 3");

                    break;
            }
        }
              
        Console.ReadKey();



    }
}