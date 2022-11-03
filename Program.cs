namespace Bank
{
    class Errors:Exception
    {
        public Errors(string ErrorMsg)
            : base(ErrorMsg)
        {

        }

    }
    class Accounts
    {
        public int[] index;
        public string Acc_no = "", C_name = "", C_add = "";
        public double Balance = 0;
        int Age;
        public Accounts() { }
        public Accounts(String Acc_no, string C_name,int Age, String C_add, double Balance)
        {
            //int[] index,
            //this.index = index;
            this.Acc_no = Acc_no;
            this.C_name = C_name;
            this.C_add = C_add;
            this.Balance=Balance;
        }

        public int Create_Acc()
        {
            //for (int i = 0; i < index.Length;i++ )
            //{

            //}
            try
            {
                Console.WriteLine("╔═════════════════════════════××××××××××××××××════════════════════════════╗");
                Console.WriteLine("║Coloque o numero da conta:                                               ║");
                Console.WriteLine("╚════════════════════════════××××××××××××××××═════════════════════════════╝");

                Acc_no = Console.ReadLine();
                if (Acc_no == null)
                    throw new Errors("Voce tem que colocar o numero da conta!");
                Console.WriteLine("╔═════════════════════════════××××××××××××××××════════════════════════════╗"); 
                Console.WriteLine("║Coloque o nome da pessoa:                                                ║");
                Console.WriteLine("╚════════════════════════════××××××××××××××××═════════════════════════════╝");
                C_name = Console.ReadLine();
                if (C_name == null)
                    throw new Errors("Voce tem que colocar o numero da conta!");
                
                Console.WriteLine("╔═════════════════════════════××××××××××××××××════════════════════════════╗");
                Console.WriteLine("║Idade:\t\t\t\t                                          ║");
                Console.WriteLine("╚════════════════════════════××××××××××××××××═════════════════════════════╝");
                Age = int.Parse(Console.ReadLine());
                if (Age <=0)
                    throw new Errors("Voce tem que colocar o numero da conta!");
                
                Console.WriteLine("╔═════════════════════════════××××××××××××××××════════════════════════════╗");
                Console.WriteLine("║Colque o endereco:                                                       ║");
                Console.WriteLine("╚════════════════════════════××××××××××××××××═════════════════════════════╝");
                C_add = Console.ReadLine();
                if (C_add == null)
                    throw new Errors("Voce tem que colocar o numero da conta!");
                
                Console.WriteLine("╔═════════════════════════════××××××××××××××××════════════════════════════╗");
                Console.WriteLine("║Deposite a quantidade:                                                   ║");
                Console.WriteLine("╚════════════════════════════××××××××××××××××═════════════════════════════╝");
                Balance = double.Parse(Console.ReadLine());
                if (Balance <= 0)
                    throw new Errors("Voce tem que colocar o numero da conta!");
            }
            catch(Errors e)
            {
                Console.Write(e.Message);
            }
            
            return 1;

        }

        public void Acc_Availability(string Acc_num)
        {
            if (Acc_no.Equals(Acc_num))
            {
                Console.WriteLine("╔═════════════════════════════××××××××××××××××═════════════════════════════╗");
                Console.WriteLine("║Numero da conta:\t"+Acc_no);
                Console.WriteLine("║Nome:\t\t"+C_name);
                Console.WriteLine("║Idade:\t\t" + Age);
                Console.WriteLine("║Endereco:\t" + C_add);
                Console.WriteLine("║Dinheiro: \t$" + Balance);
                Console.WriteLine("╚═════════════════════════════××××××××××××××××═════════════════════════════╝");
            }
            else
            {
                Console.WriteLine("╔═════════════════════════════××××××××××××××××═════════════════════════════╗");
                Console.WriteLine("║Conta nao encontrada!                                                     ║");
                Console.WriteLine("╚═════════════════════════════××××××××××××××××═════════════════════════════╝");
            }
        }
        public void Deposite(string Acc_num)
        {
            try
            {


                if (Acc_no.Equals(Acc_num))
                {
                    Console.WriteLine("╔═════════════════════════════××××××××××××××××═════════════════════════════╗");
                    Console.WriteLine("║Coloque a Quantidade:                                                     ║");
                    Console.WriteLine("╚═════════════════════════════××××××××××××××××═════════════════════════════╝");
                    int Amount = int.Parse(Console.ReadLine());
                    if (Amount <= 0)
                        throw new Errors("Precisa ser maior que R$0");
                    else
                        this.Balance = Balance + Amount;

                    Console.WriteLine("╔═════════════════════════════××××××××××××××××════════════════════════════╗");
                    Console.WriteLine("║Quantidade monetaria:  R$" + Balance + "                                           ║");
                    Console.WriteLine("╚════════════════════════════××××××××××××××××═════════════════════════════╝");
                }
                else
                {
                    Console.WriteLine("╔═════════════════════╗");
                    Console.WriteLine("║Conta nao encontrada!║");
                    Console.WriteLine("╚═════════════════════╝");
                }
            }
            catch(Errors e)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public void Withdraw(string Acc_num)
        {
            if (Acc_no.Equals(Acc_num))
            {
                Console.Write("Coloque a quantidade:\t\t");
                int Amount = int.Parse(Console.ReadLine());
                if (Balance == 0)
                {
                    Console.WriteLine("Saldo insuficiente!");

                }
                else if (Amount > Balance)
                {
                    Console.WriteLine("╔═════════════════════╗");
                    Console.WriteLine("║Saldo insuficiente!  ║");
                    Console.WriteLine("╚═════════════════════╝");
                }
                else
                {
                    Balance = Balance - Amount;
                    Console.WriteLine("╔═════════════════════╗");
                    Console.WriteLine("║Saldo: R$"+Balance+"   ║");
                    Console.WriteLine("╚═════════════════════╝");
                }
            }
            else
            {
                Console.WriteLine("╔═════════════════════╗");
                Console.WriteLine("║Conta nao encontrada!║");
                Console.WriteLine("╚═════════════════════╝");
            }
        }
        public void Balenquiry()
        {
            Console.WriteLine("╔═════════════════════╗");
            Console.WriteLine("║Seu saldo e de: " + Balance+"     ║");
            Console.WriteLine("╚═════════════════════╝");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //char ch;
            int result;
            String Acc_num,ch;
            //double depositeamount;
            //double withdrawamount;

            Accounts Acc = new Accounts();
            //try
            //{

           
                for (; ; )
                {
                    Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("║1.Criar conta ║  2.contas ║  3.Depositar ║  4.Saque  ║ 5.Sair ║");
                    Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
                    ch = Console.ReadLine();
                    
                    switch (ch)
                    {
                        case "1": 
                            
                            result=Acc.Create_Acc();
                            if(result==1)
                            {
                                Console.WriteLine("Conta \"{0}\" Criada com sucesso", Acc.Acc_no);
                            }
                            else
                            {
                                Console.WriteLine("Nao foi possivel criar a conta, tenta novamente!");
                            }
                            
                            break;

                        case "2":
                            
                            Console.Write("Coloque o numero da conta:\t");
                            Acc_num=Console.ReadLine();
                            Acc.Acc_Availability(Acc_num);
                            break;

                        case "3":
                            
                            Console.Write("Coloque o numero da conta:\t");
                            Acc_num=Console.ReadLine();
                            Acc.Deposite(Acc_num);
                            break;

                        case "4":
                            
                            Console.Write("Digite o número da conta do cliente:  ");
                            Acc_num = Console.ReadLine();
                            Acc.Withdraw(Acc_num);
                            break;
                        
                        case "5": 
                            
                            System.Environment.Exit(0);
                            break;

                        default:
                            
                            Console.WriteLine("Escolha invalida!");
                            break;
                    }
                }
             }
            //catch(Errors e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //}
             
        
    }
}