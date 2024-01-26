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
    Console.WriteLine("1. Somar (+)\n2. Subtrair (-)\n3. Multiplicar (x)\n4. Dividir (÷)\n5. Sair");
    Console.Write("\nDigite sua escolha: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);
    switch (opcaoEscolhida)
    {
        case 1:
            Console.Clear();
            Somar();
            break;
        
        case 2: 
            Console.Clear();
            Subtrair(); 
            break;
        
        case 3: 
            Console.Clear();
            Multiplicar(); 
            break;
        
        case 4: 
            Console.Clear();
            Divisao(); 
            break;
        
        case 5:
            Console.WriteLine("\nVocê escolheu sair.\nAté a próxima! :)");
            break;
        
        default: 
            Console.WriteLine("Opção digitada não existe...\nDigite qualquer tecla para voltar.");
            Console.ReadKey();
            Console.Clear();
            Apresentacao();
            break;
    }
}

void Somar()
{
    EscreveTituloOperacao("Somar (+)");
    Console.Write("Digite o primeiro número: ");
    int numero_1 = int.Parse(Console.ReadLine()!);
    Console.Write("Digite o próximo número: ");
    int numero_2 = int.Parse(Console.ReadLine()!);
    int resultado = numero_1 + numero_2;
    EscreverResultado("soma", numero_1, numero_2, resultado);
}
void Subtrair()
{
    EscreveTituloOperacao("Subtrair (-)");
    Console.Write("Digite o primeiro número: ");
    int numero_1 = int.Parse(Console.ReadLine()!);
    Console.Write("Digite o próximo número: ");
    int numero_2 = int.Parse(Console.ReadLine()!);
    int resultado = numero_1 - numero_2;
    EscreverResultado("subtração", numero_1, numero_2, resultado);
}
void Multiplicar()
{
    EscreveTituloOperacao("Multiplicar (x)");
    Console.Write("Digite o primeiro número: ");
    int numero_1 = int.Parse(Console.ReadLine()!);
    Console.Write("Digite o próximo número: ");
    int numero_2 = int.Parse(Console.ReadLine()!);
    int resultado = numero_1*numero_2;
    EscreverResultado("multiplicação", numero_1, numero_2, resultado);
}
void Divisao()
{
    EscreveTituloOperacao("Divisão (÷)");
    Console.Write("Digite o primeiro número: ");
    int numero_1 = int.Parse(Console.ReadLine()!);
    Console.Write("Digite o próximo número: ");
    int numero_2 = int.Parse(Console.ReadLine()!);
    int resultado = numero_1/numero_2;
    EscreverResultado("divisão", numero_1, numero_2, resultado);
}
void EscreveTituloOperacao(string tituloOperacao)
{
    int qntLetras = tituloOperacao.Length;
    string asteriscos = string.Empty.PadLeft(qntLetras, '*');
    Console.WriteLine($"{asteriscos}\n{tituloOperacao}\n{asteriscos}\n");
}
void EscreverResultado(string operacao, int num1, int num2, int result)
{
    Console.Write($"\nA {operacao} entre {num1} e {num2} é");
    Thread.Sleep(500);
    Console.Write($".");
    Thread.Sleep(500);
    Console.Write($".");
    Thread.Sleep(500);
    Console.Write($".");
    Thread.Sleep(500);
    Console.WriteLine($"{result}!!!\n");

    Console.WriteLine("Digite qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    Apresentacao();
}

Apresentacao();