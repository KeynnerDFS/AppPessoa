using AppPessoa.RegrasDeNegocio;

int opcao = 0;

List<Pessoa>ListaPessoa = new List<Pessoa>();

void CadastrarPessoas()
{
    int opc = 1;
    while(opc!= 0)
    {
        Console.Clear();
        Console.WriteLine("%%%%%%%%%%%%%%% CADASTRAR PESSOA %%%%%%%%%%%%%%%");
        Console.WriteLine();
        Pessoa pessoa = new Pessoa();
        pessoa.Id = ListaPessoa.Count + 1;
        Console.WriteLine("Número de Inscrição.......:" + pessoa.Id );

        Console.Write("Nome.................:");
        pessoa.Nome = Console.ReadLine();

        Console.Write("CPF.................:");
        pessoa.Cpf = Console.ReadLine();

        Console.Write("RG.................:");
        pessoa.Rg = Console.ReadLine();

        Console.Write("Salario.................:");
        pessoa.Salario = Convert.ToDouble(Console.ReadLine());

        //com o objeto devidamente preenchido, já podemos inserir na lista
     
        ListaPessoa.Add(pessoa);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine("[Cadastro com sucesso!!!]");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Deseja continuar cadastrando? (S/N).....:");
        string resp = Console.ReadLine();
        if (resp.ToUpper() == "N") opc = 0;

    }//fim do while
}//fim cadastrar pessoa

//Função listar pessoas
void ListarPessoas()
{
    foreach (var pessoa in ListaPessoa)
    {
        Console.Clear();
        Console.WriteLine("%%%%%%%%%%%%%%% LISTA DE PESSOA %%%%%%%%%%%%%%%");
        Console.WriteLine();
        Console.WriteLine("Número de Id.......:" + pessoa.Id);
        Console.WriteLine("Nome.....:" + pessoa.Nome);
        Console.WriteLine("CPF......:" + pessoa.Cpf);
        Console.WriteLine("RG.......:" + pessoa.Rg);
        Console.WriteLine("Salario..:" + pessoa.Salario.ToString("C2"));
        Console.ReadKey();
    }
    /* Com o FOR
    for (int i = 0; i < ListaPessoa.Count;i++)
    {
        Pessoa pessoa=new Pessoa();
        pessoa = ListaPessoa[i];
        Console.WriteLine("Nome:"+pessoa.Nome);
    }*/
}//fim cadastrar pessoa
void ConsultarPorNome()
{
    Console.Clear();
    Console.Write("Digite o nome de quem preocura:");
    string nome = Console.ReadLine();
    foreach (var pessoa in ListaPessoa)
    {
        Console.Clear();
        if(nome.ToUpper() == pessoa.Nome.ToUpper())
        {
            Console.WriteLine();
            Console.WriteLine("Número de Id.......:" + pessoa.Id);
            Console.WriteLine("Nome.....:" + pessoa.Nome);
            Console.WriteLine("CPF......:" + pessoa.Cpf);
            Console.WriteLine("RG.......:" + pessoa.Rg);
            Console.WriteLine("Salario..:" + pessoa.Salario.ToString("C2"));
       
        }
    }
    Console.ReadKey();
}//Fim ConsultarPornome
void ConsultarPorCpf()
{
    Console.Clear();
    Console.Write("Digite o CPF de quem preocura:");
    string Cpf = Console.ReadLine();
    foreach (var pessoa in ListaPessoa)
    {
        Console.Clear();
        if (Cpf == pessoa.Cpf)
        {
            Console.WriteLine();
            Console.WriteLine("Número de Id.......:" + pessoa.Id);
            Console.WriteLine("Nome.....:" + pessoa.Nome);
            Console.WriteLine("CPF......:" + pessoa.Cpf);
            Console.WriteLine("RG.......:" + pessoa.Rg);
            Console.WriteLine("Salario..:" + pessoa.Salario.ToString("C2"));

        }
    }
    Console.ReadKey();
}//fim ConsultarPorCpf
while (opcao != 7)
{
    Console.Clear();//Limpar tela
    Console.WriteLine("@@@@@@@@@@ MENU @@@@@@@@@@");
    Console.WriteLine();
    Console.WriteLine("1 - Cadastrar Pessoa");
    Console.WriteLine("2 - Listar Pessoa");
    Console.WriteLine("3 - Consultar Pessoa por Nome");
    Console.WriteLine("4 - Consultar Pessoa por CPF");
    Console.WriteLine("5 - Filtar pessoas por salário");
    Console.WriteLine("7 - Fechar Sistema");
    Console.Write("Opção N°......................................:");
    opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            {
                CadastrarPessoas();
                break;
            }//fim do case 1
        case 2:
            {
                ListarPessoas();
                break;
            }//fim do case 2
        case 3:
            {
               ConsultarPorNome();
                break;
            }//fim do case 3
        case 4:
            {
             
                break;
            }//fim do case 4
        case 5:
            {
                break;
            }//fim do case 5
        case 7:
            {
                Console.Clear();
                Console.WriteLine("Desaja mesmo Fechar o SISTEMA? S/N");
                string resposta = Console.ReadLine();
                if (resposta.ToUpper() == "N") opcao = 0;
                break;
            }//fim do case 7
        default:
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("OPÇÃO INVÁLIDA");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                break;
            }//Fim do default
    }//fim do switch

}//fim do laço principal