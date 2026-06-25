void exercicio1()
{
    Console.Write("Digite um valor: ");
    decimal saldo = decimal.Parse(Console.ReadLine());

    if (saldo > 0)
    {
        Console.WriteLine("O saldo é positivo");
    }
    else if (saldo == 0)
    {
        Console.WriteLine("O saldo é zero");
    }
    else
    {
        Console.WriteLine("O saldo é negativo");
    }
}

void exercicio2() 
{
    Console.Write("Digite o código do produto (1 ou 2): ");
    int codigoProduto = int.Parse(Console.ReadLine());

    if (codigoProduto == 1)
    {
        Console.WriteLine("Perecível");
    }
    else if (codigoProduto == 2) 
    {
        Console.WriteLine("Não perecível");
    } 
    else
    {
        Console.WriteLine("Código inválido");
    }
}

void exercicio3()
{
    Console.Write("Informe a nota final do aluno: ");
    decimal notaFinal = decimal.Parse(Console.ReadLine());

    if (notaFinal >= 9)
    { 
        Console.WriteLine("O aluno recebeu a nota A.");
    } 
    else if (notaFinal >= 7 && notaFinal < 9)
    {
        Console.WriteLine("O aluno recebeu a nota B.");
    } 
    else if (notaFinal >= 5 && notaFinal < 7)
    {
        Console.WriteLine("O aluno recebeu a nota C.");
    } 
    else
    {
        Console.WriteLine("O aluno recebeu a nota D.");
    }
}

void exercicio4()
{
    Console.Write("Digite a senha: ");
    int senha = int.Parse(Console.ReadLine());

    Console.Write("Digite o nível de acesso: ");
    int nivelAcesso = int.Parse(Console.ReadLine());

    if (senha == 42 && nivelAcesso >= 5)
    {
        Console.WriteLine("Acesso permitido.");
    } 
    else
    {
        Console.WriteLine("Acesso negado.");
    }
}

void exercicio5()
{
    Console.Write("Digite a idade: ");
    int idade = int.Parse(Console.ReadLine());

    if (idade >= 0 && idade <= 12)
    {
        Console.WriteLine("Classificação: Infantil");
    } 
    else if (idade >= 13 && idade <= 17)
    {
        Console.WriteLine("Classificação: Adolescente");
    } 
    else if (idade >= 18 && idade <= 59)
    {
        Console.WriteLine("Classificação: Adulto");
    } 
    else
    {
        Console.WriteLine("Classificação: Idoso");
    }
}