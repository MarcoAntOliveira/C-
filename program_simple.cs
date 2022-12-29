// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Title= "Minha priemeira C#";
string Nome;
string Sobrenome;
Int32 AnoNascimento;
Int32 AnoCorrente;
Int32 Idade;

Console.Write("Digite seu nome: ");
Nome = Console.ReadLine();

Console.Write("Digite seu sobrenome: ");
Sobrenome = Console.ReadLine();

Console.WriteLine("seja bem vindo  " + Nome +"  " + Sobrenome );
Console.Beep();

Console.WriteLine("Digite o ano que você nasceu: ");
AnoNascimento =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o ano corrente: ");
AnoCorrente = Convert.ToInt32(Console.ReadLine());

Idade= AnoCorrente - AnoNascimento;
Console.WriteLine("UAU , vc tem " + Idade + " anos !");
Console.Beep();

decimal ValorHora = 0;
decimal HorasTrabalhadas = 0;
decimal ValorReceber = 0;
Console.WriteLine("Informe o valor hora: ");
ValorHora = Convert.ToDecimal(Console.ReadLine());

Console.Write("Informe a quantidade de horas trabalhadas: ");
HorasTrabalhadas=Convert.ToDecimal(Console.ReadLine());

ValorReceber = HorasTrabalhadas - ValorHora;
Console.WriteLine(Nome + "vc tem a recber R$" + ValorReceber);
Console.Beep();
Console.Write("Usando incremento unario" + AnoNascimento);
AnoCorrente++;
Console.WriteLine("AnoNascimento após incremneto: " + AnoNascimento);
AnoNascimento = (-AnoNascimento);
Console.WriteLine(AnoNascimento);

Console.ReadKey();
