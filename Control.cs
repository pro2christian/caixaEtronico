using System;

	class Controle
{
	private double saldo;

	public double Saldo
	{
		get { return this.saldo; }
		set { this.saldo = value; }
	}
	private double deposito;

	public double Deposito
	{
		get { return this.deposito; }
		set { this.deposito = value; }
	}

	private double saque;

	public double Saque
	{
		get { return this.saque; }
		set { this.saque = value; }
	}

	
	public double valor()
	{
		saldo = deposito+saldo;
		return saldo;
	}
	public double valor2()
	{
		
		if(saldo>=saque)
		{
            saldo = saldo - saque;
            if (saldo < 0)
            {
                return 0;
            }
            Console.WriteLine("Saque Efetuado com Sucesso, Obrigado!");
		}
       
        else
        {
            Console.WriteLine("Saldo insulficiente, Obrigado!");
        }
        
        return saldo;

		
    }


}
