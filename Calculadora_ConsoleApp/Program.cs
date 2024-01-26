// Criar uma calculadora simples com as funções somar, subtrair, multiplicar, dividir

void Apresentacao()
{
    Console.WriteLine(@"
    ░█████╗░░█████╗░██╗░░░░░░█████╗░██╗░░░██╗██╗░░░░░░█████╗░██████╗░░█████╗░██████╗░░█████╗░
    ██╔══██╗██╔══██╗██║░░░░░██╔══██╗██║░░░██║██║░░░░░██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗
    ██║░░╚═╝███████║██║░░░░░██║░░╚═╝██║░░░██║██║░░░░░███████║██║░░██║██║░░██║██████╔╝███████║
    ██║░░██╗██╔══██║██║░░░░░██║░░██╗██║░░░██║██║░░░░░██╔══██║██║░░██║██║░░██║██╔══██╗██╔══██║
    ╚█████╔╝██║░░██║███████╗╚█████╔╝╚██████╔╝███████╗██║░░██║██████╔╝╚█████╔╝██║░░██║██║░░██║
    ░╚════╝░╚═╝░░╚═╝╚══════╝░╚════╝░░╚═════╝░╚══════╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝");

    Console.WriteLine("Bem vindo a calculadora de console!");
    MenuDeOperacoes();
}

void MenuDeOperacoes()
{
    Console.WriteLine("\nEscolha uma das operações a seguir: ");
    Console.WriteLine("1. Somar (+)\n2. Subtrair (-)\n3. Multiplicar (X)\n4. Dividir (÷)\n5. Sair");
    Console.Write("\nDigite sua escolha: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);
    switch (opcaoEscolhida)
    {
        case 1:
            Console.Clear();
            Soma();
            break;
        
        case 2: Soma(); 
            break;
        
        case 3: Soma(); 
            break;
        
        case 4: Soma(); 
            break;
        
        case 5: Soma(); 
            break;
        
        default: 
            Console.WriteLine("Opção digitada não existe...\nDigite qualquer tecla para voltar.");
            Console.ReadKey();
            Console.Clear();
            Apresentacao();
            break;
    }
}

void Soma()
{
    EscreveTituloOperacao("Somar (+)");
    Console.Write("Digite o primeiro número: ");
    int numero_1 = int.Parse(Console.ReadLine()!);
    Console.Write("Digite o próximo número: ");
    int numero_2 = int.Parse(Console.ReadLine()!);

    int resultado = numero_1 + numero_2;
    Console.Write($"\nA soma entre {numero_1} e {numero_2} é");
    Thread.Sleep(500);
    Console.Write($".");
    Thread.Sleep(500);
    Console.Write($".");
    Thread.Sleep(500);
    Console.Write($".");
    Thread.Sleep(500);
    Console.WriteLine($"{resultado}!!!\n");

    Console.WriteLine("Digite qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    Apresentacao();
}

void EscreveTituloOperacao(string tituloOperacao)
{
    int qntLetras = tituloOperacao.Length;
    string asteriscos = string.Empty.PadLeft(qntLetras, '*');
    Console.WriteLine($"{asteriscos}\n{tituloOperacao}\n{asteriscos}\n");
}

Apresentacao();